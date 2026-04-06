using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_HELPER.Model
{
    public class DbConnectionInfo
    {
        public string DbType { get; set; } = "PostgreSQL";
        public string Host { get; set; }
        public string Port { get; set; }
        public string Database { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }

        public string GetConnectionString()
        {
            if (DbType == "PostgreSQL")
            {
                return $"Host={Host};Port={Port};Database={Database};Username={UserId};Password={Password}";
            }

            throw new NotSupportedException($"지원하지 않는 DB 타입: {DbType}");
        }
    }
}
