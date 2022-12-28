namespace Calculadora
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btSubtrair = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btSomar = new System.Windows.Forms.Button();
            this.btLimparTudo = new System.Windows.Forms.Button();
            this.btPonto = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.btDivisao = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCalculo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Padrão";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btSubtrair);
            this.panel3.Controls.Add(this.btLimpar);
            this.panel3.Controls.Add(this.bt0);
            this.panel3.Controls.Add(this.btSomar);
            this.panel3.Controls.Add(this.btLimparTudo);
            this.panel3.Controls.Add(this.btPonto);
            this.panel3.Controls.Add(this.btIgual);
            this.panel3.Controls.Add(this.btMultiplicar);
            this.panel3.Controls.Add(this.btDivisao);
            this.panel3.Controls.Add(this.bt3);
            this.panel3.Controls.Add(this.bt6);
            this.panel3.Controls.Add(this.bt9);
            this.panel3.Controls.Add(this.bt2);
            this.panel3.Controls.Add(this.bt5);
            this.panel3.Controls.Add(this.bt8);
            this.panel3.Controls.Add(this.bt1);
            this.panel3.Controls.Add(this.bt4);
            this.panel3.Controls.Add(this.bt7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(342, 250);
            this.panel3.TabIndex = 1;
            // 
            // btSubtrair
            // 
            this.btSubtrair.BackColor = System.Drawing.Color.White;
            this.btSubtrair.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubtrair.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSubtrair.Location = new System.Drawing.Point(198, 98);
            this.btSubtrair.Name = "btSubtrair";
            this.btSubtrair.Size = new System.Drawing.Size(58, 43);
            this.btSubtrair.TabIndex = 17;
            this.btSubtrair.Text = "-";
            this.btSubtrair.UseVisualStyleBackColor = false;
            this.btSubtrair.Click += new System.EventHandler(this.btSubtrair_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.White;
            this.btLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Location = new System.Drawing.Point(262, 98);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(69, 139);
            this.btLimpar.TabIndex = 16;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // bt0
            // 
            this.bt0.BackColor = System.Drawing.Color.White;
            this.bt0.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bt0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt0.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt0.Location = new System.Drawing.Point(6, 145);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(122, 43);
            this.bt0.TabIndex = 15;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = false;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btSomar
            // 
            this.btSomar.BackColor = System.Drawing.Color.White;
            this.btSomar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSomar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSomar.Location = new System.Drawing.Point(198, 145);
            this.btSomar.Name = "btSomar";
            this.btSomar.Size = new System.Drawing.Size(58, 92);
            this.btSomar.TabIndex = 14;
            this.btSomar.Text = "+";
            this.btSomar.UseVisualStyleBackColor = false;
            this.btSomar.Click += new System.EventHandler(this.btSomar_Click);
            // 
            // btLimparTudo
            // 
            this.btLimparTudo.BackColor = System.Drawing.Color.White;
            this.btLimparTudo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btLimparTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimparTudo.Location = new System.Drawing.Point(262, 6);
            this.btLimparTudo.Name = "btLimparTudo";
            this.btLimparTudo.Size = new System.Drawing.Size(69, 89);
            this.btLimparTudo.TabIndex = 13;
            this.btLimparTudo.Text = "CE";
            this.btLimparTudo.UseVisualStyleBackColor = false;
            // 
            // btPonto
            // 
            this.btPonto.BackColor = System.Drawing.Color.White;
            this.btPonto.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPonto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btPonto.Location = new System.Drawing.Point(134, 145);
            this.btPonto.Name = "btPonto";
            this.btPonto.Size = new System.Drawing.Size(58, 43);
            this.btPonto.TabIndex = 12;
            this.btPonto.Text = ".";
            this.btPonto.UseVisualStyleBackColor = false;
            this.btPonto.Click += new System.EventHandler(this.btPonto_Click);
            // 
            // btIgual
            // 
            this.btIgual.BackColor = System.Drawing.Color.White;
            this.btIgual.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIgual.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btIgual.Location = new System.Drawing.Point(6, 194);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(186, 43);
            this.btIgual.TabIndex = 11;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = false;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.BackColor = System.Drawing.Color.White;
            this.btMultiplicar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMultiplicar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btMultiplicar.Location = new System.Drawing.Point(198, 51);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(58, 43);
            this.btMultiplicar.TabIndex = 10;
            this.btMultiplicar.Text = "*";
            this.btMultiplicar.UseVisualStyleBackColor = false;
            this.btMultiplicar.Click += new System.EventHandler(this.btMultiplicar_Click);
            // 
            // btDivisao
            // 
            this.btDivisao.BackColor = System.Drawing.Color.White;
            this.btDivisao.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btDivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDivisao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDivisao.Location = new System.Drawing.Point(198, 5);
            this.btDivisao.Name = "btDivisao";
            this.btDivisao.Size = new System.Drawing.Size(58, 43);
            this.btDivisao.TabIndex = 9;
            this.btDivisao.Text = "/";
            this.btDivisao.UseVisualStyleBackColor = false;
            this.btDivisao.Click += new System.EventHandler(this.btDivisao_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.White;
            this.bt3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt3.Location = new System.Drawing.Point(134, 99);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(58, 43);
            this.bt3.TabIndex = 8;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.White;
            this.bt6.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bt6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt6.Location = new System.Drawing.Point(134, 52);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(58, 43);
            this.bt6.TabIndex = 7;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.Color.White;
            this.bt9.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bt9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt9.Location = new System.Drawing.Point(134, 6);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(58, 43);
            this.bt9.TabIndex = 6;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.White;
            this.bt2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt2.Location = new System.Drawing.Point(70, 99);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(58, 43);
            this.bt2.TabIndex = 5;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.White;
            this.bt5.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bt5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt5.Location = new System.Drawing.Point(70, 52);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(58, 43);
            this.bt5.TabIndex = 4;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.Color.White;
            this.bt8.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bt8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt8.Location = new System.Drawing.Point(70, 6);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(58, 43);
            this.bt8.TabIndex = 3;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.White;
            this.bt1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt1.Location = new System.Drawing.Point(6, 98);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(58, 43);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.White;
            this.bt4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt4.Location = new System.Drawing.Point(6, 51);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(58, 43);
            this.bt4.TabIndex = 1;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.Color.White;
            this.bt7.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bt7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt7.Location = new System.Drawing.Point(6, 5);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(58, 43);
            this.bt7.TabIndex = 0;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.lblValor2);
            this.panel4.Controls.Add(this.lblOperador);
            this.panel4.Controls.Add(this.lblValor1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 47);
            this.panel4.TabIndex = 2;
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(173, 14);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(0, 15);
            this.lblValor2.TabIndex = 2;
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Location = new System.Drawing.Point(148, 14);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(10, 15);
            this.lblOperador.TabIndex = 1;
            this.lblOperador.Text = ".";
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(118, 14);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(0, 15);
            this.lblValor1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lblCalculo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 62);
            this.panel2.TabIndex = 3;
            // 
            // lblCalculo
            // 
            this.lblCalculo.AutoSize = true;
            this.lblCalculo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCalculo.Location = new System.Drawing.Point(301, 17);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCalculo.Size = new System.Drawing.Size(29, 32);
            this.lblCalculo.TabIndex = 0;
            this.lblCalculo.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(342, 403);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Button btSubtrair;
        private Button btLimpar;
        private Button bt0;
        private Button btSomar;
        private Button btLimparTudo;
        private Button btPonto;
        private Button btIgual;
        private Button btMultiplicar;
        private Button btDivisao;
        private Button bt3;
        private Button bt6;
        private Button bt9;
        private Button bt2;
        private Button bt5;
        private Button bt8;
        private Button bt1;
        private Button bt4;
        private Button bt7;
        private Panel panel4;
        private Label lblValor1;
        private Panel panel2;
        private Label lblCalculo;
        private Label lblValor2;
        private Label lblOperador;
    }
}