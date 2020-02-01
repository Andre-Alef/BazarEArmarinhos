namespace SistemaTCC2
{
    partial class FrmCadastroFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroFornecedores));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefoneFornecedor2 = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.txtDataEntregaPF = new System.Windows.Forms.MaskedTextBox();
            this.mstRepresentante = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecoPFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.txtCNPJFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailFornecedor = new System.Windows.Forms.TextBox();
            this.txtQuantidadePFornecedor = new System.Windows.Forms.TextBox();
            this.txtProdutoFornecedor = new System.Windows.Forms.TextBox();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrarForn = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Fornecedores";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtTelefoneFornecedor2);
            this.groupBox1.Controls.Add(this.txtTelefoneFornecedor);
            this.groupBox1.Controls.Add(this.txtDataEntregaPF);
            this.groupBox1.Controls.Add(this.mstRepresentante);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPrecoPFornecedor);
            this.groupBox1.Controls.Add(this.txtCNPJFornecedor);
            this.groupBox1.Controls.Add(this.txtEmailFornecedor);
            this.groupBox1.Controls.Add(this.txtQuantidadePFornecedor);
            this.groupBox1.Controls.Add(this.txtProdutoFornecedor);
            this.groupBox1.Controls.Add(this.txtNomeFornecedor);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 498);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Fornecedor";
            // 
            // txtTelefoneFornecedor2
            // 
            this.txtTelefoneFornecedor2.Location = new System.Drawing.Point(193, 205);
            this.txtTelefoneFornecedor2.Mask = "(##)####-####";
            this.txtTelefoneFornecedor2.Name = "txtTelefoneFornecedor2";
            this.txtTelefoneFornecedor2.Size = new System.Drawing.Size(111, 20);
            this.txtTelefoneFornecedor2.TabIndex = 4;
            this.txtTelefoneFornecedor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneFornecedor2_KeyPress);
            // 
            // txtTelefoneFornecedor
            // 
            this.txtTelefoneFornecedor.Location = new System.Drawing.Point(193, 166);
            this.txtTelefoneFornecedor.Mask = "(##)#####-####";
            this.txtTelefoneFornecedor.Name = "txtTelefoneFornecedor";
            this.txtTelefoneFornecedor.Size = new System.Drawing.Size(111, 20);
            this.txtTelefoneFornecedor.TabIndex = 3;
            this.txtTelefoneFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneFornecedor_KeyPress);
            // 
            // txtDataEntregaPF
            // 
            this.txtDataEntregaPF.Location = new System.Drawing.Point(193, 330);
            this.txtDataEntregaPF.Mask = "##/##/####";
            this.txtDataEntregaPF.Name = "txtDataEntregaPF";
            this.txtDataEntregaPF.Size = new System.Drawing.Size(81, 20);
            this.txtDataEntregaPF.TabIndex = 7;
            this.txtDataEntregaPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataEntregaPF_KeyPress);
            // 
            // mstRepresentante
            // 
            this.mstRepresentante.Location = new System.Drawing.Point(193, 417);
            this.mstRepresentante.Name = "mstRepresentante";
            this.mstRepresentante.Size = new System.Drawing.Size(183, 20);
            this.mstRepresentante.TabIndex = 9;
            this.mstRepresentante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "Representante:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Telefone:";
            // 
            // txtPrecoPFornecedor
            // 
            this.txtPrecoPFornecedor.Location = new System.Drawing.Point(193, 250);
            this.txtPrecoPFornecedor.Name = "txtPrecoPFornecedor";
            this.txtPrecoPFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoPFornecedor.TabIndex = 5;
            this.txtPrecoPFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoPFornecedor_KeyPress);
            // 
            // txtCNPJFornecedor
            // 
            this.txtCNPJFornecedor.Location = new System.Drawing.Point(193, 76);
            this.txtCNPJFornecedor.Name = "txtCNPJFornecedor";
            this.txtCNPJFornecedor.Size = new System.Drawing.Size(191, 20);
            this.txtCNPJFornecedor.TabIndex = 1;
            this.txtCNPJFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNPJFornecedor_KeyPress);
            // 
            // txtEmailFornecedor
            // 
            this.txtEmailFornecedor.Location = new System.Drawing.Point(193, 380);
            this.txtEmailFornecedor.Name = "txtEmailFornecedor";
            this.txtEmailFornecedor.Size = new System.Drawing.Size(183, 20);
            this.txtEmailFornecedor.TabIndex = 8;
            this.txtEmailFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmailFornecedor_KeyPress);
            // 
            // txtQuantidadePFornecedor
            // 
            this.txtQuantidadePFornecedor.Location = new System.Drawing.Point(193, 287);
            this.txtQuantidadePFornecedor.Name = "txtQuantidadePFornecedor";
            this.txtQuantidadePFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadePFornecedor.TabIndex = 6;
            this.txtQuantidadePFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadePFornecedor_KeyPress);
            // 
            // txtProdutoFornecedor
            // 
            this.txtProdutoFornecedor.Location = new System.Drawing.Point(193, 122);
            this.txtProdutoFornecedor.Name = "txtProdutoFornecedor";
            this.txtProdutoFornecedor.Size = new System.Drawing.Size(191, 20);
            this.txtProdutoFornecedor.TabIndex = 2;
            this.txtProdutoFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdutoFornecedor_KeyPress);
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(193, 39);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(283, 20);
            this.txtNomeFornecedor.TabIndex = 0;
            this.txtNomeFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeFornecedor_KeyPress);
            this.txtNomeFornecedor.Leave += new System.EventHandler(this.txtNomeFornecedor_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Telefone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Data da entrega:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Preço:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "CNPJ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome do Fornecedor:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCadastrarForn
            // 
            this.btnCadastrarForn.BackColor = System.Drawing.Color.White;
            this.btnCadastrarForn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarForn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrarForn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadastrarForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarForn.Location = new System.Drawing.Point(22, 608);
            this.btnCadastrarForn.Name = "btnCadastrarForn";
            this.btnCadastrarForn.Size = new System.Drawing.Size(97, 30);
            this.btnCadastrarForn.TabIndex = 10;
            this.btnCadastrarForn.Text = "Cadastrar";
            this.btnCadastrarForn.UseVisualStyleBackColor = false;
            this.btnCadastrarForn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(168, 608);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 30);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(624, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "X";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FrmCadastroFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SistemaTCC2.Properties.Resources.BorClientes;
            this.ClientSize = new System.Drawing.Size(660, 666);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrarForn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroFornecedores";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.MaskedTextBox txtPrecoPFornecedor;
        public System.Windows.Forms.MaskedTextBox txtCNPJFornecedor;
        public System.Windows.Forms.TextBox txtEmailFornecedor;
        public System.Windows.Forms.TextBox txtQuantidadePFornecedor;
        public System.Windows.Forms.TextBox txtProdutoFornecedor;
        public System.Windows.Forms.TextBox txtNomeFornecedor;
        public System.Windows.Forms.MaskedTextBox mstRepresentante;
        public System.Windows.Forms.MaskedTextBox txtDataEntregaPF;
        public System.Windows.Forms.MaskedTextBox txtTelefoneFornecedor2;
        public System.Windows.Forms.MaskedTextBox txtTelefoneFornecedor;
        public System.Windows.Forms.Button btnCadastrarForn;
        private System.Windows.Forms.Button button6;
    }
}