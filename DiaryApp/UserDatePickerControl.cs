using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaryApp
{
    public partial class UserDatePickerControl : UserControl
    {
        public event EventHandler LeftClick
        {
            add { leftButton.Click += value; }
            remove { leftButton.Click -= value; }
        }

        public event EventHandler RightClick
        {
            add { rightButton.Click += value; }
            remove { rightButton.Click -= value; }
        }
        public UserDatePickerControl()
        {
            this.Tag = new KeyEntry(DateTime.Now.Month, DateTime.Now.Year);
            InitializeComponent();
            rightButton.Click += RightButton_Click;
            leftButton.Click += LeftButton_Click;
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            ChangeMonth(-1);
            textPanel.Invalidate();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            ChangeMonth(1);
            textPanel.Invalidate();
        }

        private void textPanel_Paint(object sender, PaintEventArgs e)
        {
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(this.Tag.ToString(), Font, Brushes.Black,(sender as Panel).DisplayRectangle,format);
        }

        private void rightButton_Paint(object sender, PaintEventArgs e)
        {
            Image image = Image.FromFile("right.png");
            e.Graphics.DrawImage(image,0,0);
        }

        private void leftButton_Paint(object sender, PaintEventArgs e)
        {
            Bitmap image = new Bitmap("right.png");
            image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            e.Graphics.DrawImage(image, 0, 0);
        }
        private void ChangeMonth(int value)
        {
            KeyEntry ke = Tag as KeyEntry;
            DateTime curr = new DateTime(ke.Year, ke.Month, 1);
            curr = curr.AddMonths(value);
            Tag = new KeyEntry(curr.Month, curr.Year);
        }
    }
}
