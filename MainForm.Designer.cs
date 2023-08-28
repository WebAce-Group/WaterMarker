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
            resources.ApplyResources(this.choosePictures, "choosePictures");
            this.choosePictures.Name = "choosePictures";
            this.choosePictures.UseVisualStyleBackColor = true;
            this.choosePictures.Click += new System.EventHandler(this.ChoosePictures_Click);
            // 
            // watermark
            // 
            this.watermark.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.watermark, "watermark");
            this.watermark.Name = "watermark";
            this.watermark.UseVisualStyleBackColor = true;
            this.watermark.Click += new System.EventHandler(this.Watermark_Click);
            // 
            // PictureCounter
            // 
            resources.ApplyResources(this.PictureCounter, "PictureCounter");
            this.PictureCounter.Name = "PictureCounter";
            // 
            // WaterMarkLabel
            // 
            resources.ApplyResources(this.WaterMarkLabel, "WaterMarkLabel");
            this.WaterMarkLabel.Name = "WaterMarkLabel";
            // 
            // ApplyWaterMark
            // 
            this.ApplyWaterMark.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.ApplyWaterMark, "ApplyWaterMark");
            this.ApplyWaterMark.Name = "ApplyWaterMark";
            this.ApplyWaterMark.UseVisualStyleBackColor = true;
            this.ApplyWaterMark.Click += new System.EventHandler(this.ApplyWaterMark_Click);
            // 
            // Reset
            // 
            resources.ApplyResources(this.Reset, "Reset");
            this.Reset.Name = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.ProgressBar.BarColor1 = System.Drawing.Color.Orange;
            this.ProgressBar.BarColor2 = System.Drawing.Color.Orange;
            this.ProgressBar.BarWidth = 14F;
            resources.ApplyResources(this.ProgressBar, "ProgressBar");
            this.ProgressBar.ForeColor = System.Drawing.Color.DimGray;
            this.ProgressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.ProgressBar.LineColor = System.Drawing.Color.DimGray;
            this.ProgressBar.LineWidth = 1;
            this.ProgressBar.Maximum = ((long)(100));
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressShape = WaterMarker.CircularProgressBar._ProgressShape.Flat;
            this.ProgressBar.TextMode = WaterMarker.CircularProgressBar._TextMode.Percentage;
            this.ProgressBar.Value = ((long)(69));
            this.ProgressBar.Click += new System.EventHandler(this.ProgressBar_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WaterMarker.Properties.Resources.WaterMarkerBg;
            this.ControlBox = false;
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ApplyWaterMark);
            this.Controls.Add(this.WaterMarkLabel);
            this.Controls.Add(this.PictureCounter);
            this.Controls.Add(this.watermark);
            this.Controls.Add(this.choosePictures);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
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

