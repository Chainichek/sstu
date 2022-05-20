using System.Data;
using matrixGen;

namespace sstu
{
    public partial class Form1 : Form
    {
        TableLayoutPanel? dynamicTableLayoutPanel;
        CheckBox[] checkBoxes;
        public Form1()
        {
            InitializeComponent();

            checkBoxes = new CheckBox[] {checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6};

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dynamicTableLayoutPanelCreate(3);
        }
        private void dynamicTableLayoutPanelCreate(int N)
        {
/*            if (dynamicTableLayoutPanel != null)
                dynamicTableLayoutPanel.Dispose();*/
            dynamicTableLayoutPanel = new TableLayoutPanel();

            dynamicTableLayoutPanel.Location = new System.Drawing.Point(75, 50);
            dynamicTableLayoutPanel.Name = "TableLayoutPanel1";
            dynamicTableLayoutPanel.Size = new System.Drawing.Size(300, 300);
            dynamicTableLayoutPanel.TabIndex = 0;


            dynamicTableLayoutPanel.ColumnCount = dynamicTableLayoutPanel.RowCount = N;
            for (int i = 0; i < N; i++)
            {
                dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
                dynamicTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            }

            Generate newGenerator = new Generate();//объект генератора
            Options options = new Options();//объект свойств
            options.randomize_options();//случайные свойства

            int[,] matrix = newGenerator.matrixGenerate(5, options);//создание матрицы по введенному числу и свойствам

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Label label = new Label();
                    label.Text = matrix[i, j].ToString();
                    dynamicTableLayoutPanel.Controls.Add(label);
                }
            }
            dynamicTableLayoutPanel.BackColor = Color.Aqua;
            Controls.Add(dynamicTableLayoutPanel);
        }
        private void checkbutton_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in checkBoxes)
            {
                checkBox.ForeColor = checkBox.Checked ? Color.Green : Color.Red;
                checkBox.AutoCheck = false;
            }
        }

        private void genbutton_Click(object sender, EventArgs e)
        {

        }
    }
}