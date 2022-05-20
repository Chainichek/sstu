using System.Data;

namespace sstu
{
    public partial class Form1 : Form
    {
        CheckBox[] checkBoxes;
        public Form1()
        {
            InitializeComponent();

            checkBoxes = new CheckBox[] {checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6};

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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.ForeColor = checkBox.Checked ? Color.Green : Color.Red;
                checkBox.AutoCheck = false;
            }
        }
    }
}