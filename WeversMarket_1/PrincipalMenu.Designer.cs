namespace WeversMarket_1
{
    partial class PrincipalMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalMenu));
            menuStrip1 = new MenuStrip();
            BtProduc = new FontAwesome.Sharp.IconMenuItem();
            BtCateg = new FontAwesome.Sharp.IconMenuItem();
            BtSuplid = new FontAwesome.Sharp.IconMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Wheat;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { BtProduc, BtCateg, BtSuplid });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1022, 81);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // BtProduc
            // 
            BtProduc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtProduc.ForeColor = Color.SeaGreen;
            BtProduc.IconChar = FontAwesome.Sharp.IconChar.Box;
            BtProduc.IconColor = Color.SeaGreen;
            BtProduc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtProduc.IconSize = 50;
            BtProduc.ImageScaling = ToolStripItemImageScaling.None;
            BtProduc.Name = "BtProduc";
            BtProduc.Size = new Size(126, 77);
            BtProduc.Text = "PRODUCTOS";
            BtProduc.TextImageRelation = TextImageRelation.ImageAboveText;
            BtProduc.Click += BtProduc_Click;
            // 
            // BtCateg
            // 
            BtCateg.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtCateg.ForeColor = Color.SeaGreen;
            BtCateg.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            BtCateg.IconColor = Color.SeaGreen;
            BtCateg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtCateg.IconSize = 50;
            BtCateg.ImageScaling = ToolStripItemImageScaling.None;
            BtCateg.Name = "BtCateg";
            BtCateg.Size = new Size(128, 77);
            BtCateg.Text = "CATEGORIAS";
            BtCateg.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // BtSuplid
            // 
            BtSuplid.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtSuplid.ForeColor = Color.SeaGreen;
            BtSuplid.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            BtSuplid.IconColor = Color.SeaGreen;
            BtSuplid.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtSuplid.IconSize = 50;
            BtSuplid.ImageScaling = ToolStripItemImageScaling.None;
            BtSuplid.Name = "BtSuplid";
            BtSuplid.Size = new Size(126, 77);
            BtSuplid.Text = "SUPLIDORES";
            BtSuplid.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Cornsilk;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(203, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(549, 570);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // PrincipalMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1022, 716);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Name = "PrincipalMenu";
            StartPosition = FormStartPosition.CenterScreen;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem BtProduc;
        private FontAwesome.Sharp.IconMenuItem BtCateg;
        private FontAwesome.Sharp.IconMenuItem BtSuplid;
        private PictureBox pictureBox1;
    }
}