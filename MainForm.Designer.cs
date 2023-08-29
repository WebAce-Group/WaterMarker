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
            this.HideApp = new System.Windows.Forms.Button();
            this.CloseApp = new System.Windows.Forms.Button();
            this.ProgressBar = new WaterMarker.CircularProgressBar();
            this.SuspendLayout();
            // 
            // choosePictures
            // 
            this.choosePictures.BackColor = System.Drawing.Color.Transparent;
            this.choosePictures.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.choosePictures, "choosePictures");
            this.choosePictures.ForeColor = System.Drawing.SystemColors.Control;
            this.choosePictures.Name = "choosePictures";
            this.choosePictures.UseVisualStyleBackColor = false;
            this.choosePictures.Click += new System.EventHandler(this.ChoosePictures_Click);
            // 
            // watermark
            // 
            this.watermark.BackColor = System.Drawing.Color.Transparent;
            this.watermark.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.watermark, "watermark");
            this.watermark.ForeColor = System.Drawing.SystemColors.Control;
            this.watermark.Name = "watermark";
            this.watermark.UseVisualStyleBackColor = false;
            this.watermark.Click += new System.EventHandler(this.Watermark_Click);
            // 
            // PictureCounter
            // 
            resources.ApplyResources(this.PictureCounter, "PictureCounter");
            this.PictureCounter.BackColor = System.Drawing.Color.Transparent;
            this.PictureCounter.ForeColor = System.Drawing.SystemColors.Control;
            this.PictureCounter.Name = "PictureCounter";
            // 
            // WaterMarkLabel
            // 
            resources.ApplyResources(this.WaterMarkLabel, "WaterMarkLabel");
            this.WaterMarkLabel.BackColor = System.Drawing.Color.Transparent;
            this.WaterMarkLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.WaterMarkLabel.Name = "WaterMarkLabel";
            this.WaterMarkLabel.Click += new System.EventHandler(this.WaterMarkLabel_Click);
            // 
            // ApplyWaterMark
            // 
            this.ApplyWaterMark.BackColor = System.Drawing.Color.Transparent;
            this.ApplyWaterMark.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.ApplyWaterMark, "ApplyWaterMark");
            this.ApplyWaterMark.ForeColor = System.Drawing.SystemColors.Control;
            this.ApplyWaterMark.Name = "ApplyWaterMark";
            this.ApplyWaterMark.UseVisualStyleBackColor = false;
            this.ApplyWaterMark.Click += new System.EventHandler(this.ApplyWaterMark_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Transparent;
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Reset, "Reset");
            this.Reset.ForeColor = System.Drawing.SystemColors.Control;
            this.Reset.Name = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // HideApp
            // 
            this.HideApp.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.HideApp, "HideApp");
            this.HideApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideApp.FlatAppearance.BorderSize = 0;
            this.HideApp.ForeColor = System.Drawing.Color.Transparent;
            this.HideApp.Name = "HideApp";
            this.HideApp.UseVisualStyleBackColor = false;
            this.HideApp.Click += new System.EventHandler(this.HideApp_Click);
            // 
            // CloseApp
            // 
            this.CloseApp.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.CloseApp, "CloseApp");
            this.CloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseApp.FlatAppearance.BorderSize = 0;
            this.CloseApp.ForeColor = System.Drawing.Color.Transparent;
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.UseVisualStyleBackColor = false;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar.BarColor1 = System.Drawing.Color.Magenta;
            this.ProgressBar.BarColor2 = System.Drawing.Color.DodgerBlue;
            this.ProgressBar.BarWidth = 20F;
            resources.ApplyResources(this.ProgressBar, "ProgressBar");
            this.ProgressBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ProgressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.ProgressBar.LineColor = System.Drawing.Color.White;
            this.ProgressBar.LineWidth = 1;
            this.ProgressBar.Maximum = ((long)(100));
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressShape = WaterMarker.CircularProgressBar._ProgressShape.Flat;
            this.ProgressBar.TabStop = false;
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
            this.Controls.Add(this.CloseApp);
            this.Controls.Add(this.HideApp);
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
        private System.Windows.Forms.Button HideApp;
        private System.Windows.Forms.Button CloseApp;
    }
}

