using System;
using System.Drawing;
using System.Windows.Forms;

namespace testRep
{
    public partial class FontSelectorForm : Form
    {
        public string SelectedFontName { get; private set; }
        public string fontSize = "10";

        public FontSelectorForm()
        {
            InitializeComponent();

            fontComboBox.Items.AddRange(new string[] { "Segoe UI", "Verdana", "Calibri", "Times New Roman" });
            fontComboBox.SelectedIndex = 0; // Set default selection

            // In the form's constructor or Load event
            fontComboBox.SelectedIndexChanged += (sender, e) =>
            {
                // Get the selected font from the ComboBox and apply it to the form and its controls
                Font newFont = new Font(fontComboBox.SelectedItem.ToString(), Convert.ToInt64(fontSize));

                // Apply the font to the form itself
                this.Font = newFont;

                // Apply the font to each control in the form
                foreach (Control control in this.Controls)
                {
                    control.Font = newFont;
                }
            };

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Set the selected font name and close the dialog with OK result
            SelectedFontName = fontComboBox.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            // Close the dialog with a Cancel result
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            fontSize = trackBar1.Value.ToString();
            textBox1.Text = "Font size: "+fontSize;
        }
    }
}
