namespace appSGCM.UI
{
    partial class frmCalculadora
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
            this.btnVirgula = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxTela = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnNegativo = new System.Windows.Forms.Button();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.btnInverso = new System.Windows.Forms.Button();
            this.btnIgualdade = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVirgula
            // 
            this.btnVirgula.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(103, 257);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(40, 40);
            this.btnVirgula.TabIndex = 35;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxTela);
            this.groupBox2.Location = new System.Drawing.Point(11, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 56);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            // 
            // tbxTela
            // 
            this.tbxTela.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTela.Location = new System.Drawing.Point(6, 11);
            this.tbxTela.Name = "tbxTela";
            this.tbxTela.ReadOnly = true;
            this.tbxTela.Size = new System.Drawing.Size(213, 36);
            this.tbxTela.TabIndex = 0;
            this.tbxTela.Text = "0";
            this.tbxTela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn0.Location = new System.Drawing.Point(11, 257);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(86, 40);
            this.btn0.TabIndex = 34;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.Red;
            this.btnC.Location = new System.Drawing.Point(103, 73);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(40, 40);
            this.btnC.TabIndex = 47;
            this.btnC.Text = "c";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.Color.Red;
            this.btnCE.Location = new System.Drawing.Point(57, 73);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(40, 40);
            this.btnCE.TabIndex = 46;
            this.btnCE.Text = "ce";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(11, 73);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(40, 40);
            this.btnApagar.TabIndex = 45;
            this.btnApagar.Text = "←";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnRaiz.Location = new System.Drawing.Point(195, 73);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(40, 40);
            this.btnRaiz.TabIndex = 44;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnNegativo
            // 
            this.btnNegativo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegativo.ForeColor = System.Drawing.Color.Red;
            this.btnNegativo.Location = new System.Drawing.Point(149, 73);
            this.btnNegativo.Name = "btnNegativo";
            this.btnNegativo.Size = new System.Drawing.Size(40, 40);
            this.btnNegativo.TabIndex = 43;
            this.btnNegativo.Text = "+/-";
            this.btnNegativo.UseVisualStyleBackColor = true;
            this.btnNegativo.Click += new System.EventHandler(this.btnNegativo_Click);
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentagem.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnPorcentagem.Location = new System.Drawing.Point(195, 119);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(40, 40);
            this.btnPorcentagem.TabIndex = 42;
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = true;
            this.btnPorcentagem.Click += new System.EventHandler(this.btnPorcentagem_Click);
            // 
            // btnInverso
            // 
            this.btnInverso.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverso.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnInverso.Location = new System.Drawing.Point(195, 165);
            this.btnInverso.Name = "btnInverso";
            this.btnInverso.Size = new System.Drawing.Size(40, 40);
            this.btnInverso.TabIndex = 41;
            this.btnInverso.Text = "1/x";
            this.btnInverso.UseVisualStyleBackColor = true;
            this.btnInverso.Click += new System.EventHandler(this.btnInverso_Click);
            // 
            // btnIgualdade
            // 
            this.btnIgualdade.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgualdade.ForeColor = System.Drawing.Color.Red;
            this.btnIgualdade.Location = new System.Drawing.Point(195, 211);
            this.btnIgualdade.Name = "btnIgualdade";
            this.btnIgualdade.Size = new System.Drawing.Size(40, 86);
            this.btnIgualdade.TabIndex = 40;
            this.btnIgualdade.Text = "=";
            this.btnIgualdade.UseVisualStyleBackColor = true;
            this.btnIgualdade.Click += new System.EventHandler(this.btnIgualdade_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacao.ForeColor = System.Drawing.Color.Red;
            this.btnMultiplicacao.Location = new System.Drawing.Point(149, 165);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(40, 40);
            this.btnMultiplicacao.TabIndex = 37;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.ForeColor = System.Drawing.Color.Red;
            this.btnSubtracao.Location = new System.Drawing.Point(149, 211);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(40, 40);
            this.btnSubtracao.TabIndex = 36;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn8.Location = new System.Drawing.Point(57, 119);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 40);
            this.btn8.TabIndex = 32;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn7.Location = new System.Drawing.Point(11, 119);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 40);
            this.btn7.TabIndex = 31;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn6.Location = new System.Drawing.Point(103, 165);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 40);
            this.btn6.TabIndex = 30;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn5.Location = new System.Drawing.Point(57, 165);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 40);
            this.btn5.TabIndex = 29;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn4.Location = new System.Drawing.Point(11, 165);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 40);
            this.btn4.TabIndex = 28;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn9.Location = new System.Drawing.Point(103, 119);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 40);
            this.btn9.TabIndex = 33;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn3.Location = new System.Drawing.Point(103, 211);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 40);
            this.btn3.TabIndex = 27;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn2.Location = new System.Drawing.Point(57, 211);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 40);
            this.btn2.TabIndex = 26;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn.Location = new System.Drawing.Point(11, 211);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(40, 40);
            this.btn.TabIndex = 25;
            this.btn.Text = "1";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnAdicao
            // 
            this.btnAdicao.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicao.ForeColor = System.Drawing.Color.Red;
            this.btnAdicao.Location = new System.Drawing.Point(149, 257);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(40, 40);
            this.btnAdicao.TabIndex = 39;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.ForeColor = System.Drawing.Color.Red;
            this.btnDivisao.Location = new System.Drawing.Point(149, 119);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(40, 40);
            this.btnDivisao.TabIndex = 38;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(247, 309);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnNegativo);
            this.Controls.Add(this.btnPorcentagem);
            this.Controls.Add(this.btnInverso);
            this.Controls.Add(this.btnIgualdade);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.btnDivisao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGCM - Calculadora";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxTela;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnNegativo;
        private System.Windows.Forms.Button btnPorcentagem;
        private System.Windows.Forms.Button btnInverso;
        private System.Windows.Forms.Button btnIgualdade;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnDivisao;
    }
}