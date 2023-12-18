namespace Stundenplanner
{
    partial class Termine
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
            this.Terminliste = new System.Windows.Forms.RichTextBox();
            this.TerminLoeschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Terminliste
            // 
            this.Terminliste.Enabled = false;
            this.Terminliste.Location = new System.Drawing.Point(12, 12);
            this.Terminliste.Name = "Terminliste";
            this.Terminliste.Size = new System.Drawing.Size(359, 441);
            this.Terminliste.TabIndex = 0;
            this.Terminliste.Text = "";
            // 
            // TerminLoeschen
            // 
            this.TerminLoeschen.Location = new System.Drawing.Point(138, 459);
            this.TerminLoeschen.Name = "TerminLoeschen";
            this.TerminLoeschen.Size = new System.Drawing.Size(104, 33);
            this.TerminLoeschen.TabIndex = 1;
            this.TerminLoeschen.Text = "TerminLoeschen";
            this.TerminLoeschen.UseVisualStyleBackColor = true;
            this.TerminLoeschen.Click += new System.EventHandler(this.TerminLoeschen_Click);
            // 
            // Termine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 504);
            this.Controls.Add(this.TerminLoeschen);
            this.Controls.Add(this.Terminliste);
            this.Name = "Termine";
            this.Text = "Termine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Terminliste;
        private System.Windows.Forms.Button TerminLoeschen;
    }
}