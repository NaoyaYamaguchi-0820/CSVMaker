using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace CSVMaker
{
    static class HtmlToList
    {
        public static List<List<String>> GetList(string htmlPath)
        {
            // HTMLファイルの文字列を取得する
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.GetEncoding("shift_jis");
            string htmlStr = client.DownloadString(htmlPath);

            //HTMLファイルの文字列が正常に取得できなかった場合、nullを返却する
            if (htmlStr == null)
            {
                return null;
            }

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(htmlStr);
            HtmlNodeCollection list = htmlDoc.DocumentNode.SelectNodes("/html/body/div[2]/div[@class='oya']");

            //親要素を代入するためのListを宣言。最終的にreturnされる。
            List<List<string>> oyaList = new List<List<string>>();

            foreach(var oya in list)
            {

                HtmlNodeCollection ko = oya.SelectNodes("div[@class='ko-item']");

                //子要素を代入するためのListを宣言。最終的にoyaListにAddされる。
                List<string> koList = new List<string>();

                foreach(var data in ko)
                {
                    //単価などの具体的な情報を子リストへAddする。
                    koList.Add(data.InnerText);
                }

                //親リストに子のリストをAddする。
                oyaList.Add(koList);

            }

            return oyaList;

        }

    }

}
