namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.listport = new System.Windows.Forms.ListBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.txtMSG = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listport
            // 
            this.listport.FormattingEnabled = true;
            this.listport.Location = new System.Drawing.Point(12, 23);
            this.listport.Name = "listport";
            this.listport.Size = new System.Drawing.Size(120, 95);
            this.listport.TabIndex = 0;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(12, 150);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(120, 28);
            this.btnopen.TabIndex = 1;
            this.btnopen.Text = "Open Port";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // txtMSG
            // 
            this.txtMSG.Location = new System.Drawing.Point(176, 70);
            this.txtMSG.Name = "txtMSG";
            this.txtMSG.Size = new System.Drawing.Size(100, 20);
            this.txtMSG.TabIndex = 2;
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(12, 190);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(120, 28);
            this.btnsend.TabIndex = 3;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(12, 230);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(120, 28);
            this.close.TabIndex = 4;
            this.close.Text = "Close Port";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // read
            // 
            this.read.AutoSize = true;
            this.read.Location = new System.Drawing.Point(173, 54);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(28, 13);
            this.read.TabIndex = 5;
            this.read.Text = "read";
            this.read.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 284);
            this.Controls.Add(this.read);
            this.Controls.Add(this.close);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txtMSG);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.listport);
            this.Name = "Form1";
            this.Text = "SerialPort_GPS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ListBox listport;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.TextBox txtMSG;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label read;
    }
}

