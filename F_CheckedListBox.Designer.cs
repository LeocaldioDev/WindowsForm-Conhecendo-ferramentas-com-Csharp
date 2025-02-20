namespace CFB_Cursos_Aula
{
    partial class F_CheckedListBox
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
            this.clb_Veiculos = new System.Windows.Forms.CheckedListBox();
            this.btn_MostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_ResetarLista = new System.Windows.Forms.Button();
            this.tb_Adicionartransporte = new System.Windows.Forms.TextBox();
            this.btn_adicionarTransporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_Veiculos
            // 
            this.clb_Veiculos.FormattingEnabled = true;
            this.clb_Veiculos.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.clb_Veiculos.Location = new System.Drawing.Point(12, 12);
            this.clb_Veiculos.Name = "clb_Veiculos";
            this.clb_Veiculos.Size = new System.Drawing.Size(248, 379);
            this.clb_Veiculos.TabIndex = 0;
            // 
            // btn_MostrarSelecionados
            // 
            this.btn_MostrarSelecionados.Location = new System.Drawing.Point(266, 24);
            this.btn_MostrarSelecionados.Name = "btn_MostrarSelecionados";
            this.btn_MostrarSelecionados.Size = new System.Drawing.Size(284, 23);
            this.btn_MostrarSelecionados.TabIndex = 1;
            this.btn_MostrarSelecionados.Text = "Mostrar Selecionados";
            this.btn_MostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_MostrarSelecionados.Click += new System.EventHandler(this.btn_MostrarSelecionados_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(266, 66);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(284, 23);
            this.btn_limpar.TabIndex = 2;
            this.btn_limpar.Text = "Limpar Lista";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_ResetarLista
            // 
            this.btn_ResetarLista.Location = new System.Drawing.Point(266, 115);
            this.btn_ResetarLista.Name = "btn_ResetarLista";
            this.btn_ResetarLista.Size = new System.Drawing.Size(284, 23);
            this.btn_ResetarLista.TabIndex = 3;
            this.btn_ResetarLista.Text = "Resetar Lista";
            this.btn_ResetarLista.UseVisualStyleBackColor = true;
            this.btn_ResetarLista.Click += new System.EventHandler(this.btn_ResetarLista_Click);
            // 
            // tb_Adicionartransporte
            // 
            this.tb_Adicionartransporte.Location = new System.Drawing.Point(266, 317);
            this.tb_Adicionartransporte.Name = "tb_Adicionartransporte";
            this.tb_Adicionartransporte.Size = new System.Drawing.Size(284, 20);
            this.tb_Adicionartransporte.TabIndex = 4;
            // 
            // btn_adicionarTransporte
            // 
            this.btn_adicionarTransporte.Location = new System.Drawing.Point(266, 343);
            this.btn_adicionarTransporte.Name = "btn_adicionarTransporte";
            this.btn_adicionarTransporte.Size = new System.Drawing.Size(284, 23);
            this.btn_adicionarTransporte.TabIndex = 5;
            this.btn_adicionarTransporte.Text = "Adicionar Transporte";
            this.btn_adicionarTransporte.UseVisualStyleBackColor = true;
            this.btn_adicionarTransporte.Click += new System.EventHandler(this.btn_adicionarTransporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um novo transporte";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 404);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_adicionarTransporte);
            this.Controls.Add(this.tb_Adicionartransporte);
            this.Controls.Add(this.btn_ResetarLista);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_MostrarSelecionados);
            this.Controls.Add(this.clb_Veiculos);
            this.Name = "F_CheckedListBox";
            this.Text = "F_CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_Veiculos;
        private System.Windows.Forms.Button btn_MostrarSelecionados;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_ResetarLista;
        private System.Windows.Forms.TextBox tb_Adicionartransporte;
        private System.Windows.Forms.Button btn_adicionarTransporte;
        private System.Windows.Forms.Label label1;
    }
}