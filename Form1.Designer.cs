namespace Calculadora_CSharp
{
    partial class Form1
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
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btigual = new System.Windows.Forms.Button();
            this.btmais = new System.Windows.Forms.Button();
            this.btmenos = new System.Windows.Forms.Button();
            this.btmultiplicar = new System.Windows.Forms.Button();
            this.btdividir = new System.Windows.Forms.Button();
            this.ContaF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(23, 110);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(54, 50);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.BotaoNumero);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(83, 110);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(54, 50);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.BotaoNumero);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(143, 110);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(54, 50);
            this.bt3.TabIndex = 2;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.BotaoNumero);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(23, 166);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(54, 50);
            this.bt4.TabIndex = 3;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.BotaoNumero);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(83, 166);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(54, 50);
            this.bt5.TabIndex = 4;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.BotaoNumero);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(143, 166);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(54, 50);
            this.bt6.TabIndex = 5;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.BotaoNumero);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(23, 222);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(54, 50);
            this.bt7.TabIndex = 6;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.BotaoNumero);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(83, 222);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(54, 50);
            this.bt8.TabIndex = 7;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.BotaoNumero);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(143, 222);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(54, 50);
            this.bt9.TabIndex = 8;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.BotaoNumero);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(83, 278);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(54, 50);
            this.bt0.TabIndex = 9;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.BotaoNumero);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(23, 278);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(54, 50);
            this.btLimpar.TabIndex = 10;
            this.btLimpar.Text = "Limpiar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.BotaodeLimpar);
            // 
            // btigual
            // 
            this.btigual.Location = new System.Drawing.Point(143, 278);
            this.btigual.Name = "btigual";
            this.btigual.Size = new System.Drawing.Size(54, 50);
            this.btigual.TabIndex = 11;
            this.btigual.Text = "=";
            this.btigual.UseVisualStyleBackColor = true;
            this.btigual.Click += new System.EventHandler(this.BotaoResultadoFinal);
            // 
            // btmais
            // 
            this.btmais.Location = new System.Drawing.Point(203, 110);
            this.btmais.Name = "btmais";
            this.btmais.Size = new System.Drawing.Size(54, 50);
            this.btmais.TabIndex = 12;
            this.btmais.Text = "+";
            this.btmais.UseVisualStyleBackColor = true;
            this.btmais.Click += new System.EventHandler(this.Operacao);
            // 
            // btmenos
            // 
            this.btmenos.Location = new System.Drawing.Point(203, 166);
            this.btmenos.Name = "btmenos";
            this.btmenos.Size = new System.Drawing.Size(54, 50);
            this.btmenos.TabIndex = 13;
            this.btmenos.Text = "-";
            this.btmenos.UseVisualStyleBackColor = true;
            this.btmenos.Click += new System.EventHandler(this.Operacao);
            // 
            // btmultiplicar
            // 
            this.btmultiplicar.Location = new System.Drawing.Point(203, 222);
            this.btmultiplicar.Name = "btmultiplicar";
            this.btmultiplicar.Size = new System.Drawing.Size(54, 50);
            this.btmultiplicar.TabIndex = 14;
            this.btmultiplicar.Text = "*";
            this.btmultiplicar.UseVisualStyleBackColor = true;
            this.btmultiplicar.Click += new System.EventHandler(this.Operacao);
            // 
            // btdividir
            // 
            this.btdividir.Location = new System.Drawing.Point(203, 278);
            this.btdividir.Name = "btdividir";
            this.btdividir.Size = new System.Drawing.Size(54, 50);
            this.btdividir.TabIndex = 15;
            this.btdividir.Text = "/";
            this.btdividir.UseVisualStyleBackColor = true;
            this.btdividir.Click += new System.EventHandler(this.Operacao);
            // 
            // ContaF
            // 
            this.ContaF.Enabled = false;
            this.ContaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContaF.Location = new System.Drawing.Point(23, 31);
            this.ContaF.Multiline = true;
            this.ContaF.Name = "ContaF";
            this.ContaF.Size = new System.Drawing.Size(234, 53);
            this.ContaF.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 351);
            this.Controls.Add(this.ContaF);
            this.Controls.Add(this.btdividir);
            this.Controls.Add(this.btmultiplicar);
            this.Controls.Add(this.btmenos);
            this.Controls.Add(this.btmais);
            this.Controls.Add(this.btigual);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btigual;
        private System.Windows.Forms.Button btmais;
        private System.Windows.Forms.Button btmenos;
        private System.Windows.Forms.Button btmultiplicar;
        private System.Windows.Forms.Button btdividir;
        private System.Windows.Forms.TextBox ContaF;
    }
}

