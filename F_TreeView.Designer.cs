namespace CFB_Cursos_Aula
{
    partial class F_TreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Novas Hurbanizações");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Pedreira");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Paraiso");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Cacuaco", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Da Barra");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ngoma");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Sambizanga", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nó8");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(26, 23);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "N_novashurbanizacoes";
            treeNode1.Text = "Novas Hurbanizações";
            treeNode2.Name = "N_pedreira";
            treeNode2.Text = "Pedreira";
            treeNode3.Name = "N_paraiso";
            treeNode3.Text = "Paraiso";
            treeNode4.Name = "N_cacuaco";
            treeNode4.Tag = "Municipio de Cacuaco";
            treeNode4.Text = "Cacuaco";
            treeNode5.Name = "N_dabarra";
            treeNode5.Text = "Da Barra";
            treeNode6.Name = "N_ngoma";
            treeNode6.Text = "Ngoma";
            treeNode7.Name = "N_sambila";
            treeNode7.Tag = "Municipio de Luanda";
            treeNode7.Text = "Sambizanga";
            treeNode8.Name = "Nó8";
            treeNode8.Tag = "Muni";
            treeNode8.Text = "Nó8";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(155, 299);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(257, 23);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(130, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(257, 52);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(130, 23);
            this.btn_remover.TabIndex = 2;
            this.btn_remover.Text = "remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(257, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "remover selecionado";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.AccessibleDescription = "";
            this.textBox2.Location = new System.Drawing.Point(257, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 5;
            // 
            // F_TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 395);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.treeView1);
            this.Name = "F_TreeView";
            this.Text = "F_TreeView";
            this.Load += new System.EventHandler(this.F_TreeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}