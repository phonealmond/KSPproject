namespace ksp_automation
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
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            comboBox1 = new ComboBox();
            button2 = new Button();
            tabPage3 = new TabPage();
            textBox1 = new TextBox();
            button3 = new Button();
            dataGridView3 = new DataGridView();
            tabPage4 = new TabPage();
            comboBox2 = new ComboBox();
            button4 = new Button();
            dataGridView4 = new DataGridView();
            tabPage5 = new TabPage();
            textBox3 = new TextBox();
            button6 = new Button();
            comboBox6 = new ComboBox();
            comboBox5 = new ComboBox();
            textBox2 = new TextBox();
            button5 = new Button();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(6, 30);
            button1.Name = "button1";
            button1.Size = new Size(125, 23);
            button1.TabIndex = 0;
            button1.Text = "Load Celestial Bodies";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(781, 436);
            tabControl1.TabIndex = 1;
            tabControl1.Tag = "celestial bodys";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(773, 408);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Celestial_Bodies";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(761, 328);
            dataGridView1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(button2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(773, 408);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Parts";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(19, 59);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(722, 343);
            dataGridView2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(116, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Category Filter";
            // 
            // button2
            // 
            button2.Location = new Point(19, 15);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "Load Parts";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(773, 408);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Engines";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Search Engines";
            // 
            // button3
            // 
            button3.Location = new Point(6, 15);
            button3.Name = "button3";
            button3.Size = new Size(98, 23);
            button3.TabIndex = 1;
            button3.Text = "Load Engines";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 55);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(761, 347);
            dataGridView3.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(comboBox2);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(773, 408);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Fuel Tanks";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(145, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 2;
            comboBox2.Text = "Fuel Type Filter";
            // 
            // button4
            // 
            button4.Location = new Point(26, 27);
            button4.Name = "button4";
            button4.Size = new Size(98, 23);
            button4.TabIndex = 1;
            button4.Text = "load fuel tanks";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(6, 71);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(761, 331);
            dataGridView4.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(textBox3);
            tabPage5.Controls.Add(button6);
            tabPage5.Controls.Add(comboBox6);
            tabPage5.Controls.Add(comboBox5);
            tabPage5.Controls.Add(textBox2);
            tabPage5.Controls.Add(button5);
            tabPage5.Controls.Add(comboBox4);
            tabPage5.Controls.Add(comboBox3);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(773, 408);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Mission Planning";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(541, 49);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 23);
            textBox3.TabIndex = 7;
            textBox3.Text = "Estimated Burn Time";
            // 
            // button6
            // 
            button6.Location = new Point(541, 20);
            button6.Name = "button6";
            button6.Size = new Size(125, 23);
            button6.TabIndex = 6;
            button6.Text = "Calculate Burn Time";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(402, 49);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(133, 23);
            comboBox6.TabIndex = 5;
            comboBox6.Text = "Fuel Tank Selection";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(402, 20);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(133, 23);
            comboBox5.TabIndex = 4;
            comboBox5.Text = "Engine Selection";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(274, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "Delta-V Required";
            // 
            // button5
            // 
            button5.Location = new Point(274, 20);
            button5.Name = "button5";
            button5.Size = new Size(122, 23);
            button5.TabIndex = 2;
            button5.Text = "Calculate Delta-V";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(147, 20);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 1;
            comboBox4.Text = "Destination";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(20, 20);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 0;
            comboBox3.Text = "Origin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dataGridView1;
        private TabPage tabPage5;
        private DataGridView dataGridView2;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView3;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Button button4;
        private DataGridView dataGridView4;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private TextBox textBox2;
        private Button button5;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private TextBox textBox3;
        private Button button6;
    }
}
