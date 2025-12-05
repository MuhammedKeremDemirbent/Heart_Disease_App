namespace Heart_Disease_App
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbx_age = new System.Windows.Forms.TextBox();
            this.txtbx_gender = new System.Windows.Forms.TextBox();
            this.txtbx_restecg_lv_hypertrophy = new System.Windows.Forms.TextBox();
            this.txtbx_thalch = new System.Windows.Forms.TextBox();
            this.txtbx_cp_asymptomatic = new System.Windows.Forms.TextBox();
            this.txtbx_trestbps = new System.Windows.Forms.TextBox();
            this.txtbx_restecg_normal = new System.Windows.Forms.TextBox();
            this.txtbx_fbs_false = new System.Windows.Forms.TextBox();
            this.txtbx_dataset_cleveland = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_predict = new System.Windows.Forms.Button();
            this.txtbx_dataset_hungary = new System.Windows.Forms.TextBox();
            this.txtbx_dataset_switzerland = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelmid = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelmid.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbx_age
            // 
            this.txtbx_age.Location = new System.Drawing.Point(195, 278);
            this.txtbx_age.Name = "txtbx_age";
            this.txtbx_age.Size = new System.Drawing.Size(103, 22);
            this.txtbx_age.TabIndex = 0;
            // 
            // txtbx_gender
            // 
            this.txtbx_gender.Location = new System.Drawing.Point(195, 54);
            this.txtbx_gender.Name = "txtbx_gender";
            this.txtbx_gender.Size = new System.Drawing.Size(103, 22);
            this.txtbx_gender.TabIndex = 1;
            // 
            // txtbx_restecg_lv_hypertrophy
            // 
            this.txtbx_restecg_lv_hypertrophy.Location = new System.Drawing.Point(195, 222);
            this.txtbx_restecg_lv_hypertrophy.Name = "txtbx_restecg_lv_hypertrophy";
            this.txtbx_restecg_lv_hypertrophy.Size = new System.Drawing.Size(103, 22);
            this.txtbx_restecg_lv_hypertrophy.TabIndex = 2;
            // 
            // txtbx_thalch
            // 
            this.txtbx_thalch.Location = new System.Drawing.Point(195, 334);
            this.txtbx_thalch.Name = "txtbx_thalch";
            this.txtbx_thalch.Size = new System.Drawing.Size(103, 22);
            this.txtbx_thalch.TabIndex = 3;
            // 
            // txtbx_cp_asymptomatic
            // 
            this.txtbx_cp_asymptomatic.Location = new System.Drawing.Point(195, 166);
            this.txtbx_cp_asymptomatic.Name = "txtbx_cp_asymptomatic";
            this.txtbx_cp_asymptomatic.Size = new System.Drawing.Size(103, 22);
            this.txtbx_cp_asymptomatic.TabIndex = 4;
            // 
            // txtbx_trestbps
            // 
            this.txtbx_trestbps.Location = new System.Drawing.Point(195, 306);
            this.txtbx_trestbps.Name = "txtbx_trestbps";
            this.txtbx_trestbps.Size = new System.Drawing.Size(103, 22);
            this.txtbx_trestbps.TabIndex = 5;
            // 
            // txtbx_restecg_normal
            // 
            this.txtbx_restecg_normal.Location = new System.Drawing.Point(195, 250);
            this.txtbx_restecg_normal.Name = "txtbx_restecg_normal";
            this.txtbx_restecg_normal.Size = new System.Drawing.Size(103, 22);
            this.txtbx_restecg_normal.TabIndex = 6;
            // 
            // txtbx_fbs_false
            // 
            this.txtbx_fbs_false.Location = new System.Drawing.Point(195, 194);
            this.txtbx_fbs_false.Name = "txtbx_fbs_false";
            this.txtbx_fbs_false.Size = new System.Drawing.Size(103, 22);
            this.txtbx_fbs_false.TabIndex = 7;
            // 
            // txtbx_dataset_cleveland
            // 
            this.txtbx_dataset_cleveland.Location = new System.Drawing.Point(195, 82);
            this.txtbx_dataset_cleveland.Name = "txtbx_dataset_cleveland";
            this.txtbx_dataset_cleveland.Size = new System.Drawing.Size(103, 22);
            this.txtbx_dataset_cleveland.TabIndex = 8;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(28, 51);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(156, 25);
            this.lbl_result.TabIndex = 9;
            this.lbl_result.Text = "Prediction Result";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_predict
            // 
            this.btn_predict.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_predict.Location = new System.Drawing.Point(84, 395);
            this.btn_predict.Name = "btn_predict";
            this.btn_predict.Size = new System.Drawing.Size(127, 90);
            this.btn_predict.TabIndex = 10;
            this.btn_predict.Text = "Predict";
            this.btn_predict.UseVisualStyleBackColor = true;
            this.btn_predict.Click += new System.EventHandler(this.btn_predict_Click);
            // 
            // txtbx_dataset_hungary
            // 
            this.txtbx_dataset_hungary.Location = new System.Drawing.Point(195, 110);
            this.txtbx_dataset_hungary.Name = "txtbx_dataset_hungary";
            this.txtbx_dataset_hungary.Size = new System.Drawing.Size(103, 22);
            this.txtbx_dataset_hungary.TabIndex = 11;
            // 
            // txtbx_dataset_switzerland
            // 
            this.txtbx_dataset_switzerland.Location = new System.Drawing.Point(195, 138);
            this.txtbx_dataset_switzerland.Name = "txtbx_dataset_switzerland";
            this.txtbx_dataset_switzerland.Size = new System.Drawing.Size(103, 22);
            this.txtbx_dataset_switzerland.TabIndex = 12;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.MistyRose;
            this.panelTop.Controls.Add(this.label12);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1073, 100);
            this.panelTop.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(376, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(342, 32);
            this.label12.TabIndex = 25;
            this.label12.Text = "Heart Disease Application";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "From_switzerland";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "cp_asymptomatic";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fbs";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Restecg_lv_hypertrophy";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Restecg_normal";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Age";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Trestbps";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Thalch";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "From_hungary";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Gender";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "From_cleveland";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(429, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(272, 29);
            this.label13.TabIndex = 25;
            this.label13.Text = "How To Use Application";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(415, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(334, 72);
            this.label14.TabIndex = 26;
            this.label14.Text = "You need to enter your bleeding variables,\r\n such as cholesterol and talus. \r\nThe" +
    "n, enter the correct variables in the text box. \r\nFinally, click the predict but" +
    "ton to see your results.";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.IndianRed;
            this.panelLeft.Controls.Add(this.txtbx_age);
            this.panelLeft.Controls.Add(this.txtbx_gender);
            this.panelLeft.Controls.Add(this.btn_predict);
            this.panelLeft.Controls.Add(this.txtbx_restecg_lv_hypertrophy);
            this.panelLeft.Controls.Add(this.label11);
            this.panelLeft.Controls.Add(this.txtbx_thalch);
            this.panelLeft.Controls.Add(this.label10);
            this.panelLeft.Controls.Add(this.txtbx_cp_asymptomatic);
            this.panelLeft.Controls.Add(this.label9);
            this.panelLeft.Controls.Add(this.txtbx_trestbps);
            this.panelLeft.Controls.Add(this.label8);
            this.panelLeft.Controls.Add(this.txtbx_restecg_normal);
            this.panelLeft.Controls.Add(this.label7);
            this.panelLeft.Controls.Add(this.txtbx_fbs_false);
            this.panelLeft.Controls.Add(this.label6);
            this.panelLeft.Controls.Add(this.txtbx_dataset_cleveland);
            this.panelLeft.Controls.Add(this.label5);
            this.panelLeft.Controls.Add(this.txtbx_dataset_hungary);
            this.panelLeft.Controls.Add(this.label4);
            this.panelLeft.Controls.Add(this.txtbx_dataset_switzerland);
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 100);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(312, 531);
            this.panelLeft.TabIndex = 27;
            // 
            // panelmid
            // 
            this.panelmid.BackColor = System.Drawing.Color.RosyBrown;
            this.panelmid.Controls.Add(this.label14);
            this.panelmid.Controls.Add(this.lbl_result);
            this.panelmid.Controls.Add(this.label13);
            this.panelmid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmid.Location = new System.Drawing.Point(312, 100);
            this.panelmid.Name = "panelmid";
            this.panelmid.Size = new System.Drawing.Size(761, 531);
            this.panelmid.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 631);
            this.Controls.Add(this.panelmid);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelmid.ResumeLayout(false);
            this.panelmid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_age;
        private System.Windows.Forms.TextBox txtbx_gender;
        private System.Windows.Forms.TextBox txtbx_restecg_lv_hypertrophy;
        private System.Windows.Forms.TextBox txtbx_thalch;
        private System.Windows.Forms.TextBox txtbx_cp_asymptomatic;
        private System.Windows.Forms.TextBox txtbx_trestbps;
        private System.Windows.Forms.TextBox txtbx_restecg_normal;
        private System.Windows.Forms.TextBox txtbx_fbs_false;
        private System.Windows.Forms.TextBox txtbx_dataset_cleveland;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_predict;
        private System.Windows.Forms.TextBox txtbx_dataset_hungary;
        private System.Windows.Forms.TextBox txtbx_dataset_switzerland;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelmid;
    }
}

