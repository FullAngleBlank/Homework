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
using System.Web;
using System.Windows.Forms;

namespace CrawlerConsole
{
   public class Crawler
    {
        public event Action<Crawler, string, string> PageDownloaded;
        public Dictionary<string, bool> DownloadedPages { get; } = new Dictionary<string, bool>();
        //URL检测表达式，用于在HTML文本中查找URL
        public static readonly string UrlDetectRegex = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";
        //URL解析表达式
        public static readonly string urlParseRegex = @"^(?<site>(?<protocal>https?)://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        public Hashtable urls = new Hashtable();
        public int count = 0;
        static void Main(string[] args)
        {
            Crawler myCrawler = new Crawler();
            string startUrl = Console.ReadLine();

            if (Regex.IsMatch(startUrl, "((.html?|.aspx|.jsp|.php)$|^[^.]+$)"))
            {
                if (args.Length >= 1) startUrl = args[0];
                myCrawler.urls.Add(startUrl, false);//加入初始页面
                new Thread(myCrawler.Crawl).Start();
                Console.ReadKey();
            }
            try
            {
                String TransformedURL = myCrawler.Transform(startUrl, "Http://cnblogs.com");
                Console.WriteLine(TransformedURL);
                Console.ReadKey();
            }
            catch (UriFormatException e)
            {
                throw new UriFormatException("请输入正确的基地址");
            }
        }

        public void Crawl()
        {
            DownloadedPages.Clear();
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                    try
                    {
                        DownloadedPages[url] = true;
                        PageDownloaded(this, url, "success");
                    }
                    catch(Exception ex) {
                        PageDownloaded(this, url, "  Error:" + ex.Message);
                    }
                }

                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html,current);//解析,并加入新的链接
                Console.WriteLine("爬行结束");
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
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public void Parse(string html, string pageUrl)
        {
            var matches = new Regex(UrlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "" || linkUrl.StartsWith("javascript:")) continue;

                linkUrl = Transform(linkUrl, pageUrl);//转绝对路径

            }
        }

        ///   <summary>
        ///  格式化URL函数  RelativeUrl 传入相对URL ObjUrl 传入绝对基URL  基URL一定要带HTTP://
        ///   </summary>
        ///   <param name="RelativeUrl"> 传入单个的URL </param>
        ///   <param name="ObjUrl">
        ///  传入得到值的页面URL
        ///   </param>
        ///   <returns></returns>
        public String Transform(String RelativeUrl,String ObjUrl) {
            Uri BaseUri = new Uri(ObjUrl);
            Uri AbsoluteUri = new Uri(BaseUri, RelativeUrl);
            return AbsoluteUri.ToString();
        }
    }
}
