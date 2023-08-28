﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterMarker
{
    public partial class MainForm : Form
    {
        private Image _waterMarkImage;

        private readonly string _outputFolderPath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WaterMarker");

        private List<Image> _chosenPictures = new List<Image>();

        public MainForm()
        {
            InitializeComponent();
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
                    _chosenPictures.Add(Image.FromFile(fileName));
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

                _waterMarkImage = Image.FromFile(openFileDialog.FileName);
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

            var croppedWaterMark = CropTransparentImage(_waterMarkImage);
            if (croppedWaterMark == null)
            {
                MessageBox.Show(@"Znak wodny nie może być przezroczysty!", @"Błąd", MessageBoxButtons.OK,
                                                          MessageBoxIcon.Error);
                return;
            }

            _waterMarkImage = croppedWaterMark;
            var waterMarkedImages = ApplyWatermarkToImages(_chosenPictures);
            SaveWaterMarkedImages(waterMarkedImages);
        }

        private Image CropTransparentImage(Image img)
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

            return hasColours ? croppedImage : null;
        }

        private Image ApplyWm(Image original)
        {
            var bmp = new Bitmap(original);
            var xPos = (bmp.Width - _waterMarkImage.Width) / 2;
            var yPos = (bmp.Height - _waterMarkImage.Height) / 2;

            using (var g = Graphics.FromImage(bmp))
            {
                g.DrawImage(_waterMarkImage, new Rectangle(xPos, yPos, _waterMarkImage.Width, _waterMarkImage.Height));
            }

            return bmp;
        }

        private List<Image> ApplyWatermarkToImages(List<Image> images)
        {
            if (images == null) throw new ArgumentNullException(nameof(images));
            return images.Select(ApplyWm).ToList();
        }

        private void SaveWaterMarkedImages(List<Image> images)
        {
            if (images == null) throw new ArgumentNullException(nameof(images));

            Directory.CreateDirectory(_outputFolderPath);

            var counter = 1;
            foreach (var image in images)
            {
                var fileName = Path.Combine(_outputFolderPath, $"watermarked{counter}_{Guid.NewGuid()}.png");
                image.Save(fileName);
                counter++;
            }

            System.Diagnostics.Process.Start("explorer.exe", _outputFolderPath);
        }
    }

}