namespace Projectc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random slump = new Random();

            int datortal = slump.Next();

            int gissatal = int.Parse(textBox1.Text);

            if (gissatal==datortal)
            {
                label6.Text = "correct :)";
            }
            else if(gissatal < datortal)
            {
                label6.Text = "För lågt.";
                label4.Text = "Datorns tal var" + datortal;
            }
            else
            {
                label6.Text = "För högt";
                label4.Text = "Datorns tal var" + datortal;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}