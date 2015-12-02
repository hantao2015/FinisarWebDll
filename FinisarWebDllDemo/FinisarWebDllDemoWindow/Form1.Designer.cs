namespace FinisarWebDllDemoWindow
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_upass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.txt_ProductionStage = new System.Windows.Forms.TextBox();
            this.txt_ProjectCode = new System.Windows.Forms.TextBox();
            this.txt_StepNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_from = new System.Windows.Forms.DateTimePicker();
            this.dt_to = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "登入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(38, 24);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(767, 21);
            this.txt_url.TabIndex = 1;
            this.txt_url.Text = "http://121.199.9.136:8082/rispweb/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "系统URL";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "1.\t获取部门出勤工时和人头数";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "2.\t获取项目代码出勤工时和人头数";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "3.\t获取工序出勤工时";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(190, 51);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(259, 21);
            this.txt_user.TabIndex = 6;
            this.txt_user.Text = "001";
            // 
            // txt_upass
            // 
            this.txt_upass.Location = new System.Drawing.Point(546, 51);
            this.txt_upass.Name = "txt_upass";
            this.txt_upass.Size = new System.Drawing.Size(259, 21);
            this.txt_upass.TabIndex = 7;
            this.txt_upass.Text = "123456";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "密码";
            // 
            // txt_department
            // 
            this.txt_department.Location = new System.Drawing.Point(402, 134);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(259, 21);
            this.txt_department.TabIndex = 10;
            this.txt_department.Text = "OSA";
            // 
            // txt_ProductionStage
            // 
            this.txt_ProductionStage.Location = new System.Drawing.Point(402, 161);
            this.txt_ProductionStage.Name = "txt_ProductionStage";
            this.txt_ProductionStage.Size = new System.Drawing.Size(259, 21);
            this.txt_ProductionStage.TabIndex = 11;
            this.txt_ProductionStage.Text = "MP";
            // 
            // txt_ProjectCode
            // 
            this.txt_ProjectCode.Location = new System.Drawing.Point(402, 188);
            this.txt_ProjectCode.Name = "txt_ProjectCode";
            this.txt_ProjectCode.Size = new System.Drawing.Size(259, 21);
            this.txt_ProjectCode.TabIndex = 12;
            this.txt_ProjectCode.Text = "SH44";
            // 
            // txt_StepNo
            // 
            this.txt_StepNo.Location = new System.Drawing.Point(402, 215);
            this.txt_StepNo.Name = "txt_StepNo";
            this.txt_StepNo.Size = new System.Drawing.Size(259, 21);
            this.txt_StepNo.TabIndex = 13;
            this.txt_StepNo.Text = "SH44-01-002";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "大部门";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "生产阶段";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "项目代码 ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "工序代码";
            // 
            // dt_from
            // 
            this.dt_from.Location = new System.Drawing.Point(412, 259);
            this.dt_from.Name = "dt_from";
            this.dt_from.Size = new System.Drawing.Size(200, 21);
            this.dt_from.TabIndex = 18;
            // 
            // dt_to
            // 
            this.dt_to.Location = new System.Drawing.Point(412, 298);
            this.dt_to.Name = "dt_to";
            this.dt_to.Size = new System.Drawing.Size(200, 21);
            this.dt_to.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "开始";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(349, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "结束";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 416);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dt_to);
            this.Controls.Add(this.dt_from);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_StepNo);
            this.Controls.Add(this.txt_ProjectCode);
            this.Controls.Add(this.txt_ProductionStage);
            this.Controls.Add(this.txt_department);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_upass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_upass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.TextBox txt_ProductionStage;
        private System.Windows.Forms.TextBox txt_ProjectCode;
        private System.Windows.Forms.TextBox txt_StepNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_from;
        private System.Windows.Forms.DateTimePicker dt_to;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

