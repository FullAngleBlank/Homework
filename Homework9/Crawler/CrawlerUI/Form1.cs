using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using CrawlerConsole;

namespace CrawlerUI
{
    public partial class Form1 : Form
    {
        private String BaseUrl;
        private String RelativeUrl;
        private String AbsoluteUrl;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_RelativeCrawl_Click(object sender, EventArgs e)
        {
            Crawler crawler = new Crawler();
            this.BaseUrl = textBox_BaseUrl.Text;
            this.RelativeUrl = textBox_RelativeUrl.Text;
            string AbsoluteUrl = crawler.Transform(RelativeUrl, BaseUrl);
            if (Regex.IsMatch(AbsoluteUrl, ".(html|aspx|jsp)"))
            {
                crawler.urls.Add(AbsoluteUrl, false);//加入初始页面
                new Thread(crawler.Crawl).Start();
                MessageBox.Show("爬取成功");
            }
            else {
                MessageBox.Show("爬取失败，请检查Url");
            }

        }

        private void button_AbsoluteCrawl_Click(object sender, EventArgs e)
        {
            Crawler crawler = new Crawler();

            this.AbsoluteUrl = textBox_AbsoluteUrl.Text;
            if (Regex.IsMatch(AbsoluteUrl, ".(html|aspx|jsp)"))
            {
                crawler.urls.Add(AbsoluteUrl, false);//加入初始页面
                new Thread(crawler.Crawl).Start();
                MessageBox.Show("爬取成功");
            }
            else
            {
                MessageBox.Show("爬取失败，请检查Url");
            }
        }
    }
}
