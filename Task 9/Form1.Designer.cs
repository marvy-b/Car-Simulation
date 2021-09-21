
namespace Task_9
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.btnBrake = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnGear1 = new System.Windows.Forms.Button();
            this.btnGear2 = new System.Windows.Forms.Button();
            this.btnGear3 = new System.Windows.Forms.Button();
            this.btnGear4 = new System.Windows.Forms.Button();
            this.Car4 = new System.Windows.Forms.PictureBox();
            this.Car3 = new System.Windows.Forms.PictureBox();
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Car4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // btnBrake
            // 
            this.btnBrake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBrake.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrake.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBrake.Location = new System.Drawing.Point(242, 497);
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Size = new System.Drawing.Size(88, 40);
            this.btnBrake.TabIndex = 4;
            this.btnBrake.Text = "Brake";
            this.btnBrake.UseVisualStyleBackColor = false;
            this.btnBrake.Click += new System.EventHandler(this.btnBrake_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.Green;
            this.btnLaunch.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLaunch.Location = new System.Drawing.Point(336, 497);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(88, 40);
            this.btnLaunch.TabIndex = 5;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.Navy;
            this.btnMove.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMove.Location = new System.Drawing.Point(430, 497);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(88, 40);
            this.btnMove.TabIndex = 6;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnGear1
            // 
            this.btnGear1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGear1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGear1.Location = new System.Drawing.Point(552, 498);
            this.btnGear1.Name = "btnGear1";
            this.btnGear1.Size = new System.Drawing.Size(45, 40);
            this.btnGear1.TabIndex = 7;
            this.btnGear1.Text = "1";
            this.btnGear1.UseVisualStyleBackColor = false;
            this.btnGear1.Click += new System.EventHandler(this.btnGear1_Click);
            // 
            // btnGear2
            // 
            this.btnGear2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGear2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGear2.Location = new System.Drawing.Point(603, 498);
            this.btnGear2.Name = "btnGear2";
            this.btnGear2.Size = new System.Drawing.Size(45, 40);
            this.btnGear2.TabIndex = 8;
            this.btnGear2.Text = "2";
            this.btnGear2.UseVisualStyleBackColor = false;
            this.btnGear2.Click += new System.EventHandler(this.btnGear2_Click);
            // 
            // btnGear3
            // 
            this.btnGear3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGear3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGear3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGear3.Location = new System.Drawing.Point(654, 497);
            this.btnGear3.Name = "btnGear3";
            this.btnGear3.Size = new System.Drawing.Size(45, 40);
            this.btnGear3.TabIndex = 9;
            this.btnGear3.Text = "3";
            this.btnGear3.UseVisualStyleBackColor = false;
            this.btnGear3.Click += new System.EventHandler(this.btnGear3_Click);
            // 
            // btnGear4
            // 
            this.btnGear4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGear4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGear4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGear4.Location = new System.Drawing.Point(705, 498);
            this.btnGear4.Name = "btnGear4";
            this.btnGear4.Size = new System.Drawing.Size(45, 40);
            this.btnGear4.TabIndex = 10;
            this.btnGear4.Text = "4";
            this.btnGear4.UseVisualStyleBackColor = false;
            this.btnGear4.Click += new System.EventHandler(this.btnGear4_Click);
            // 
            // Car4
            // 
            this.Car4.Image = global::Task_9.Properties.Resources._240_F_246680613_v2Rclar3CN0vRuOtlN3r1MlV;
            this.Car4.Location = new System.Drawing.Point(12, 21);
            this.Car4.Name = "Car4";
            this.Car4.Size = new System.Drawing.Size(141, 96);
            this.Car4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car4.TabIndex = 3;
            this.Car4.TabStop = false;
            // 
            // Car3
            // 
            this.Car3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Car3.Image = global::Task_9.Properties.Resources._240_F_246680613_v2Rclar3CN0vRuOtlN3r1MlVfP;
            this.Car3.Location = new System.Drawing.Point(797, 21);
            this.Car3.Name = "Car3";
            this.Car3.Size = new System.Drawing.Size(134, 96);
            this.Car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car3.TabIndex = 2;
            this.Car3.TabStop = false;
            this.Car3.Click += new System.EventHandler(this.Car3_Click);
            // 
            // Car2
            // 
            this.Car2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Car2.Image = global::Task_9.Properties.Resources._240_F_246680613_v2Rclar3CN0vRuOtlN3r1MlVfP2D;
            this.Car2.Location = new System.Drawing.Point(797, 352);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(134, 96);
            this.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car2.TabIndex = 1;
            this.Car2.TabStop = false;
            // 
            // Car1
            // 
            this.Car1.Image = global::Task_9.Properties.Resources._240_F_246680613_v2Rclar3CN0vRuOtlN3r1MlVfP2Dqafb;
            this.Car1.Location = new System.Drawing.Point(13, 352);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(141, 96);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car1.TabIndex = 0;
            this.Car1.TabStop = false;
            this.Car1.Click += new System.EventHandler(this.Car1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(943, 550);
            this.Controls.Add(this.btnGear4);
            this.Controls.Add(this.btnGear3);
            this.Controls.Add(this.btnGear2);
            this.Controls.Add(this.btnGear1);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.btnBrake);
            this.Controls.Add(this.Car4);
            this.Controls.Add(this.Car3);
            this.Controls.Add(this.Car2);
            this.Controls.Add(this.Car1);
            this.Name = "Form1";
            this.Text = "Car Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Car4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.PictureBox Car2;
        private System.Windows.Forms.PictureBox Car3;
        private System.Windows.Forms.PictureBox Car4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button btnBrake;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnGear1;
        private System.Windows.Forms.Button btnGear2;
        private System.Windows.Forms.Button btnGear3;
        private System.Windows.Forms.Button btnGear4;
    }
}

