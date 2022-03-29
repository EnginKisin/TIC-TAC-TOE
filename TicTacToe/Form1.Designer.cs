
namespace TicTacToe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.tbx4 = new System.Windows.Forms.TextBox();
            this.tbx5 = new System.Windows.Forms.TextBox();
            this.tbx6 = new System.Windows.Forms.TextBox();
            this.tbx7 = new System.Windows.Forms.TextBox();
            this.tbx8 = new System.Windows.Forms.TextBox();
            this.tbx9 = new System.Windows.Forms.TextBox();
            this.btnX = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.tmrControll = new System.Windows.Forms.Timer(this.components);
            this.ptbRestart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRestart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "TicTacToe";
            // 
            // ptbClose
            // 
            this.ptbClose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbClose.Image = ((System.Drawing.Image)(resources.GetObject("ptbClose.Image")));
            this.ptbClose.Location = new System.Drawing.Point(328, 12);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(34, 35);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClose.TabIndex = 18;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            // 
            // tbx1
            // 
            this.tbx1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbx1.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx1.Location = new System.Drawing.Point(75, 155);
            this.tbx1.Multiline = true;
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(71, 67);
            this.tbx1.TabIndex = 19;
            this.tbx1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx1.Click += new System.EventHandler(this.tbxClick);
            // 
            // tbx2
            // 
            this.tbx2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbx2.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx2.Location = new System.Drawing.Point(146, 155);
            this.tbx2.Multiline = true;
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(71, 67);
            this.tbx2.TabIndex = 20;
            this.tbx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx2.Click += new System.EventHandler(this.tbxClick);
            // 
            // tbx3
            // 
            this.tbx3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbx3.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Bold);
            this.tbx3.Location = new System.Drawing.Point(217, 155);
            this.tbx3.Multiline = true;
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(71, 67);
            this.tbx3.TabIndex = 21;
            this.tbx3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx3.Click += new System.EventHandler(this.tbxClick);
            // 
            // tbx4
            // 
            this.tbx4.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbx4.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Bold);
            this.tbx4.Location = new System.Drawing.Point(75, 222);
            this.tbx4.Multiline = true;
            this.tbx4.Name = "tbx4";
            this.tbx4.Size = new System.Drawing.Size(71, 67);
            this.tbx4.TabIndex = 22;
            this.tbx4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx4.Click += new System.EventHandler(this.tbxClick);
            // 
            // tbx5
            // 
            this.tbx5.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbx5.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Bold);
            this.tbx5.Location = new System.Drawing.Point(146, 222);
            this.tbx5.Multiline = true;
            this.tbx5.Name = "tbx5";
            this.tbx5.Size = new System.Drawing.Size(71, 67);
            this.tbx5.TabIndex = 23;
            this.tbx5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx5.Click += new System.EventHandler(this.tbxClick);
            // 
            // tbx6
            // 
            this.tbx6.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbx6.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Bold);
            this.tbx6.Location = new System.Drawing.Point(217, 222);
            this.tbx6.Multiline = true;
            this.tbx6.Name = "tbx6";
            this.tbx6.Size = new System.Drawing.Size(71, 67);
            this.tbx6.TabIndex = 24;
            this.tbx6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx6.Click += new System.EventHandler(this.tbxClick);
            // 
            // tbx7
            // 
            this.tbx7.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbx7.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Bold);
            this.tbx7.Location = new System.Drawing.Point(75, 289);
            this.tbx7.Multiline = true;
            this.tbx7.Name = "tbx7";
            this.tbx7.Size = new System.Drawing.Size(71, 67);
            this.tbx7.TabIndex = 25;
            this.tbx7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx7.Click += new System.EventHandler(this.tbxClick);
            // 
            // tbx8
            // 
            this.tbx8.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbx8.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Bold);
            this.tbx8.Location = new System.Drawing.Point(146, 289);
            this.tbx8.Multiline = true;
            this.tbx8.Name = "tbx8";
            this.tbx8.Size = new System.Drawing.Size(71, 67);
            this.tbx8.TabIndex = 26;
            this.tbx8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx8.Click += new System.EventHandler(this.tbxClick);
            // 
            // tbx9
            // 
            this.tbx9.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbx9.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Bold);
            this.tbx9.Location = new System.Drawing.Point(217, 289);
            this.tbx9.Multiline = true;
            this.tbx9.Name = "tbx9";
            this.tbx9.Size = new System.Drawing.Size(71, 67);
            this.tbx9.TabIndex = 27;
            this.tbx9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbx9.Click += new System.EventHandler(this.tbxClick);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnX.Location = new System.Drawing.Point(118, 65);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(53, 40);
            this.btnX.TabIndex = 28;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnO.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.Location = new System.Drawing.Point(177, 65);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(53, 40);
            this.btnO.TabIndex = 29;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = false;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // tmrControll
            // 
            this.tmrControll.Enabled = true;
            this.tmrControll.Tick += new System.EventHandler(this.tmrControll_Tick);
            // 
            // ptbRestart
            // 
            this.ptbRestart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbRestart.Image = ((System.Drawing.Image)(resources.GetObject("ptbRestart.Image")));
            this.ptbRestart.Location = new System.Drawing.Point(288, 12);
            this.ptbRestart.Name = "ptbRestart";
            this.ptbRestart.Size = new System.Drawing.Size(34, 35);
            this.ptbRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbRestart.TabIndex = 30;
            this.ptbRestart.TabStop = false;
            this.ptbRestart.Click += new System.EventHandler(this.ptbRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.ptbRestart);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.tbx9);
            this.Controls.Add(this.tbx8);
            this.Controls.Add(this.tbx7);
            this.Controls.Add(this.tbx6);
            this.Controls.Add(this.tbx5);
            this.Controls.Add(this.tbx4);
            this.Controls.Add(this.tbx3);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.tbx1);
            this.Controls.Add(this.ptbClose);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRestart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnO;
        public System.Windows.Forms.TextBox tbx1;
        public System.Windows.Forms.TextBox tbx2;
        public System.Windows.Forms.TextBox tbx3;
        public System.Windows.Forms.TextBox tbx4;
        public System.Windows.Forms.TextBox tbx5;
        public System.Windows.Forms.TextBox tbx6;
        public System.Windows.Forms.TextBox tbx7;
        public System.Windows.Forms.TextBox tbx8;
        public System.Windows.Forms.TextBox tbx9;
        private System.Windows.Forms.Timer tmrControll;
        private System.Windows.Forms.PictureBox ptbRestart;
    }
}

