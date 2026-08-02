using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {

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
    }
}
