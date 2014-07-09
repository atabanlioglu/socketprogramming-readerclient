namespace ReaderClient_Computer
{
    partial class ReaderClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_AlınanVeri = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Durdur = new System.Windows.Forms.Button();
            this.btn_Dinle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIpAdersi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_AlınanVeri
            // 
            this.txt_AlınanVeri.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_AlınanVeri.FormattingEnabled = true;
            this.txt_AlınanVeri.HorizontalScrollbar = true;
            this.txt_AlınanVeri.IntegralHeight = false;
            this.txt_AlınanVeri.Location = new System.Drawing.Point(102, 6);
            this.txt_AlınanVeri.Name = "txt_AlınanVeri";
            this.txt_AlınanVeri.Size = new System.Drawing.Size(570, 398);
            this.txt_AlınanVeri.TabIndex = 12;
            this.txt_AlınanVeri.SelectedIndexChanged += new System.EventHandler(this.txt_AlınanVeri_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Port Numarası";
            // 
            // btn_Durdur
            // 
            this.btn_Durdur.Location = new System.Drawing.Point(8, 152);
            this.btn_Durdur.Name = "btn_Durdur";
            this.btn_Durdur.Size = new System.Drawing.Size(75, 38);
            this.btn_Durdur.TabIndex = 10;
            this.btn_Durdur.Text = "Durdur";
            this.btn_Durdur.UseVisualStyleBackColor = true;
            this.btn_Durdur.Click += new System.EventHandler(this.btn_Durdur_Click);
            // 
            // btn_Dinle
            // 
            this.btn_Dinle.Location = new System.Drawing.Point(8, 108);
            this.btn_Dinle.Name = "btn_Dinle";
            this.btn_Dinle.Size = new System.Drawing.Size(75, 38);
            this.btn_Dinle.TabIndex = 9;
            this.btn_Dinle.Text = "Oku";
            this.btn_Dinle.UseVisualStyleBackColor = true;
            this.btn_Dinle.Click += new System.EventHandler(this.btn_Dinle_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(8, 82);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(75, 20);
            this.txt_Port.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.txtIpAdersi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Port);
            this.groupBox1.Controls.Add(this.btn_Dinle);
            this.groupBox1.Controls.Add(this.btn_Durdur);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 196);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reader Client";
            // 
            // txtIpAdersi
            // 
            this.txtIpAdersi.Location = new System.Drawing.Point(6, 39);
            this.txtIpAdersi.Name = "txtIpAdersi";
            this.txtIpAdersi.Size = new System.Drawing.Size(77, 20);
            this.txtIpAdersi.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "İp Adresi";
            // 
            // ReaderClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(724, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_AlınanVeri);
            this.Name = "ReaderClient";
            this.Text = "ReaderClient";
            this.Load += new System.EventHandler(this.ReaderClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox txt_AlınanVeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Durdur;
        private System.Windows.Forms.Button btn_Dinle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIpAdersi;
        private System.Windows.Forms.Label label2;
    }
}