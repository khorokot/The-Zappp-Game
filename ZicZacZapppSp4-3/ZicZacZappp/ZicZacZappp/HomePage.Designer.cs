﻿namespace ZicZacZappp
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.Onebt = new System.Windows.Forms.Button();
            this.Twobt = new System.Windows.Forms.Button();
            this.Exitbt = new System.Windows.Forms.Button();
            this.howtobt = new System.Windows.Forms.Button();
            this.battle5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Clip", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(61, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zic Zac Zappp";
            // 
            // Onebt
            // 
            this.Onebt.BackgroundImage = global::ZicZacZappp.Properties.Resources.sheep;
            this.Onebt.Font = new System.Drawing.Font("Chiller", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Onebt.Location = new System.Drawing.Point(38, 309);
            this.Onebt.Name = "Onebt";
            this.Onebt.Size = new System.Drawing.Size(124, 43);
            this.Onebt.TabIndex = 2;
            this.Onebt.Text = "3 x 3";
            this.Onebt.UseVisualStyleBackColor = true;
            this.Onebt.Click += new System.EventHandler(this.Onebt_Click);
            // 
            // Twobt
            // 
            this.Twobt.BackgroundImage = global::ZicZacZappp.Properties.Resources.sheep;
            this.Twobt.Font = new System.Drawing.Font("Chiller", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Twobt.Location = new System.Drawing.Point(38, 358);
            this.Twobt.Name = "Twobt";
            this.Twobt.Size = new System.Drawing.Size(124, 43);
            this.Twobt.TabIndex = 3;
            this.Twobt.Text = "4 x 4";
            this.Twobt.UseVisualStyleBackColor = true;
            this.Twobt.Click += new System.EventHandler(this.Twobt_Click);
            // 
            // Exitbt
            // 
            this.Exitbt.BackgroundImage = global::ZicZacZappp.Properties.Resources.sheep2;
            this.Exitbt.Font = new System.Drawing.Font("Chiller", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbt.Location = new System.Drawing.Point(263, 416);
            this.Exitbt.Name = "Exitbt";
            this.Exitbt.Size = new System.Drawing.Size(109, 34);
            this.Exitbt.TabIndex = 4;
            this.Exitbt.Text = "Exit";
            this.Exitbt.UseVisualStyleBackColor = true;
            this.Exitbt.Click += new System.EventHandler(this.Exitbt_Click);
            // 
            // howtobt
            // 
            this.howtobt.BackgroundImage = global::ZicZacZappp.Properties.Resources.sheep;
            this.howtobt.Font = new System.Drawing.Font("Chiller", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howtobt.Location = new System.Drawing.Point(38, 254);
            this.howtobt.Name = "howtobt";
            this.howtobt.Size = new System.Drawing.Size(124, 49);
            this.howtobt.TabIndex = 5;
            this.howtobt.Text = "How To Play";
            this.howtobt.UseVisualStyleBackColor = true;
            this.howtobt.Click += new System.EventHandler(this.howtobt_Click);
            // 
            // battle5
            // 
            this.battle5.BackgroundImage = global::ZicZacZappp.Properties.Resources.sheep;
            this.battle5.Font = new System.Drawing.Font("Chiller", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battle5.Location = new System.Drawing.Point(38, 407);
            this.battle5.Name = "battle5";
            this.battle5.Size = new System.Drawing.Size(124, 43);
            this.battle5.TabIndex = 6;
            this.battle5.Text = "5 x 5";
            this.battle5.UseVisualStyleBackColor = true;
            this.battle5.Click += new System.EventHandler(this.battle5_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::ZicZacZappp.Properties.Resources.Home1;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.battle5);
            this.Controls.Add(this.howtobt);
            this.Controls.Add(this.Exitbt);
            this.Controls.Add(this.Twobt);
            this.Controls.Add(this.Onebt);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Onebt;
        private System.Windows.Forms.Button Twobt;
        private System.Windows.Forms.Button Exitbt;
        private System.Windows.Forms.Button howtobt;
        private System.Windows.Forms.Button battle5;
    }
}