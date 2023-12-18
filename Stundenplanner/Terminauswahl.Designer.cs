namespace Stundenplanner
{
    partial class Terminauswahl
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
            this.senden = new System.Windows.Forms.Button();
            this.ID_box = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ID_box)).BeginInit();
            this.SuspendLayout();
            // 
            // senden
            // 
            this.senden.Location = new System.Drawing.Point(58, 103);
            this.senden.Name = "senden";
            this.senden.Size = new System.Drawing.Size(75, 23);
            this.senden.TabIndex = 1;
            this.senden.Text = "Senden";
            this.senden.UseVisualStyleBackColor = true;
            this.senden.Click += new System.EventHandler(this.senden_Click);
            // 
            // ID_box
            // 
            this.ID_box.Location = new System.Drawing.Point(58, 41);
            this.ID_box.Name = "ID_box";
            this.ID_box.Size = new System.Drawing.Size(75, 20);
            this.ID_box.TabIndex = 2;
            // 
            // Terminauswahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 174);
            this.Controls.Add(this.ID_box);
            this.Controls.Add(this.senden);
            this.Name = "Terminauswahl";
            this.Text = "Terminauswahl";
            ((System.ComponentModel.ISupportInitialize)(this.ID_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button senden;
        private System.Windows.Forms.NumericUpDown ID_box;
    }
}