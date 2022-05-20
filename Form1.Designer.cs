namespace sstu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.property6 = new System.Windows.Forms.CheckBox();
            this.property4 = new System.Windows.Forms.CheckBox();
            this.property3 = new System.Windows.Forms.CheckBox();
            this.property5 = new System.Windows.Forms.CheckBox();
            this.property2 = new System.Windows.Forms.CheckBox();
            this.property1 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // property6
            // 
            this.property6.AutoSize = true;
            this.property6.Location = new System.Drawing.Point(137, 53);
            this.property6.Name = "property6";
            this.property6.Size = new System.Drawing.Size(113, 19);
            this.property6.TabIndex = 5;
            this.property6.Text = "Транзитивность";
            this.property6.UseVisualStyleBackColor = true;
            this.property6.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // property4
            // 
            this.property4.AutoSize = true;
            this.property4.Location = new System.Drawing.Point(137, 28);
            this.property4.Name = "property4";
            this.property4.Size = new System.Drawing.Size(147, 19);
            this.property4.TabIndex = 1;
            this.property4.Text = "Антисимметричность";
            this.property4.UseVisualStyleBackColor = true;
            this.property4.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // property3
            // 
            this.property3.AutoSize = true;
            this.property3.Location = new System.Drawing.Point(3, 28);
            this.property3.Name = "property3";
            this.property3.Size = new System.Drawing.Size(122, 19);
            this.property3.TabIndex = 0;
            this.property3.Text = "Симметричность";
            this.property3.UseVisualStyleBackColor = true;
            this.property3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // property5
            // 
            this.property5.AutoSize = true;
            this.property5.Location = new System.Drawing.Point(3, 53);
            this.property5.Name = "property5";
            this.property5.Size = new System.Drawing.Size(128, 19);
            this.property5.TabIndex = 4;
            this.property5.Text = "Асимметричность";
            this.property5.UseVisualStyleBackColor = true;
            // 
            // property2
            // 
            this.property2.AutoSize = true;
            this.property2.Location = new System.Drawing.Point(137, 3);
            this.property2.Name = "property2";
            this.property2.Size = new System.Drawing.Size(144, 19);
            this.property2.TabIndex = 3;
            this.property2.Text = "Антирефлексивность";
            this.property2.UseVisualStyleBackColor = true;
            // 
            // property1
            // 
            this.property1.AutoSize = true;
            this.property1.Location = new System.Drawing.Point(3, 3);
            this.property1.Name = "property1";
            this.property1.Size = new System.Drawing.Size(117, 19);
            this.property1.TabIndex = 2;
            this.property1.Text = "Рефлексивность";
            this.property1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.property2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.property1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.property6, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.property5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.property4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.property3, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(120, 168);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(299, 115);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CheckBox property6;
        private CheckBox property5;
        private CheckBox property2;
        private CheckBox property1;
        private CheckBox property4;
        private CheckBox property3;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}