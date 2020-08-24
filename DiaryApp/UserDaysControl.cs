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
    public partial class UserDaysControl : UserControl
    {
        public event EventHandler ButtonClick;
        public event EventHandler ButtonDoubleClick;
        public UserDaysControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
            Init(DateTime.Now.Year, DateTime.Now.Month, new int[1] {0});
        }
        public void InitHeader()
        {
            tableLayoutPanel1.Controls.Add(new UserCellButtonControl(days.Mon.ToString()), 0, 0);
            tableLayoutPanel1.Controls.Add(new UserCellButtonControl(days.Tue.ToString()), 1, 0);
            tableLayoutPanel1.Controls.Add(new UserCellButtonControl(days.Wed.ToString()), 2, 0);
            tableLayoutPanel1.Controls.Add(new UserCellButtonControl(days.Thu.ToString()), 3, 0);
            tableLayoutPanel1.Controls.Add(new UserCellButtonControl(days.Fri.ToString()), 4, 0);
            tableLayoutPanel1.Controls.Add(new UserCellButtonControl(days.Sat.ToString()), 5, 0);
            tableLayoutPanel1.Controls.Add(new UserCellButtonControl(days.Sun.ToString()), 6, 0);
        }
        public void Init(int year,int month,int[] activeButtons)
        {
            tableLayoutPanel1.Controls.Clear();
            InitHeader();
            InitBody(year,month,activeButtons);
        }
        protected void InitBody(int year, int month,int[] activeButtons)
        {
            DateTime date = new DateTime(year, month, 1);
            TableLayoutPanelCellPosition pos = new TableLayoutPanelCellPosition(0, 1);
            //init first empty cells
            while (!pos.isStart(date))
            {
                UserCellButtonControl btn = new UserCellButtonControl();
                tableLayoutPanel1.Controls.Add(btn, pos.Column, pos.Row);
                pos = pos.Next();
            }
            //init days cells
            int daysCount = DateTime.DaysInMonth(year, month);
            for (int i = 0; i < daysCount;)
            {
                UserCellButtonControl btn = new UserCellButtonControl((++i).ToString());
                btn.Enabled = true;
                btn.ButtonClick += Btn_ButtonClick;
                btn.MouseDoubleClick += Btn_DoubleClick;
                if (activeButtons.Contains(i))
                    btn.ButtonBackColor = Color.FromArgb(27, 210, 199);
                tableLayoutPanel1.Controls.Add(btn, pos.Column, pos.Row);
                pos = pos.Next();
            }
            //init last empty cells
            while (!pos.isEnd())
            {
                UserCellButtonControl btn = new UserCellButtonControl();
                tableLayoutPanel1.Controls.Add(btn, pos.Column, pos.Row);
                pos = pos.Next();
            }
        }
        private void Btn_DoubleClick(object sender, MouseEventArgs e)
            => ButtonDoubleClick?.Invoke(sender, e);
        private void Btn_ButtonClick(object sender, EventArgs e)
            => ButtonClick?.Invoke(sender, e);
        //values for header
        enum days {
            Mon = DayOfWeek.Monday,
            Tue = DayOfWeek.Tuesday,
            Wed = DayOfWeek.Wednesday, 
            Thu = DayOfWeek.Thursday,
            Fri = DayOfWeek.Friday,
            Sat = DayOfWeek.Saturday,
            Sun = DayOfWeek.Sunday
        };
    }
    public static class MoveCellPosition
    {
        public static TableLayoutPanelCellPosition Next(this TableLayoutPanelCellPosition pos)
        {
            TableLayoutPanelCellPosition next = pos;
            if(++next.Column > 6)
            {
                next.Column = 0;
                ++next.Row;
            }
            return next;
        }
        public static bool isEnd(this TableLayoutPanelCellPosition pos)
            => pos.Column == 0;
        public static bool isStart(this TableLayoutPanelCellPosition pos, DateTime date)
            => pos.Column == 6
            ? (int)date.DayOfWeek == 0
            : (int)date.DayOfWeek == pos.Column + 1;
    }
}
