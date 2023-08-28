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
            this.choosePictures = new System.Windows.Forms.Button();
            this.watermark = new System.Windows.Forms.Button();
            this.PictureCounter = new System.Windows.Forms.Label();
            this.WaterMarkLabel = new System.Windows.Forms.Label();
            this.ApplyWaterMark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choosePictures
            // 
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
            this.watermark.Location = new System.Drawing.Point(98, 152);
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
            this.WaterMarkLabel.Location = new System.Drawing.Point(241, 157);
            this.WaterMarkLabel.Name = "WaterMarkLabel";
            this.WaterMarkLabel.Size = new System.Drawing.Size(68, 13);
            this.WaterMarkLabel.TabIndex = 3;
            this.WaterMarkLabel.Text = "Nazwa pliku:";
            this.WaterMarkLabel.Visible = false;
            // 
            // ApplyWaterMark
            // 
            this.ApplyWaterMark.Location = new System.Drawing.Point(98, 230);
            this.ApplyWaterMark.Name = "ApplyWaterMark";
            this.ApplyWaterMark.Size = new System.Drawing.Size(137, 23);
            this.ApplyWaterMark.TabIndex = 4;
            this.ApplyWaterMark.Text = "Nałóż znak wodny";
            this.ApplyWaterMark.UseVisualStyleBackColor = true;
            this.ApplyWaterMark.Click += new System.EventHandler(this.ApplyWaterMark_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ApplyWaterMark);
            this.Controls.Add(this.WaterMarkLabel);
            this.Controls.Add(this.PictureCounter);
            this.Controls.Add(this.watermark);
            this.Controls.Add(this.choosePictures);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button watermark;
        protected internal System.Windows.Forms.Button choosePictures;
        private System.Windows.Forms.Label PictureCounter;
        private System.Windows.Forms.Label WaterMarkLabel;
        private System.Windows.Forms.Button ApplyWaterMark;
    }
}

