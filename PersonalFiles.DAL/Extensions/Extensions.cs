using System.Data.SqlClient;

namespace PersonalFiles.DAL
{
    public static class Extensions
    {
        public static Type GetValue<Type>(this SqlDataReader reader, int index)
        {
            return reader.IsDBNull(index) ? default(Type) : (Type)reader.GetValue(index);
        }
    }
}
