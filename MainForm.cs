using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WaterMarker
{
    public partial class MainForm : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private string _waterMarkImage;

        private Image _waterMarkImageDisposal;

        private readonly string _outputFolderPath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WaterMarker");

        private readonly List<string> _chosenPictures = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            var buttons = this.Controls.OfType<Button>();

            foreach (var button in buttons)
            {
                button.FlatAppearance.MouseOverBackColor = button.BackColor;
                button.BackColorChanged += (s, e) =>
                {
                    button.FlatAppearance.MouseOverBackColor = button.BackColor;
                };
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void ChoosePictures_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = @"Pliki zdjęć (*.jpg, *.jpeg, *.png, *bmp) | *.jpg; *.jpeg; *.png; *bmp";

                if (openFileDialog.ShowDialog() != DialogResult.OK) return;

                foreach (var fileName in openFileDialog.FileNames)
                {
                    _chosenPictures.Add(fileName);
                }

                PictureCounter.Text = $@"Wybrano obrazków: {_chosenPictures.Count}";
                PictureCounter.Visible = true;
            }
        }

        private void Watermark_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = @"Plik PNG (*.png) | *.png";

                if (openFileDialog.ShowDialog() != DialogResult.OK) return;

                _waterMarkImage = openFileDialog.FileName;
                WaterMarkLabel.Text = $@"Wybrany znak wodny: {Path.GetFileName(openFileDialog.FileName)}";
                WaterMarkLabel.Visible = true;
            }
        }

        private void ApplyWaterMark_Click(object sender, EventArgs e)
        {
            if (_chosenPictures.Count == 0 || _waterMarkImage == null)
            {
                MessageBox.Show(@"Nie wybrano obrazków lub znaku wodnego!", @"Błąd", MessageBoxButtons.OK,
                                       MessageBoxIcon.Error);
                return;
            }

            var croppedWaterMark = CropTransparentImage(Image.FromFile(_waterMarkImage));
            if (croppedWaterMark == null)
            {
                MessageBox.Show(@"Znak wodny nie może być przezroczysty!", @"Błąd", MessageBoxButtons.OK,
                                                          MessageBoxIcon.Error);
                return;
            }

            _waterMarkImageDisposal = croppedWaterMark;
            var waterMarkedImages = ApplyWatermarkToImages(_chosenPictures);

            SaveWaterMarkedImages(waterMarkedImages);

            croppedWaterMark.Dispose();
            waterMarkedImages.ForEach(x => x.Dispose());
        }

        private static Image CropTransparentImage(Image img)
        {
            var bmp = new Bitmap(img);
            var cropArea = new Rectangle(0, 0, bmp.Width, bmp.Height);
            var croppedImage = bmp.Clone(cropArea, bmp.PixelFormat);

            var hasColours = false;
            for (var i = 0; i < croppedImage.Width; i++)
            {
                for (var j = 0; j < croppedImage.Height; j++)
                {
                    var pixel = croppedImage.GetPixel(i, j);
                    if (pixel.A == 0) continue;
                    hasColours = true;
                }
            }

            bmp.Dispose();
            if (hasColours) return croppedImage;
            croppedImage.Dispose();
            return null;
        }

        private Image ApplyWm(string original)
        {
            var originalImage = Image.FromFile(original);
            var bmp = new Bitmap(originalImage);
            var xPos = (bmp.Width - _waterMarkImageDisposal.Width) / 2;
            var yPos = (bmp.Height - _waterMarkImageDisposal.Height) / 2;

            using (var g = Graphics.FromImage(bmp))
            {
                g.DrawImage(_waterMarkImageDisposal, new Rectangle(xPos, yPos, _waterMarkImageDisposal.Width, _waterMarkImageDisposal.Height));
            }

            originalImage.Dispose();
            return bmp;
        }

        private List<Image> ApplyWatermarkToImages(List<string> images)
        {
            if (images == null) throw new ArgumentNullException(nameof(images));
            Cursor.Current = Cursors.WaitCursor;
            return images.Select(ApplyWm).ToList();
        }

        private void SaveWaterMarkedImages(List<Image> images)
        {
            if (images == null) throw new ArgumentNullException(nameof(images));

            Directory.CreateDirectory(_outputFolderPath);

            var counter = 1;
            var max = images.Count;
            ProgressBar.Visible = true;
            
            foreach (var image in images)
            {
                var fileName = Path.Combine(_outputFolderPath, $"watermarked{counter}_{Guid.NewGuid()}.png");
                image.Save(fileName);
                ProgressBar.Value = CalculatePercentage(counter, max);
                ProgressBar.Update();
                counter++;
            }
            
            Cursor.Current = Cursors.Default;
            System.Diagnostics.Process.Start("explorer.exe", _outputFolderPath);

        }

        private static int CalculatePercentage(int current, int max)
        {
            if (current == max) return 100;
            return (int)Math.Round((double)current / max * 100);
        }

        private void ResetForm()
        {
            _waterMarkImageDisposal?.Dispose();
            _waterMarkImageDisposal = null;
            _waterMarkImage = null;
            _chosenPictures.Clear();
            PictureCounter.Visible = false;
            WaterMarkLabel.Visible = false;
            ProgressBar.Visible = false;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void WaterMarkLabel_Click(object sender, EventArgs e)
        {

        }

        private void HideApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}