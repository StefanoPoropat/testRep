using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace testRep
{
    public partial class addStud : Form
    {
        public addStud()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[brojac];
        }

        private DateTime pocetno = DateTime.Now;

        private string study;
        public string name => txbName.Text;
        public string surname => txbSurname.Text;
        public string index => txbIndex.Text;
        public string direction => cbDirection.Text;
        public string date => dtpDateOfBirth.Text;
        // Declare the default image path as a constant or variable
        private string defaultImagePath = @"..\..\Images\image1.png";
        private int brojac = 0;

        public string studyType
        {
            get
            {
                if (rbRegular.Checked)
                {
                    study = "R";
                }
                if (rbIregular.Checked)
                {
                    study = "I";
                }
                return study;
            }
        }

        private void btnCloseWithOutSaving_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            Close();
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Trenutno: " + DateTime.Now.ToLongTimeString();
            TimeSpan proteklo = DateTime.Now - pocetno;
            toolStripStatusLabel1.Text = "Proteklo: " +
                proteklo.Hours.ToString() + ":" + proteklo.Minutes.ToString() + ":" + proteklo.Seconds.ToString();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Show message box with Yes, No, and Cancel options
            DialogResult rez = MessageBox.Show(
                "Do you wish to save and exit?",
                "Exit",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information
            );

            // Handle each possible DialogResult from the message box
            if (rez == DialogResult.Yes)
            {
                // Allow the form to close normally
                e.Cancel = false;  // Form closes
            }
            if(rez == DialogResult.No)
            {
                DialogResult = DialogResult.Abort;
                e.Cancel = false;
            }
            else if (rez == DialogResult.Cancel)
            {
                // Prevent the form from closing if No or Cancel is selected
                DialogResult = DialogResult.Abort;
                e.Cancel = true;  // Form stays open
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                // Create and configure the OpenFileDialog
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Select an Image",
                    Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*",
                    InitialDirectory = @"..\..\Images\" // Optionally set the initial directory
                };

                // Show the dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file's path
                    string selectedImagePath = openFileDialog.FileName;

                    // Check if the file exists before loading it
                    if (File.Exists(selectedImagePath))
                    {
                        // Use Image.FromFile to load the selected image
                        pictureBox1.Image = System.Drawing.Image.FromFile(selectedImagePath);
                        pictureBox1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("The selected file could not be found.", "ERROR", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                // Show the exception message if an error occurs
                MessageBox.Show($"Couldn't load image: {ex.Message}", "ERROR", MessageBoxButtons.OK);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[brojac];
            pictureBox1.Visible = true;
        }

        private void nextImg_Click(object sender, EventArgs e)
        {
            brojac++;
            if (imageList1.Images.Count == brojac)
            {
                brojac = 0;
                trackBar1.Value = 0;
            }
            trackBar1.Value = brojac;
            pictureBox1.Image = imageList1.Images[brojac];
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            brojac++;
            if (imageList1.Images.Count == brojac)
            {
                brojac = 0;
            }
            pictureBox1.Image = imageList1.Images[brojac];
        }
    }
}
