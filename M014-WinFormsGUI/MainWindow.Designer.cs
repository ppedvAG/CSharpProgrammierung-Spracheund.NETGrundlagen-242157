namespace M014_WinFormsGUI
{
    partial class MainWindow
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
            label1 = new Label();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            rb0 = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            listBox1 = new ListBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            lblCurrentTask = new Label();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 60);
            label1.Name = "label1";
            label1.Size = new Size(364, 32);
            label1.TabIndex = 0;
            label1.Text = "Dies ist ein String in einem Label";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(325, 132);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(177, 36);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Ja oder nein";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(50, 218);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(50, 126);
            button1.Name = "button1";
            button1.Size = new Size(218, 46);
            button1.TabIndex = 3;
            button1.Text = "Farbe wechseln";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(325, 219);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 4;
            textBox1.Text = "Kein Text";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb2);
            groupBox1.Controls.Add(rb1);
            groupBox1.Controls.Add(rb0);
            groupBox1.Location = new Point(50, 312);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 239);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prorität";
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(38, 174);
            rb2.Name = "rb2";
            rb2.Size = new Size(124, 36);
            rb2.TabIndex = 2;
            rb2.TabStop = true;
            rb2.Text = "Niedrig";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(36, 118);
            rb1.Name = "rb1";
            rb1.Size = new Size(124, 36);
            rb1.TabIndex = 1;
            rb1.TabStop = true;
            rb1.Text = "Normal";
            rb1.UseVisualStyleBackColor = true;
            // 
            // rb0
            // 
            rb0.AutoSize = true;
            rb0.Location = new Point(38, 58);
            rb0.Name = "rb0";
            rb0.Size = new Size(126, 36);
            rb0.TabIndex = 0;
            rb0.TabStop = true;
            rb0.Text = "Wichtig";
            rb0.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1143, 40);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(90, 36);
            toolStripMenuItem1.Text = "Datei";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(242, 44);
            toolStripMenuItem2.Text = "Beenden";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(631, 202);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(476, 228);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(631, 60);
            label2.Name = "label2";
            label2.Size = new Size(104, 32);
            label2.TabIndex = 8;
            label2.Text = "Aufgabe";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(631, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(373, 39);
            textBox2.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(1010, 120);
            button2.Name = "button2";
            button2.Size = new Size(47, 46);
            button2.TabIndex = 10;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += AddTask_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1063, 120);
            button3.Name = "button3";
            button3.Size = new Size(44, 46);
            button3.TabIndex = 11;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += RemoveTask_Click;
            // 
            // lblCurrentTask
            // 
            lblCurrentTask.AutoSize = true;
            lblCurrentTask.Location = new Point(631, 476);
            lblCurrentTask.Name = "lblCurrentTask";
            lblCurrentTask.Size = new Size(0, 32);
            lblCurrentTask.TabIndex = 12;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 562);
            Controls.Add(lblCurrentTask);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private RadioButton rb0;
        private RadioButton rb2;
        private RadioButton rb1;
        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ListBox listBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Label lblCurrentTask;
    }
}
