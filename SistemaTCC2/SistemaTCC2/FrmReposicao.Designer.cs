namespace SistemaTCC2
{
    partial class FrmReposicao
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataEntregaPF = new System.Windows.Forms.MaskedTextBox();
            this.txtProdutoFornecedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecoProduto = new System.Windows.Forms.MaskedTextBox();
            this.txtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskVencimento = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtParcelasReposicao = new System.Windows.Forms.TextBox();
            this.btnRepor = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtIDProduto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reposição de Produtos";
            // 
            // txtDataEntregaPF
            // 
            this.txtDataEntregaPF.Location = new System.Drawing.Point(172, 115);
            this.txtDataEntregaPF.Mask = "##/##/####";
            this.txtDataEntregaPF.Name = "txtDataEntregaPF";
            this.txtDataEntregaPF.Size = new System.Drawing.Size(72, 20);
            this.txtDataEntregaPF.TabIndex = 2;
            this.txtDataEntregaPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDataEntregaPF_MaskInputRejected);
            // 
            // txtProdutoFornecedor
            // 
            this.txtProdutoFornecedor.Location = new System.Drawing.Point(172, 77);
            this.txtProdutoFornecedor.Name = "txtProdutoFornecedor";
            this.txtProdutoFornecedor.Size = new System.Drawing.Size(191, 20);
            this.txtProdutoFornecedor.TabIndex = 1;
            this.txtProdutoFornecedor.Click += new System.EventHandler(this.txtProdutoFornecedor_Click);
            this.txtProdutoFornecedor.Leave += new System.EventHandler(this.txtProdutoFornecedor_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Data da entrega:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nome Produto:";
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.Location = new System.Drawing.Point(172, 157);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoProduto.TabIndex = 3;
            // 
            // txtQuantidadeProduto
            // 
            this.txtQuantidadeProduto.Location = new System.Drawing.Point(172, 299);
            this.txtQuantidadeProduto.Name = "txtQuantidadeProduto";
            this.txtQuantidadeProduto.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeProduto.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Preço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Data de Vencimento:";
            // 
            // mskVencimento
            // 
            this.mskVencimento.Location = new System.Drawing.Point(172, 215);
            this.mskVencimento.Mask = "00/00/0000";
            this.mskVencimento.Name = "mskVencimento";
            this.mskVencimento.Size = new System.Drawing.Size(72, 20);
            this.mskVencimento.TabIndex = 4;
            this.mskVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 18);
            this.label8.TabIndex = 33;
            this.label8.Text = "Parcelas:";
            // 
            // txtParcelasReposicao
            // 
            this.txtParcelasReposicao.Location = new System.Drawing.Point(172, 258);
            this.txtParcelasReposicao.Name = "txtParcelasReposicao";
            this.txtParcelasReposicao.Size = new System.Drawing.Size(100, 20);
            this.txtParcelasReposicao.TabIndex = 5;
            // 
            // btnRepor
            // 
            this.btnRepor.BackColor = System.Drawing.Color.White;
            this.btnRepor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRepor.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnRepor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRepor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRepor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepor.Location = new System.Drawing.Point(15, 438);
            this.btnRepor.Name = "btnRepor";
            this.btnRepor.Size = new System.Drawing.Size(107, 29);
            this.btnRepor.TabIndex = 7;
            this.btnRepor.Text = "Salvar";
            this.btnRepor.UseVisualStyleBackColor = false;
            this.btnRepor.Click += new System.EventHandler(this.btnRepor_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(480, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "X";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.Location = new System.Drawing.Point(404, 258);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(100, 20);
            this.txtIDProduto.TabIndex = 34;
            this.txtIDProduto.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 343);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da reposição ";
            // 
            // FrmReposicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SistemaTCC2.Properties.Resources.BorReposicao;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 514);
            this.Controls.Add(this.txtIDProduto);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnRepor);
            this.Controls.Add(this.txtParcelasReposicao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mskVencimento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecoProduto);
            this.Controls.Add(this.txtQuantidadeProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataEntregaPF);
            this.Controls.Add(this.txtProdutoFornecedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReposicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReposicao";
            this.Load += new System.EventHandler(this.FrmReposicao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox txtDataEntregaPF;
        public System.Windows.Forms.TextBox txtProdutoFornecedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.MaskedTextBox txtPrecoProduto;
        public System.Windows.Forms.TextBox txtQuantidadeProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnRepor;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.MaskedTextBox mskVencimento;
        public System.Windows.Forms.TextBox txtParcelasReposicao;
        public System.Windows.Forms.TextBox txtIDProduto;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}