namespace GM48TT
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonBatchExplanation = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownImageBatch = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOpenOutput = new System.Windows.Forms.Button();
            this.labelOutputFolder = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBrowseOutput = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarJPGQuality = new System.Windows.Forms.TrackBar();
            this.radioButtonJPG = new System.Windows.Forms.RadioButton();
            this.radioButtonPNG = new System.Windows.Forms.RadioButton();
            this.radioButtonSmart = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxFPS = new System.Windows.Forms.ComboBox();
            this.buttonEstimate = new System.Windows.Forms.Button();
            this.comboBoxHours = new System.Windows.Forms.ComboBox();
            this.labelAt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxStampLogo = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxAutomated = new System.Windows.Forms.CheckBox();
            this.buttonFullyAutomatedTip = new System.Windows.Forms.Button();
            this.checkBoxStartup = new System.Windows.Forms.CheckBox();
            this.buttonTestScreenshot = new System.Windows.Forms.Button();
            this.buttonStartCapture = new System.Windows.Forms.Button();
            this.buttonForceCapture = new System.Windows.Forms.Button();
            this.pictureBoxProgress = new System.Windows.Forms.PictureBox();
            this.tabControlMain.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImageBatch)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJPGQuality)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Location = new System.Drawing.Point(12, 27);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(330, 388);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numericUpDownInterval);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(322, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Capturing";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(8, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 227);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonBatchExplanation);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.numericUpDownImageBatch);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.textBoxPrefix);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.buttonOpenOutput);
            this.groupBox5.Controls.Add(this.labelOutputFolder);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.buttonBrowseOutput);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(292, 98);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Destination";
            // 
            // buttonBatchExplanation
            // 
            this.buttonBatchExplanation.Location = new System.Drawing.Point(201, 72);
            this.buttonBatchExplanation.Name = "buttonBatchExplanation";
            this.buttonBatchExplanation.Size = new System.Drawing.Size(85, 21);
            this.buttonBatchExplanation.TabIndex = 9;
            this.buttonBatchExplanation.Text = "<-- what\'s that do?";
            this.buttonBatchExplanation.UseVisualStyleBackColor = true;
            this.buttonBatchExplanation.Click += new System.EventHandler(this.buttonBatchExplanation_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "images.";
            // 
            // numericUpDownImageBatch
            // 
            this.numericUpDownImageBatch.Location = new System.Drawing.Point(107, 73);
            this.numericUpDownImageBatch.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownImageBatch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownImageBatch.Name = "numericUpDownImageBatch";
            this.numericUpDownImageBatch.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownImageBatch.TabIndex = 7;
            this.numericUpDownImageBatch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Write in batch every";
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Location = new System.Drawing.Point(201, 45);
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(85, 20);
            this.textBoxPrefix.TabIndex = 5;
            this.textBoxPrefix.TextChanged += new System.EventHandler(this.textBoxPrefix_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "File prefix:";
            // 
            // buttonOpenOutput
            // 
            this.buttonOpenOutput.Location = new System.Drawing.Point(41, 44);
            this.buttonOpenOutput.Name = "buttonOpenOutput";
            this.buttonOpenOutput.Size = new System.Drawing.Size(100, 23);
            this.buttonOpenOutput.TabIndex = 3;
            this.buttonOpenOutput.Text = "&Open destination";
            this.buttonOpenOutput.UseVisualStyleBackColor = true;
            this.buttonOpenOutput.Click += new System.EventHandler(this.buttonOpenOutput_Click);
            // 
            // labelOutputFolder
            // 
            this.labelOutputFolder.AutoSize = true;
            this.labelOutputFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOutputFolder.Location = new System.Drawing.Point(6, 29);
            this.labelOutputFolder.Name = "labelOutputFolder";
            this.labelOutputFolder.Size = new System.Drawing.Size(29, 12);
            this.labelOutputFolder.TabIndex = 1;
            this.labelOutputFolder.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Output folder:";
            // 
            // buttonBrowseOutput
            // 
            this.buttonBrowseOutput.Image = ((System.Drawing.Image)(resources.GetObject("buttonBrowseOutput.Image")));
            this.buttonBrowseOutput.Location = new System.Drawing.Point(6, 44);
            this.buttonBrowseOutput.Name = "buttonBrowseOutput";
            this.buttonBrowseOutput.Size = new System.Drawing.Size(29, 23);
            this.buttonBrowseOutput.TabIndex = 2;
            this.buttonBrowseOutput.UseVisualStyleBackColor = true;
            this.buttonBrowseOutput.Click += new System.EventHandler(this.buttonBrowseOutput_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.trackBarJPGQuality);
            this.groupBox3.Controls.Add(this.radioButtonJPG);
            this.groupBox3.Controls.Add(this.radioButtonPNG);
            this.groupBox3.Controls.Add(this.radioButtonSmart);
            this.groupBox3.Location = new System.Drawing.Point(7, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 98);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compression";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quality:";
            // 
            // trackBarJPGQuality
            // 
            this.trackBarJPGQuality.AutoSize = false;
            this.trackBarJPGQuality.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trackBarJPGQuality.Enabled = false;
            this.trackBarJPGQuality.Location = new System.Drawing.Point(135, 69);
            this.trackBarJPGQuality.Maximum = 100;
            this.trackBarJPGQuality.Name = "trackBarJPGQuality";
            this.trackBarJPGQuality.Size = new System.Drawing.Size(157, 22);
            this.trackBarJPGQuality.TabIndex = 4;
            this.trackBarJPGQuality.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // radioButtonJPG
            // 
            this.radioButtonJPG.AutoSize = true;
            this.radioButtonJPG.Location = new System.Drawing.Point(13, 70);
            this.radioButtonJPG.Name = "radioButtonJPG";
            this.radioButtonJPG.Size = new System.Drawing.Size(81, 17);
            this.radioButtonJPG.TabIndex = 2;
            this.radioButtonJPG.Text = "Always JPG";
            this.radioButtonJPG.UseVisualStyleBackColor = true;
            this.radioButtonJPG.CheckedChanged += new System.EventHandler(this.radioButtonAlwaysPNG_CheckedChanged);
            // 
            // radioButtonPNG
            // 
            this.radioButtonPNG.AutoSize = true;
            this.radioButtonPNG.Checked = true;
            this.radioButtonPNG.Location = new System.Drawing.Point(13, 19);
            this.radioButtonPNG.Name = "radioButtonPNG";
            this.radioButtonPNG.Size = new System.Drawing.Size(129, 17);
            this.radioButtonPNG.TabIndex = 0;
            this.radioButtonPNG.TabStop = true;
            this.radioButtonPNG.Text = "Always PNG (lossless)";
            this.radioButtonPNG.UseVisualStyleBackColor = true;
            this.radioButtonPNG.CheckedChanged += new System.EventHandler(this.radioButtonAlwaysPNG_CheckedChanged);
            // 
            // radioButtonSmart
            // 
            this.radioButtonSmart.AutoSize = true;
            this.radioButtonSmart.Location = new System.Drawing.Point(13, 44);
            this.radioButtonSmart.Name = "radioButtonSmart";
            this.radioButtonSmart.Size = new System.Drawing.Size(240, 17);
            this.radioButtonSmart.TabIndex = 1;
            this.radioButtonSmart.Text = "Variable format (use best JPG if PNG is larger)";
            this.radioButtonSmart.UseVisualStyleBackColor = true;
            this.radioButtonSmart.CheckedChanged += new System.EventHandler(this.radioButtonAlwaysPNG_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxFPS);
            this.groupBox1.Controls.Add(this.buttonEstimate);
            this.groupBox1.Controls.Add(this.comboBoxHours);
            this.groupBox1.Controls.Add(this.labelAt);
            this.groupBox1.Location = new System.Drawing.Point(9, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculations";
            // 
            // comboBoxFPS
            // 
            this.comboBoxFPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFPS.FormattingEnabled = true;
            this.comboBoxFPS.Items.AddRange(new object[] {
            "60",
            "30",
            "24",
            "15"});
            this.comboBoxFPS.Location = new System.Drawing.Point(22, 17);
            this.comboBoxFPS.Name = "comboBoxFPS";
            this.comboBoxFPS.Size = new System.Drawing.Size(39, 21);
            this.comboBoxFPS.TabIndex = 1;
            this.comboBoxFPS.SelectedIndexChanged += new System.EventHandler(this.numericUpDownInterval_ValueChanged);
            // 
            // buttonEstimate
            // 
            this.buttonEstimate.Location = new System.Drawing.Point(6, 41);
            this.buttonEstimate.Name = "buttonEstimate";
            this.buttonEstimate.Size = new System.Drawing.Size(291, 23);
            this.buttonEstimate.TabIndex = 0;
            this.buttonEstimate.Text = "Calculate time lapse size &estimation";
            this.buttonEstimate.UseVisualStyleBackColor = true;
            this.buttonEstimate.Click += new System.EventHandler(this.buttonEstimate_Click);
            // 
            // comboBoxHours
            // 
            this.comboBoxHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHours.FormattingEnabled = true;
            this.comboBoxHours.Items.AddRange(new object[] {
            "48",
            "40",
            "32",
            "24",
            "16",
            "8"});
            this.comboBoxHours.Location = new System.Drawing.Point(95, 17);
            this.comboBoxHours.Name = "comboBoxHours";
            this.comboBoxHours.Size = new System.Drawing.Size(39, 21);
            this.comboBoxHours.TabIndex = 2;
            this.comboBoxHours.SelectedIndexChanged += new System.EventHandler(this.numericUpDownInterval_ValueChanged);
            // 
            // labelAt
            // 
            this.labelAt.AutoSize = true;
            this.labelAt.Location = new System.Drawing.Point(6, 20);
            this.labelAt.Name = "labelAt";
            this.labelAt.Size = new System.Drawing.Size(256, 13);
            this.labelAt.TabIndex = 0;
            this.labelAt.Text = "At                FPS,                hours of work adds up to ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "seconds";
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Location = new System.Drawing.Point(149, 10);
            this.numericUpDownInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownInterval.TabIndex = 1;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownInterval.ValueChanged += new System.EventHandler(this.numericUpDownInterval_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capture a screenshot every";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.resetSettingsToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(354, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // resetSettingsToolStripMenuItem1
            // 
            this.resetSettingsToolStripMenuItem1.Name = "resetSettingsToolStripMenuItem1";
            this.resetSettingsToolStripMenuItem1.Size = new System.Drawing.Size(91, 20);
            this.resetSettingsToolStripMenuItem1.Text = "Reset settings";
            this.resetSettingsToolStripMenuItem1.Click += new System.EventHandler(this.resetSettingsToolStripMenuItem1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxStampLogo);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.checkBoxAutomated);
            this.groupBox4.Controls.Add(this.buttonFullyAutomatedTip);
            this.groupBox4.Controls.Add(this.checkBoxStartup);
            this.groupBox4.Controls.Add(this.buttonTestScreenshot);
            this.groupBox4.Location = new System.Drawing.Point(12, 421);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 94);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // checkBoxStampLogo
            // 
            this.checkBoxStampLogo.AutoSize = true;
            this.checkBoxStampLogo.Location = new System.Drawing.Point(107, 19);
            this.checkBoxStampLogo.Name = "checkBoxStampLogo";
            this.checkBoxStampLogo.Size = new System.Drawing.Size(79, 17);
            this.checkBoxStampLogo.TabIndex = 1;
            this.checkBoxStampLogo.Text = "Stamp logo";
            this.checkBoxStampLogo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBoxAutomated
            // 
            this.checkBoxAutomated.AutoSize = true;
            this.checkBoxAutomated.Location = new System.Drawing.Point(6, 42);
            this.checkBoxAutomated.Name = "checkBoxAutomated";
            this.checkBoxAutomated.Size = new System.Drawing.Size(139, 17);
            this.checkBoxAutomated.TabIndex = 2;
            this.checkBoxAutomated.Text = "Fully automated capture";
            this.checkBoxAutomated.UseVisualStyleBackColor = true;
            this.checkBoxAutomated.CheckedChanged += new System.EventHandler(this.checkBoxAutomated_CheckedChanged);
            // 
            // buttonFullyAutomatedTip
            // 
            this.buttonFullyAutomatedTip.Location = new System.Drawing.Point(151, 38);
            this.buttonFullyAutomatedTip.Name = "buttonFullyAutomatedTip";
            this.buttonFullyAutomatedTip.Size = new System.Drawing.Size(27, 23);
            this.buttonFullyAutomatedTip.TabIndex = 3;
            this.buttonFullyAutomatedTip.Text = "???";
            this.buttonFullyAutomatedTip.UseVisualStyleBackColor = true;
            this.buttonFullyAutomatedTip.Click += new System.EventHandler(this.buttonFullyAutomatedTip_Click);
            // 
            // checkBoxStartup
            // 
            this.checkBoxStartup.AutoSize = true;
            this.checkBoxStartup.Location = new System.Drawing.Point(6, 19);
            this.checkBoxStartup.Name = "checkBoxStartup";
            this.checkBoxStartup.Size = new System.Drawing.Size(98, 17);
            this.checkBoxStartup.TabIndex = 0;
            this.checkBoxStartup.Text = "Start on startup";
            this.checkBoxStartup.UseVisualStyleBackColor = true;
            this.checkBoxStartup.CheckedChanged += new System.EventHandler(this.checkBoxStartup_CheckedChanged);
            // 
            // buttonTestScreenshot
            // 
            this.buttonTestScreenshot.Location = new System.Drawing.Point(6, 65);
            this.buttonTestScreenshot.Name = "buttonTestScreenshot";
            this.buttonTestScreenshot.Size = new System.Drawing.Size(172, 21);
            this.buttonTestScreenshot.TabIndex = 4;
            this.buttonTestScreenshot.Text = "Test &screenshot";
            this.buttonTestScreenshot.UseVisualStyleBackColor = true;
            this.buttonTestScreenshot.Click += new System.EventHandler(this.buttonTestScreenshot_Click);
            // 
            // buttonStartCapture
            // 
            this.buttonStartCapture.Location = new System.Drawing.Point(12, 518);
            this.buttonStartCapture.Name = "buttonStartCapture";
            this.buttonStartCapture.Size = new System.Drawing.Size(167, 23);
            this.buttonStartCapture.TabIndex = 3;
            this.buttonStartCapture.Text = "Start &capture";
            this.buttonStartCapture.UseVisualStyleBackColor = true;
            this.buttonStartCapture.Click += new System.EventHandler(this.buttonStartCapture_Click);
            // 
            // buttonForceCapture
            // 
            this.buttonForceCapture.Location = new System.Drawing.Point(185, 518);
            this.buttonForceCapture.Name = "buttonForceCapture";
            this.buttonForceCapture.Size = new System.Drawing.Size(157, 23);
            this.buttonForceCapture.TabIndex = 4;
            this.buttonForceCapture.Text = "&Force capture";
            this.buttonForceCapture.UseVisualStyleBackColor = true;
            this.buttonForceCapture.Click += new System.EventHandler(this.buttonForceCapture_Click);
            // 
            // pictureBoxProgress
            // 
            this.pictureBoxProgress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxProgress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProgress.Location = new System.Drawing.Point(12, 547);
            this.pictureBoxProgress.Name = "pictureBoxProgress";
            this.pictureBoxProgress.Size = new System.Drawing.Size(330, 20);
            this.pictureBoxProgress.TabIndex = 6;
            this.pictureBoxProgress.TabStop = false;
            this.pictureBoxProgress.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxProgress_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 575);
            this.Controls.Add(this.pictureBoxProgress);
            this.Controls.Add(this.buttonForceCapture);
            this.Controls.Add(this.buttonStartCapture);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "caption";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImageBatch)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarJPGQuality)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelAt;
        private System.Windows.Forms.ComboBox comboBoxFPS;
        private System.Windows.Forms.ComboBox comboBoxHours;
        private System.Windows.Forms.Button buttonEstimate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonJPG;
        private System.Windows.Forms.RadioButton radioButtonPNG;
        private System.Windows.Forms.RadioButton radioButtonSmart;
        private System.Windows.Forms.TrackBar trackBarJPGQuality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxStartup;
        private System.Windows.Forms.Button buttonTestScreenshot;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelOutputFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBrowseOutput;
        private System.Windows.Forms.Button buttonOpenOutput;
        private System.Windows.Forms.Button buttonFullyAutomatedTip;
        private System.Windows.Forms.Button buttonStartCapture;
        private System.Windows.Forms.CheckBox checkBoxAutomated;
        private System.Windows.Forms.Button buttonForceCapture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxStampLogo;
        private System.Windows.Forms.TextBox textBoxPrefix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem resetSettingsToolStripMenuItem1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxProgress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownImageBatch;
        private System.Windows.Forms.Button buttonBatchExplanation;
    }
}

