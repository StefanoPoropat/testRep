namespace testRep
{
    partial class addStud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addStud));
            this.lblName = new System.Windows.Forms.Label();
            this.lblNoIndex = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbIndex = new System.Windows.Forms.TextBox();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbDirection = new System.Windows.Forms.ComboBox();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnCloseWithOutSaving = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIregular = new System.Windows.Forms.RadioButton();
            this.rbRegular = new System.Windows.Forms.RadioButton();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nextImg = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(27, 45);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ime:";
            // 
            // lblNoIndex
            // 
            this.lblNoIndex.Location = new System.Drawing.Point(264, 45);
            this.lblNoIndex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoIndex.Name = "lblNoIndex";
            this.lblNoIndex.Size = new System.Drawing.Size(81, 23);
            this.lblNoIndex.TabIndex = 1;
            this.lblNoIndex.Text = "Broj indexa:";
            // 
            // lblSurname
            // 
            this.lblSurname.Location = new System.Drawing.Point(27, 126);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(81, 23);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Prezime:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Location = new System.Drawing.Point(264, 126);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(81, 23);
            this.lblDateOfBirth.TabIndex = 3;
            this.lblDateOfBirth.Text = "Datum rođenja:";
            // 
            // lblDirection
            // 
            this.lblDirection.Location = new System.Drawing.Point(27, 200);
            this.lblDirection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(81, 23);
            this.lblDirection.TabIndex = 4;
            this.lblDirection.Text = "Smjer:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(29, 70);
            this.txbName.Margin = new System.Windows.Forms.Padding(2);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(119, 20);
            this.txbName.TabIndex = 5;
            // 
            // txbIndex
            // 
            this.txbIndex.Location = new System.Drawing.Point(266, 70);
            this.txbIndex.Margin = new System.Windows.Forms.Padding(2);
            this.txbIndex.Name = "txbIndex";
            this.txbIndex.Size = new System.Drawing.Size(119, 20);
            this.txbIndex.TabIndex = 6;
            // 
            // txbSurname
            // 
            this.txbSurname.Location = new System.Drawing.Point(29, 151);
            this.txbSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(119, 20);
            this.txbSurname.TabIndex = 7;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(266, 150);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(151, 20);
            this.dtpDateOfBirth.TabIndex = 8;
            // 
            // cbDirection
            // 
            this.cbDirection.FormattingEnabled = true;
            this.cbDirection.Items.AddRange(new object[] {
            "Programer",
            "Sistem administrator",
            "Mrežni administrator"});
            this.cbDirection.Location = new System.Drawing.Point(29, 225);
            this.cbDirection.Margin = new System.Windows.Forms.Padding(2);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(120, 21);
            this.cbDirection.TabIndex = 9;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(36, 310);
            this.btnSaveData.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(111, 36);
            this.btnSaveData.TabIndex = 10;
            this.btnSaveData.Text = "Snimi";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnCloseWithOutSaving
            // 
            this.btnCloseWithOutSaving.Location = new System.Drawing.Point(273, 310);
            this.btnCloseWithOutSaving.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseWithOutSaving.Name = "btnCloseWithOutSaving";
            this.btnCloseWithOutSaving.Size = new System.Drawing.Size(111, 36);
            this.btnCloseWithOutSaving.TabIndex = 11;
            this.btnCloseWithOutSaving.Text = "Otkaži";
            this.btnCloseWithOutSaving.UseVisualStyleBackColor = true;
            this.btnCloseWithOutSaving.Click += new System.EventHandler(this.btnCloseWithOutSaving_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIregular);
            this.groupBox1.Controls.Add(this.rbRegular);
            this.groupBox1.Location = new System.Drawing.Point(266, 225);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(138, 66);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vrsta studija:";
            // 
            // rbIregular
            // 
            this.rbIregular.AutoSize = true;
            this.rbIregular.Location = new System.Drawing.Point(7, 39);
            this.rbIregular.Margin = new System.Windows.Forms.Padding(2);
            this.rbIregular.Name = "rbIregular";
            this.rbIregular.Size = new System.Drawing.Size(74, 17);
            this.rbIregular.TabIndex = 1;
            this.rbIregular.Text = "Izvanredni";
            this.rbIregular.UseVisualStyleBackColor = true;
            // 
            // rbRegular
            // 
            this.rbRegular.AutoSize = true;
            this.rbRegular.Checked = true;
            this.rbRegular.Location = new System.Drawing.Point(7, 18);
            this.rbRegular.Margin = new System.Windows.Forms.Padding(2);
            this.rbRegular.Name = "rbRegular";
            this.rbRegular.Size = new System.Drawing.Size(65, 17);
            this.rbRegular.TabIndex = 0;
            this.rbRegular.TabStop = true;
            this.rbRegular.Text = "Redovni";
            this.rbRegular.UseVisualStyleBackColor = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 19);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 19);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 379);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(882, 24);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(626, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Change Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(616, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Show image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nextImg
            // 
            this.nextImg.Location = new System.Drawing.Point(707, 225);
            this.nextImg.Name = "nextImg";
            this.nextImg.Size = new System.Drawing.Size(75, 23);
            this.nextImg.TabIndex = 18;
            this.nextImg.Text = "Next Image";
            this.nextImg.UseVisualStyleBackColor = true;
            this.nextImg.Click += new System.EventHandler(this.nextImg_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ddrgkv3-deab32ae-aed2-4263-8570-ef718152d2bb.png");
            this.imageList1.Images.SetKeyName(1, "flareon_loaf_during_a_rainy_day__by_therandomartz_dgmwpik-fullview.jpg");
            this.imageList1.Images.SetKeyName(2, "image1.png");
            this.imageList1.Images.SetKeyName(3, "TRRS-80-3.jpg");
            this.imageList1.Images.SetKeyName(4, "yugo-gv-placement-1528210669.jpg");
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(592, 254);
            this.trackBar1.Maximum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(211, 45);
            this.trackBar1.TabIndex = 19;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // addStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 403);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.nextImg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCloseWithOutSaving);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.cbDirection);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.txbIndex);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblNoIndex);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addStud";
            this.Text = "addStud";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNoIndex;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbIndex;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cbDirection;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnCloseWithOutSaving;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbIregular;
        private System.Windows.Forms.RadioButton rbRegular;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button nextImg;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}