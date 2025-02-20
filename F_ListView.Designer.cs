namespace CFB_Cursos_Aula
{
    partial class F_ListView
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Computador",
            "2",
            "120.000kz"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Munitor",
            "4",
            "50.000kz"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Mouse",
            "12",
            "12.000kz"}, -1);
            this.ListView_Principal = new System.Windows.Forms.ListView();
            this.lv_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_produto = new System.Windows.Forms.TextBox();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListView_Principal
            // 
            this.ListView_Principal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lv_id,
            this.lv_produto,
            this.lv_quantidade,
            this.lv_preco});
            this.ListView_Principal.FullRowSelect = true;
            this.ListView_Principal.HideSelection = false;
            this.ListView_Principal.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.ListView_Principal.Location = new System.Drawing.Point(12, 12);
            this.ListView_Principal.MultiSelect = false;
            this.ListView_Principal.Name = "ListView_Principal";
            this.ListView_Principal.Size = new System.Drawing.Size(514, 117);
            this.ListView_Principal.TabIndex = 0;
            this.ListView_Principal.UseCompatibleStateImageBehavior = false;
            this.ListView_Principal.View = System.Windows.Forms.View.Details;
            // 
            // lv_id
            // 
            this.lv_id.Text = "ID";
            this.lv_id.Width = 100;
            // 
            // lv_produto
            // 
            this.lv_produto.Text = "Produto";
            this.lv_produto.Width = 120;
            // 
            // lv_quantidade
            // 
            this.lv_quantidade.Text = "Quantidade";
            this.lv_quantidade.Width = 130;
            // 
            // lv_preco
            // 
            this.lv_preco.Text = "Preço";
            this.lv_preco.Width = 120;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(13, 208);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(58, 20);
            this.tb_id.TabIndex = 1;
            // 
            // tb_produto
            // 
            this.tb_produto.Location = new System.Drawing.Point(88, 208);
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Size = new System.Drawing.Size(183, 20);
            this.tb_produto.TabIndex = 2;
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Location = new System.Drawing.Point(290, 207);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(73, 20);
            this.tb_quantidade.TabIndex = 3;
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(383, 207);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(130, 20);
            this.tb_preco.TabIndex = 4;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(13, 255);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(179, 26);
            this.btn_adicionar.TabIndex = 5;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(13, 288);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(179, 25);
            this.btn_remover.TabIndex = 6;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(13, 320);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(179, 28);
            this.btn_obter.TabIndex = 7;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Preço";
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 402);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.tb_quantidade);
            this.Controls.Add(this.tb_produto);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.ListView_Principal);
            this.Name = "F_ListView";
            this.Text = "F_ListView";
            this.Load += new System.EventHandler(this.F_ListView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListView_Principal;
        private System.Windows.Forms.ColumnHeader lv_id;
        private System.Windows.Forms.ColumnHeader lv_produto;
        private System.Windows.Forms.ColumnHeader lv_quantidade;
        private System.Windows.Forms.ColumnHeader lv_preco;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_produto;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_obter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}