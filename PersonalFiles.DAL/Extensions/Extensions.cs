using System.Data.SqlClient;

namespace PersonalFiles.DAL
{
    public static class Extensions
    {
        public static Type GetValue<Type>(this SqlDataReader reader, int index)
        {
            return (Type)reader.GetValue(index);
        }
    }
}
