namespace CFB_Cursos_Aula
{
    partial class F_LinkLabel
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
            this.ll_Canal = new System.Windows.Forms.LinkLabel();
            this.ll_calculadora = new System.Windows.Forms.LinkLabel();
            this.ll_multiplosLinks = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ll_Canal
            // 
            this.ll_Canal.AutoSize = true;
            this.ll_Canal.Location = new System.Drawing.Point(112, 78);
            this.ll_Canal.Name = "ll_Canal";
            this.ll_Canal.Size = new System.Drawing.Size(34, 13);
            this.ll_Canal.TabIndex = 0;
            this.ll_Canal.TabStop = true;
            this.ll_Canal.Text = "Canal";
            this.ll_Canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Canal_LinkClicked);
            // 
            // ll_calculadora
            // 
            this.ll_calculadora.AutoSize = true;
            this.ll_calculadora.Location = new System.Drawing.Point(344, 78);
            this.ll_calculadora.Name = "ll_calculadora";
            this.ll_calculadora.Size = new System.Drawing.Size(63, 13);
            this.ll_calculadora.TabIndex = 1;
            this.ll_calculadora.TabStop = true;
            this.ll_calculadora.Text = "Calculadora";
            this.ll_calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_calculadora_LinkClicked);
            // 
            // ll_multiplosLinks
            // 
            this.ll_multiplosLinks.AutoSize = true;
            this.ll_multiplosLinks.Location = new System.Drawing.Point(190, 163);
            this.ll_multiplosLinks.Name = "ll_multiplosLinks";
            this.ll_multiplosLinks.Size = new System.Drawing.Size(115, 13);
            this.ll_multiplosLinks.TabIndex = 2;
            this.ll_multiplosLinks.TabStop = true;
            this.ll_multiplosLinks.Text = "Google-Yahoo-Chatgpt";
            this.ll_multiplosLinks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_multiplosLinks_LinkClicked);
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 332);
            this.Controls.Add(this.ll_multiplosLinks);
            this.Controls.Add(this.ll_calculadora);
            this.Controls.Add(this.ll_Canal);
            this.Name = "F_LinkLabel";
            this.Text = "F_LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ll_Canal;
        private System.Windows.Forms.LinkLabel ll_calculadora;
        private System.Windows.Forms.LinkLabel ll_multiplosLinks;
    }
}