namespace gg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();

        }
        int s = 1;

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("we are using timer !!!");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (checkBox1.Checked)

                progressBar1.Increment(s + 10);

            else

                progressBar1.Increment(s);

            label1.Text = progressBar1.Value.ToString();
        
    }
    }
}
