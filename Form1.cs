using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Calculo_Frete
{
    public partial class Form1 : Form 
    {
        float a = 0;
        float kmRodado = 0;
        float kmDobrado = 0;
        float qtdLitros = 0;
        double DespesaCombustivel = 0;
        double Custo1Km = 0;
        string cbtabelaindex = "";
        public Form1()
        {
            InitializeComponent();
            cbVeiculo.Focus();
            cbtabela.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoComb.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVeiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            txtConsuCombus.ReadOnly = true;txtDepsComb.ReadOnly = true;txtDistPerco.ReadOnly = true;txtCustoPorKm.ReadOnly = true;txtTotal.ReadOnly = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtautonomia, "Quantos Km o veículo faz por litro.");
            tooltip.SetToolTip(cbtabela, "A tabela é caso precise calcular a depreciação do veículo.\r\nCaso não precisar, selecione a opção  Nenhum.\r\nCada valor escolhido na tabela multiplica o valor Total de Gastos.");
            tooltip.SetToolTip(txtDistancia, "Quantos Km o veículo irá percorrer.");

        }

        private void cbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se foi escolhido um tipo de Veículo
            if (cbVeiculo.Text == "Caminhão") { imgVeiculo.Image = Calculo_Frete.Properties.Resources.Caminhao_com; }
            else if (cbVeiculo.Text == "Carro") { imgVeiculo.Image = Calculo_Frete.Properties.Resources.Carro_com; }
            else if (cbVeiculo.Text == "Moto") { imgVeiculo.Image = Calculo_Frete.Properties.Resources.moto_com; }
            else if (cbVeiculo.Text == "Ônibus") { imgVeiculo.Image = Calculo_Frete.Properties.Resources.Onibuscom; }
            else if (cbVeiculo.Text == "Van") { imgVeiculo.Image = Calculo_Frete.Properties.Resources.Van_com; }

            // Limpa as opções atuais do ComboBox cbTipoComb
            cbTipoComb.Items.Clear();

            if (cbVeiculo.Text == "Caminhão" || cbVeiculo.Text == "Ônibus" || cbVeiculo.Text == "Van")
            {
                cbTipoComb.Items.Add("Diesel");
                cbTipoComb.Items.Add("Elétrico");
            }
            else if (cbVeiculo.Text == "Carro" || cbVeiculo.Text == "Moto")
            {
                cbTipoComb.Items.Add("Gasolina");
                cbTipoComb.Items.Add("Etanol");
                cbTipoComb.Items.Add("Elétrico");
                if (cbVeiculo.Text == "Carro") { cbTipoComb.Items.Add("GNV"); }
                
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cbVeiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Você não escolheu nenhum Veículo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se foi escolhido um tipo de combustível
            if (cbTipoComb.SelectedIndex == -1)
            {
                MessageBox.Show("Você não escolheu nenhum combustível!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Verifica se txtprecoComb.Text é um número válido
            if (!double.TryParse(txtprecoComb.Text, out double precoComb) || txtprecoComb.Text.Contains(".") || precoComb == 0)
            {
                MessageBox.Show("Você não digitou um preço de combustível válido. \r\nDigite no formato: 5 ou 5,00.\r\nCertifique-se de usar vírgula em vez de ponto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtprecoComb.Focus();
                txtprecoComb.SelectAll();
                return;
            }
            // Verifica se txtautonomia.Text é um número válido
            if (!float.TryParse(txtautonomia.Text, out float autonomia) || autonomia == 0)
            {
                MessageBox.Show("Você não digitou uma autonomia válida. \r\nDigite: Quantos KM o veículo faz por Litro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtautonomia.Focus();
                return;
            }
            // Verifica se txtDistancia.Text é um número válido
            if (!float.TryParse(txtDistancia.Text, out float distancia) || distancia == 0)
            {
                MessageBox.Show("Você não digitou uma distância válida. \r\nDigite: Quantos KM o veículo irá percorrer.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtautonomia.Focus();
                return;
            }
            // Verifica se cbtabela tem um item selecionado
            if (string.IsNullOrEmpty(cbtabela.Text))
            {
                MessageBox.Show("Você não selecionou um valor da tabela de depreciação do veículo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbtabela.Focus();
                return;
            }
            kmRodado = float.Parse(txtDistancia.Text);
            if (checkBox1.Checked == false)
            {
                kmDobrado = kmRodado * 1; // Só a ida
            }
            else
            {
                kmDobrado = kmRodado * 2; // INICIO + VOLTA
            }

            if (cbtabela.Text == "Nenhum")
            {
                cbtabelaindex = "1";
            }
            else if (cbtabela.Text == "Multiplicar por 2")
            {
                cbtabelaindex = "2";
            }
            else if (cbtabela.Text == "Multiplicar por 3")
            {
                cbtabelaindex = "3";
            }
            //Calculos para Efutuar os calcúlos do FRETE
            qtdLitros = kmDobrado / float.Parse(txtautonomia.Text);
            DespesaCombustivel = qtdLitros * double.Parse(txtprecoComb.Text);
            Custo1Km = double.Parse(txtprecoComb.Text) / double.Parse(txtautonomia.Text);
            string qtdlitroFormatado = qtdLitros.ToString("F2");
            string despesaFormatada = DespesaCombustivel.ToString("F2");
            string kmDobradoFormatado = kmDobrado.ToString("F2");
            double total = DespesaCombustivel * float.Parse(cbtabelaindex);
            string totalFormatado = total.ToString("F2");
            string custo1kmFormatado = Custo1Km.ToString("F2");

            txtConsuCombus.Text = qtdlitroFormatado + " L";
            txtDepsComb.Text = "R$ " + despesaFormatada;
            txtDistPerco.Text = kmDobradoFormatado + " Km";
            txtCustoPorKm.Text = "R$ " + custo1kmFormatado;
            txtTotal.Text = "R$ " + totalFormatado;
            txtTotal.BackColor = Color.FromArgb(27, 31, 82);
            txtTotal.ForeColor = Color.FromArgb(237, 150, 0);

            label6.Visible = true; label7.Visible = true; label8.Visible = true; label9.Visible = true; label10.Visible = true;
            txtConsuCombus.Visible = true; txtDepsComb.Visible = true; txtDistPerco.Visible = true; txtCustoPorKm.Visible = true; txtTotal.Visible = true;
            btnRelatório.Visible = true;
            btnPDF.Visible = true;
        
    }

        private void btnRelatório_Click(object sender, EventArgs e)
        {
            string a = "Veículo: " + cbVeiculo.Text + "\r\nAutonomia: " + txtautonomia.Text + " Km/L" + "\r\nLocal de partida: " + txtLocalidade.Text + "\r\nDestino: " + txtDestino.Text + "\r\nTipo do combustível:  " + cbTipoComb.Text + "\r\nDepreciação Tabela: " + cbtabela.Text + "\r\n\r\n\r\nO veículo consumirá: " + txtConsuCombus.Text + "\r\nPercorrendo: " + txtDistPerco.Text + "\r\nDespesa Total = " + txtTotal.Text;
            MessageBox.Show(a, "Relatório", MessageBoxButtons.OK);

            if (!string.IsNullOrEmpty(a))
            {
                Clipboard.SetText(a);
                MessageBox.Show("Os dados foram copiados para a área de transferência!\r\nSó pressionar as teclas Ctrl + V na área que deseja colar os dados!", "Relatório",MessageBoxButtons.OK);
            }
            else
            {
                return;
            }
        }

        private void impressora_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Image image = Properties.Resources.rere;

            string a = "Veículo: " + cbVeiculo.Text + "\r\nAutonomia: " + txtautonomia.Text + " Km/L" + "\r\nLocal de partida: " + txtLocalidade.Text + "\r\nDestino: " + txtDestino.Text + "\r\nTipo do combustível:  " + cbTipoComb.Text + "\r\nDepreciação Tabela: " + cbtabela.Text + "\r\n\r\n\r\nO veículo consumirá: " + txtConsuCombus.Text + "\r\nPercorrendo: " + txtDistPerco.Text + "\r\nDespesa Total = " + txtTotal.Text;
            Font tipo_Fonte = new Font("Arial",18, FontStyle.Regular, GraphicsUnit.Pixel);
            Font tipo_FonteTITULO = new Font("Arial", 26, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(Color.Black);
            Point local = new Point(100,300);
            Point localTitulo = new Point(320,200);
            e.Graphics.DrawImage(image, new Point(1, 1));
            e.Graphics.DrawString("- Relatório -\r\n", tipo_FonteTITULO, cor, localTitulo);
            e.Graphics.DrawString(a,tipo_Fonte,cor,local);
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            impressora.Print();
        }


    }
}


