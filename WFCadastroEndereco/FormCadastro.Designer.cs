namespace WFCadastroEndereco
{
    partial class FormCadastro
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
            lblNomeCompleto = new Label();
            txtNomeCompleto = new TextBox();
            btnSalvar = new Button();
            lblCep = new Label();
            mkdCEP = new MaskedTextBox();
            lblLinha = new Label();
            lblLogradouro = new Label();
            lblComplemento = new Label();
            lblCidade = new Label();
            txtLogradouro = new TextBox();
            txtNumero = new TextBox();
            lblNumero = new Label();
            txtComplemento = new TextBox();
            txtCidade = new TextBox();
            cbxUF = new ComboBox();
            lblUF = new Label();
            chkSemNumero = new CheckBox();
            txtBairro = new TextBox();
            lblBairro = new Label();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(18, 23);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(96, 15);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(18, 41);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(412, 23);
            txtNomeCompleto.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.save;
            btnSalvar.Location = new Point(351, 323);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 41);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(18, 102);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 9;
            lblCep.Text = "CEP";
            // 
            // mkdCEP
            // 
            mkdCEP.Location = new Point(18, 120);
            mkdCEP.Mask = "00000-999";
            mkdCEP.Name = "mkdCEP";
            mkdCEP.ResetOnSpace = false;
            mkdCEP.Size = new Size(96, 23);
            mkdCEP.TabIndex = 2;
            // 
            // lblLinha
            // 
            lblLinha.BorderStyle = BorderStyle.Fixed3D;
            lblLinha.Location = new Point(18, 83);
            lblLinha.Name = "lblLinha";
            lblLinha.Size = new Size(429, 1);
            lblLinha.TabIndex = 13;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(18, 157);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 14;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(18, 217);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 15;
            lblComplemento.Text = "Complemento";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(18, 276);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 16;
            lblCidade.Text = "Cidade";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(18, 180);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(254, 23);
            txtLogradouro.TabIndex = 3;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(292, 180);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(53, 23);
            txtNumero.TabIndex = 4;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(292, 162);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 19;
            lblNumero.Text = "Número";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(18, 235);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(171, 23);
            txtComplemento.TabIndex = 5;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(18, 294);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(100, 23);
            txtCidade.TabIndex = 7;
            // 
            // cbxUF
            // 
            cbxUF.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUF.FormattingEnabled = true;
            cbxUF.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxUF.Location = new Point(207, 294);
            cbxUF.Name = "cbxUF";
            cbxUF.Size = new Size(121, 23);
            cbxUF.TabIndex = 8;
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Location = new Point(207, 276);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(21, 15);
            lblUF.TabIndex = 23;
            lblUF.Text = "UF";
            // 
            // chkSemNumero
            // 
            chkSemNumero.AutoSize = true;
            chkSemNumero.Location = new Point(351, 182);
            chkSemNumero.Name = "chkSemNumero";
            chkSemNumero.Size = new Size(96, 19);
            chkSemNumero.TabIndex = 24;
            chkSemNumero.Text = "Sem Número";
            chkSemNumero.UseVisualStyleBackColor = true;
            chkSemNumero.CheckedChanged += chkSemNumero_CheckedChanged;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(207, 235);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(171, 23);
            txtBairro.TabIndex = 6;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(207, 217);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 25;
            lblBairro.Text = "Bairro";
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 376);
            Controls.Add(txtBairro);
            Controls.Add(lblBairro);
            Controls.Add(chkSemNumero);
            Controls.Add(lblUF);
            Controls.Add(cbxUF);
            Controls.Add(txtCidade);
            Controls.Add(txtComplemento);
            Controls.Add(lblNumero);
            Controls.Add(txtNumero);
            Controls.Add(txtLogradouro);
            Controls.Add(lblCidade);
            Controls.Add(lblComplemento);
            Controls.Add(lblLogradouro);
            Controls.Add(lblLinha);
            Controls.Add(mkdCEP);
            Controls.Add(lblCep);
            Controls.Add(btnSalvar);
            Controls.Add(txtNomeCompleto);
            Controls.Add(lblNomeCompleto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private TextBox txtNomeCompleto;
        private Button btnSalvar;
        private Label lblCep;
        private Label label2;
        private MaskedTextBox mkdCEP;
        private Label lblLinha;
        private Label lblLogradouro;
        private Label lblComplemento;
        private Label lblCidade;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private Label lblNumero;
        private TextBox txtComplemento;
        private TextBox txtCidade;
        private ComboBox cbxUF;
        private Label lblUF;
        private CheckBox chkSemNumero;
        private TextBox txtBairro;
        private Label lblBairro;
    }
}