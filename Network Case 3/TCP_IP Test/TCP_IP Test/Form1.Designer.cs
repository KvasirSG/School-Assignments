namespace TCP_IP_Test
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_connectionline = new System.Windows.Forms.Label();
            this.label_connectioninfo = new System.Windows.Forms.Label();
            this.textBox_Connectionlog = new System.Windows.Forms.TextBox();
            this.textBox_host = new System.Windows.Forms.TextBox();
            this.button_help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PC1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TCP_IP_Test.Properties.Resources.Microsoft_icon;
            this.pictureBox2.Location = new System.Drawing.Point(343, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCP_IP_Test.Properties.Resources.longhorn_0308_mycomputer_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_connectionline
            // 
            this.label_connectionline.AutoSize = true;
            this.label_connectionline.Location = new System.Drawing.Point(102, 74);
            this.label_connectionline.Name = "label_connectionline";
            this.label_connectionline.Size = new System.Drawing.Size(0, 13);
            this.label_connectionline.TabIndex = 6;
            // 
            // label_connectioninfo
            // 
            this.label_connectioninfo.AutoSize = true;
            this.label_connectioninfo.Location = new System.Drawing.Point(105, 22);
            this.label_connectioninfo.Name = "label_connectioninfo";
            this.label_connectioninfo.Size = new System.Drawing.Size(96, 13);
            this.label_connectioninfo.TabIndex = 7;
            this.label_connectioninfo.Text = "Click Start to begin";
            // 
            // textBox_Connectionlog
            // 
            this.textBox_Connectionlog.Location = new System.Drawing.Point(12, 159);
            this.textBox_Connectionlog.Multiline = true;
            this.textBox_Connectionlog.Name = "textBox_Connectionlog";
            this.textBox_Connectionlog.ReadOnly = true;
            this.textBox_Connectionlog.Size = new System.Drawing.Size(428, 166);
            this.textBox_Connectionlog.TabIndex = 8;
            // 
            // textBox_host
            // 
            this.textBox_host.Location = new System.Drawing.Point(93, 130);
            this.textBox_host.Name = "textBox_host";
            this.textBox_host.Size = new System.Drawing.Size(112, 20);
            this.textBox_host.TabIndex = 9;
            this.textBox_host.Text = "ENTER HOST HERE";
            // 
            // button_help
            // 
            this.button_help.Location = new System.Drawing.Point(212, 130);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(19, 23);
            this.button_help.TabIndex = 10;
            this.button_help.Text = "?";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 337);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.textBox_host);
            this.Controls.Add(this.textBox_Connectionlog);
            this.Controls.Add(this.label_connectioninfo);
            this.Controls.Add(this.label_connectionline);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "TCP/IP Sim";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_connectionline;
        private System.Windows.Forms.Label label_connectioninfo;
        private System.Windows.Forms.TextBox textBox_Connectionlog;
        private System.Windows.Forms.TextBox textBox_host;
        private System.Windows.Forms.Button button_help;
    }
}

