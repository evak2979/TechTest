using System.IO;
using LiteDB;
using TechTest.Dto;

namespace TechTest.Data
{
    public static class Database
    {
        public const string Name = @"MyData.db";
        public const string OffersTableName = "offers";

        public static void Reset()
        {
            if (File.Exists(Name))
            {
                File.Delete(Name);
            }
        }
    }
}
