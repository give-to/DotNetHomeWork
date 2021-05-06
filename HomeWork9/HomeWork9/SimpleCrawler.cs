using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork9
{
    public class SimpleCrawler
    {
        public Hashtable urls = new Hashtable();
        private int count = 0;
        public List<MyURL> SuccessUrl = new List<MyURL>();
        public List<MyURL> FailUrl = new List<MyURL>();
        public Action refreshData;
        public string CrawlUrl { get; set; }
        public bool OnlyHtmlAspxJsp { get; set; }
        private int MaxPage = 50;

        public void Crawl()
        {
            if (CrawlUrl==null)
                return;
            if (urls.ContainsKey(CrawlUrl) && (bool)urls[CrawlUrl] == true)
                return;
            count = 0;
            SuccessUrl.Clear();
            FailUrl.Clear();
            urls.Add(CrawlUrl, false);//加入初始页面
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url])
                        continue;
                    current = url;
                }

                if (current == null || count > MaxPage) break;
                //Console.WriteLine("爬行" + current + "页面!");                
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html);//解析,并加入新的链接                
                //Console.WriteLine("爬行结束");
                refreshData();
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                MyURL successUrlTemp = new MyURL();
                successUrlTemp.Url = url;
                SuccessUrl.Add(successUrlTemp);
                return html;
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                MyURL failUrlTemp = new MyURL();
                failUrlTemp.Url = url;
                FailUrl.Add(failUrlTemp);
                return "";
            }
        }

        private void Parse(string html)
        {
            string strRef;
            if(!OnlyHtmlAspxJsp)
            {
                strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
                
                //老师写的：
                //UrlDetectRegex = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";
                //urlParseRegex = @"^(?<site>(?<protocal>https?)://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
                //示例：href="//common.cnblogs.com/favicon.svg"
            }
            else
            {
                strRef= @"(href|HREF)[]*=[]*[""'][^""'#>]+(html?|aspx|jsp)[""']";
            }
                
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
        
    }
}
