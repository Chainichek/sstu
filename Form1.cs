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
            TableLayoutPanel dynamicTableLayoutPanel = new TableLayoutPanel();

            dynamicTableLayoutPanel.Location = new System.Drawing.Point(100, 50);
            dynamicTableLayoutPanel.Name = "TableLayoutPanel1";
            dynamicTableLayoutPanel.Size = new System.Drawing.Size(100, 100);
            dynamicTableLayoutPanel.TabIndex = 0;


            dynamicTableLayoutPanel.ColumnCount = 5;
            dynamicTableLayoutPanel.RowCount = 5;

            dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            dynamicTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            dynamicTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            dynamicTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            dynamicTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            dynamicTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dynamicTableLayoutPanel.Controls.Add(new Label { Text = "i + j" }, j, i);
                }
            }
            dynamicTableLayoutPanel.BackColor = Color.Aqua;

            Controls.Add(dynamicTableLayoutPanel);
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

            if (pr1 == true)
            {
                property1.ForeColor = Color.Red;
            }

            if (pr2 == true)
            {
                property2.ForeColor = Color.Green;
            }
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