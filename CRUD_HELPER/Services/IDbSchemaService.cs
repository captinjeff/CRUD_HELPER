using CRUD_HELPER.Model;
using CRUD_HELPER.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_HELPER.Services
{
    public interface IDbSchemaService
    {
        List<string> GetTables(DbConnectionInfo connInfo);
        List<ColumnInfo> GetColumns(DbConnectionInfo connInfo, string tableName);
    }
}
