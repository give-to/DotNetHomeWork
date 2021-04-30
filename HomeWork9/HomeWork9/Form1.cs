using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace HomeWork9
{
    public partial class Form1 : Form
    {
        SimpleCrawler myCrawler = new SimpleCrawler();
        Hashtable HadCrawl = new Hashtable();
        public Thread threadNow;
        public bool OnlyHtmlAspxJsp { get; set; }
        public Form1()
        {
            InitializeComponent();
            myCrawler.refreshData += RefreshDGV;
            dgvSuccessUrl.DataSource = myCrawler.SuccessUrl;            
            dgvFailUrl.DataSource = myCrawler.FailUrl;

            threadNow = new Thread(myCrawler.Crawl);
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtURL.DataBindings.Add("Text", this.myCrawler, "CrawlUrl");
            chkType.DataBindings.Add("Checked", this.myCrawler, "OnlyHtmlAspxJsp");
            
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            
            /*
            if (txtURL.Text == "")
            {
                return;
            }
            if(HadCrawl.ContainsKey(txtURL.Text))
            {
                return;
            }
            threadNow.Abort();
            */
            threadNow = new Thread(myCrawler.Crawl);
            threadNow.Start();
            //HadCrawl.Add(txtURL.Text, "true");
            
            
            
        }
        public void RefreshDGV()
        {
            dgvSuccessUrl.DataSource = null;
            dgvFailUrl.DataSource = null;
            dgvSuccessUrl.DataSource = myCrawler.SuccessUrl;
            dgvFailUrl.DataSource = myCrawler.FailUrl;
        }
    }
}
