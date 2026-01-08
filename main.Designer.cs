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
            this.txtbx_thalch = new System.Windows.Forms.TextBox();
            this.txtbx_trestbps = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_predict = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTop = new System.Windows.Forms.Label();
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.comboBoxgender = new System.Windows.Forms.ComboBox();
            this.comboBoxcleveland = new System.Windows.Forms.ComboBox();
            this.comboBoxhungary = new System.Windows.Forms.ComboBox();
            this.comboBoxswitzerland = new System.Windows.Forms.ComboBox();
            this.comboBoxasymptomatic = new System.Windows.Forms.ComboBox();
            this.comboBoxfbs = new System.Windows.Forms.ComboBox();
            this.comboBoxreslvhyper = new System.Windows.Forms.ComboBox();
            this.comboBoxresnormal = new System.Windows.Forms.ComboBox();
            this.panelmid = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelmid.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbx_age
            // 
            this.txtbx_age.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_age.Location = new System.Drawing.Point(285, 349);
            this.txtbx_age.Name = "txtbx_age";
            this.txtbx_age.Size = new System.Drawing.Size(121, 25);
            this.txtbx_age.TabIndex = 0;
            // 
            // txtbx_thalch
            // 
            this.txtbx_thalch.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_thalch.Location = new System.Drawing.Point(285, 405);
            this.txtbx_thalch.Name = "txtbx_thalch";
            this.txtbx_thalch.Size = new System.Drawing.Size(121, 25);
            this.txtbx_thalch.TabIndex = 3;
            // 
            // txtbx_trestbps
            // 
            this.txtbx_trestbps.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_trestbps.Location = new System.Drawing.Point(285, 377);
            this.txtbx_trestbps.Name = "txtbx_trestbps";
            this.txtbx_trestbps.Size = new System.Drawing.Size(121, 25);
            this.txtbx_trestbps.TabIndex = 5;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(30, 34);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(156, 25);
            this.lbl_result.TabIndex = 9;
            this.lbl_result.Text = "Prediction Result";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_predict
            // 
            this.btn_predict.BackColor = System.Drawing.Color.IndianRed;
            this.btn_predict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_predict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_predict.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_predict.FlatAppearance.BorderSize = 3;
            this.btn_predict.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_predict.Location = new System.Drawing.Point(459, 234);
            this.btn_predict.Name = "btn_predict";
            this.btn_predict.Size = new System.Drawing.Size(127, 90);
            this.btn_predict.TabIndex = 10;
            this.btn_predict.Text = "Predict";
            this.btn_predict.UseVisualStyleBackColor = false;
            this.btn_predict.Click += new System.EventHandler(this.btn_predict_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.MistyRose;
            this.panelTop.Controls.Add(this.lblTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1377, 100);
            this.panelTop.TabIndex = 13;
            // 
            // lblTop
            // 
            this.lblTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTop.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(0, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(1377, 100);
            this.lblTop.TabIndex = 25;
            this.lblTop.Text = "Heart Disease Application";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 217);
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
            this.label2.Location = new System.Drawing.Point(22, 245);
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
            this.label3.Location = new System.Drawing.Point(22, 273);
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
            this.label4.Location = new System.Drawing.Point(22, 301);
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
            this.label5.Location = new System.Drawing.Point(22, 329);
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
            this.label6.Location = new System.Drawing.Point(22, 357);
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
            this.label7.Location = new System.Drawing.Point(22, 385);
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
            this.label8.Location = new System.Drawing.Point(22, 413);
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
            this.label9.Location = new System.Drawing.Point(22, 189);
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
            this.label10.Location = new System.Drawing.Point(22, 133);
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
            this.label11.Location = new System.Drawing.Point(22, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "From_cleveland";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.IndianRed;
            this.panelLeft.Controls.Add(this.txtbx_age);
            this.panelLeft.Controls.Add(this.btn_predict);
            this.panelLeft.Controls.Add(this.label11);
            this.panelLeft.Controls.Add(this.comboBoxgender);
            this.panelLeft.Controls.Add(this.comboBoxcleveland);
            this.panelLeft.Controls.Add(this.label10);
            this.panelLeft.Controls.Add(this.comboBoxhungary);
            this.panelLeft.Controls.Add(this.label9);
            this.panelLeft.Controls.Add(this.label8);
            this.panelLeft.Controls.Add(this.comboBoxswitzerland);
            this.panelLeft.Controls.Add(this.label7);
            this.panelLeft.Controls.Add(this.txtbx_thalch);
            this.panelLeft.Controls.Add(this.label6);
            this.panelLeft.Controls.Add(this.comboBoxasymptomatic);
            this.panelLeft.Controls.Add(this.label5);
            this.panelLeft.Controls.Add(this.label4);
            this.panelLeft.Controls.Add(this.comboBoxfbs);
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.comboBoxreslvhyper);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.txtbx_trestbps);
            this.panelLeft.Controls.Add(this.comboBoxresnormal);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 100);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(646, 665);
            this.panelLeft.TabIndex = 27;
            // 
            // comboBoxgender
            // 
            this.comboBoxgender.FormattingEnabled = true;
            this.comboBoxgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxgender.Location = new System.Drawing.Point(285, 126);
            this.comboBoxgender.Name = "comboBoxgender";
            this.comboBoxgender.Size = new System.Drawing.Size(121, 24);
            this.comboBoxgender.TabIndex = 29;
            // 
            // comboBoxcleveland
            // 
            this.comboBoxcleveland.FormattingEnabled = true;
            this.comboBoxcleveland.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.comboBoxcleveland.Location = new System.Drawing.Point(285, 154);
            this.comboBoxcleveland.Name = "comboBoxcleveland";
            this.comboBoxcleveland.Size = new System.Drawing.Size(121, 24);
            this.comboBoxcleveland.TabIndex = 38;
            // 
            // comboBoxhungary
            // 
            this.comboBoxhungary.FormattingEnabled = true;
            this.comboBoxhungary.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.comboBoxhungary.Location = new System.Drawing.Point(285, 182);
            this.comboBoxhungary.Name = "comboBoxhungary";
            this.comboBoxhungary.Size = new System.Drawing.Size(121, 24);
            this.comboBoxhungary.TabIndex = 37;
            // 
            // comboBoxswitzerland
            // 
            this.comboBoxswitzerland.FormattingEnabled = true;
            this.comboBoxswitzerland.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.comboBoxswitzerland.Location = new System.Drawing.Point(285, 210);
            this.comboBoxswitzerland.Name = "comboBoxswitzerland";
            this.comboBoxswitzerland.Size = new System.Drawing.Size(121, 24);
            this.comboBoxswitzerland.TabIndex = 36;
            // 
            // comboBoxasymptomatic
            // 
            this.comboBoxasymptomatic.FormattingEnabled = true;
            this.comboBoxasymptomatic.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.comboBoxasymptomatic.Location = new System.Drawing.Point(285, 238);
            this.comboBoxasymptomatic.Name = "comboBoxasymptomatic";
            this.comboBoxasymptomatic.Size = new System.Drawing.Size(121, 24);
            this.comboBoxasymptomatic.TabIndex = 35;
            // 
            // comboBoxfbs
            // 
            this.comboBoxfbs.FormattingEnabled = true;
            this.comboBoxfbs.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.comboBoxfbs.Location = new System.Drawing.Point(285, 266);
            this.comboBoxfbs.Name = "comboBoxfbs";
            this.comboBoxfbs.Size = new System.Drawing.Size(121, 24);
            this.comboBoxfbs.TabIndex = 34;
            // 
            // comboBoxreslvhyper
            // 
            this.comboBoxreslvhyper.FormattingEnabled = true;
            this.comboBoxreslvhyper.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.comboBoxreslvhyper.Location = new System.Drawing.Point(285, 294);
            this.comboBoxreslvhyper.Name = "comboBoxreslvhyper";
            this.comboBoxreslvhyper.Size = new System.Drawing.Size(121, 24);
            this.comboBoxreslvhyper.TabIndex = 33;
            // 
            // comboBoxresnormal
            // 
            this.comboBoxresnormal.FormattingEnabled = true;
            this.comboBoxresnormal.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.comboBoxresnormal.Location = new System.Drawing.Point(285, 322);
            this.comboBoxresnormal.Name = "comboBoxresnormal";
            this.comboBoxresnormal.Size = new System.Drawing.Size(121, 24);
            this.comboBoxresnormal.TabIndex = 32;
            // 
            // panelmid
            // 
            this.panelmid.BackColor = System.Drawing.Color.RosyBrown;
            this.panelmid.Controls.Add(this.lbl_result);
            this.panelmid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmid.Location = new System.Drawing.Point(646, 100);
            this.panelmid.Name = "panelmid";
            this.panelmid.Size = new System.Drawing.Size(731, 665);
            this.panelmid.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 765);
            this.Controls.Add(this.panelmid);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.Text = "Heart Disease App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelmid.ResumeLayout(false);
            this.panelmid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_age;
        private System.Windows.Forms.TextBox txtbx_thalch;
        private System.Windows.Forms.TextBox txtbx_trestbps;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_predict;
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
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelmid;
        private System.Windows.Forms.ComboBox comboBoxgender;
        private System.Windows.Forms.ComboBox comboBoxhungary;
        private System.Windows.Forms.ComboBox comboBoxswitzerland;
        private System.Windows.Forms.ComboBox comboBoxasymptomatic;
        private System.Windows.Forms.ComboBox comboBoxfbs;
        private System.Windows.Forms.ComboBox comboBoxreslvhyper;
        private System.Windows.Forms.ComboBox comboBoxresnormal;
        private System.Windows.Forms.ComboBox comboBoxcleveland;
    }
}

