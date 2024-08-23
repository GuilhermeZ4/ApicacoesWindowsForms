namespace TrocaValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClicar_Click(object sender, EventArgs e)
        {
            string aux = TxtValor1.Text;
            TxtValor1.Text = TxtValor2.Text;
            TxtValor2.Text = aux;
        }

        private void TxtValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblValor2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TRANSFORMAR AS IMAGENS EM BOTÕES E USAR O CÓDIGO MESSAGEBOX.SHOW("");
        }
    }
}
