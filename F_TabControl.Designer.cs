namespace CFB_Cursos_Aula
{
    partial class F_TabControl
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
            this.btn_novatab = new System.Windows.Forms.Button();
            this.btn_removertab = new System.Windows.Forms.Button();
            this.btn_posicionarNaTab = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_nometab = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_novatab
            // 
            this.btn_novatab.Location = new System.Drawing.Point(195, 40);
            this.btn_novatab.Name = "btn_novatab";
            this.btn_novatab.Size = new System.Drawing.Size(162, 23);
            this.btn_novatab.TabIndex = 0;
            this.btn_novatab.Text = "Nova Tab";
            this.btn_novatab.UseVisualStyleBackColor = true;
            this.btn_novatab.Click += new System.EventHandler(this.btn_novatab_Click);
            // 
            // btn_removertab
            // 
            this.btn_removertab.Location = new System.Drawing.Point(363, 40);
            this.btn_removertab.Name = "btn_removertab";
            this.btn_removertab.Size = new System.Drawing.Size(148, 23);
            this.btn_removertab.TabIndex = 1;
            this.btn_removertab.Text = "Remover Tab actual";
            this.btn_removertab.UseVisualStyleBackColor = true;
            this.btn_removertab.Click += new System.EventHandler(this.btn_removertab_Click);
            // 
            // btn_posicionarNaTab
            // 
            this.btn_posicionarNaTab.Location = new System.Drawing.Point(195, 100);
            this.btn_posicionarNaTab.Name = "btn_posicionarNaTab";
            this.btn_posicionarNaTab.Size = new System.Drawing.Size(162, 23);
            this.btn_posicionarNaTab.TabIndex = 2;
            this.btn_posicionarNaTab.Text = "Posicionar na Tab";
            this.btn_posicionarNaTab.UseVisualStyleBackColor = true;
            this.btn_posicionarNaTab.Click += new System.EventHandler(this.btn_posicionarNaTab_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 129);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 293);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(628, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_nometab
            // 
            this.tb_nometab.Location = new System.Drawing.Point(13, 40);
            this.tb_nometab.Name = "tb_nometab";
            this.tb_nometab.Size = new System.Drawing.Size(176, 20);
            this.tb_nometab.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 100);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(176, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // F_TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 422);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.tb_nometab);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_posicionarNaTab);
            this.Controls.Add(this.btn_removertab);
            this.Controls.Add(this.btn_novatab);
            this.Name = "F_TabControl";
            this.Text = "F_TabControl";
            this.Load += new System.EventHandler(this.F_TabControl_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_novatab;
        private System.Windows.Forms.Button btn_removertab;
        private System.Windows.Forms.Button btn_posicionarNaTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_nometab;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}