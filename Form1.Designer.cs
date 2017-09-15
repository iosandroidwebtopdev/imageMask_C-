namespace CSApp
{
    partial class Form1
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
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.lblIntensity = new System.Windows.Forms.Label();
            this.trcIntensity = new System.Windows.Forms.TrackBar();
            this.btnOpenOriginal = new System.Windows.Forms.Button();
            this.cmbEdgeDetection = new System.Windows.Forms.ComboBox();
            this.btnSaveNewImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcIntensity)).BeginInit();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.Silver;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picPreview.Location = new System.Drawing.Point(12, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(600, 600);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // lblIntensity
            // 
            this.lblIntensity.AutoSize = true;
            this.lblIntensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntensity.Location = new System.Drawing.Point(618, 12);
            this.lblIntensity.Name = "lblIntensity";
            this.lblIntensity.Size = new System.Drawing.Size(78, 25);
            this.lblIntensity.TabIndex = 21;
            this.lblIntensity.Text = "100 %";
            this.lblIntensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcIntensity
            // 
            this.trcIntensity.BackColor = System.Drawing.Color.Silver;
            this.trcIntensity.LargeChange = 1;
            this.trcIntensity.Location = new System.Drawing.Point(633, 40);
            this.trcIntensity.Maximum = 300;
            this.trcIntensity.Name = "trcIntensity";
            this.trcIntensity.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcIntensity.Size = new System.Drawing.Size(45, 572);
            this.trcIntensity.TabIndex = 22;
            this.trcIntensity.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trcIntensity.Value = 100;
            this.trcIntensity.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOriginal.Location = new System.Drawing.Point(12, 629);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(145, 44);
            this.btnOpenOriginal.TabIndex = 23;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // cmbEdgeDetection
            // 
            this.cmbEdgeDetection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdgeDetection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdgeDetection.FormattingEnabled = true;
            this.cmbEdgeDetection.Items.AddRange(new object[] {
            "None",
            "Gaussian 3x3",
            "Gaussian 5x5",
            "Mean 3x3",
            "Mean 5x5"});
            this.cmbEdgeDetection.Location = new System.Drawing.Point(177, 635);
            this.cmbEdgeDetection.Name = "cmbEdgeDetection";
            this.cmbEdgeDetection.Size = new System.Drawing.Size(254, 32);
            this.cmbEdgeDetection.TabIndex = 24;
            this.cmbEdgeDetection.SelectedIndexChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(467, 629);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(145, 44);
            this.btnSaveNewImage.TabIndex = 25;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(702, 685);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.cmbEdgeDetection);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.trcIntensity);
            this.Controls.Add(this.lblIntensity);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Image Unsharp Mask";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcIntensity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Label lblIntensity;
        private System.Windows.Forms.TrackBar trcIntensity;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.ComboBox cmbEdgeDetection;
        private System.Windows.Forms.Button btnSaveNewImage;
    }
}

