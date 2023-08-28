namespace WaterMarker
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.choosePictures = new System.Windows.Forms.Button();
            this.watermark = new System.Windows.Forms.Button();
            this.PictureCounter = new System.Windows.Forms.Label();
            this.WaterMarkLabel = new System.Windows.Forms.Label();
            this.ApplyWaterMark = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.ProgressBar = new WaterMarker.CircularProgressBar();
            this.SuspendLayout();
            // 
            // choosePictures
            // 
            this.choosePictures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choosePictures.Location = new System.Drawing.Point(98, 80);
            this.choosePictures.Name = "choosePictures";
            this.choosePictures.Size = new System.Drawing.Size(137, 23);
            this.choosePictures.TabIndex = 0;
            this.choosePictures.Text = "Wybierz zdjęcia";
            this.choosePictures.UseVisualStyleBackColor = true;
            this.choosePictures.Click += new System.EventHandler(this.ChoosePictures_Click);
            // 
            // watermark
            // 
            this.watermark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.watermark.Location = new System.Drawing.Point(98, 134);
            this.watermark.Name = "watermark";
            this.watermark.Size = new System.Drawing.Size(137, 23);
            this.watermark.TabIndex = 1;
            this.watermark.Text = "Wybierz znak wodny";
            this.watermark.UseVisualStyleBackColor = true;
            this.watermark.Click += new System.EventHandler(this.Watermark_Click);
            // 
            // PictureCounter
            // 
            this.PictureCounter.AutoSize = true;
            this.PictureCounter.Location = new System.Drawing.Point(241, 85);
            this.PictureCounter.Name = "PictureCounter";
            this.PictureCounter.Size = new System.Drawing.Size(89, 13);
            this.PictureCounter.TabIndex = 2;
            this.PictureCounter.Text = "Wybrano plików: ";
            this.PictureCounter.Visible = false;
            // 
            // WaterMarkLabel
            // 
            this.WaterMarkLabel.AutoSize = true;
            this.WaterMarkLabel.Location = new System.Drawing.Point(241, 139);
            this.WaterMarkLabel.Name = "WaterMarkLabel";
            this.WaterMarkLabel.Size = new System.Drawing.Size(68, 13);
            this.WaterMarkLabel.TabIndex = 3;
            this.WaterMarkLabel.Text = "Nazwa pliku:";
            this.WaterMarkLabel.Visible = false;
            // 
            // ApplyWaterMark
            // 
            this.ApplyWaterMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApplyWaterMark.Location = new System.Drawing.Point(98, 190);
            this.ApplyWaterMark.Name = "ApplyWaterMark";
            this.ApplyWaterMark.Size = new System.Drawing.Size(137, 23);
            this.ApplyWaterMark.TabIndex = 4;
            this.ApplyWaterMark.Text = "Nałóż znak wodny";
            this.ApplyWaterMark.UseVisualStyleBackColor = true;
            this.ApplyWaterMark.Click += new System.EventHandler(this.ApplyWaterMark_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(132, 242);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 6;
            this.Reset.Text = "Resetuj";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.ProgressBar.BarColor1 = System.Drawing.Color.Orange;
            this.ProgressBar.BarColor2 = System.Drawing.Color.Orange;
            this.ProgressBar.BarWidth = 14F;
            this.ProgressBar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ProgressBar.ForeColor = System.Drawing.Color.DimGray;
            this.ProgressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.ProgressBar.LineColor = System.Drawing.Color.DimGray;
            this.ProgressBar.LineWidth = 1;
            this.ProgressBar.Location = new System.Drawing.Point(471, 85);
            this.ProgressBar.Maximum = ((long)(100));
            this.ProgressBar.MinimumSize = new System.Drawing.Size(100, 100);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressShape = WaterMarker.CircularProgressBar._ProgressShape.Flat;
            this.ProgressBar.Size = new System.Drawing.Size(180, 180);
            this.ProgressBar.TabIndex = 5;
            this.ProgressBar.Text = "69";
            this.ProgressBar.TextMode = WaterMarker.CircularProgressBar._TextMode.Percentage;
            this.ProgressBar.Value = ((long)(69));
            this.ProgressBar.Visible = false;
            this.ProgressBar.Click += new System.EventHandler(this.ProgressBar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 357);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ApplyWaterMark);
            this.Controls.Add(this.WaterMarkLabel);
            this.Controls.Add(this.PictureCounter);
            this.Controls.Add(this.watermark);
            this.Controls.Add(this.choosePictures);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "WaterMarker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button watermark;
        protected internal System.Windows.Forms.Button choosePictures;
        private System.Windows.Forms.Label PictureCounter;
        private System.Windows.Forms.Label WaterMarkLabel;
        private System.Windows.Forms.Button ApplyWaterMark;
        private CircularProgressBar ProgressBar;
        private System.Windows.Forms.Button Reset;
    }
}

