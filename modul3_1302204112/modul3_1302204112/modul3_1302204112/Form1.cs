namespace modul3_1302204112
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string oper1 = string.Empty;
        string oper2 = string.Empty;
        char oper;
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = " ";
            input += "1";
            this.textBox3.Text += input;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = " ";
            input += "2";
            this.textBox3.Text += input;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = " ";
            input += "3";
            this.textBox3.Text += input;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = " ";
            input += "4";
            this.textBox3.Text += input;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = " ";
            input += "5";
            this.textBox3.Text += input;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = " ";
            input += "6";
            this.textBox3.Text += input;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = " ";
            input += "7";
            this.textBox3.Text += input;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = " ";
            input += "8";
            this.textBox3.Text += input;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = " ";
            input += "9";
            this.textBox3.Text += input;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = " ";
            input += "0";
            this.textBox3.Text += input;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            oper1 = input;
            oper = '+';
            input = string.Empty;
        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }