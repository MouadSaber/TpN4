namespace tp_n4
{
    public partial class Form1 : Form
    {

        // La déclaration du second formulaire

        Form pagedecreation = new Form2();
        Form pagedesuppression = new Form3();
        Form pagedemodification = new Form4();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pagedecreation.Owner = this;
            pagedecreation.Hide();
            pagedecreation.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pagedesuppression.Owner = this;
            pagedesuppression.Hide();
            pagedesuppression.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pagedemodification.Owner = this;
            pagedemodification.Hide();
            pagedemodification.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clickez ok pour confirmer le recherche ");
        }
    }
}
