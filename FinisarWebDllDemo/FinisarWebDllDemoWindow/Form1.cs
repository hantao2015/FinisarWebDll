using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Finisar.EffientReport;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;
using System.Windows.Threading;


namespace FinisarWebDllDemoWindow
{
    public partial class Form1 : Form

    {
        EffientReport Ep;
        private List<FinisarAttendance> attendances = new List<FinisarAttendance>();
       private  List<FinisarHeadCount> headcounts = new List<FinisarHeadCount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dt_from.

        }

        private  void  button1_Click(object sender, EventArgs e)
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
         
            Int64 requestid = 0;
         

            if (!(Ep == null)) {
                if (Ep.getAttendanceByDepartment(strDepartment, strStart, strEnd, ref attendances, ref headcounts,ref requestid))
                {

                    databind();

                }
                else
                {
                    MessageBox.Show(Ep.getLastErroMessage());
                }
            }

          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strDepartment = txt_department.Text;
            string strProductionStage = txt_ProductionStage.Text;
            string strProjectCode = txt_ProjectCode.Text;
            string strStepNO = txt_StepNo.Text;

            DateTime dFrom = dt_from.Value;
            DateTime dTo = dt_to.Value;
            Int64 requestid = 0;
            string strStart = dFrom.ToString("yyyy-MM-dd HH:mm:ss");
            string strEnd = dTo.ToString("yyyy-MM-dd HH:mm:ss");
          
            if (!(Ep == null))
            {
                if (Ep.getAttendanceByProjCode(strDepartment, strStart, strEnd, ref attendances, ref headcounts, ref   requestid ))
                {
                    databind();

                }
                else
                {
                    MessageBox.Show(Ep.getLastErroMessage());
                }
            }

        }
        private void databind()
        {
            dataGridView1.DataSource = attendances;
          
            dataGridView2.DataSource = headcounts;


        }
        private void button4_Click(object sender, EventArgs e)
        {
            string strDepartment = txt_department.Text;
            string strProductionStage = txt_ProductionStage.Text;
            string strProjectCode = txt_ProjectCode.Text;
            string strStepNO = txt_StepNo.Text;

            DateTime dFrom = dt_from.Value;
            DateTime dTo = dt_to.Value;
            Int64 requestid = 0;
            string strStart = dFrom.ToString("yyyy-MM-dd HH:mm:ss");
            string strEnd = dTo.ToString("yyyy-MM-dd HH:mm:ss");
           
            if (!(Ep == null))
            {
                if (Ep.getAttendanceByStepNo(strDepartment, strProjectCode, strProductionStage, strStepNO, strStart, strEnd, ref attendances,ref  requestid))
                {

                    databind();
                }
                else
                {
                    MessageBox.Show(Ep.getLastErroMessage());
                }
            }

        }

        private   void button5_Click(object sender, EventArgs e)

        {
            //return (Task<Hashtable>)Form.win.Dispatcher.Invoke()
          

        }
     
      
    }
}
