namespace CFB_Cursos_Aula
{
    partial class TelaVisualizacao
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
            this.tb_Tela2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_Tela2
            // 
            this.tb_Tela2.Location = new System.Drawing.Point(12, 12);
            this.tb_Tela2.Multiline = true;
            this.tb_Tela2.Name = "tb_Tela2";
            this.tb_Tela2.Size = new System.Drawing.Size(319, 316);
            this.tb_Tela2.TabIndex = 0;
            // 
            // TelaVisualizacao
            // 
            this.ClientSize = new System.Drawing.Size(343, 340);
            this.Controls.Add(this.tb_Tela2);
            this.Name = "TelaVisualizacao";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaVisualizacao_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Tela2;
    }
}