namespace ZicZacZappp
{
    partial class OnePlayerName
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
            this.oneName = new System.Windows.Forms.TextBox();
            this.Cancelbt = new System.Windows.Forms.Button();
            this.Playbt = new System.Windows.Forms.Button();
            this.backsheep = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backsheep)).BeginInit();
            this.SuspendLayout();
            // 
            // oneName
            // 
            this.oneName.Location = new System.Drawing.Point(182, 83);
            this.oneName.Name = "oneName";
            this.oneName.Size = new System.Drawing.Size(176, 20);
            this.oneName.TabIndex = 5;
            // 
            // Cancelbt
            // 
            this.Cancelbt.Location = new System.Drawing.Point(283, 120);
            this.Cancelbt.Name = "Cancelbt";
            this.Cancelbt.Size = new System.Drawing.Size(75, 23);
            this.Cancelbt.TabIndex = 7;
            this.Cancelbt.Text = "Cancel";
            this.Cancelbt.UseVisualStyleBackColor = true;
            this.Cancelbt.Click += new System.EventHandler(this.Cancelbt_Click);
            // 
            // Playbt
            // 
            this.Playbt.Location = new System.Drawing.Point(182, 120);
            this.Playbt.Name = "Playbt";
            this.Playbt.Size = new System.Drawing.Size(75, 23);
            this.Playbt.TabIndex = 6;
            this.Playbt.Text = "Play";
            this.Playbt.UseVisualStyleBackColor = true;
            this.Playbt.Click += new System.EventHandler(this.Playbt_Click);
            // 
            // backsheep
            // 
            this.backsheep.Image = global::ZicZacZappp.Properties.Resources.bs5;
            this.backsheep.Location = new System.Drawing.Point(34, 65);
            this.backsheep.Name = "backsheep";
            this.backsheep.Size = new System.Drawing.Size(50, 50);
            this.backsheep.TabIndex = 9;
            this.backsheep.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dance fever", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = " : Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Clip", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "One Player";
            // 
            // OnePlayerName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 162);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backsheep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancelbt);
            this.Controls.Add(this.Playbt);
            this.Controls.Add(this.oneName);
            this.Name = "OnePlayerName";
            this.Text = "OnePlayerName";
            ((System.ComponentModel.ISupportInitialize)(this.backsheep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oneName;
        private System.Windows.Forms.Button Cancelbt;
        private System.Windows.Forms.Button Playbt;
        private System.Windows.Forms.PictureBox backsheep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}