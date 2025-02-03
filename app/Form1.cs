using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace testRep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string name, surname, date, direction, index, study, startOfTests = "ne dela", endOfTests = "zasada";
        public string fontName2, fontSize2;
        private DateTime pocetno = DateTime.Now;

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Trenutno: " + DateTime.Now.ToLongTimeString();
            TimeSpan proteklo = new TimeSpan();
            proteklo = DateTime.Now - pocetno;
            toolStripStatusLabel1.Text = "Proteklo: " +
            proteklo.Hours.ToString() + ":" + proteklo.Minutes.ToString() + ":" + proteklo.Seconds.ToString();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ovo je informativna poruka. Želite li nastaviti?",
                                            "Informacija",
                                            MessageBoxButtons.YesNoCancel,
                                            MessageBoxIcon.Information);

            // Provjeravamo koji je gumb kliknut
            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Odabrali ste 'Yes'.");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Odabrali ste 'No'.");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Odabrali ste 'Cancel'.");
                    break;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Lorem ipsum",
                                           "About the program",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Information);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FontSelectorForm fontSelectorForm = new FontSelectorForm();
            DialogResult result = fontSelectorForm.ShowDialog();

            // Only add student information to the ListBox if the form was saved (DialogResult == OK)
            if (result == DialogResult.OK)
            {
                fontName2 = fontSelectorForm.SelectedFontName;
                fontSize2 = fontSelectorForm.fontSize;
                FontSize fontSize = new FontSize(fontName2, fontSize2);

                Font newFont = new Font(fontName2, Convert.ToInt64(fontSize2));

                // Apply the font to the form itself
                this.Font = newFont;

                // Apply the font to each control in the form
                foreach (Control control in this.Controls)
                {
                    control.Font = newFont;
                }
            };
        }

        private void chrome_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe");
        }

        private void excel_Click(object sender, EventArgs e)
        {
            Process.Start("EXCEL.EXE");
        }

        private void powerPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("POWERPNT.EXE");
        }

        private void word_Click(object sender, EventArgs e)
        {
            Process.Start("WINWORD.EXE");
        }

        private void startInfo_Click(object sender, EventArgs e)
        {
            var uri = "http://ss-zcrnje-rovinj.skole.hr/";
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = uri
            };
            psi.WindowStyle = ProcessWindowStyle.Normal;
            Process.Start(psi);
        }

        private void vacationTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monthCalendarControl monthCalendarControl = new monthCalendarControl();
            DialogResult result = monthCalendarControl.ShowDialog();

            if (result == DialogResult.OK)
            {
                startOfTests = monthCalendarControl.start;
                endOfTests = monthCalendarControl.end;

                Test Test = new Test(startOfTests, endOfTests);
                testSeasonBox.Text = "Ispiti počinju " + startOfTests + ", a završavaju " + endOfTests;
            }
            testSeasonBox.Visible = true;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter saveFile = new System.IO.StreamWriter("C:\\Users\\ucenik\\Documents\\fileGoHere\\students.txt");
            foreach (var item in listBox1.Items)
            {
                saveFile.WriteLine(item.ToString());
            }
            saveFile.Close();
            MessageBox.Show("Saving success.");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string line;
            System.IO.StreamReader saveFile = new System.IO.StreamReader("C:\\Users\\ucenik\\Documents\\fileGoHere\\students.txt");
            while ((line = saveFile.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }
            saveFile.Close();
            MessageBox.Show("Loading success.");
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Molimo odaberite studenta za brisanje.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addNewStudent_Click(object sender, EventArgs e)
        {
            addStud addStudForm = new addStud();
            DialogResult result = addStudForm.ShowDialog();

            // Only add student information to the ListBox if the form was saved (DialogResult == OK)
            if (result == DialogResult.OK)
            {
                name = addStudForm.name;
                surname = addStudForm.surname;
                date = addStudForm.date;
                direction = addStudForm.direction;
                index = addStudForm.index;
                study = addStudForm.studyType;

                Students student = new Students(study, name, surname, date, direction, index);
                listBox1.Items.Add(student.ToString());
            }
            // If DialogResult is Cancel or form closed with X, nothing is added to the ListBox
        }
    }
}