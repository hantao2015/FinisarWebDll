using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Finisar.EffientReport;

namespace FinisarWebDllDemoWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strUrl=  txt_url.Text;
            string strUser = txt_user.Text;
            string strUpass = txt_upass.Text;

            EffientReport Ep = new EffientReport(strUrl, strUser, strUpass);
            if (Ep.Login())
            {
                MessageBox.Show("祝贺,系统登入成功!");
            }
            else
            {
                MessageBox.Show(Ep.getLastErroMessage());
            }


        }
    }
}
