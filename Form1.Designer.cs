namespace Calculo_Frete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDistancia = new System.Windows.Forms.NumericUpDown();
            this.txtautonomia = new System.Windows.Forms.NumericUpDown();
            this.cbVeiculo = new System.Windows.Forms.ComboBox();
            this.cbTipoComb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbtabela = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.txtprecoComb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConsuCombus = new System.Windows.Forms.TextBox();
            this.txtDepsComb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDistPerco = new System.Windows.Forms.TextBox();
            this.txtCustoPorKm = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.imgVeiculo = new System.Windows.Forms.PictureBox();
            this.btnRelatório = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.impressora = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtautonomia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtDistancia);
            this.panel1.Controls.Add(this.txtautonomia);
            this.panel1.Controls.Add(this.cbVeiculo);
            this.panel1.Controls.Add(this.cbTipoComb);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbtabela);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDestino);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLocalidade);
            this.panel1.Controls.Add(this.txtprecoComb);
            this.panel1.Location = new System.Drawing.Point(12, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 166);
            this.panel1.TabIndex = 1;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.txtDistancia.Location = new System.Drawing.Point(401, 93);
            this.txtDistancia.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(145, 20);
            this.txtDistancia.TabIndex = 25;
            // 
            // txtautonomia
            // 
            this.txtautonomia.Location = new System.Drawing.Point(552, 38);
            this.txtautonomia.Name = "txtautonomia";
            this.txtautonomia.Size = new System.Drawing.Size(132, 20);
            this.txtautonomia.TabIndex = 24;
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.FormattingEnabled = true;
            this.cbVeiculo.Items.AddRange(new object[] {
            "Caminhão",
            "Carro",
            "Moto",
            "Ônibus",
            "Van"});
            this.cbVeiculo.Location = new System.Drawing.Point(129, 39);
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Size = new System.Drawing.Size(126, 21);
            this.cbVeiculo.TabIndex = 1;
            this.cbVeiculo.SelectedIndexChanged += new System.EventHandler(this.cbVeiculo_SelectedIndexChanged);
            // 
            // cbTipoComb
            // 
            this.cbTipoComb.FormattingEnabled = true;
            this.cbTipoComb.Items.AddRange(new object[] {
            "Diesel",
            "Elétrico",
            "Etanol",
            "Gasolina",
            "GNV"});
            this.cbTipoComb.Location = new System.Drawing.Point(261, 39);
            this.cbTipoComb.Name = "cbTipoComb";
            this.cbTipoComb.Size = new System.Drawing.Size(134, 21);
            this.cbTipoComb.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(258, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "Tipo de Combustível";
            // 
            // cbtabela
            // 
            this.cbtabela.FormattingEnabled = true;
            this.cbtabela.Items.AddRange(new object[] {
            "Nenhum",
            "Multiplicar por 2",
            "Multiplicar por 3"});
            this.cbtabela.Location = new System.Drawing.Point(552, 93);
            this.cbtabela.Name = "cbtabela";
            this.cbtabela.Size = new System.Drawing.Size(132, 21);
            this.cbtabela.TabIndex = 8;
            this.cbtabela.Text = "Nenhum";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(126, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "Local de Partida";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(549, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "Autonomia (Km/L)";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Navy;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Transparent;
            this.btnCalcular.Location = new System.Drawing.Point(348, 131);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(98, 32);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(398, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Distância(KM)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(549, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tabela de Depreciação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(126, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Veículo";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(260, 94);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(135, 20);
            this.txtDestino.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(398, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Preço do Combustível";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkBox1.Location = new System.Drawing.Point(702, 63);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "IR e VOLTAR";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(258, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Destino";
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(129, 95);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(126, 20);
            this.txtLocalidade.TabIndex = 5;
            // 
            // txtprecoComb
            // 
            this.txtprecoComb.Location = new System.Drawing.Point(401, 38);
            this.txtprecoComb.Name = "txtprecoComb";
            this.txtprecoComb.Size = new System.Drawing.Size(145, 20);
            this.txtprecoComb.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(82, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Despesa Do Combustível";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(82, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Consumo de Combustível";
            this.label7.Visible = false;
            // 
            // txtConsuCombus
            // 
            this.txtConsuCombus.Location = new System.Drawing.Point(235, 372);
            this.txtConsuCombus.Name = "txtConsuCombus";
            this.txtConsuCombus.Size = new System.Drawing.Size(145, 20);
            this.txtConsuCombus.TabIndex = 14;
            this.txtConsuCombus.TabStop = false;
            this.txtConsuCombus.Visible = false;
            // 
            // txtDepsComb
            // 
            this.txtDepsComb.Location = new System.Drawing.Point(235, 405);
            this.txtDepsComb.Name = "txtDepsComb";
            this.txtDepsComb.Size = new System.Drawing.Size(145, 20);
            this.txtDepsComb.TabIndex = 13;
            this.txtDepsComb.TabStop = false;
            this.txtDepsComb.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(82, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quantidade Percorrida";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(82, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Custo para Cada 1 Km";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(288, 514);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Total";
            this.label10.Visible = false;
            // 
            // txtDistPerco
            // 
            this.txtDistPerco.Location = new System.Drawing.Point(235, 438);
            this.txtDistPerco.Name = "txtDistPerco";
            this.txtDistPerco.Size = new System.Drawing.Size(145, 20);
            this.txtDistPerco.TabIndex = 20;
            this.txtDistPerco.TabStop = false;
            this.txtDistPerco.Visible = false;
            // 
            // txtCustoPorKm
            // 
            this.txtCustoPorKm.Location = new System.Drawing.Point(235, 468);
            this.txtCustoPorKm.Name = "txtCustoPorKm";
            this.txtCustoPorKm.Size = new System.Drawing.Size(145, 20);
            this.txtCustoPorKm.TabIndex = 21;
            this.txtCustoPorKm.TabStop = false;
            this.txtCustoPorKm.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTotal.Location = new System.Drawing.Point(235, 532);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(145, 20);
            this.txtTotal.TabIndex = 22;
            this.txtTotal.TabStop = false;
            this.txtTotal.Visible = false;
            // 
            // imgVeiculo
            // 
            this.imgVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.imgVeiculo.Location = new System.Drawing.Point(431, 352);
            this.imgVeiculo.Name = "imgVeiculo";
            this.imgVeiculo.Size = new System.Drawing.Size(338, 246);
            this.imgVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVeiculo.TabIndex = 13;
            this.imgVeiculo.TabStop = false;
            // 
            // btnRelatório
            // 
            this.btnRelatório.BackColor = System.Drawing.Color.Navy;
            this.btnRelatório.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatório.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatório.ForeColor = System.Drawing.Color.Transparent;
            this.btnRelatório.Location = new System.Drawing.Point(300, 566);
            this.btnRelatório.Name = "btnRelatório";
            this.btnRelatório.Size = new System.Drawing.Size(98, 32);
            this.btnRelatório.TabIndex = 17;
            this.btnRelatório.Text = "Relatório";
            this.btnRelatório.UseVisualStyleBackColor = false;
            this.btnRelatório.Visible = false;
            this.btnRelatório.Click += new System.EventHandler(this.btnRelatório_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPDF.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.Transparent;
            this.btnPDF.Location = new System.Drawing.Point(196, 566);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(98, 32);
            this.btnPDF.TabIndex = 23;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Visible = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // impressora
            // 
            this.impressora.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.impressora_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::Calculo_Frete.Properties.Resources.Group_4__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 639);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnRelatório);
            this.Controls.Add(this.imgVeiculo);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCustoPorKm);
            this.Controls.Add(this.txtDistPerco);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtConsuCombus);
            this.Controls.Add(this.txtDepsComb);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtautonomia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConsuCombus;
        private System.Windows.Forms.TextBox txtDepsComb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDistPerco;
        private System.Windows.Forms.TextBox txtCustoPorKm;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.PictureBox imgVeiculo;
        private System.Windows.Forms.ComboBox cbtabela;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.TextBox txtprecoComb;
        private System.Windows.Forms.ComboBox cbTipoComb;
        private System.Windows.Forms.Button btnRelatório;
        private System.Windows.Forms.ComboBox cbVeiculo;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.NumericUpDown txtautonomia;
        private System.Drawing.Printing.PrintDocument impressora;
        private System.Windows.Forms.NumericUpDown txtDistancia;
    }
}

