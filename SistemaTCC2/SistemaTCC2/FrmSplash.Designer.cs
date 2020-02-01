namespace Bazar.UI
{
    partial class FrmSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            this.barradeprogresso = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtprogresso = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barradeprogresso
            // 
            this.barradeprogresso.BackColor = System.Drawing.Color.Aqua;
            this.barradeprogresso.Location = new System.Drawing.Point(30, 246);
            this.barradeprogresso.Name = "barradeprogresso";
            this.barradeprogresso.Size = new System.Drawing.Size(402, 33);
            this.barradeprogresso.TabIndex = 3;
            this.barradeprogresso.Click += new System.EventHandler(this.barradeprogresso_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 99;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtprogresso
            // 
            this.txtprogresso.AutoSize = true;
            this.txtprogresso.BackColor = System.Drawing.Color.White;
            this.txtprogresso.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprogresso.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtprogresso.Location = new System.Drawing.Point(140, 292);
            this.txtprogresso.Name = "txtprogresso";
            this.txtprogresso.Size = new System.Drawing.Size(57, 19);
            this.txtprogresso.TabIndex = 2;
            this.txtprogresso.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaTCC2.Properties.Resources.LogoForm1;
            this.pictureBox1.Location = new System.Drawing.Point(123, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SistemaTCC2.Properties.Resources.Borda;
            this.ClientSize = new System.Drawing.Size(464, 351);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtprogresso);
            this.Controls.Add(this.barradeprogresso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar barradeprogresso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtprogresso;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}