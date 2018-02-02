namespace TürkçeyiİngilizceyeCevir
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
            this.BtNÇevir = new System.Windows.Forms.Button();
            this.txtLitter = new System.Windows.Forms.TextBox();
            this.cOutputLang = new System.Windows.Forms.ComboBox();
            this.cInputLang = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtNÇevir
            // 
            this.BtNÇevir.Location = new System.Drawing.Point(168, 125);
            this.BtNÇevir.Name = "BtNÇevir";
            this.BtNÇevir.Size = new System.Drawing.Size(179, 21);
            this.BtNÇevir.TabIndex = 7;
            this.BtNÇevir.Text = "Translate";
            this.BtNÇevir.UseVisualStyleBackColor = true;
            this.BtNÇevir.Click += new System.EventHandler(this.BtNÇevir_Click);
            // 
            // txtLitter
            // 
            this.txtLitter.Location = new System.Drawing.Point(3, 3);
            this.txtLitter.Multiline = true;
            this.txtLitter.Name = "txtLitter";
            this.txtLitter.Size = new System.Drawing.Size(344, 116);
            this.txtLitter.TabIndex = 4;
            // 
            // cOutputLang
            // 
            this.cOutputLang.FormattingEnabled = true;
            this.cOutputLang.Location = new System.Drawing.Point(83, 125);
            this.cOutputLang.Name = "cOutputLang";
            this.cOutputLang.Size = new System.Drawing.Size(74, 21);
            this.cOutputLang.TabIndex = 9;
            // 
            // cInputLang
            // 
            this.cInputLang.FormattingEnabled = true;
            this.cInputLang.Location = new System.Drawing.Point(3, 125);
            this.cInputLang.Name = "cInputLang";
            this.cInputLang.Size = new System.Drawing.Size(74, 21);
            this.cInputLang.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 164);
            this.Controls.Add(this.cOutputLang);
            this.Controls.Add(this.cInputLang);
            this.Controls.Add(this.BtNÇevir);
            this.Controls.Add(this.txtLitter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtNÇevir;
        private System.Windows.Forms.TextBox txtLitter;
        private System.Windows.Forms.ComboBox cOutputLang;
        private System.Windows.Forms.ComboBox cInputLang;
    }
}

