namespace WeversMarket_1
{
    partial class ProducForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProducForm));
            panel1 = new Panel();
            BtBack = new Button();
            label1 = new Label();
            BtRefresh = new Button();
            BtDelete = new Button();
            BtUpdate = new Button();
            BtAdd = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(BtBack);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BtRefresh);
            panel1.Controls.Add(BtDelete);
            panel1.Controls.Add(BtUpdate);
            panel1.Controls.Add(BtAdd);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 666);
            panel1.TabIndex = 0;
            // 
            // BtBack
            // 
            BtBack.BackgroundImage = (Image)resources.GetObject("BtBack.BackgroundImage");
            BtBack.BackgroundImageLayout = ImageLayout.Center;
            BtBack.Cursor = Cursors.Hand;
            BtBack.FlatStyle = FlatStyle.Flat;
            BtBack.ForeColor = Color.Wheat;
            BtBack.Location = new Point(15, 590);
            BtBack.Name = "BtBack";
            BtBack.Size = new Size(69, 61);
            BtBack.TabIndex = 5;
            BtBack.UseVisualStyleBackColor = true;
            BtBack.Click += BtBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 79);
            label1.Name = "label1";
            label1.Size = new Size(287, 60);
            label1.TabIndex = 4;
            label1.Text = "PRODUCTOS";
            // 
            // BtRefresh
            // 
            BtRefresh.BackColor = Color.FromArgb(128, 128, 255);
            BtRefresh.Cursor = Cursors.Hand;
            BtRefresh.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            BtRefresh.ForeColor = SystemColors.ControlLightLight;
            BtRefresh.Location = new Point(80, 396);
            BtRefresh.Name = "BtRefresh";
            BtRefresh.Size = new Size(172, 42);
            BtRefresh.TabIndex = 3;
            BtRefresh.Text = "REFRESH";
            BtRefresh.UseVisualStyleBackColor = false;
            // 
            // BtDelete
            // 
            BtDelete.BackColor = Color.Red;
            BtDelete.Cursor = Cursors.Hand;
            BtDelete.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            BtDelete.ForeColor = SystemColors.ControlLightLight;
            BtDelete.Location = new Point(80, 332);
            BtDelete.Name = "BtDelete";
            BtDelete.Size = new Size(172, 42);
            BtDelete.TabIndex = 2;
            BtDelete.Text = "ELIMINAR";
            BtDelete.UseVisualStyleBackColor = false;
            // 
            // BtUpdate
            // 
            BtUpdate.BackColor = Color.FromArgb(255, 128, 0);
            BtUpdate.Cursor = Cursors.Hand;
            BtUpdate.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            BtUpdate.ForeColor = SystemColors.ControlLightLight;
            BtUpdate.Location = new Point(80, 268);
            BtUpdate.Name = "BtUpdate";
            BtUpdate.Size = new Size(172, 42);
            BtUpdate.TabIndex = 1;
            BtUpdate.Text = "EDITAR";
            BtUpdate.UseVisualStyleBackColor = false;
            // 
            // BtAdd
            // 
            BtAdd.BackColor = Color.Green;
            BtAdd.Cursor = Cursors.Hand;
            BtAdd.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold);
            BtAdd.ForeColor = SystemColors.ControlLightLight;
            BtAdd.Location = new Point(80, 209);
            BtAdd.Name = "BtAdd";
            BtAdd.Size = new Size(172, 42);
            BtAdd.TabIndex = 0;
            BtAdd.Text = "AGREGAR";
            BtAdd.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Wheat;
            panel2.Location = new Point(378, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(938, 69);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(378, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(938, 591);
            dataGridView1.TabIndex = 2;
            // 
            // ProducForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1337, 690);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ProducForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button BtRefresh;
        private Button BtDelete;
        private Button BtUpdate;
        private Button BtAdd;
        private DataGridView dataGridView1;
        private Button BtBack;
    }
}