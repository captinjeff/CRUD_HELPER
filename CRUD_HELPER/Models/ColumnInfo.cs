using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_HELPER.Models
{
    public class ColumnInfo
    {
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsNullable { get; set; }
    }
}
