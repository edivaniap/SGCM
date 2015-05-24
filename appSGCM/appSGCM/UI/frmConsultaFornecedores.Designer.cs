namespace appSGCM.UI
{
    partial class frmConsultaFornecedores
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 39);
            this.panel1.TabIndex = 5;
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
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Enabled = false;
            this.btnVisualizar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(12, 107);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(108, 29);
            this.btnVisualizar.TabIndex = 4;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnVisualizar);
            this.groupBox1.Controls.Add(this.btnDeletar);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.btnInserir);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 382);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(12, 231);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(108, 29);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(12, 170);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(108, 29);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(12, 47);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(108, 29);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
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
            this.groupBox2.Size = new System.Drawing.Size(897, 81);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[ Filtro ]";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbRegistros);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(718, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 57);
            this.panel2.TabIndex = 6;
            // 
            // lbRegistros
            // 
            this.lbRegistros.AutoSize = true;
            this.lbRegistros.Location = new System.Drawing.Point(70, 25);
            this.lbRegistros.Name = "lbRegistros";
            this.lbRegistros.Size = new System.Drawing.Size(16, 18);
            this.lbRegistros.TabIndex = 1;
            this.lbRegistros.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de Registros";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(21, 32);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(339, 25);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtCampoFiltro_TextChanged);
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "CodFornecedor",
            "Nome",
            "Cidade",
            "UF"});
            this.cbxFiltro.Location = new System.Drawing.Point(366, 31);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(132, 26);
            this.cbxFiltro.TabIndex = 0;
            this.cbxFiltro.TextChanged += new System.EventHandler(this.cbxFiltro_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFornecedores.Location = new System.Drawing.Point(140, 81);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.Size = new System.Drawing.Size(757, 382);
            this.dgvFornecedores.TabIndex = 8;
            this.dgvFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedores_CellClick);
            // 
            // frmConsultaFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(897, 463);
            this.Controls.Add(this.dgvFornecedores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmConsultaFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGCM - Consulta de Fornecedor";
            this.Load += new System.EventHandler(this.frmConsultaFornecedores_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cbxFiltro;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbRegistros;
        private System.Windows.Forms.Label label1;
    }
}