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
    public partial class UserCellButtonControl : UserControl
    {
        public UserCellButtonControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            button.FlatAppearance.BorderColor = Color.FromArgb(241, 246, 250);
        }
        public UserCellButtonControl(string text)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            button.Enabled = true;
            button.Text = text;
            Color clr = Color.FromArgb(241, 246, 250); ;
            button.BackColor = clr;
            button.FlatAppearance.BorderColor = clr;
            button.FlatAppearance.MouseOverBackColor = clr;
            button.FlatAppearance.MouseDownBackColor = clr;
        }
        public event MouseEventHandler ButtonDoubleClick
        {
            add { button.MouseDoubleClick += value; }
            remove { button.MouseDoubleClick -= value; }
        }
        public event EventHandler ButtonClick
        {
            add { button.Click += value; }
            remove { button.Click -= value; }
        }
        public int Text
            => Convert.ToInt32(button.Text);
        public Color ButtonBackColor
        {
            set { 
                button.BackColor = value;
                button.FlatAppearance.BorderColor = value;
                button.FlatAppearance.MouseDownBackColor = value;
                button.FlatAppearance.MouseOverBackColor = value;
            }
        }
            

    }
}
