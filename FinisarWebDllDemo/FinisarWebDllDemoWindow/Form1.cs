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
        EffientReport Ep;
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

           Ep= new EffientReport(strUrl, strUser, strUpass);
            if (Ep.Login())
            {
                MessageBox.Show("祝贺,系统登入成功!");
            }
            else
            {
                MessageBox.Show(Ep.getLastErroMessage());
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strDepartment = txt_department.Text;
            string strProductionStage = txt_ProductionStage.Text;
            string strProjectCode = txt_ProjectCode.Text;
            string strStepNO = txt_StepNo.Text;
            
            DateTime dFrom = dt_from.Value;
            DateTime dTo = dt_to.Value;
           
            string strStart = dFrom.ToString("yyyy-MM-dd HH:mm:ss");
            string strEnd = dTo.ToString("yyyy-MM-dd HH:mm:ss");
            List<FinisarAttendance> attendances = new List<FinisarAttendance>();
            
            List<FinisarHeadCount>   headcounts = new List<FinisarHeadCount>();
            if (!(Ep == null)) {
                if (Ep.getAttendanceByDepartment(strDepartment, strStart, strEnd, ref attendances, ref headcounts))
                {


                }
                else
                {
                    MessageBox.Show(Ep.getLastErroMessage());
                }
            }

          
        }
    }
}
