using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryApp
{
    public partial class DiaryForm : Form
    {
        public DiaryForm()
        {
            diary = new Diary();
            diary.AddEntry(1, "Первое число тестовая запись");
            diary.AddEntry(2, "Второе число тестовая запись");
            diary.AddEntry(7, "Седямое число тестовая запись");
            InitializeComponent();
            //year month picker
            datePicker = new UserDatePickerControl();
            datePicker.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(datePicker, 0, 0);

            //calendar
            calendar.ButtonClick += Calendar_Click;
            calendar.ButtonClick += Calendar_DoubleClick;
            calendar.Init(DateTime.Now.Year,DateTime.Now.Month,diary.ActiveButtons());

            //buttons
            datePicker.LeftClick += DatePickerClick;
            datePicker.RightClick += DatePickerClick;

            //textbox
            textBox1.TextChanged += TextBox1_TextChanged;
        }

        private void Calendar_DoubleClick(object sender, EventArgs e)
        {
            modalForm = new ModalForm();
            modalForm.DialogText = diary.GetEntry(Convert.ToInt32(button.Text));
            DialogResult result = modalForm.ShowDialog(this);
            if (result == DialogResult.Cancel)
                modalForm.Close();
            else if (result == DialogResult.OK)
            {
                if (!String.IsNullOrWhiteSpace(modalForm.DialogText) || !String.IsNullOrEmpty(modalForm.DialogText))
                {
                    diary.AddEntry(Convert.ToInt32(button.Text), modalForm.DialogText);
                    Color clr = Color.FromArgb(27, 210, 199);
                    button.BackColor = clr;
                    button.FlatAppearance.MouseOverBackColor = clr;
                    button.FlatAppearance.MouseDownBackColor = clr;
                    button.FlatAppearance.BorderColor = clr;
                }
                else if (String.IsNullOrWhiteSpace(modalForm.DialogText) || String.IsNullOrEmpty(modalForm.DialogText))
                {
                    diary.RemoveEntry(Convert.ToInt32(button.Text));
                    Color clr = Color.FromArgb(241, 246, 250);
                    button.BackColor = clr;
                    button.FlatAppearance.MouseOverBackColor = clr;
                    button.FlatAppearance.MouseDownBackColor = clr;
                    button.FlatAppearance.BorderColor = clr;
                }
                textBox1.Text = modalForm.DialogText;
                modalForm.Close();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (button == null)
                return;
            if (!String.IsNullOrWhiteSpace(textBox1.Text) || !String.IsNullOrEmpty(textBox1.Text))
            {
                diary.AddEntry(Convert.ToInt32(button.Text), textBox1.Text);
                Color clr = Color.FromArgb(27, 210, 199);
                button.BackColor = clr;
                button.FlatAppearance.MouseOverBackColor = clr;
                button.FlatAppearance.MouseDownBackColor = clr;
                button.FlatAppearance.BorderColor = clr;
            }
            else
            {
                diary.RemoveEntry(Convert.ToInt32(button.Text));
                Color clr = Color.FromArgb(241, 246, 250);
                button.BackColor = clr;
                button.FlatAppearance.MouseOverBackColor = clr;
                button.FlatAppearance.MouseDownBackColor = clr;
                button.FlatAppearance.BorderColor = clr;
            }
        }

        private void DatePickerClick(object sender, EventArgs e)
        {
            KeyEntry keyEntry = datePicker.Tag as KeyEntry;
            diary.CurrentMonth = keyEntry;
            calendar.Init(keyEntry.Year, keyEntry.Month, diary.ActiveButtons());
            this.textBox1.Text = "";
        }

        private void Calendar_Click(object sender, EventArgs e)
        {
            if (button != null)
                button.Font = Font;
            button = sender as Button;
            button.Font = new Font(Font.FontFamily,12.0F,FontStyle.Bold);
            this.textBox1.Text = diary.GetEntry(Convert.ToInt32(button.Text));
        }

        UserDatePickerControl datePicker;
        Diary diary;
        Button button;
        ModalForm modalForm;
    }
}
