namespace appSGCM.UI
{
    partial class frmConsultarProdVendidos
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
            this.dgvProdutosVendidos = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosVendidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutosVendidos
            // 
            this.dgvProdutosVendidos.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvProdutosVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosVendidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutosVendidos.Location = new System.Drawing.Point(140, 71);
            this.dgvProdutosVendidos.Name = "dgvProdutosVendidos";
            this.dgvProdutosVendidos.Size = new System.Drawing.Size(529, 385);
            this.dgvProdutosVendidos.TabIndex = 19;
            this.dgvProdutosVendidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutosVendidos_CellClick);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(12, 28);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(339, 25);
            this.txtFiltro.TabIndex = 4;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "CodProdVendidos",
            "CodVenda",
            "CodProduto",
            "Quantidade"});
            this.cbxFiltro.Location = new System.Drawing.Point(357, 27);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(132, 26);
            this.cbxFiltro.TabIndex = 3;
            this.cbxFiltro.TextChanged += new System.EventHandler(this.cbxFiltro_TextChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(9, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(108, 29);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnDeletar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 385);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 39);
            this.panel1.TabIndex = 5;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(12, 24);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(108, 29);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.txtFiltro);
            this.groupBox2.Controls.Add(this.cbxFiltro);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 71);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[ Filtro ]";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbRegistros);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(504, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 47);
            this.panel2.TabIndex = 7;
            // 
            // lbRegistros
            // 
            this.lbRegistros.AutoSize = true;
            this.lbRegistros.Location = new System.Drawing.Point(59, 23);
            this.lbRegistros.Name = "lbRegistros";
            this.lbRegistros.Size = new System.Drawing.Size(16, 18);
            this.lbRegistros.TabIndex = 1;
            this.lbRegistros.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de Registros";
            // 
            // frmConsultarProdVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(669, 456);
            this.Controls.Add(this.dgvProdutosVendidos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmConsultarProdVendidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGCM - Consulta de Produtos Vendidos";
            this.Load += new System.EventHandler(this.frmConsultarProdVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosVendidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutosVendidos;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbRegistros;
        private System.Windows.Forms.Label label1;
    }
}