namespace BANCO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aRQUIVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBRIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALVARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fEHARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.labelCifrao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSaldoValor = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDepositar = new System.Windows.Forms.Button();
            this.textBoxDeposito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSaque = new System.Windows.Forms.GroupBox();
            this.buttonSacar = new System.Windows.Forms.Button();
            this.textBoxDebito = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxSaque.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRQUIVOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aRQUIVOToolStripMenuItem
            // 
            this.aRQUIVOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOVOToolStripMenuItem,
            this.aBRIRToolStripMenuItem,
            this.sALVARToolStripMenuItem,
            this.fEHARToolStripMenuItem});
            this.aRQUIVOToolStripMenuItem.Name = "aRQUIVOToolStripMenuItem";
            this.aRQUIVOToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.aRQUIVOToolStripMenuItem.Text = "ARQUIVO";
            this.aRQUIVOToolStripMenuItem.Click += new System.EventHandler(this.aRQUIVOToolStripMenuItem_Click);
            // 
            // nOVOToolStripMenuItem
            // 
            this.nOVOToolStripMenuItem.Name = "nOVOToolStripMenuItem";
            this.nOVOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nOVOToolStripMenuItem.Text = "NOVO";
            // 
            // aBRIRToolStripMenuItem
            // 
            this.aBRIRToolStripMenuItem.Name = "aBRIRToolStripMenuItem";
            this.aBRIRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aBRIRToolStripMenuItem.Text = "ABRIR";
            // 
            // sALVARToolStripMenuItem
            // 
            this.sALVARToolStripMenuItem.Name = "sALVARToolStripMenuItem";
            this.sALVARToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sALVARToolStripMenuItem.Text = "SALVAR";
            // 
            // fEHARToolStripMenuItem
            // 
            this.fEHARToolStripMenuItem.Name = "fEHARToolStripMenuItem";
            this.fEHARToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fEHARToolStripMenuItem.Text = "FECHAR";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.Location = new System.Drawing.Point(6, 0);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(55, 20);
            this.labelSaldo.TabIndex = 2;
            this.labelSaldo.Text = "Saldo";
            this.labelSaldo.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCifrao
            // 
            this.labelCifrao.AutoSize = true;
            this.labelCifrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCifrao.Location = new System.Drawing.Point(4, 22);
            this.labelCifrao.Name = "labelCifrao";
            this.labelCifrao.Size = new System.Drawing.Size(59, 31);
            this.labelCifrao.TabIndex = 3;
            this.labelCifrao.Text = "R$ ";
            this.labelCifrao.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNomeCliente);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(169, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 55);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nome Do Cliente";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCliente.Location = new System.Drawing.Point(6, 20);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(106, 33);
            this.labelNomeCliente.TabIndex = 5;
            this.labelNomeCliente.Text = "Carlos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSaldoValor);
            this.groupBox2.Controls.Add(this.labelCifrao);
            this.groupBox2.Controls.Add(this.labelSaldo);
            this.groupBox2.Location = new System.Drawing.Point(12, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 55);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // labelSaldoValor
            // 
            this.labelSaldoValor.AutoSize = true;
            this.labelSaldoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldoValor.Location = new System.Drawing.Point(52, 22);
            this.labelSaldoValor.Name = "labelSaldoValor";
            this.labelSaldoValor.Size = new System.Drawing.Size(71, 31);
            this.labelSaldoValor.TabIndex = 4;
            this.labelSaldoValor.Text = "0,00";
            this.labelSaldoValor.Click += new System.EventHandler(this.labelSaldoValor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDepositar);
            this.groupBox3.Controls.Add(this.textBoxDeposito);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 75);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Depósito";
            // 
            // buttonDepositar
            // 
            this.buttonDepositar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDepositar.Location = new System.Drawing.Point(247, 25);
            this.buttonDepositar.Name = "buttonDepositar";
            this.buttonDepositar.Size = new System.Drawing.Size(101, 39);
            this.buttonDepositar.TabIndex = 7;
            this.buttonDepositar.Text = "Depositar";
            this.buttonDepositar.UseVisualStyleBackColor = false;
            this.buttonDepositar.Click += new System.EventHandler(this.buttonDepositar_Click);
            // 
            // textBoxDeposito
            // 
            this.textBoxDeposito.Location = new System.Drawing.Point(10, 26);
            this.textBoxDeposito.Name = "textBoxDeposito";
            this.textBoxDeposito.Size = new System.Drawing.Size(231, 33);
            this.textBoxDeposito.TabIndex = 0;
            this.textBoxDeposito.TextChanged += new System.EventHandler(this.textBoxDeposito_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Opções:";
            // 
            // groupBoxSaque
            // 
            this.groupBoxSaque.Controls.Add(this.buttonSacar);
            this.groupBoxSaque.Controls.Add(this.textBoxDebito);
            this.groupBoxSaque.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSaque.Location = new System.Drawing.Point(385, 141);
            this.groupBoxSaque.Name = "groupBoxSaque";
            this.groupBoxSaque.Size = new System.Drawing.Size(354, 75);
            this.groupBoxSaque.TabIndex = 8;
            this.groupBoxSaque.TabStop = false;
            this.groupBoxSaque.Text = "Saque";
            // 
            // buttonSacar
            // 
            this.buttonSacar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSacar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSacar.Location = new System.Drawing.Point(247, 25);
            this.buttonSacar.Name = "buttonSacar";
            this.buttonSacar.Size = new System.Drawing.Size(101, 39);
            this.buttonSacar.TabIndex = 7;
            this.buttonSacar.Text = "Sacar";
            this.buttonSacar.UseVisualStyleBackColor = false;
            this.buttonSacar.Click += new System.EventHandler(this.buttonSacar_Click);
            // 
            // textBoxDebito
            // 
            this.textBoxDebito.Location = new System.Drawing.Point(10, 26);
            this.textBoxDebito.Name = "textBoxDebito";
            this.textBoxDebito.Size = new System.Drawing.Size(231, 33);
            this.textBoxDebito.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(821, 509);
            this.Controls.Add(this.groupBoxSaque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxSaque.ResumeLayout(false);
            this.groupBoxSaque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aRQUIVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBRIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALVARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fEHARToolStripMenuItem;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label labelCifrao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDeposito;
        private System.Windows.Forms.Button buttonDepositar;
        private System.Windows.Forms.GroupBox groupBoxSaque;
        private System.Windows.Forms.Button buttonSacar;
        private System.Windows.Forms.TextBox textBoxDebito;
        private System.Windows.Forms.Label labelSaldoValor;
    }
}

