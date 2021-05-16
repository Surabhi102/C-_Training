
namespace FruitBasket_Final
{
    partial class FruitBasket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FruitBasket));
            this.pip = new System.Windows.Forms.PictureBox();
            this.app = new System.Windows.Forms.PictureBox();
            this.brin = new System.Windows.Forms.PictureBox();
            this.bowl = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sc = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.app)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowl)).BeginInit();
            this.SuspendLayout();
            // 
            // pip
            // 
            this.pip.Image = ((System.Drawing.Image)(resources.GetObject("pip.Image")));
            this.pip.Location = new System.Drawing.Point(103, 40);
            this.pip.Name = "pip";
            this.pip.Size = new System.Drawing.Size(61, 65);
            this.pip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pip.TabIndex = 0;
            this.pip.TabStop = false;
            this.pip.Tag = "fruits";
            // 
            // app
            // 
            this.app.Image = ((System.Drawing.Image)(resources.GetObject("app.Image")));
            this.app.Location = new System.Drawing.Point(323, 38);
            this.app.Name = "app";
            this.app.Size = new System.Drawing.Size(78, 67);
            this.app.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.app.TabIndex = 1;
            this.app.TabStop = false;
            this.app.Tag = "fruits";
            // 
            // brin
            // 
            this.brin.Image = ((System.Drawing.Image)(resources.GetObject("brin.Image")));
            this.brin.Location = new System.Drawing.Point(575, 38);
            this.brin.Name = "brin";
            this.brin.Size = new System.Drawing.Size(40, 59);
            this.brin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brin.TabIndex = 2;
            this.brin.TabStop = false;
            this.brin.Tag = "veg";
            // 
            // bowl
            // 
            this.bowl.Image = ((System.Drawing.Image)(resources.GetObject("bowl.Image")));
            this.bowl.Location = new System.Drawing.Point(3, 371);
            this.bowl.Name = "bowl";
            this.bowl.Size = new System.Drawing.Size(144, 77);
            this.bowl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bowl.TabIndex = 3;
            this.bowl.TabStop = false;
            this.bowl.Click += new System.EventHandler(this.bowl_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sc
            // 
            this.sc.AutoSize = true;
            this.sc.Location = new System.Drawing.Point(681, 13);
            this.sc.Name = "sc";
            this.sc.Size = new System.Drawing.Size(46, 17);
            this.sc.TabIndex = 4;
            this.sc.Text = "label1";
            // 
            // pname
            // 
            this.pname.AutoSize = true;
            this.pname.Location = new System.Drawing.Point(13, 12);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(46, 17);
            this.pname.TabIndex = 5;
            this.pname.Text = "label1";
            // 
            // FruitBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.bowl);
            this.Controls.Add(this.brin);
            this.Controls.Add(this.app);
            this.Controls.Add(this.pip);
            this.Name = "FruitBasket";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FruitBasket_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.app)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pip;
        private System.Windows.Forms.PictureBox app;
        private System.Windows.Forms.PictureBox brin;
        private System.Windows.Forms.PictureBox bowl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label sc;
        private System.Windows.Forms.Label pname;
    }
}

