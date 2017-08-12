﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void addgood()
        {
            int co = int.Parse(bunifuCustomLabel1.Text);
            co++;
            bunifuCustomLabel1.Text = co.ToString();
        }
        public async Task testProxy(string ip, int port)
        {
            bool OK = false;
            try
            {
                WebClient wc = new WebClient();
                wc.Proxy = new WebProxy(ip, port);
                await wc.DownloadStringTaskAsync(new Uri("http://google.com/ncr"));
                OK = true;
                addgood();
                richTextBox2.Text += ip + ":" + port + "\n";
            }
            catch { }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "TXT Files | *.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                proxy_list.Text = File.ReadAllText(@fileName);
                proxy_list.Refresh();
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            String ip;
            int port;
            if (proxy_list.Lines.Length < 1)
            {
                MessageBox.Show("Proxy list is Vide");
            }
            else
            {
                var asyncTasks = new List<Task>();
                foreach (String i in proxy_list.Lines)
                {
                    String[] tab = i.Split(':');
                    port = int.Parse(tab[1]);
                    ip = tab[0];
                    asyncTasks.Add(testProxy(ip, port));
                }
                foreach (var task in asyncTasks)
                {
                    task.Wait();
                }
            }
        }
    }
}
