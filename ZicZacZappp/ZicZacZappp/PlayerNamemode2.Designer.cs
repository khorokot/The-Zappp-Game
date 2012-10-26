namespace ZicZacZappp
{
    partial class PlayerNamemode2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameX = new System.Windows.Forms.TextBox();
            this.nameO = new System.Windows.Forms.TextBox();
            this.Playbt = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.whitesheep = new System.Windows.Forms.PictureBox();
            this.backsheep = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.whitesheep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backsheep)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Clip", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Two Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dance fever", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = " : Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dance fever", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = ": Name";
            // 
            // nameX
            // 
            this.nameX.Location = new System.Drawing.Point(176, 68);
            this.nameX.Name = "nameX";
            this.nameX.Size = new System.Drawing.Size(176, 20);
            this.nameX.TabIndex = 3;
            // 
            // nameO
            // 
            this.nameO.Location = new System.Drawing.Point(176, 127);
            this.nameO.Name = "nameO";
            this.nameO.Size = new System.Drawing.Size(176, 20);
            this.nameO.TabIndex = 4;
            // 
            // Playbt
            // 
            this.Playbt.Location = new System.Drawing.Point(176, 167);
            this.Playbt.Name = "Playbt";
            this.Playbt.Size = new System.Drawing.Size(75, 23);
            this.Playbt.TabIndex = 5;
            this.Playbt.Text = "Play";
            this.Playbt.UseVisualStyleBackColor = true;
            this.Playbt.Click += new System.EventHandler(this.Playbt_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(277, 167);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // whitesheep
            // 
            this.whitesheep.Image = global::ZicZacZappp.Properties.Resources.ws5;
            this.whitesheep.Location = new System.Drawing.Point(28, 105);
            this.whitesheep.Name = "whitesheep";
            this.whitesheep.Size = new System.Drawing.Size(50, 50);
            this.whitesheep.TabIndex = 8;
            this.whitesheep.TabStop = false;
            // 
            // backsheep
            // 
            this.backsheep.Image = global::ZicZacZappp.Properties.Resources.bs5;
            this.backsheep.Location = new System.Drawing.Point(28, 49);
            this.backsheep.Name = "backsheep";
            this.backsheep.Size = new System.Drawing.Size(50, 50);
            this.backsheep.TabIndex = 7;
            this.backsheep.TabStop = false;
            // 
            // TwoPlayerName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 202);
            this.Controls.Add(this.whitesheep);
            this.Controls.Add(this.backsheep);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Playbt);
            this.Controls.Add(this.nameO);
            this.Controls.Add(this.nameX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TwoPlayerName";
            this.Text = "TwoPlayerName";
            ((System.ComponentModel.ISupportInitialize)(this.whitesheep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backsheep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameX;
        private System.Windows.Forms.TextBox nameO;
        private System.Windows.Forms.Button Playbt;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.PictureBox backsheep;
        private System.Windows.Forms.PictureBox whitesheep;
    }
}