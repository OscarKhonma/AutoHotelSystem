
namespace Hotel_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnMRes = new System.Windows.Forms.Button();
            this.BtnMR = new System.Windows.Forms.Button();
            this.BtnMC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.BtnMRes);
            this.groupBox1.Controls.Add(this.BtnMR);
            this.groupBox1.Controls.Add(this.BtnMC);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1129, 554);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // BtnMRes
            // 
            this.BtnMRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMRes.BackColor = System.Drawing.Color.Violet;
            this.BtnMRes.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMRes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BtnMRes.Location = new System.Drawing.Point(981, 0);
            this.BtnMRes.Name = "BtnMRes";
            this.BtnMRes.Size = new System.Drawing.Size(148, 63);
            this.BtnMRes.TabIndex = 2;
            this.BtnMRes.Text = "Управление бронью";
            this.BtnMRes.UseVisualStyleBackColor = false;
            this.BtnMRes.Click += new System.EventHandler(this.BtnMRes_Click);
            // 
            // BtnMR
            // 
            this.BtnMR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnMR.BackColor = System.Drawing.Color.Violet;
            this.BtnMR.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMR.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BtnMR.Location = new System.Drawing.Point(489, 0);
            this.BtnMR.Name = "BtnMR";
            this.BtnMR.Size = new System.Drawing.Size(148, 63);
            this.BtnMR.TabIndex = 1;
            this.BtnMR.Text = "Управление номерами";
            this.BtnMR.UseVisualStyleBackColor = false;
            this.BtnMR.Click += new System.EventHandler(this.BtnMR_Click);
            // 
            // BtnMC
            // 
            this.BtnMC.BackColor = System.Drawing.Color.Violet;
            this.BtnMC.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMC.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.BtnMC.Location = new System.Drawing.Point(0, 0);
            this.BtnMC.Name = "BtnMC";
            this.BtnMC.Size = new System.Drawing.Size(148, 63);
            this.BtnMC.TabIndex = 0;
            this.BtnMC.Text = "Управление клиентами";
            this.BtnMC.UseVisualStyleBackColor = false;
            this.BtnMC.Click += new System.EventHandler(this.BtnMC_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Violet;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Управление клиентами";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Violet;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Location = new System.Drawing.Point(489, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Управление номерами";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Violet;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Location = new System.Drawing.Point(981, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "Управление бронью";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 554);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem manageClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageReservationsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnMC;
        private System.Windows.Forms.Button BtnMRes;
        private System.Windows.Forms.Button BtnMR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}