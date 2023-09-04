namespace WebcamApp
{
    partial class ComboBox
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxWebcamList = new System.Windows.Forms.ComboBox();
            ButtonStart = new Button();
            ButtonCapture = new Button();
            ButtonSaveImage = new Button();
            ButtonExit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBoxWebcamList
            // 
            comboBoxWebcamList.FormattingEnabled = true;
            comboBoxWebcamList.Location = new Point(12, 12);
            comboBoxWebcamList.Name = "comboBoxWebcamList";
            comboBoxWebcamList.Size = new Size(121, 23);
            comboBoxWebcamList.TabIndex = 0;
            comboBoxWebcamList.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ButtonStart
            // 
            ButtonStart.Location = new Point(139, 11);
            ButtonStart.Name = "ButtonStart";
            ButtonStart.Size = new Size(75, 23);
            ButtonStart.TabIndex = 1;
            ButtonStart.Text = "Start";
            ButtonStart.UseVisualStyleBackColor = true;
            ButtonStart.Click += ButtonStart_Click;
            // 
            // ButtonCapture
            // 
            ButtonCapture.Location = new Point(220, 12);
            ButtonCapture.Name = "ButtonCapture";
            ButtonCapture.Size = new Size(75, 23);
            ButtonCapture.TabIndex = 2;
            ButtonCapture.Text = "Capture";
            ButtonCapture.UseVisualStyleBackColor = true;
            ButtonCapture.Click += ButtonCapture_Click;
            // 
            // ButtonSaveImage
            // 
            ButtonSaveImage.Location = new Point(301, 12);
            ButtonSaveImage.Name = "ButtonSaveImage";
            ButtonSaveImage.Size = new Size(75, 23);
            ButtonSaveImage.TabIndex = 3;
            ButtonSaveImage.Text = "Save Image";
            ButtonSaveImage.UseVisualStyleBackColor = true;
            ButtonSaveImage.Click += ButtonSaveImage_Click;
            // 
            // ButtonExit
            // 
            ButtonExit.Location = new Point(713, 12);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new Size(75, 23);
            ButtonExit.TabIndex = 4;
            ButtonExit.Text = "Exit";
            ButtonExit.UseVisualStyleBackColor = true;
            ButtonExit.Click += ButtonExit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.5F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 41);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(776, 397);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(378, 391);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(387, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(386, 391);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // ComboBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(ButtonExit);
            Controls.Add(ButtonSaveImage);
            Controls.Add(ButtonCapture);
            Controls.Add(ButtonStart);
            Controls.Add(comboBoxWebcamList);
            Name = "ComboBox";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxWebcamList;
        private Button ButtonStart;
        private Button ButtonCapture;
        private Button ButtonSaveImage;
        private Button ButtonExit;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}