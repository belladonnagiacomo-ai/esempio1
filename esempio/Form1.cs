namespace esempio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void conv1_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(text1.Text);
            double tempF = (temp * (9 / 5)) + 32;
            ris1.Text = tempF.ToString();
        }

        private void conv2_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(text2.Text);
            double tempC = (temp - 32) * (5 / 9);
            ris2.Text = tempC.ToString();
        }

        private void agg_Click(object sender, EventArgs e)
        {
            string pa = text3.Text;
            lista.Items.Add(pa);
        }

        private void svuota_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
        }

        private void somma_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textB1.Text);
            int num2 = int.Parse(textB2.Text);

            int somma = num1 + num2;
            risu.Text = somma.ToString();

        }

        private void sottrazione_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textB1.Text);
            int num2 = int.Parse(textB2.Text);

            int sottrazione = num1 - num2;
            risu.Text = sottrazione.ToString();
        }

        private void molt_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textB1.Text);
            int num2 = int.Parse(textB2.Text);

            int mol = num1 * num2;
            risu.Text = mol.ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textB1.Text);
            int num2 = int.Parse(textB2.Text);

            int div = num1/num2;
            risu.Text = div.ToString();
        }
    }
}
