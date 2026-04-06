using CRUD_HELPER.Model;
using CRUD_HELPER.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_HELPER.Services
{
    internal class PostgresSchemaService : IDbSchemaService
    {
        public List<string> GetTables(DbConnectionInfo connInfo)
        {
            var result = new List<string>();

            using (var conn = new NpgsqlConnection(connInfo.GetConnectionString()))
            {
                conn.Open();

                string sql = @"
                    SELECT table_name
                    FROM information_schema.tables
                    WHERE table_schema = 'public'
                      AND table_type = 'BASE TABLE'
                    ORDER BY table_name";

                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(reader.GetString(0));
                    }
                }
            }

            return result;
        }

        public List<ColumnInfo> GetColumns(DbConnectionInfo connInfo, string tableName)
        {
            var result = new List<ColumnInfo>();

            using (var conn = new NpgsqlConnection(connInfo.GetConnectionString()))
            {
                conn.Open();

                string sql = @"
                    SELECT 
                        c.column_name,
                        c.data_type,
                        c.is_nullable,
                        CASE 
                            WHEN tc.constraint_type = 'PRIMARY KEY' THEN 'Y'
                            ELSE 'N'
                        END AS is_pk
                    FROM information_schema.columns c
                    LEFT JOIN information_schema.key_column_usage kcu
                        ON c.table_name = kcu.table_name
                       AND c.column_name = kcu.column_name
                       AND c.table_schema = kcu.table_schema
                    LEFT JOIN information_schema.table_constraints tc
                        ON kcu.constraint_name = tc.constraint_name
                       AND kcu.table_schema = tc.table_schema
                    WHERE c.table_schema = 'public'
                      AND c.table_name = @tableName
                    ORDER BY c.ordinal_position";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@tableName", tableName);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new ColumnInfo
                            {
                                ColumnName = reader["column_name"].ToString(),
                                DataType = reader["data_type"].ToString(),
                                IsNullable = reader["is_nullable"].ToString() == "YES",
                                IsPrimaryKey = reader["is_pk"].ToString() == "Y"
                            });
                        }
                    }
                }
            }

            return result;
        }
    }
}
