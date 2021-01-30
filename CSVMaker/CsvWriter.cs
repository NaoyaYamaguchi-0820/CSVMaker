using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVMaker
{
    static class CsvWriter
    {
        public static void CreateCsv(List<List<string>> list)
        {

            //ファイルオープン
            using (StreamWriter file = new StreamWriter(@"test.csv", false, Encoding.GetEncoding("shift_jis")))
            {
                foreach (List<string> row in list)
                {

                    StringBuilder rowstr = new StringBuilder();

                    foreach(string column in row)
                    {

                        rowstr.Append("\"" + column + "\"" + ",");

                    }

                    //行末のカンマは削除する
                    rowstr.Length -= 1;
                    //1行書き込み
                    file.Write(rowstr.ToString());
                    //改行
                    file.WriteLine();

                }
            }
        }
    }
}
