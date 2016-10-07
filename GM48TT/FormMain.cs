using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Diagnostics;

//GM48TT 1.0.1
//by @blokatt
//blokatt.net

namespace GM48TT
{
    public partial class MainForm : Form
    {
        bool capturing = false;
        const int FILE_FORMAT_PNG = 0;
        const int FILE_FORMAT_SMART = 1;
        const int FILE_FORMAT_JPG = 2;
        int ImageFileFormat = FILE_FORMAT_PNG;
        String OutputFolder = Path.GetDirectoryName(Application.ExecutablePath).ToString();
        NotifyIcon trayIcon = new NotifyIcon();
        ContextMenu trayMenu = new ContextMenu();
        Timer captureTimer = new Timer();
        Timer processTimer = new Timer();
        float timeElapsed = 0;
        float timeInterval = 0;
        int fileCount;
        String prefix = "";

        //constructor
        public MainForm()
        {
            InitializeComponent();

            ToolTip warning = new ToolTip();
            warning.ShowAlways = true;
            warning.SetToolTip(textBoxPrefix, "WARNING: Changing prefixes mid-time-lapse might mess up file ordering!");

            ToolTip forceCap = new ToolTip();
            forceCap.ShowAlways = true;
            forceCap.SetToolTip(buttonForceCapture, "(capture one frame)");

            ToolTip logoTip = new ToolTip();
            logoTip.ShowAlways = true;
            logoTip.SetToolTip(checkBoxStampLogo, "Put gm(48) logo on every image.");

            captureTimer.Enabled = false;
            captureTimer.Tick += captureTimer_Tick;

            processTimer.Enabled = false;
            processTimer.Tick += processTimer_Tick;

            trayMenu.MenuItems.Add("Exit");
            trayMenu.MenuItems[0].Click += closeApp;
            trayIcon.ContextMenu = trayMenu;

            SetupValues();
        }

        //GM:S detection
        void processTimer_Tick(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            bool got = false;
            foreach (Process process in processes){
                if (process.ToString().ToLower().Contains("5pice") || process.ToString().ToLower().Contains("gamemaker") || process.ToString().ToLower().Contains("game maker")) //hey, it works
                {
                    got = true;
                    break;
                }
            }

            if (got)
            {
                if (!capturing)
                {
                    if (!this.Visible)
                    {
                        trayIcon.ShowBalloonTip(2000, "Capturing started!", "GM:S has been detected.", ToolTipIcon.Info);
                    }
                    startCapturing();
                }
            }
            else
            {
                if (capturing)
                {
                    if (!this.Visible)
                    {
                        trayIcon.ShowBalloonTip(2000, "Capturing stopped!", "GM:S is no longer running.", ToolTipIcon.Warning);
                    }
                    stopCapturing();
                }

            }
        }

        //self-explanatory
        private void takeScreenshot()
        {
         
            fileCount = Directory.GetFiles(OutputFolder, "*.png", SearchOption.TopDirectoryOnly).Length;
            fileCount += Directory.GetFiles(OutputFolder, "*.jpg", SearchOption.TopDirectoryOnly).Length;
            Bitmap img = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            string path = OutputFolder + @"\" + prefix + "_(" + fileCount.ToString() + ")";

            //image buffer
            using (Graphics buffer = Graphics.FromImage(img))
            {
                //take a screenshot from the primary monitor 
                buffer.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, img.Size, CopyPixelOperation.SourceCopy);

                //why
                if (checkBoxStampLogo.Checked)
                {
                    ColorMatrix cm = new ColorMatrix();
                    cm.Matrix33 = 0.85f;
                    ImageAttributes ia = new ImageAttributes();
                    ia.SetColorMatrix(cm);
                    buffer.DrawImage(Properties.Resources.gm48Logo, new Rectangle(0, 0, 200, 200), 0, 0, 200, 200, GraphicsUnit.Pixel, ia); //this took a while to figure out
                }
                
                MemoryStream ms = new MemoryStream();
                System.Drawing.Imaging.Encoder newEncoder = System.Drawing.Imaging.Encoder.Quality;
                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
                EncoderParameters encParams = new EncoderParameters();
                EncoderParameter Quality;
                
                switch (ImageFileFormat) {
                    case FILE_FORMAT_PNG:
                        path += ".png";  
                        img.Save(path, ImageFormat.Png);
                    break;

                    case FILE_FORMAT_SMART:
                        MemoryStream pngStream = new MemoryStream();
                    
                        Quality = new EncoderParameter(newEncoder, 100);
                        encParams.Param[0] = Quality;
                        img.Save(Application.LocalUserAppDataPath + @"\tempCapture.jpg", jpgEncoder, encParams);
                        FileStream jpgStream = File.Open(Application.LocalUserAppDataPath + @"\tempCapture.jpg", FileMode.Open);

            
                        img.Save(pngStream, ImageFormat.Png);

                        if (pngStream.Length <= jpgStream.Length)
                        {
                            path += ".png";
                            img.Save(path, ImageFormat.Png);
                        }
                        else
                        {
                            path += ".jpg";
                            img.Save(path, jpgEncoder, encParams);
                        }

                        jpgStream.Dispose();
                        pngStream.Dispose();

                        try{
                            File.Delete(Application.LocalUserAppDataPath + @"\tempCapture.jpg");
                        }
                        catch {
                            //don't tell mum
                        }
                    break;

                    case FILE_FORMAT_JPG:
                        Quality = new EncoderParameter(newEncoder, (int)trackBarJPGQuality.Value);
                        encParams.Param[0] = Quality;
                        path += ".jpg";   
                        img.Save(path, jpgEncoder, encParams);
                        
                    break;
                    default: break;
                }

                img.Dispose();
                encParams.Dispose();
                Quality = null;
                jpgEncoder = null;
                newEncoder = null;
            }
            
        }
        

        //capture timer
        void captureTimer_Tick(object sender, EventArgs e)
        {
            timeElapsed += captureTimer.Interval;
            progressBarCapture.Value = Math.Min(100, (int)(((timeElapsed / (timeInterval * 1000)) * 100)));
            if (timeElapsed >= timeInterval * 1000)
            {
                timeElapsed = 0;
                takeScreenshot();
            }
        }

        #region ui_stuff

        //reset ui elements
        private void SetupValues()
        {
            textBoxPrefix.Text = Properties.Settings.Default.prefix;

            checkBoxStartup.Checked = Properties.Settings.Default.startOnStartup;
            checkBoxAutomated.Checked = Properties.Settings.Default.autoCapture;
            if (Properties.Settings.Default.outputFolder != "none")
            {
                OutputFolder = Properties.Settings.Default.outputFolder;
            }
            OutputFolder = OutputFolder.Replace("\"", "");
            OutputFolder = OutputFolder.Replace(@"\\", @"\");

            trackBarJPGQuality.Value = Properties.Settings.Default.JPGQuality;
            numericUpDownInterval.Value = Properties.Settings.Default.captureInterval;

            ImageFileFormat = Properties.Settings.Default.imageFormat;

            switch (ImageFileFormat)
            {
                case FILE_FORMAT_PNG: radioButtonPNG.Checked = true; break;
                case FILE_FORMAT_JPG: radioButtonJPG.Checked = true; trackBarJPGQuality.Enabled = true; break;
                case FILE_FORMAT_SMART: radioButtonSmart.Checked = true; break;
            }
            UpdateOutputPathLabel();

            numericUpDownInterval_ValueChanged(this, null);
            comboBoxFPS.SelectedIndex = 0;
            comboBoxHours.SelectedIndex = 0;

            checkBoxStampLogo.Checked = Properties.Settings.Default.logoStamp;

            if (Program.tiny)
            {
                this.WindowState = FormWindowState.Minimized;
                HideToTray();
            }

            if (checkBoxAutomated.Checked)
            {
                buttonStartCapture.Enabled = false;
                processTimer.Interval = 1000;
                processTimer.Enabled = true;
            }
        }

        //output path label updating
        private void UpdateOutputPathLabel()
        {
            labelOutputFolder.Text = OutputFolder;
            bool snip = false;
            while (labelOutputFolder.Size.Width > 270)
            {
                labelOutputFolder.Text = labelOutputFolder.Text.Substring(1, labelOutputFolder.Text.Length - 1);
                snip = true;
            }
            if (snip)
            {
                ToolTip fullPath = new ToolTip();
                fullPath.SetToolTip(labelOutputFolder, OutputFolder);
                labelOutputFolder.Text = "..." + labelOutputFolder.Text;
            }
        }

        private void numericUpDownInterval_ValueChanged(object sender, EventArgs e)
        {
            float interval = (float)numericUpDownInterval.Value;
            float framerate = (float)Convert.ToDouble(comboBoxFPS.SelectedItem);
            float hours = (float)Convert.ToDouble(comboBoxHours.SelectedItem);
            float frames = (60 / interval) * 60 * hours;
            String secs = Math.Round((frames / framerate) % 60, 0).ToString();
            if (secs.Length < 2)
            {
                secs = secs.Insert(0, "0");
            }
            //look away now
            labelAt.Text = "At                FPS,                hours of work adds up to " + (int)Math.Floor(frames / framerate / 60) + ":" + secs + ".";
        }

        private String getSize(float byteSize){
            int place = 0;
            if (byteSize > 0){
                String[] places = {"B","KB","MB","GB","TB","PB","EB"};
            
                while (byteSize >= 1024 && place + 1 < places.Length){
                    place++;
                    byteSize /= 1024;
                }
                return Math.Round(byteSize, 2) + places[place];
            }else{
                return "0";
            }
        }

        private void closeApp(object sender, EventArgs e)
        {
            this.Close(); // ¯\_(ツ)_/¯
        }

        //file size estimation 
        private void buttonEstimate_Click(object sender, EventArgs e)
        {
            float interval = (float)numericUpDownInterval.Value;
            float hours = (float)Convert.ToDouble(comboBoxHours.SelectedItem);
            float frames = (float)Math.Round((60 / interval) * 60 * hours, 0);


            Bitmap img = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (var ms = new MemoryStream())
            {
                using (Graphics buffer = Graphics.FromImage(img))
                {
                    buffer.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, img.Size, CopyPixelOperation.SourceCopy);

                    switch (ImageFileFormat)
                    {
                        case FILE_FORMAT_PNG:
                            img.Save(ms, ImageFormat.Png);
                            break;

                        case FILE_FORMAT_JPG:
                            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
                            System.Drawing.Imaging.Encoder newEncoder = System.Drawing.Imaging.Encoder.Quality;
                            EncoderParameters encParams = new EncoderParameters();
                            EncoderParameter Quality = new EncoderParameter(newEncoder, (int)trackBarJPGQuality.Value);
                            encParams.Param[0] = Quality;
                            img.Save(ms, jpgEncoder, encParams);
                            break;

                        default: break;
                    }
                    string formatString = "";
                    string qualityString = "Lossless";
                    switch (ImageFileFormat)
                    {
                        case FILE_FORMAT_PNG: formatString = "PNG"; break;
                        case FILE_FORMAT_JPG: formatString = "JPEG"; qualityString = trackBarJPGQuality.Value.ToString() +"%"; break;
                    }

                    MessageBox.Show(this, String.Format("File format: {0}\nQuality: {1}\nNumber of frames: {2}\nSize of the current screenshot: {3}\nEstimated time-lapse size: {4}", formatString, qualityString, frames, getSize((float)(ms.Length)), getSize((float)(ms.Length * frames))), "Sick math...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    img.Dispose();
                }
            }
            
            
        }

        private void radioButtonAlwaysPNG_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPNG.Checked)
            {
                ImageFileFormat = FILE_FORMAT_PNG;
                buttonEstimate.Enabled = true;
            }
            if (radioButtonJPG.Checked)
            {
                ImageFileFormat = FILE_FORMAT_JPG;
                buttonEstimate.Enabled = true;
            }
            if (radioButtonSmart.Checked)
            {
                ImageFileFormat = FILE_FORMAT_SMART;
                buttonEstimate.Enabled = false;
            }
            if (radioButtonJPG.Checked)
            {
                trackBarJPGQuality.Enabled = true;
            }
            else
            {
                trackBarJPGQuality.Enabled = false;
            }
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        //duplicate code!
        private void buttonTestScreenshot_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            string path = "";
            using (Graphics buffer = Graphics.FromImage(img))
            {
                buffer.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, img.Size, CopyPixelOperation.SourceCopy);

                System.Drawing.Imaging.Encoder newEncoder = System.Drawing.Imaging.Encoder.Quality;
                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
                EncoderParameters encParams = new EncoderParameters();
                EncoderParameter Quality;

                if (checkBoxStampLogo.Checked)
                {
                    ColorMatrix cm = new ColorMatrix();
                    cm.Matrix33 = 0.85f;
                    ImageAttributes ia = new ImageAttributes();
                    ia.SetColorMatrix(cm);
                    buffer.DrawImage(Properties.Resources.gm48Logo, new Rectangle(0, 0, 200, 200), 0, 0, 200, 200, GraphicsUnit.Pixel, ia);
                }

                MemoryStream ms = new MemoryStream();

                try
                {
                    File.Delete(path);
                }
                catch {
                    //yeah...
                }

                switch (ImageFileFormat) {
                    case FILE_FORMAT_PNG:
                        path = Application.LocalUserAppDataPath + @"\testCapture.png";  
                        img.Save(path, ImageFormat.Png);
                    break;


                    case FILE_FORMAT_SMART:
                        MemoryStream pngStream = new MemoryStream();
                        
                        path = Application.LocalUserAppDataPath + @"\testCapture";
                        Quality = new EncoderParameter(newEncoder, (int)trackBarJPGQuality.Value);
                        encParams.Param[0] = Quality;
                        img.Save(path + ".jpg", jpgEncoder, encParams);

                        FileStream jpgStream = File.Open(path + ".jpg", FileMode.Open);
                        img.Save(pngStream, ImageFormat.Png);
                        if (pngStream.Length <= jpgStream.Length)
                        {
                            path = path + ".png";
                            img.Save(path, ImageFormat.Png);
                        }
                        else
                        {
                            path = path + ".jpg";
                        }

                        jpgStream.Dispose();
                        pngStream.Dispose();

                    break;

                    case FILE_FORMAT_JPG:
                        Quality = new EncoderParameter(newEncoder, (int)trackBarJPGQuality.Value);
                        encParams.Param[0] = Quality;
                        path = Application.LocalUserAppDataPath + @"\testCapture.jpg";  
                        img.Save(path, jpgEncoder, encParams);
                    break;

                    default: break;
                }
                Process.Start(path);   
                img.Dispose();
            }
            
        }



        private void checkBoxStartup_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (checkBoxStartup.Checked)
                {
                    key.SetValue(Process.GetCurrentProcess().ProcessName, "\"" + Application.ExecutablePath.ToString() + "\"" + " +tiny");
                }
                else
                {
                    key.DeleteValue(Process.GetCurrentProcess().ProcessName);
                }
            }
            catch
            {
            }
        }

        private void buttonBrowseOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fn = new FolderBrowserDialog();
            fn.SelectedPath = Path.GetDirectoryName(Application.ExecutablePath).ToString();
            fn.Description = "Select a folder for your time-lapse";
            fn.ShowNewFolderButton = true;
            fn.ShowDialog();
            OutputFolder = fn.SelectedPath;
            OutputFolder = OutputFolder.Replace("\"", "");
            OutputFolder = OutputFolder.Replace(@"\\", @"\");
            UpdateOutputPathLabel();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to close gm(48) Time-lapse Tool?\n\nThis will prevent it from capturing anything!", "Hold on!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No){
                e.Cancel = true;
            }

            if (!e.Cancel)
            {
                Properties.Settings.Default.outputFolder = OutputFolder;
                Properties.Settings.Default.startOnStartup = checkBoxStartup.Checked;
                Properties.Settings.Default.autoCapture = checkBoxAutomated.Checked;
                Properties.Settings.Default.JPGQuality = trackBarJPGQuality.Value;
                Properties.Settings.Default.captureInterval = numericUpDownInterval.Value;
                Properties.Settings.Default.imageFormat = ImageFileFormat;
                Properties.Settings.Default.logoStamp = checkBoxStampLogo.Checked;
                Properties.Settings.Default.prefix = textBoxPrefix.Text;
                Properties.Settings.Default.Save();
                trayIcon.Visible = false;
                trayIcon.Icon = null;
                trayIcon.Dispose();
            }
        }

        private void buttonOpenOutput_Click(object sender, EventArgs e)
        {
            Process.Start(OutputFolder);
        }

        private void buttonFullyAutomatedTip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When this mode is enabled, the application will automatically check if GameMaker: Studio is running, in which case it will start capturing.\n\nThis feature is really cool, so you should use it.", "What?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                HideToTray();
            }
            if (WindowState == FormWindowState.Normal)
            {
                trayIcon.Visible = false;
            }
        }

        void trayIcon_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            trayIcon.Visible = false;
            this.BringToFront();
        }

        private void HideToTray()
        {
            this.Hide();
            this.ShowInTaskbar = false;
            trayIcon.Icon = this.Icon;
            trayIcon.Visible = true;
            trayIcon.Click += trayIcon_Click;
            trayIcon.ShowBalloonTip(1000, "GM48TT", "I'll be down here if you need me.", ToolTipIcon.Info);
            /*
            TIME FOR A RANT!

            Okay, here's what pisses me off about Windows 10 - on 7, this looked like a cute lil' white baloon, you could put an
            icon in it, all that stuff. Whereas on 10, it's this ugly-ass rectangle that shows half the text the original one, 
            doesn't look like a speech bubble so you can't tell where's it coming from and the text formatting is all messed up!
            It basically swooshes in from the outside of the screen all like "hey guys, the only way you can tell what application
            is this coming from is by reading the heading of this notification that will disappear in one se-".
            
            I hate you, Microsoft.
            
            Sincerely,
            Jan
            */
        }

        private void startCapturing()
        {
            prefix = textBoxPrefix.Text;
            buttonTestScreenshot.Enabled = false;
            timeElapsed = 0;
            timeInterval = (float)numericUpDownInterval.Value;
            buttonStartCapture.Text = "Stop capture";
            tabControlMain.Enabled = false;
            captureTimer.Interval = (int)Math.Round((timeInterval * 100), 0);
            captureTimer.Enabled = true;
            capturing = true;
        }

        private void stopCapturing()
        {

            buttonTestScreenshot.Enabled = true;
            progressBarCapture.Value = 0;
            buttonStartCapture.Text = "Start capture";
            tabControlMain.Enabled = true;
            captureTimer.Enabled = false;
            capturing = false;
            buttonStartCapture.Enabled = true;
            processTimer.Interval = 1000;
            processTimer.Enabled = false;
        }
        private void buttonStartCapture_Click(object sender, EventArgs e)
        {
            if (!capturing)
            {
                startCapturing();
            }
            else
            {
                stopCapturing();
            }
        }

        private void checkBoxAutomated_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutomated.Checked)
            {
                buttonStartCapture.Enabled = false;
                processTimer.Interval = 1000;
                processTimer.Enabled = true;
            }
            else
            {
                if (capturing)
                {
                    stopCapturing();
                }
                processTimer.Enabled = false;
                progressBarCapture.Value = 0;
                buttonStartCapture.Enabled = true;
            }
        }

        private void buttonForceCapture_Click(object sender, EventArgs e)
        {
            char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
            prefix = textBoxPrefix.Text;
            takeScreenshot();
        }

        private void textBoxPrefix_TextChanged(object sender, EventArgs e)
        {
            char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
            string temp = new string((textBoxPrefix.Text).Where(ch => !invalidFileNameChars.Contains(ch)).ToArray());

            if (temp == "")
            {
                textBoxPrefix.Text = "capture";
            }
            else
            {
                textBoxPrefix.Text = temp;
            }
        }

        private void resetSettingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Would you like to reset all settings?", "Huh?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Properties.Settings.Default.outputFolder = "none";
                Properties.Settings.Default.startOnStartup = false;
                Properties.Settings.Default.autoCapture = false;
                Properties.Settings.Default.JPGQuality = 80;
                Properties.Settings.Default.captureInterval = 5;
                Properties.Settings.Default.imageFormat = 0;
                Properties.Settings.Default.logoStamp = true;
                Properties.Settings.Default.prefix = "capture";
                Properties.Settings.Default.Save();
                SetupValues();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.gm48.net");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FormAbout()).ShowDialog();
        }

        #endregion
    }
}
