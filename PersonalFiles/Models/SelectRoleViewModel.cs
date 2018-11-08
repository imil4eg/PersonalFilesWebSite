using PersonalFiles.DAL;
using System.Collections.Generic;

namespace PersonalFiles.Models
{
    public sealed class SelectRoleViewModel
    {
        public int SelectedRoleId { get; set; }
        public IEnumerable<ApplicationRole> Roles { get; set; }
    }
}
