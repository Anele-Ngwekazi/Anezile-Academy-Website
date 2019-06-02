namespace AezileAcademy
{
    partial class FrmAnezile
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
            this.Mainfrmimg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Mainfrmimg)).BeginInit();
            this.SuspendLayout();
            // 
            // Mainfrmimg
            // 
            this.Mainfrmimg.ImageLocation = "C:\\Users\\Anele\\source\\repos\\AezileAcademy\\AezileAcademy\\formpicture.jpg";
            this.Mainfrmimg.Location = new System.Drawing.Point(0, 0);
            this.Mainfrmimg.Name = "Mainfrmimg";
            this.Mainfrmimg.Size = new System.Drawing.Size(276, 183);
            this.Mainfrmimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Mainfrmimg.TabIndex = 0;
            this.Mainfrmimg.TabStop = false;
            // 
            // FrmAnezile
            // 
            this.ClientSize = new System.Drawing.Size(729, 330);
            this.Controls.Add(this.Mainfrmimg);
            this.Name = "FrmAnezile";
            this.Load += new System.EventHandler(this.FrmAnezile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mainfrmimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Mainfrmimg;
    }
}

