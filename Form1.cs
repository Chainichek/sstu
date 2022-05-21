using System.Data;
using matrixGen;
using binaryRelations;

namespace sstu
{
    public partial class Form1 : Form
    {
        TableLayoutPanel? dynamicTableLayoutPanel;//�������������� �������
        int totalScore = 0;
        int maxScore = 0;
        CheckBox[] checkBoxes;//����� �������
        RadioButton[] radioButtons;//������ ��������������

        int[,]? matrix;
        public Form1()
        {
            InitializeComponent();
            this.Text = "�������� �� �������� ���������� by Daniyar & Ildar";
            checkBoxes = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6 };
            radioButtons = new RadioButton[] { radioButton1, radioButton2 };
        }

        private void refreshScore()
        {
            label3.Text = "���������� ������� ������: " + totalScore;
        }
        private void refreshMaxScore()
        {
            label4.Text = "������: " + maxScore;
        }
        private void lockButton()
        {
            button1.Enabled = false;
        }
        private void unLockButton()
        {
            button1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)//��������� �������� ������� ������������ ������� - 3
        {

            dynamicTableLayoutPanelCreate(3);
        }
        private void dynamicTableLayoutPanelCreate(int N)
        {
            /*�������� ������� ��� �������������*/
            if (dynamicTableLayoutPanel != null)
            {
                dynamicTableLayoutPanel.Dispose();
            }
            /*�������� �������*/
            refreshScore();

            dynamicTableLayoutPanel = new TableLayoutPanel();

            dynamicTableLayoutPanel.Location = new System.Drawing.Point(50, 35);
            dynamicTableLayoutPanel.Name = "TableLayoutPanel1";
            dynamicTableLayoutPanel.Size = new System.Drawing.Size(300, 300);
            dynamicTableLayoutPanel.TabIndex = 0;


            dynamicTableLayoutPanel.ColumnCount = dynamicTableLayoutPanel.RowCount = N;
            for (int i = 0; i < N; i++)
            {
                dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
                dynamicTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            }

            matrix = null;//�������� �������
            matrix = Generate.matrixGenerate(N);//�������� ������� �� ���������� ����� � ���������dsd
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    dynamicTableLayoutPanel.Controls.Add(new Label { Text = matrix[i, j].ToString(), Anchor = AnchorStyles.None, AutoSize = true, Font = new Font("Arial", 20) }); ;//����������� ��������
                }
            }

            dynamicTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;

/*            dynamicTableLayoutPanel.BackColor = Color.Aqua; //������� ���� - ������� �������*/ // ������(((((((((((((((( ���� ����� ������ ������� ����� ����������
            Controls.Add(dynamicTableLayoutPanel);

            //checkMessageBox();
        }
        private void checkbutton_Click(object sender, EventArgs e)
        {
            /*������ ������� �������� ��� ������ � foreach*/
            bool[] optionsCheck = Generate.getOptions(matrix);
            /*����������� � �������� �������, ����� ���� �� ��� ������������*/
            bool is_win = true; // true - ���� ��� �� ������ ������������� ������
            foreach (var box_options in optionsCheck.Zip(checkBoxes, Tuple.Create))//����� ������ ���������
            {
                if (box_options.Item1)
                {
                    box_options.Item2.ForeColor = Color.Green;
                    if (!box_options.Item2.Checked)
                    {
                        is_win = false;
                    }
                }
                else if (box_options.Item2.Checked)
                {
                    box_options.Item2.ForeColor = Color.Red;
                    is_win = false;
                }
                 //���� �������� ������� � ���  � ������ ������� 
                box_options.Item2.AutoCheck = false;//��������� ��������� ������
            }
            if (is_win)
            {
                totalScore++;
            }
            else
            {
                totalScore = 0;
            }

            if (totalScore > maxScore)
            {
                maxScore = totalScore;
                refreshMaxScore();
            }

            refreshScore();
            lockButton();
        }

        private void genbutton_Click(object sender, EventArgs e)//������ ���������
        {
            unLockButton();
            foreach (CheckBox checkBox in checkBoxes)//�������� ��������� �������
            {
                checkBox.Checked = false;
                checkBox.ForeColor = Color.Black;
                checkBox.AutoCheck = true;
            }
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                    switch (radioButton.Name)
                    {
                        case "radioButton1":
                            dynamicTableLayoutPanelCreate(3);
                            break;
                        case "radioButton2":
                            dynamicTableLayoutPanelCreate(5);
                            break;
                    }
            }
        }

        private void checkMessageBox()
        {
            bool[] optionsCheck = Generate.getOptions(matrix);
            string message = new string("");
            foreach(bool options in optionsCheck)
            {
                message += options.ToString();
            }
            MessageBox.Show(message);
        }
    }
}