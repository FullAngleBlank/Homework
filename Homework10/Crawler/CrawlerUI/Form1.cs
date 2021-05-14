using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using CrawlerConsole;
using System.Threading.Tasks;

namespace CrawlerUI
{
    public partial class Form1 : Form
    {
        private String BaseUrl;
        private String RelativeUrl;
        private String AbsoluteUrl;
        Crawler crawler = new Crawler();
        BindingSource resultBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            crawler.PageDownloaded += Crawler_PageDownloaded;
            dgvResult.DataSource = resultBindingSource;
        }

        private void Crawler_PageDownloaded(Crawler crawler, string url, string info)
        {
            var pageInfo = new { Index = resultBindingSource.Count + 1, URL = url, Status = info };
            Action action = () => { resultBindingSource.Add(pageInfo); };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void button_RelativeCrawl_Click(object sender, EventArgs e)
        {

            this.BaseUrl = textBox_BaseUrl.Text;
            this.RelativeUrl = textBox_RelativeUrl.Text;
            string AbsoluteUrl = crawler.Transform(RelativeUrl, BaseUrl);

            if (Regex.IsMatch(AbsoluteUrl, "((.html?|.aspx|.jsp|.php)$|^[^.]+$)"))
            {
                crawler.urls.Add(AbsoluteUrl, false);//加入初始页面
                //new Thread(crawler.Crawl).Start();
                StartCrawlers(crawler);
                MessageBox.Show("爬取成功");
            }
            else
            {
                MessageBox.Show("爬取失败，请检查Url");
            }

        }

        private void button_AbsoluteCrawl_Click(object sender, EventArgs e)
        {
            this.AbsoluteUrl = textBox_AbsoluteUrl.Text;

            if (Regex.IsMatch(AbsoluteUrl, "((.html?|.aspx|.jsp|.php)$|^[^.]+$)"))
            {
                crawler.urls.Add(AbsoluteUrl, false);//加入初始页面
                //new Thread(crawler.Crawl).Start();
                StartCrawlers(crawler);
                MessageBox.Show("爬取成功");
            }
            else
            {
                MessageBox.Show("爬取失败，请检查Url");
            }
        }
        public void StartCrawlers(Crawler mycrawler)
        {
            Thread thread_1 = new Thread(() => mycrawler.Crawl());
            thread_1.Name = "爬虫线程1";
            Thread thread_2 = new Thread(() => mycrawler.Crawl());
            thread_2.Name = "爬虫线程2";
            Thread thread_3 = new Thread(() => mycrawler.Crawl());
            thread_3.Name = "爬虫线程3";

            Task[] tasks =
                {   Task.Run(() => thread_1.Start()),Task.Run(() => thread_2.Start()),
                    Task.Run(() => thread_3.Start()),
                };

            Task.WaitAll(tasks);
        }
    }
}
