using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PersonalFiles.DAL;
using PersonalFiles.BLL;
using AutoMapper;

namespace PersonalFiles
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.Configure<PasswordHasherOptions>(options =>
                options.CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV2
            );

            services.AddTransient<IUserStore<ApplicationUser>, UserStore>();
            services.AddTransient<IRoleStore<ApplicationRole>, RoleStore>();

            IUnitOfWork unitOfWork = new UnitOfWork(Configuration.GetConnectionString("DefaultConnection"));
            services.AddTransient<IPersonService, PersonService>(s => new PersonService(unitOfWork));
            services.AddTransient<IEducationService, EducationService>(s => new EducationService(unitOfWork));
            services.AddTransient<IPassportService, PassportService>(s => new PassportService(unitOfWork));
            services.AddTransient<IInsuranceService, InsuranceService>(s => new InsuranceService(unitOfWork));
            services.AddTransient<IPositionService, PositionService>(s => new PositionService(unitOfWork));
            services.AddTransient<IPersonPositionService, IPersonPositionService>(s => new PersonPositionService(unitOfWork));

            var mappingConfigurator = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfigurator.CreateMapper();
            services.AddSingleton(mapper);

            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddUserManager<UserManager<ApplicationUser>>()
                .AddRoleManager<RoleManager<ApplicationRole>>()
                .AddSignInManager<SignInManager<ApplicationUser>>()
                .AddDefaultTokenProviders();

            services.AddAuthentication()
                .AddCookie(options => 
                {
                    options.LoginPath = "/Authorization/Login";
                });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Authorization}/{action=Login}/{id?}");
            });

            var scopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();
            using(var scope = scopeFactory.CreateScope())
            {
                var roleService = scope.ServiceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
                var userService = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                var personService = scope.ServiceProvider.GetRequiredService<IPersonService>();
                var positionService = scope.ServiceProvider.GetRequiredService<IPositionService>();
                var personPositionService = scope.ServiceProvider.GetRequiredService<IPersonPositionService>();
                var educationService = scope.ServiceProvider.GetRequiredService<IEducationService>();
                var insuranceService = scope.ServiceProvider.GetRequiredService<IInsuranceService>();
                var passportService = scope.ServiceProvider.GetRequiredService<IPassportService>();
                Seed.InitializeDataAsync(roleService, userService, personService, 
                    positionService, personPositionService, educationService, insuranceService, passportService).Wait();
            }
        }
    }
}
