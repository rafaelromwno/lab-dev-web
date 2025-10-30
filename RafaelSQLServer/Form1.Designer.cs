namespace RafaelSQLServer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            labelId = new Label();
            labelNome = new Label();
            labelTelefone = new Label();
            labelIdade = new Label();
            textBoxId = new TextBox();
            textBoxNome = new TextBox();
            textBoxTelefone = new TextBox();
            textBoxIdade = new TextBox();
            buttonAdicionar = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 152, 219);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(428, 41);
            button1.Name = "button1";
            button1.Size = new Size(343, 57);
            button1.TabIndex = 5;
            button1.Text = "\U0001f9f1 CRIAR TABELA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += CriarTabela;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(46, 204, 113);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(428, 104);
            button2.Name = "button2";
            button2.Size = new Size(343, 57);
            button2.TabIndex = 4;
            button2.Text = "➕ INSERIR DADO";
            button2.UseVisualStyleBackColor = false;
            button2.Click += InserirDados;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(241, 196, 15);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(428, 167);
            button3.Name = "button3";
            button3.Size = new Size(343, 57);
            button3.TabIndex = 3;
            button3.Text = "🔄 ATUALIZAR DADO";
            button3.UseVisualStyleBackColor = false;
            button3.Click += AtualizarDados;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(155, 89, 182);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(428, 230);
            button4.Name = "button4";
            button4.Size = new Size(343, 57);
            button4.TabIndex = 2;
            button4.Text = "📖 LER DADO(S)";
            button4.UseVisualStyleBackColor = false;
            button4.Click += LerDados;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(231, 76, 60);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(428, 293);
            button5.Name = "button5";
            button5.Size = new Size(343, 57);
            button5.TabIndex = 1;
            button5.Text = "🗑️ APAGAR DADO";
            button5.UseVisualStyleBackColor = false;
            button5.Click += ApagarDados;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 57, 43);
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(428, 356);
            button6.Name = "button6";
            button6.Size = new Size(343, 57);
            button6.TabIndex = 0;
            button6.Text = "⚠️ APAGAR TABELA";
            button6.UseVisualStyleBackColor = false;
            button6.Click += DeletarTabela;
            // 
            // labelId
            // 
            labelId.Location = new Point(108, 121);
            labelId.Name = "labelId";
            labelId.Size = new Size(88, 33);
            labelId.TabIndex = 6;
            labelId.Text = "ID:";
            // 
            // labelNome
            // 
            labelNome.Location = new Point(108, 161);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(88, 33);
            labelNome.TabIndex = 7;
            labelNome.Text = "Nome:";
            // 
            // labelTelefone
            // 
            labelTelefone.Location = new Point(108, 201);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(88, 33);
            labelTelefone.TabIndex = 8;
            labelTelefone.Text = "Telefone:";
            // 
            // labelIdade
            // 
            labelIdade.Location = new Point(108, 241);
            labelIdade.Name = "labelIdade";
            labelIdade.Size = new Size(88, 33);
            labelIdade.TabIndex = 9;
            labelIdade.Text = "Idade:";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(202, 121);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(144, 23);
            textBoxId.TabIndex = 10;
            textBoxId.TextChanged += textBoxId_TextChanged;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(202, 161);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(144, 23);
            textBoxNome.TabIndex = 11;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(202, 201);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(144, 23);
            textBoxTelefone.TabIndex = 12;
            // 
            // textBoxIdade
            // 
            textBoxIdade.Location = new Point(202, 241);
            textBoxIdade.Name = "textBoxIdade";
            textBoxIdade.Size = new Size(144, 23);
            textBoxIdade.TabIndex = 13;
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackColor = Color.FromArgb(46, 204, 113);
            buttonAdicionar.Cursor = Cursors.Hand;
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdicionar.ForeColor = Color.White;
            buttonAdicionar.Location = new Point(108, 291);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(238, 48);
            buttonAdicionar.TabIndex = 14;
            buttonAdicionar.Text = "➕ ADICIONAR DADO";
            buttonAdicionar.UseVisualStyleBackColor = false;
            buttonAdicionar.Click += EnviarDados;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 532);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelId);
            Controls.Add(labelNome);
            Controls.Add(labelTelefone);
            Controls.Add(labelIdade);
            Controls.Add(textBoxId);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxTelefone);
            Controls.Add(textBoxIdade);
            Controls.Add(buttonAdicionar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label labelId;
        private Label labelNome;
        private Label labelTelefone;
        private Label labelIdade;
        private TextBox textBoxId;
        private TextBox textBoxNome;
        private TextBox textBoxTelefone;
        private TextBox textBoxIdade;
        private Button buttonAdicionar;
    }
}
