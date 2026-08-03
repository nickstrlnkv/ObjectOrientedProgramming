using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        int paintCount = 0;
        // Создаем Labels для координат мыши
        ToolStripLabel labelX = new ToolStripLabel();
        ToolStripLabel labelY = new ToolStripLabel();

        public MainForm()
        {
            InitializeComponent();
            statusStrip1.Items.Add(labelX);
            statusStrip1.Items.Add(labelY);

        }

        private void ButtonChangeStudentInfo_Click(object sender, EventArgs e)
        {
            LabelLastNameStudentInfo.Text = $"Фамилия: {TextBoxLastName.Text}";
            LabelFirstNameStudentInfo.Text = $"Имя: {TextBoxFirstName.Text}";
            
            LabelGroupStudentInfo.Text = $"Группа: {ComboBoxStudentGroup.Text}";

            try
            {
                LabelStatusStudentInfo.Text
                = $"Оценка по ООП: " +
                $"{GroupBoxChangeMarkStudentInfo.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text}";
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Пожалуйста, выберите оценку");
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            labelX.Text = $"X: {e.X.ToString()}";
            labelY.Text = $"X: {e.Y.ToString()}";
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (SpawnButtonsCheckBox.Checked)
            {
                Button newButton = new Button();
                newButton.Text = "New Button";
                newButton.Location = new Point(e.X - newButton.Width / 2, e.Y - newButton.Height / 2);
                newButton.Click += new System.EventHandler(ShowMessageBoxSpawnClick);
                this.Controls.Add(newButton);
            }
        }
        private void ShowMessageBoxSpawnClick(object sender, EventArgs e)
        {
            MessageBox.Show("Вы кликнули по динамической кнопке!");
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            paintCount++;
            toolStripStatusLabelPaint.Text = $"Событие Paint сработало {paintCount} раз";
            e.Graphics.DrawLine(Pens.Black, 0, 0, this.Width, this.Height);
            
        }

    }
}
