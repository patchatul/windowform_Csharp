namespace Slug_A_Palooza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int slug1 = Convert.ToInt32(textBox1.Text);
            int slug2 = Convert.ToInt32(textBox2.Text);
            int slug3 = Convert.ToInt32(textBox3.Text);
            int slug4 = Convert.ToInt32(textBox4.Text);
            int slug5 = Convert.ToInt32(textBox5.Text);
            int sum = slug1 + slug2 + slug3 + slug4 + slug5;
            label7.Text = "Total number of slugs is " + sum;

        }

    }
}
