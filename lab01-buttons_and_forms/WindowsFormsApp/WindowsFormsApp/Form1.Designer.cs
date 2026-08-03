namespace WindowsFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ButtonChangeStudentInfo = new System.Windows.Forms.Button();
            this.GroupBoxChangeMarkStudentInfo = new System.Windows.Forms.GroupBox();
            this.FiveRadioButtonMark = new System.Windows.Forms.RadioButton();
            this.FourRadioButtonMark = new System.Windows.Forms.RadioButton();
            this.ThreeRadioButtonMark = new System.Windows.Forms.RadioButton();
            this.TwoRadioButtonMark = new System.Windows.Forms.RadioButton();
            this.GroupBoxChangeStudentInfo = new System.Windows.Forms.GroupBox();
            this.ComboBoxStudentGroup = new System.Windows.Forms.ComboBox();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.LabelStatusStudentInfo = new System.Windows.Forms.Label();
            this.LabelFirstNameStudentInfo = new System.Windows.Forms.Label();
            this.LabelLastNameStudentInfo = new System.Windows.Forms.Label();
            this.LabelGroupStudentInfo = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelPaint = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SpawnButtonsCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.myButton = new System.Windows.Forms.Button();
            this.StudentInfoGroupBox.SuspendLayout();
            this.GroupBoxChangeMarkStudentInfo.SuspendLayout();
            this.GroupBoxChangeStudentInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentInfoGroupBox
            // 
            this.StudentInfoGroupBox.Controls.Add(this.ButtonChangeStudentInfo);
            this.StudentInfoGroupBox.Controls.Add(this.GroupBoxChangeMarkStudentInfo);
            this.StudentInfoGroupBox.Controls.Add(this.GroupBoxChangeStudentInfo);
            this.StudentInfoGroupBox.Controls.Add(this.LabelStatusStudentInfo);
            this.StudentInfoGroupBox.Controls.Add(this.LabelFirstNameStudentInfo);
            this.StudentInfoGroupBox.Controls.Add(this.LabelLastNameStudentInfo);
            this.StudentInfoGroupBox.Controls.Add(this.LabelGroupStudentInfo);
            this.StudentInfoGroupBox.Location = new System.Drawing.Point(13, 13);
            this.StudentInfoGroupBox.Name = "StudentInfoGroupBox";
            this.StudentInfoGroupBox.Size = new System.Drawing.Size(353, 226);
            this.StudentInfoGroupBox.TabIndex = 0;
            this.StudentInfoGroupBox.TabStop = false;
            this.StudentInfoGroupBox.Text = "Информация о студенте";
            // 
            // ButtonChangeStudentInfo
            // 
            this.ButtonChangeStudentInfo.Location = new System.Drawing.Point(259, 15);
            this.ButtonChangeStudentInfo.Name = "ButtonChangeStudentInfo";
            this.ButtonChangeStudentInfo.Size = new System.Drawing.Size(75, 23);
            this.ButtonChangeStudentInfo.TabIndex = 6;
            this.ButtonChangeStudentInfo.Text = "Обновить информацию";
            this.ButtonChangeStudentInfo.UseVisualStyleBackColor = true;
            this.ButtonChangeStudentInfo.Click += new System.EventHandler(this.ButtonChangeStudentInfo_Click);
            // 
            // GroupBoxChangeMarkStudentInfo
            // 
            this.GroupBoxChangeMarkStudentInfo.Controls.Add(this.FiveRadioButtonMark);
            this.GroupBoxChangeMarkStudentInfo.Controls.Add(this.FourRadioButtonMark);
            this.GroupBoxChangeMarkStudentInfo.Controls.Add(this.ThreeRadioButtonMark);
            this.GroupBoxChangeMarkStudentInfo.Controls.Add(this.TwoRadioButtonMark);
            this.GroupBoxChangeMarkStudentInfo.Location = new System.Drawing.Point(177, 118);
            this.GroupBoxChangeMarkStudentInfo.Name = "GroupBoxChangeMarkStudentInfo";
            this.GroupBoxChangeMarkStudentInfo.Size = new System.Drawing.Size(157, 93);
            this.GroupBoxChangeMarkStudentInfo.TabIndex = 5;
            this.GroupBoxChangeMarkStudentInfo.TabStop = false;
            this.GroupBoxChangeMarkStudentInfo.Text = "Оценка";
            // 
            // FiveRadioButtonMark
            // 
            this.FiveRadioButtonMark.AutoSize = true;
            this.FiveRadioButtonMark.Location = new System.Drawing.Point(44, 20);
            this.FiveRadioButtonMark.Name = "FiveRadioButtonMark";
            this.FiveRadioButtonMark.Size = new System.Drawing.Size(31, 17);
            this.FiveRadioButtonMark.TabIndex = 3;
            this.FiveRadioButtonMark.TabStop = true;
            this.FiveRadioButtonMark.Text = "5";
            this.FiveRadioButtonMark.UseVisualStyleBackColor = true;
            // 
            // FourRadioButtonMark
            // 
            this.FourRadioButtonMark.AutoSize = true;
            this.FourRadioButtonMark.Location = new System.Drawing.Point(6, 66);
            this.FourRadioButtonMark.Name = "FourRadioButtonMark";
            this.FourRadioButtonMark.Size = new System.Drawing.Size(31, 17);
            this.FourRadioButtonMark.TabIndex = 2;
            this.FourRadioButtonMark.TabStop = true;
            this.FourRadioButtonMark.Text = "4";
            this.FourRadioButtonMark.UseVisualStyleBackColor = true;
            // 
            // ThreeRadioButtonMark
            // 
            this.ThreeRadioButtonMark.AutoSize = true;
            this.ThreeRadioButtonMark.Location = new System.Drawing.Point(6, 43);
            this.ThreeRadioButtonMark.Name = "ThreeRadioButtonMark";
            this.ThreeRadioButtonMark.Size = new System.Drawing.Size(31, 17);
            this.ThreeRadioButtonMark.TabIndex = 1;
            this.ThreeRadioButtonMark.TabStop = true;
            this.ThreeRadioButtonMark.Text = "3";
            this.ThreeRadioButtonMark.UseVisualStyleBackColor = true;
            // 
            // TwoRadioButtonMark
            // 
            this.TwoRadioButtonMark.AutoSize = true;
            this.TwoRadioButtonMark.Location = new System.Drawing.Point(7, 20);
            this.TwoRadioButtonMark.Name = "TwoRadioButtonMark";
            this.TwoRadioButtonMark.Size = new System.Drawing.Size(31, 17);
            this.TwoRadioButtonMark.TabIndex = 0;
            this.TwoRadioButtonMark.TabStop = true;
            this.TwoRadioButtonMark.Text = "2";
            this.TwoRadioButtonMark.UseVisualStyleBackColor = true;
            // 
            // GroupBoxChangeStudentInfo
            // 
            this.GroupBoxChangeStudentInfo.Controls.Add(this.ComboBoxStudentGroup);
            this.GroupBoxChangeStudentInfo.Controls.Add(this.TextBoxLastName);
            this.GroupBoxChangeStudentInfo.Controls.Add(this.TextBoxFirstName);
            this.GroupBoxChangeStudentInfo.Location = new System.Drawing.Point(10, 107);
            this.GroupBoxChangeStudentInfo.Name = "GroupBoxChangeStudentInfo";
            this.GroupBoxChangeStudentInfo.Size = new System.Drawing.Size(150, 104);
            this.GroupBoxChangeStudentInfo.TabIndex = 4;
            this.GroupBoxChangeStudentInfo.TabStop = false;
            this.GroupBoxChangeStudentInfo.Text = "Изменить информацию";
            // 
            // ComboBoxStudentGroup
            // 
            this.ComboBoxStudentGroup.AutoCompleteCustomSource.AddRange(new string[] {
            "ПРО-106Б",
            "ПРО-206Б",
            "ПРО-306Б",
            "ПРО-406Б"});
            this.ComboBoxStudentGroup.FormattingEnabled = true;
            this.ComboBoxStudentGroup.Items.AddRange(new object[] {
            "ПРО-106Б",
            "ПРО-206Б",
            "ПРО-306Б",
            "ПРО-406Б"});
            this.ComboBoxStudentGroup.Location = new System.Drawing.Point(7, 73);
            this.ComboBoxStudentGroup.Name = "ComboBoxStudentGroup";
            this.ComboBoxStudentGroup.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxStudentGroup.TabIndex = 2;
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(7, 46);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLastName.TabIndex = 1;
            this.TextBoxLastName.Text = "Фамилия";
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(7, 20);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxFirstName.TabIndex = 0;
            this.TextBoxFirstName.Text = "Имя";
            // 
            // LabelStatusStudentInfo
            // 
            this.LabelStatusStudentInfo.AutoSize = true;
            this.LabelStatusStudentInfo.Location = new System.Drawing.Point(7, 91);
            this.LabelStatusStudentInfo.Name = "LabelStatusStudentInfo";
            this.LabelStatusStudentInfo.Size = new System.Drawing.Size(105, 13);
            this.LabelStatusStudentInfo.TabIndex = 3;
            this.LabelStatusStudentInfo.Text = "Статус предмета: 2";
            // 
            // LabelFirstNameStudentInfo
            // 
            this.LabelFirstNameStudentInfo.AutoSize = true;
            this.LabelFirstNameStudentInfo.Location = new System.Drawing.Point(7, 66);
            this.LabelFirstNameStudentInfo.Name = "LabelFirstNameStudentInfo";
            this.LabelFirstNameStudentInfo.Size = new System.Drawing.Size(72, 13);
            this.LabelFirstNameStudentInfo.TabIndex = 2;
            this.LabelFirstNameStudentInfo.Text = "Имя: Никита";
            // 
            // LabelLastNameStudentInfo
            // 
            this.LabelLastNameStudentInfo.AutoSize = true;
            this.LabelLastNameStudentInfo.Location = new System.Drawing.Point(7, 44);
            this.LabelLastNameStudentInfo.Name = "LabelLastNameStudentInfo";
            this.LabelLastNameStudentInfo.Size = new System.Drawing.Size(128, 13);
            this.LabelLastNameStudentInfo.TabIndex = 1;
            this.LabelLastNameStudentInfo.Text = "Фамилия: Стрельников";
            // 
            // LabelGroupStudentInfo
            // 
            this.LabelGroupStudentInfo.AutoSize = true;
            this.LabelGroupStudentInfo.Location = new System.Drawing.Point(7, 20);
            this.LabelGroupStudentInfo.Name = "LabelGroupStudentInfo";
            this.LabelGroupStudentInfo.Size = new System.Drawing.Size(99, 13);
            this.LabelGroupStudentInfo.TabIndex = 0;
            this.LabelGroupStudentInfo.Text = "Группа: ПРО-206Б";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelPaint});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelPaint
            // 
            this.toolStripStatusLabelPaint.Name = "toolStripStatusLabelPaint";
            this.toolStripStatusLabelPaint.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelPaint.Text = "toolStripStatusLabel1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(389, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(361, 211);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SpawnButtonsCheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(353, 185);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Прикол1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SpawnButtonsCheckBox
            // 
            this.SpawnButtonsCheckBox.AutoSize = true;
            this.SpawnButtonsCheckBox.Location = new System.Drawing.Point(17, 16);
            this.SpawnButtonsCheckBox.Name = "SpawnButtonsCheckBox";
            this.SpawnButtonsCheckBox.Size = new System.Drawing.Size(228, 17);
            this.SpawnButtonsCheckBox.TabIndex = 0;
            this.SpawnButtonsCheckBox.Text = "Спавнить кликом мышки новые кнопки";
            this.SpawnButtonsCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(353, 185);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Прикол2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // myButton
            // 
            this.myButton.Location = new System.Drawing.Point(13, 489);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(135, 23);
            this.myButton.TabIndex = 3;
            this.myButton.Text = "Я всегда в центре!";
            this.myButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.myButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.StudentInfoGroupBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.StudentInfoGroupBox.ResumeLayout(false);
            this.StudentInfoGroupBox.PerformLayout();
            this.GroupBoxChangeMarkStudentInfo.ResumeLayout(false);
            this.GroupBoxChangeMarkStudentInfo.PerformLayout();
            this.GroupBoxChangeStudentInfo.ResumeLayout(false);
            this.GroupBoxChangeStudentInfo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox StudentInfoGroupBox;
        private System.Windows.Forms.Label LabelFirstNameStudentInfo;
        private System.Windows.Forms.Label LabelLastNameStudentInfo;
        private System.Windows.Forms.Label LabelGroupStudentInfo;
        private System.Windows.Forms.Label LabelStatusStudentInfo;
        private System.Windows.Forms.GroupBox GroupBoxChangeStudentInfo;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.ComboBox ComboBoxStudentGroup;
        private System.Windows.Forms.Button ButtonChangeStudentInfo;
        private System.Windows.Forms.GroupBox GroupBoxChangeMarkStudentInfo;
        private System.Windows.Forms.RadioButton FiveRadioButtonMark;
        private System.Windows.Forms.RadioButton FourRadioButtonMark;
        private System.Windows.Forms.RadioButton ThreeRadioButtonMark;
        private System.Windows.Forms.RadioButton TwoRadioButtonMark;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox SpawnButtonsCheckBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPaint;
        private System.Windows.Forms.Button myButton;
    }
}

