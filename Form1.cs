using System.Data;
using matrixGen;

namespace sstu
{
    public partial class Form1 : Form
    {
        TableLayoutPanel? dynamicTableLayoutPanel;//генерирующаяся таблица
        int totalScore = 0;
        CheckBox[] checkBoxes;//масив чекеров
        RadioButton[] radioButtons;//массив переключателей
        Generate newGenerator = new Generate();//объект генератора
        Options options = new Options();//объект свойств
        public Form1()
        {
            InitializeComponent();
            this.Text = "Тренажер по бинарным отношениям by Daniyar & Ildar";
            checkBoxes = new CheckBox[] {checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6};
            radioButtons = new RadioButton[] { radioButton1, radioButton2 }; 
        }

        private void refreshScore()
        {
            label3.Text = "Правильных ответов подряд: " + totalScore;
        }

        private void Form1_Load(object sender, EventArgs e)//Начальное значение размера генерируемой матрицы - 3
        {

            dynamicTableLayoutPanelCreate(3);
        }
        private void dynamicTableLayoutPanelCreate(int N)
        {
            /*Удаление матрицы для перегенерации*/
            if (dynamicTableLayoutPanel != null)
            {
                dynamicTableLayoutPanel.Dispose();
            }
            /*Создание матрицы*/
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

            options.randomize_options();//случайные свойства    
            //string check = options.logOptions();
            int[,] matrix = newGenerator.matrixGenerate(N, ref options);//создание матрицы по введенному числу и свойствам
            //check  +=options.logOptions();
            //MessageBox.Show(check);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    dynamicTableLayoutPanel.Controls.Add(new Label { Text = matrix[i, j].ToString(), Anchor = AnchorStyles.None, AutoSize = true, Font = new Font("Arial", 20) }); ;//заполенение матрицей
                }
            }

            dynamicTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;

/*            dynamicTableLayoutPanel.BackColor = Color.Aqua; //мерзкий цвет - любимый ильдара*/ // обидно((((((((((((((((
            Controls.Add(dynamicTableLayoutPanel);
        }
        private void checkbutton_Click(object sender, EventArgs e)
        {
            /*массив булевых значений для работы с foreach*/
            bool[] optionsCheck = new bool[] { options.reflexive, options.antireflexive, options.symmetry, options.asymmetry, options.antisymmetry, options.transitivie };
            /*Объединение с массивом чекеров, чтобы идти по ним одновременно*/
            bool is_win = true; // true - если нет ни одного неправильного ответа
            foreach (var box_options in optionsCheck.Zip(checkBoxes, Tuple.Create))//Новый кортеж элементов
            {
                if (box_options.Item1)
                {
                    box_options.Item2.ForeColor = Color.Green;
                }
                else if (box_options.Item2.Checked)
                {
                    box_options.Item2.ForeColor = Color.Red;
                    is_win = false;
                }
                else
                {
                    box_options.Item2.ForeColor = Color.Black;
                }
                 //Если значение выбрано и оно  в списке свойств 
                box_options.Item2.AutoCheck = false;//Выключить изменение чекера
            }
            if (is_win)
            {
                totalScore++;
            }
            else
            {
                totalScore = 0;
            }
            refreshScore();
        }

        private void genbutton_Click(object sender, EventArgs e)//кнопка генерации
        {
            foreach (CheckBox checkBox in checkBoxes)//исходное состояние чекеров
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}