namespace WeversMarket_1
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            pictureBox1 = new PictureBox();
            BtNext = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Cornsilk;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(161, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(667, 685);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtNext
            // 
            BtNext.BackgroundImage = (Image)resources.GetObject("BtNext.BackgroundImage");
            BtNext.BackgroundImageLayout = ImageLayout.Center;
            BtNext.Cursor = Cursors.Hand;
            BtNext.FlatStyle = FlatStyle.Flat;
            BtNext.ForeColor = Color.Cornsilk;
            BtNext.Location = new Point(928, 576);
            BtNext.Name = "BtNext";
            BtNext.Size = new Size(110, 102);
            BtNext.TabIndex = 1;
            BtNext.UseVisualStyleBackColor = true;
            BtNext.Click += BtNext_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1050, 690);
            Controls.Add(BtNext);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtNext;
    }
}
