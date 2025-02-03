using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testRep
{
    public partial class monthCalendarControl : Form
    {
        public monthCalendarControl()
        {
            InitializeComponent();
        }
        public string start => monthCalendar1.SelectionStart.ToShortDateString();
        public string end => monthCalendar1.SelectionEnd.ToShortDateString();
        public void button1_Click(object sender, EventArgs e)
        {
            TimeSpan ts = monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart;
            if (ts.Days < 1)
            {
                MessageBox.Show("Korištenjem tipke SHIFT odaberite opseg datuma.");
                return;
            }
            MessageBox.Show("Rezervirali ste usluge u trajanju od "+ts.Days.ToString() + " dana.", "Rezervacija");

            MessageBox.Show("Vasa rezervacija počinje " + start + " a završava " + end);
            this.DialogResult = DialogResult.OK;
            Close();
        }
        public override string ToString()
        {
            return start;
        }
        public string ToString2()
        {
            return end;
        }
    }
}
