using System.Data;

namespace sstu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Label label = new Label();
                    label.Text = Convert.ToString(i);
                    tableLayoutPanel1.Controls.Add(label, i, j);

                }
                tableLayoutPanel1.ColumnCount = tableLayoutPanel1.ColumnCount + 1;
            }
            tableLayoutPanel1.ColumnCount = tableLayoutPanel1.ColumnCount -1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool pr1 = property1.Checked;
            bool pr2 = property2.Checked;
            bool pr3 = property3.Checked;
            bool pr4 = property4.Checked;
            bool pr5 = property5.Checked;
            bool pr6 = property6.Checked;


            Console.WriteLine("21");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}