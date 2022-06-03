using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorCorrectionProgram
{
    public partial class ColorCorr : Form
    {
        // bitmap of the processed image
        byte[] RGBArray;

        // array of arguments passed to libraries
        object[] arrayOfArguments;

        // image width
        int imageWidth;

        // image height
        int imageHeight;

        // stopwatch for measuring function execution time
        readonly Stopwatch timer = new();

        // delegate where the selected library will be stored
        Delegate selectedDll;

        /// <summary>
        ///  Library written in assembler, correcting colors
        /// </summary>
        /// <param name="RGBvalues">The beginning of the image's bit table</param>
        /// <param name="begin">Beginning of the section to be processed</param>
        /// <param name="finish">End of the section to be processed</param>
        /// <param name="redNew">Red color value taken from the slider</param>
        /// <param name="blueNew">Blue color value taken from the slider</param>
        /// <param name="greenNew">Green color value taken from the slider</param>
        [DllImport(@"..\..\..\..\..\x64\Release\AsmDll.dll")]
        private static extern void AsmColorCorr(byte[] RGBvalues, int begin, int finish, byte redNew, byte greenNew, byte blueNew);

        /// <summary>
        /// Application GUI builder
        /// </summary>
        public ColorCorr()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The function clears the image from the PictureBox
        /// </summary>
        /// <param name="picture">PictureBox to be cleared</param>
        private void ClearImage(PictureBox picture)
        {
            if (picture.Image != null)
            {
                picture.Image.Dispose();
                picture.Image = null;
            }
        }

        /// <summary>
        /// The function converts a ComboBox value to an integer
        /// </summary>
        /// <param name="combobox">ComboBox whose value is to be converted</param>
        /// <returns>Integer in a ComboBox</returns>
        private int ConvertComboboxItemSelected(ComboBox combobox)
        {
            if (combobox.SelectedItem != null)
            {
                // parsed integer retrieved from combobox
                int value = Int32.Parse(combobox.SelectedItem.ToString());
                return value;
            }
            else
                return 0;
        }

        /// <summary>
        /// The function sets the number of threads on the appropriate label
        /// </summary>
        /// <param name="labelThreadsUsedValue">The label on which the value is to be set</param>
        /// <param name="numberOfThreds">Number of threads to be set</param>
        private void SetNumberOfThreads(Label labelThreadsUsedValue, int numberOfThreds)
        {
            labelThreadsUsedValue.Text = numberOfThreds.ToString();
        }

        /// <summary>
        /// The function converts the file to a bitmap
        /// </summary>
        /// <param name="filename">The name of the file to be converted</param>
        /// <returns>Bitmap from the converted file</returns>
        private Bitmap ConvertToBitmap(string filename)
        {
            // bitmap object from which the loaded image will be saved
            Bitmap bitmap;
            using (Stream bmpStream = File.Open(filename, FileMode.Open))
            {
                bmpStream.Position = 0;

                // Image object to convert the file to a bitmap
                Image image = Image.FromStream(bmpStream);

                bitmap = new Bitmap(image);
            }
            return bitmap;
        }

        /// <summary>
        /// The function sets the initial values in the window, i.e. the number 
        /// of logical and the selected library
        /// </summary>
        /// <param name="sender">Object of the action to be sent after the window is loaded</param>
        /// <param name="e">Object that communicates information about a window</param>
        private void WindowLoad(object sender, EventArgs e)
        {
            ActiveThreadsComboBox.SelectedItem = Environment.ProcessorCount.ToString();
            CsharpRadioButton.Checked = true;
        }

        /// <summary>
        /// The function that opens the window for loading an image into the program
        /// </summary>
        /// <param name="sender">Object of the action to be sent after pressing the button</param>
        /// <param name="e">Object that communicates information about the pressed button</param>
        private void UploadImageButton(object sender, EventArgs e)
        {

            openFileDialog.Filter = "Bitmap images (*.bmp) | *.bmp;";
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // FileStream object to open a file from the stream
                    using (FileStream file = new(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        // Image object to retrieve data from the file
                        using Image image = Image.FromStream(stream: file, useEmbeddedColorManagement: false, validateImageData: false);
                        imageWidth = (int)image.PhysicalDimension.Width;
                        imageHeight = (int)image.PhysicalDimension.Height;
                        labelImageSizeValue.Text = imageWidth + " x " + imageHeight;
                    }
                    uploadImageTextBox.Text = openFileDialog.FileName;
                    InsertImage.SizeMode = PictureBoxSizeMode.Zoom;
                    InsertImage.Image = ConvertToBitmap(openFileDialog.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error while loading the image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Function that opens a window to save the converted image
        /// </summary>
        /// <param name="sender">Object of the action to be sent after pressing the button</param>
        /// <param name="e">Object that communicates information about the pressed button</param>
        private void SaveImageButton(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.FileName = "converted.bmp";
                saveFileDialog.Filter = "Bitmap image (*.bmp) | *.bmp;";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ConvertedImage.Image.Save(saveFileDialog.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't save the image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// A function that returns the time in ms from a stopwatch
        /// </summary>
        /// <returns>Stopwatch time as string</returns>
        public string GetTime()
        {
            // save clock ticks to a variable
            double ticks = timer.ElapsedTicks;
            // calculate milliseconds by dividing the ticks value by the frequency of the stopwatch and multiplying by 1000
            double milliseconds = (ticks / Stopwatch.Frequency) * 1000;
            timer.Reset();
            return milliseconds.ToString("0.000");
        }

        /// <summary>
        /// The function sets the time from the stopwatch on the appropriate label
        /// </summary>
        /// <param name="labelTimeValue">Label on which the time is to be set</param>
        public void SetTimeLabel(Label labelTimeValue)
        {
            // get elapsed time as string
            string time = GetTime();
            labelTimeValue.Text = time + "ms";
        }

        /// <summary>
        /// The function responsible for starting the conversion of an image that has been previously loaded
        /// </summary>
        /// <param name="sender">Object of the action to be sent after pressing the button</param>
        /// <param name="e">Object that communicates information about the pressed button</param>
        private async void ConvertImageButton(object sender, EventArgs e)
        {
            ConvertButton.Enabled = false;
            ConvertButton.Click -= ConvertImageButton;

            // initialize the variables that will receive the values from the sliders
            byte redValue = 0, blueValue = 0, greenValue = 0;

            // Bitmap object that will hold the bitmap of the image
            Bitmap bitmapImage;

            try
            {
                bitmapImage = new Bitmap(InsertImage.Image);
                redValue = (byte)trackBarRed.Value;
                greenValue = (byte)trackBarGreen.Value;
                blueValue = (byte)trackBarBlue.Value;

                // variable that stores information about whether the conversion was successful or not
                bool isConverted = ConvertBitmap(bitmapImage, redValue, greenValue, blueValue);

                if (isConverted)
                {
                    ConvertedImage.SizeMode = PictureBoxSizeMode.Zoom;
                    ClearImage(ConvertedImage);
                    ConvertedImage.Image = bitmapImage;
                    buttonSaveImage.Enabled = true;
                }
            }
            catch (Exception)
            {
                buttonSaveImage.Enabled = false;
                ClearImage(ConvertedImage);
                MessageBox.Show("Please select correct image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                await Task.Delay(500);
                ConvertButton.Enabled = true;
                ConvertButton.Click += ConvertImageButton;
            }
        }

        /// <summary>
        /// Function that copies the bitmap of the loaded image splits it into parts,
        /// creates appropriate tasks, starts the work of threads that convert the image, measures time
        /// of their execution and sets the appropriate label values after converting the image
        /// </summary>
        /// <param name="bitmapImage">Bitmap of the loaded image</param>
        /// <param name="redValue">Red color value taken from the slider</param>
        /// <param name="greenValue">Green color value taken from the slider</param>
        /// <param name="blueValue">Blue color value taken from the slider</param>
        /// <returns>True if the conversion is successful, false if not</returns>
        private bool ConvertBitmap(Bitmap bitmapImage, byte redValue, byte greenValue, byte blueValue)
        {
            // Rectangle object initialized with the width and height of the image
            Rectangle rectangle = new(0, 0, bitmapImage.Width, bitmapImage.Height);
            // keep the data on the used ARGB convention
            BitmapData data = bitmapImage.LockBits(rectangle, ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);
            // image depth
            int depth = Bitmap.GetPixelFormatSize(data.PixelFormat) / 8;

            RGBArray = new byte[data.Width * data.Height * depth];

            try
            {
                Marshal.Copy(data.Scan0, RGBArray, 0, RGBArray.Length);

                PrepareTasks(redValue, greenValue, blueValue);

                // currently set number of threads
                int threads = ConvertComboboxItemSelected(ActiveThreadsComboBox);

                ThreadPool.SetMinThreads(1, 1);
                ThreadPool.SetMaxThreads(64, 64);

                // variable storing information whether it was possible to set the minimum number of threads
                bool isMinSet = ThreadPool.SetMinThreads(threads, threads);
                // variable storing information whether it was possible to set the maximum number of threads
                bool isMaxSet = ThreadPool.SetMaxThreads(threads, threads);

                if (selectedDll == null || !isMaxSet || !isMinSet)
                    return false;

                CreateThreads();

                SetTimeLabel(labelTimeValue);
                SetNumberOfThreads(labelThreadsUsedValue, ConvertComboboxItemSelected(ActiveThreadsComboBox));

                if (CsharpRadioButton.Checked)
                    labelDllUsedValue.Text = "C#";
                else
                    labelDllUsedValue.Text = "Asm";

                Marshal.Copy(RGBArray, 0, data.Scan0, RGBArray.Length);

                this.Invalidate();
                bitmapImage.UnlockBits(data);

            }
            catch (Exception)
            {
                bitmapImage.UnlockBits(data);
                MessageBox.Show("There was an error during image conversion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            RGBArray = null;
            arrayOfArguments = null;
            return true;
        }

        /// <summary>
        /// The function prepares tasks for individual threads
        /// </summary>
        /// <param name="redValue">Red color value taken from the slider</param>
        /// <param name="greenValue">Green color value taken from the slider</param>
        /// <param name="blueValue">Blue color value taken from the slider</param>
        public void PrepareTasks(byte redValue, byte greenValue, byte blueValue)
        {

            if (RGBArray == null)
                return;

            arrayOfArguments = new object[imageHeight];
            // each section should be one image line long
            int interval = (RGBArray.GetLength(0) / imageHeight);

            if (CsharpRadioButton.Checked)
                selectedDll = (Action<object>)InvokeCsharpFunction;
            else
                selectedDll = (Action<object>)InvokeAssemblerFunction;

            for (int i = 0; i < imageHeight; ++i)
            {
                // calculate the beginning of the bitmap section for individual tasks
                int start = i * interval;
                // calculate the end of the bitmap section for individual tasks
                int stop = (i + 1) * interval;

                if (stop >= RGBArray.GetLength(0))
                    stop = RGBArray.GetLength(0);

                // write arguments to an array of objects
                arrayOfArguments[i] = new object[6] { start, stop, RGBArray, redValue, greenValue, blueValue };
            }
        }

        /// <summary>
        /// The function creates and adds threads to the ThreadPool, then waits for all of them
        /// to execute, and also measures the execution time of the threads
        /// </summary>
        private void CreateThreads()
        {
            // recording how many tasks should be performed
            int toProcess = arrayOfArguments.Length;
            // object of the ManualResetEvent type used to check whether all tasks have been completed
            using ManualResetEvent resetEvent = new(false);
            timer.Start();
            for (int i = 0; i < arrayOfArguments.Length; i++)
            {
                ThreadPool.QueueUserWorkItem(
                   new WaitCallback(x =>
                   {
                       selectedDll.DynamicInvoke(x);
                       if (Interlocked.Decrement(ref toProcess) == 0)
                           resetEvent.Set();
                   }), arrayOfArguments[i]);
            }
            resetEvent.WaitOne();
            timer.Stop();
        }

        /// <summary>
        /// The function reads the arguments from the object, and then passes them to the 
        /// appropriate assembly language function in the appropriate library
        /// </summary>
        /// <param name="argum">Object with arguments</param>
        private void InvokeAssemblerFunction(object argum)
        {
            Array args = new object[6];
            args = (Array)argum;
            int begin = (int)args.GetValue(0);
            int finish = (int)args.GetValue(1);
            byte[] RGBarray = (byte[])args.GetValue(2);
            byte redNew = (byte)args.GetValue(3);
            byte greenNew = (byte)args.GetValue(4);
            byte blueNew = (byte)args.GetValue(5);
            AsmColorCorr(RGBarray, begin, finish, redNew, greenNew, blueNew);
        }

        /// <summary>
        /// The function reads the arguments from the object, and then passes them to the 
        /// appropriate C# function in the appropriate library
        /// </summary>
        /// <param name="argum">Object with arguments</param>
        private void InvokeCsharpFunction(object argum)
        {
            Array args = new object[6];
            args = (Array)argum;
            int begin = (int)args.GetValue(0);
            int finish = (int)args.GetValue(1);
            byte[] RGBarray = (byte[])args.GetValue(2);
            byte redNew = (byte)args.GetValue(3);
            byte greenNew = (byte)args.GetValue(4);
            byte blueNew = (byte)args.GetValue(5);
            CsDll.CorrectColor.CsColorCorr(RGBarray, begin, finish, redNew, greenNew, blueNew);
        }

        /// <summary>
        /// The function updates the labels under the sliders for the appropriate colors
        /// </summary>
        /// <param name="sender">Object of sent action after moving the slider</param>
        /// <param name="e">Object that communicates information about the shifted slider</param>
        private void ColorComponentValueChangedEventHandler(object sender, EventArgs e)
        {
            labelRedValue.Text = trackBarRed.Value.ToString();
            labelGreenValue.Text = trackBarGreen.Value.ToString();
            labelBlueValue.Text = trackBarBlue.Value.ToString();
        }
    }

}
