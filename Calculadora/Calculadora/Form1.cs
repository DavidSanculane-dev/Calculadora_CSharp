

namespace Calculadora
{
    public partial class Form1 : Form
    {
       
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //lblOperador.Visible = false;
            panel2.BackColor = Color.White;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            lblCalculo.Text = "0";
            lblValor1.Text = "";
            lblValor2.Text = "";
            lblOperador.Text = "";
        }

        private void bt7_Click(object sender, EventArgs e)
        {


            if (lblValor1.Text == "")
            {
                if (lblValor1.Text != "")
                {
                    lblValor1.Text = lblValor1.Text + "7";
                }
                else
                {
                    lblValor1.Text = lblValor1.Text + "7";
                }

            }
            else
            {

                lblValor2.Text = lblValor2.Text + "7";
            }

        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (lblValor1.Text == "")
            {
                if (lblValor1.Text != "")
                {
                    lblValor1.Text = lblValor1.Text + "4";
                }
                else
                {
                    lblValor1.Text = "4";
                }
                
            }
            else
            {

                lblValor2.Text = lblValor2.Text + "4";
            }

        }

        private void bt1_Click(object sender, EventArgs e)
        {

        }

        private void bt8_Click(object sender, EventArgs e)
        {

        }

        private void bt5_Click(object sender, EventArgs e)
        {

        }

        private void bt2_Click(object sender, EventArgs e)
        {

        }

        private void bt0_Click(object sender, EventArgs e)
        {

        }

        private void bt9_Click(object sender, EventArgs e)
        {

        }

        private void bt6_Click(object sender, EventArgs e)
        {

        }

        private void bt3_Click(object sender, EventArgs e)
        {

        }

        private void btPonto_Click(object sender, EventArgs e)
        {
           
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            lblOperador.Text = "/";
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            lblOperador.Text = "*";
        }

        private void btSubtrair_Click(object sender, EventArgs e)
        {
            lblOperador.Text = "-";
        }

        private void btSomar_Click(object sender, EventArgs e)
        {
            
            lblOperador.Text = "+";

        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            //Calculo a = new Calculo();
            //lblValor1.Text = a.valor1.ToString();
            //lblValor2.Text = a.valor2.ToString();

            if (lblOperador.Text == "+")
            {

                int resultado = int.Parse(lblCalculo.Text);
                resultado = int.Parse(lblValor1.Text) + int.Parse(lblValor2.Text);
            }
        }

        
    }
}