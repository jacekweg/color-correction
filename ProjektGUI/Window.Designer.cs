namespace ColorCorrectionProgram
{
    partial class ColorCorr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// <returns> void </returns>
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
        /// Required selectedDll for Designer support - do not modify
        /// the contents of this selectedDll with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorCorr));
            this.uploadImageButton = new System.Windows.Forms.Button();
            this.uploadImageTextBox = new System.Windows.Forms.TextBox();
            this.InsertImage = new System.Windows.Forms.PictureBox();
            this.CsharpRadioButton = new System.Windows.Forms.RadioButton();
            this.AsmRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.threadsGroupBox = new System.Windows.Forms.GroupBox();
            this.labelDllUsedValue = new System.Windows.Forms.Label();
            this.labelDllUsed = new System.Windows.Forms.Label();
            this.labelThreadsUsedValue = new System.Windows.Forms.Label();
            this.labelThreadsUsed = new System.Windows.Forms.Label();
            this.labelSelectNumberOfThreads = new System.Windows.Forms.Label();
            this.labelTimeValue = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.ActiveThreadsComboBox = new System.Windows.Forms.ComboBox();
            this.labelImageSizeValue = new System.Windows.Forms.Label();
            this.labelImageSize = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ConvertedImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.LabelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelRedValue = new System.Windows.Forms.Label();
            this.labelGreenValue = new System.Windows.Forms.Label();
            this.labelBlueValue = new System.Windows.Forms.Label();
            this.groupBoxSliders = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.labelImagePath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InsertImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.threadsGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.groupBoxSliders.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UploadImage
            // 
            this.uploadImageButton.Location = new System.Drawing.Point(76, 138);
            this.uploadImageButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.uploadImageButton.Name = "UploadImage";
            this.uploadImageButton.Size = new System.Drawing.Size(187, 47);
            this.uploadImageButton.TabIndex = 0;
            this.uploadImageButton.Text = "Load image";
            this.uploadImageButton.UseVisualStyleBackColor = true;
            this.uploadImageButton.Click += new System.EventHandler(this.UploadImageButton);
            // 
            // uploadImageTextBox
            // 
            this.uploadImageTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uploadImageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uploadImageTextBox.Location = new System.Drawing.Point(202, 43);
            this.uploadImageTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.uploadImageTextBox.MaximumSize = new System.Drawing.Size(458, 27);
            this.uploadImageTextBox.Name = "uploadImageTextBox";
            this.uploadImageTextBox.ReadOnly = true;
            this.uploadImageTextBox.Size = new System.Drawing.Size(458, 34);
            this.uploadImageTextBox.TabIndex = 1;
            // 
            // InsertImage
            // 
            this.InsertImage.BackColor = System.Drawing.Color.Silver;
            this.InsertImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InsertImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InsertImage.Location = new System.Drawing.Point(9, 39);
            this.InsertImage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.InsertImage.Name = "InsertImage";
            this.InsertImage.Size = new System.Drawing.Size(673, 472);
            this.InsertImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InsertImage.TabIndex = 2;
            this.InsertImage.TabStop = false;
            // 
            // CsharpRadioButton
            // 
            this.CsharpRadioButton.AutoSize = true;
            this.CsharpRadioButton.Location = new System.Drawing.Point(11, 83);
            this.CsharpRadioButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CsharpRadioButton.Name = "CsharpRadioButton";
            this.CsharpRadioButton.Size = new System.Drawing.Size(66, 31);
            this.CsharpRadioButton.TabIndex = 3;
            this.CsharpRadioButton.TabStop = true;
            this.CsharpRadioButton.Text = "C#";
            this.CsharpRadioButton.UseVisualStyleBackColor = true;
            // 
            // AsmRadioButton
            // 
            this.AsmRadioButton.AutoSize = true;
            this.AsmRadioButton.Location = new System.Drawing.Point(11, 39);
            this.AsmRadioButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AsmRadioButton.Name = "AsmRadioButton";
            this.AsmRadioButton.Size = new System.Drawing.Size(85, 31);
            this.AsmRadioButton.TabIndex = 4;
            this.AsmRadioButton.TabStop = true;
            this.AsmRadioButton.Text = "ASM";
            this.AsmRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.CsharpRadioButton);
            this.groupBox1.Controls.Add(this.AsmRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(708, 788);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(371, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DLL";
            // 
            // threadsGroupBox
            // 
            this.threadsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.threadsGroupBox.Controls.Add(this.labelDllUsedValue);
            this.threadsGroupBox.Controls.Add(this.labelDllUsed);
            this.threadsGroupBox.Controls.Add(this.labelThreadsUsedValue);
            this.threadsGroupBox.Controls.Add(this.labelThreadsUsed);
            this.threadsGroupBox.Controls.Add(this.labelSelectNumberOfThreads);
            this.threadsGroupBox.Controls.Add(this.labelTimeValue);
            this.threadsGroupBox.Controls.Add(this.labelTime);
            this.threadsGroupBox.Controls.Add(this.ActiveThreadsComboBox);
            this.threadsGroupBox.Location = new System.Drawing.Point(709, 542);
            this.threadsGroupBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.threadsGroupBox.Name = "threadsGroupBox";
            this.threadsGroupBox.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.threadsGroupBox.Size = new System.Drawing.Size(370, 236);
            this.threadsGroupBox.TabIndex = 6;
            this.threadsGroupBox.TabStop = false;
            this.threadsGroupBox.Text = "Performance";
            // 
            // labelDllUsedValue
            // 
            this.labelDllUsedValue.AutoSize = true;
            this.labelDllUsedValue.Location = new System.Drawing.Point(290, 185);
            this.labelDllUsedValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDllUsedValue.Name = "labelDllUsedValue";
            this.labelDllUsedValue.Size = new System.Drawing.Size(61, 27);
            this.labelDllUsedValue.TabIndex = 21;
            this.labelDllUsedValue.Text = "None";
            // 
            // labelDllUsed
            // 
            this.labelDllUsed.AutoSize = true;
            this.labelDllUsed.Location = new System.Drawing.Point(33, 185);
            this.labelDllUsed.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDllUsed.Name = "labelDllUsed";
            this.labelDllUsed.Size = new System.Drawing.Size(99, 27);
            this.labelDllUsed.TabIndex = 20;
            this.labelDllUsed.Text = "DLL used:";
            // 
            // labelThreadsUsedValue
            // 
            this.labelThreadsUsedValue.AutoSize = true;
            this.labelThreadsUsedValue.Location = new System.Drawing.Point(290, 146);
            this.labelThreadsUsedValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelThreadsUsedValue.Name = "labelThreadsUsedValue";
            this.labelThreadsUsedValue.Size = new System.Drawing.Size(61, 27);
            this.labelThreadsUsedValue.TabIndex = 19;
            this.labelThreadsUsedValue.Text = "None";
            // 
            // labelThreadsUsed
            // 
            this.labelThreadsUsed.AutoSize = true;
            this.labelThreadsUsed.Location = new System.Drawing.Point(33, 146);
            this.labelThreadsUsed.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelThreadsUsed.Name = "labelThreadsUsed";
            this.labelThreadsUsed.Size = new System.Drawing.Size(141, 27);
            this.labelThreadsUsed.TabIndex = 18;
            this.labelThreadsUsed.Text = "Threads used:";
            // 
            // labelSelectNumberOfThreads
            // 
            this.labelSelectNumberOfThreads.AutoSize = true;
            this.labelSelectNumberOfThreads.Location = new System.Drawing.Point(33, 62);
            this.labelSelectNumberOfThreads.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSelectNumberOfThreads.Name = "labelSelectNumberOfThreads";
            this.labelSelectNumberOfThreads.Size = new System.Drawing.Size(248, 27);
            this.labelSelectNumberOfThreads.TabIndex = 17;
            this.labelSelectNumberOfThreads.Text = "Select number of threads:";
            // 
            // labelTimeValue
            // 
            this.labelTimeValue.AutoSize = true;
            this.labelTimeValue.Location = new System.Drawing.Point(290, 105);
            this.labelTimeValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTimeValue.Name = "labelTimeValue";
            this.labelTimeValue.Size = new System.Drawing.Size(61, 27);
            this.labelTimeValue.TabIndex = 13;
            this.labelTimeValue.Text = "None";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(33, 105);
            this.labelTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(139, 27);
            this.labelTime.TabIndex = 14;
            this.labelTime.Text = "Time elapsed:";
            // 
            // ActiveThreadsComboBox
            // 
            this.ActiveThreadsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActiveThreadsComboBox.FormattingEnabled = true;
            this.ActiveThreadsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64"});
            this.ActiveThreadsComboBox.Location = new System.Drawing.Point(290, 55);
            this.ActiveThreadsComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ActiveThreadsComboBox.Name = "ActiveThreadsComboBox";
            this.ActiveThreadsComboBox.Size = new System.Drawing.Size(42, 34);
            this.ActiveThreadsComboBox.TabIndex = 7;
            // 
            // labelImageSizeValue
            // 
            this.labelImageSizeValue.AutoSize = true;
            this.labelImageSizeValue.Location = new System.Drawing.Point(202, 84);
            this.labelImageSizeValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelImageSizeValue.Name = "labelImageSizeValue";
            this.labelImageSizeValue.Size = new System.Drawing.Size(61, 27);
            this.labelImageSizeValue.TabIndex = 15;
            this.labelImageSizeValue.Text = "None";
            // 
            // labelImageSize
            // 
            this.labelImageSize.AutoSize = true;
            this.labelImageSize.Location = new System.Drawing.Point(11, 84);
            this.labelImageSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelImageSize.Name = "labelImageSize";
            this.labelImageSize.Size = new System.Drawing.Size(113, 27);
            this.labelImageSize.TabIndex = 16;
            this.labelImageSize.Text = "Image size:";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.InsertImage);
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox3.Size = new System.Drawing.Size(693, 528);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Before";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(3, 793);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(687, 113);
            this.ConvertButton.TabIndex = 8;
            this.ConvertButton.Text = "Convert!";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertImageButton);
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox5.Controls.Add(this.ConvertedImage);
            this.groupBox5.Location = new System.Drawing.Point(708, 4);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox5.Size = new System.Drawing.Size(715, 528);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "After";
            // 
            // ConvertedImage
            // 
            this.ConvertedImage.BackColor = System.Drawing.Color.Silver;
            this.ConvertedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConvertedImage.Location = new System.Drawing.Point(38, 39);
            this.ConvertedImage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ConvertedImage.Name = "ConvertedImage";
            this.ConvertedImage.Size = new System.Drawing.Size(662, 472);
            this.ConvertedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ConvertedImage.TabIndex = 0;
            this.ConvertedImage.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.ReadOnlyChecked = true;
            //
            // saveFileDialog
            //
            this.saveFileDialog.DefaultExt = "bmp";
            // 
            // trackBarRed
            // 
            this.trackBarRed.AutoSize = false;
            this.trackBarRed.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarRed.Location = new System.Drawing.Point(70, 66);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarRed.Size = new System.Drawing.Size(23, 266);
            this.trackBarRed.TabIndex = 16;
            this.trackBarRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRed.ValueChanged += new System.EventHandler(this.ColorComponentValueChangedEventHandler);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.AutoSize = false;
            this.trackBarGreen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarGreen.Location = new System.Drawing.Point(169, 66);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarGreen.Size = new System.Drawing.Size(23, 266);
            this.trackBarGreen.TabIndex = 17;
            this.trackBarGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGreen.ValueChanged += new System.EventHandler(this.ColorComponentValueChangedEventHandler);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.AutoSize = false;
            this.trackBarBlue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trackBarBlue.Location = new System.Drawing.Point(262, 66);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarBlue.Size = new System.Drawing.Size(23, 266);
            this.trackBarBlue.TabIndex = 18;
            this.trackBarBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBlue.ValueChanged += new System.EventHandler(this.ColorComponentValueChangedEventHandler);
            // 
            // LabelRed
            // 
            this.LabelRed.AutoSize = true;
            this.LabelRed.Font = new System.Drawing.Font("Calibri", 9.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelRed.Location = new System.Drawing.Point(52, 30);
            this.LabelRed.Name = "LabelRed";
            this.LabelRed.Size = new System.Drawing.Size(58, 33);
            this.LabelRed.TabIndex = 19;
            this.LabelRed.Text = "Red";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Font = new System.Drawing.Font("Calibri", 9.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGreen.Location = new System.Drawing.Point(138, 30);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(84, 33);
            this.labelGreen.TabIndex = 20;
            this.labelGreen.Text = "Green";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Font = new System.Drawing.Font("Calibri", 9.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBlue.Location = new System.Drawing.Point(241, 30);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(65, 33);
            this.labelBlue.TabIndex = 21;
            this.labelBlue.Text = "Blue";
            // 
            // labelRedValue
            // 
            this.labelRedValue.AutoSize = true;
            this.labelRedValue.Font = new System.Drawing.Font("Calibri", 9.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRedValue.Location = new System.Drawing.Point(70, 329);
            this.labelRedValue.Name = "labelRedValue";
            this.labelRedValue.Size = new System.Drawing.Size(29, 33);
            this.labelRedValue.TabIndex = 22;
            this.labelRedValue.Text = "0";
            // 
            // labelGreenValue
            // 
            this.labelGreenValue.AutoSize = true;
            this.labelGreenValue.Font = new System.Drawing.Font("Calibri", 9.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGreenValue.Location = new System.Drawing.Point(169, 329);
            this.labelGreenValue.Name = "labelGreenValue";
            this.labelGreenValue.Size = new System.Drawing.Size(29, 33);
            this.labelGreenValue.TabIndex = 23;
            this.labelGreenValue.Text = "0";
            // 
            // labelBlueValue
            // 
            this.labelBlueValue.AutoSize = true;
            this.labelBlueValue.Font = new System.Drawing.Font("Calibri", 9.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBlueValue.Location = new System.Drawing.Point(262, 329);
            this.labelBlueValue.Name = "labelBlueValue";
            this.labelBlueValue.Size = new System.Drawing.Size(29, 33);
            this.labelBlueValue.TabIndex = 24;
            this.labelBlueValue.Text = "0";
            // 
            // groupBoxSliders
            // 
            this.groupBoxSliders.Controls.Add(this.LabelRed);
            this.groupBoxSliders.Controls.Add(this.trackBarRed);
            this.groupBoxSliders.Controls.Add(this.labelBlueValue);
            this.groupBoxSliders.Controls.Add(this.trackBarGreen);
            this.groupBoxSliders.Controls.Add(this.labelGreenValue);
            this.groupBoxSliders.Controls.Add(this.trackBarBlue);
            this.groupBoxSliders.Controls.Add(this.labelRedValue);
            this.groupBoxSliders.Controls.Add(this.labelGreen);
            this.groupBoxSliders.Controls.Add(this.labelBlue);
            this.groupBoxSliders.Location = new System.Drawing.Point(1088, 539);
            this.groupBoxSliders.Name = "groupBoxSliders";
            this.groupBoxSliders.Size = new System.Drawing.Size(335, 366);
            this.groupBoxSliders.TabIndex = 25;
            this.groupBoxSliders.TabStop = false;
            this.groupBoxSliders.Text = "Adjust color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSaveImage);
            this.groupBox2.Controls.Add(this.labelImagePath);
            this.groupBox2.Controls.Add(this.uploadImageButton);
            this.groupBox2.Controls.Add(this.uploadImageTextBox);
            this.groupBox2.Controls.Add(this.labelImageSize);
            this.groupBox2.Controls.Add(this.labelImageSizeValue);
            this.groupBox2.Location = new System.Drawing.Point(4, 542);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 236);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image info";
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Enabled = false;
            this.buttonSaveImage.Location = new System.Drawing.Point(383, 138);
            this.buttonSaveImage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(187, 47);
            this.buttonSaveImage.TabIndex = 23;
            this.buttonSaveImage.Text = "Save image";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.SaveImageButton);
            // 
            // labelImagePath
            // 
            this.labelImagePath.AutoSize = true;
            this.labelImagePath.Location = new System.Drawing.Point(11, 43);
            this.labelImagePath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelImagePath.Name = "labelImagePath";
            this.labelImagePath.Size = new System.Drawing.Size(121, 27);
            this.labelImagePath.TabIndex = 22;
            this.labelImagePath.Text = "Image path:";
            // 
            // ColorCorr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1444, 920);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxSliders);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.threadsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ColorCorr";
            this.Text = "ColorCorrection";
            this.Load += new System.EventHandler(this.WindowLoad);
            ((System.ComponentModel.ISupportInitialize)(this.InsertImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.threadsGroupBox.ResumeLayout(false);
            this.threadsGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConvertedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.groupBoxSliders.ResumeLayout(false);
            this.groupBoxSliders.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button uploadImageButton;
        private System.Windows.Forms.TextBox uploadImageTextBox;
        private System.Windows.Forms.PictureBox InsertImage;
        private System.Windows.Forms.RadioButton CsharpRadioButton;
        private System.Windows.Forms.RadioButton AsmRadioButton;
        private System.Windows.Forms.GroupBox threadsGroupBox;
        private System.Windows.Forms.ComboBox ActiveThreadsComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox ConvertedImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label LabelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelRedValue;
        private System.Windows.Forms.Label labelGreenValue;
        private System.Windows.Forms.Label labelBlueValue;
        private System.Windows.Forms.Label labelTimeValue;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelImageSizeValue;
        private System.Windows.Forms.Label labelImageSize;
        private System.Windows.Forms.Label labelThreadsUsedValue;
        private System.Windows.Forms.Label labelThreadsUsed;
        private System.Windows.Forms.Label labelSelectNumberOfThreads;
        private System.Windows.Forms.GroupBox groupBoxSliders;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelDllUsedValue;
        private System.Windows.Forms.Label labelDllUsed;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.Label labelImagePath;
    }
}

