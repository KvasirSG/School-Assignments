namespace TCP_IP_Test
{
    partial class Form_help
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
            this.textBox_help = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_help
            // 
            this.textBox_help.Location = new System.Drawing.Point(13, 13);
            this.textBox_help.Multiline = true;
            this.textBox_help.Name = "textBox_help";
            this.textBox_help.ReadOnly = true;
            this.textBox_help.Size = new System.Drawing.Size(259, 236);
            this.textBox_help.TabIndex = 0;
            // 
            // Form_help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox_help);
            this.Name = "Form_help";
            this.Text = "Form_help";
            this.Load += new System.EventHandler(this.Form_help_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_help;
    }
}