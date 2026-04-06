using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_HELPER.Models
{
    public class CsvCodeLoader
    {
        public static List<BasicCodeItem> LoadBasicCodes(string filePath)
        {
            var result = new List<BasicCodeItem>();

            if (!File.Exists(filePath))
                throw new FileNotFoundException("파일이 없습니다.", filePath);

            var lines = File.ReadAllLines(filePath, System.Text.Encoding.UTF8);

            if (lines.Length <= 1)
                return result;

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                    continue;

                var arr = lines[i].Split(',');

                result.Add(new BasicCodeItem
                {
                    GroupCd = arr.Length > 0 ? arr[0] : "",
                    GroupNm = arr.Length > 1 ? arr[1] : "",
                    Code = arr.Length > 2 ? arr[2] : "",
                    CodeNm = arr.Length > 3 ? arr[3] : "",
                    UseYn = arr.Length > 3 ? arr[4] : "",
                    SortNo = arr.Length > 5 && int.TryParse(arr[5], out int sortNo) ? sortNo : 0
                });
            }

            return result;
        }
    }
}
