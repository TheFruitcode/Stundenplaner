namespace Stundenplanner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.speichern_btn = new System.Windows.Forms.Button();
            this.loeschen_btn = new System.Windows.Forms.Button();
            this.termine_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(59, 36);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(59, 226);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(178, 97);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // speichern_btn
            // 
            this.speichern_btn.Location = new System.Drawing.Point(59, 347);
            this.speichern_btn.Name = "speichern_btn";
            this.speichern_btn.Size = new System.Drawing.Size(75, 23);
            this.speichern_btn.TabIndex = 2;
            this.speichern_btn.Text = "Speichern";
            this.speichern_btn.UseVisualStyleBackColor = true;
            this.speichern_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // loeschen_btn
            // 
            this.loeschen_btn.Location = new System.Drawing.Point(162, 347);
            this.loeschen_btn.Name = "loeschen_btn";
            this.loeschen_btn.Size = new System.Drawing.Size(75, 23);
            this.loeschen_btn.TabIndex = 3;
            this.loeschen_btn.Text = "Loeschen";
            this.loeschen_btn.UseVisualStyleBackColor = true;
            this.loeschen_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // termine_btn
            // 
            this.termine_btn.Location = new System.Drawing.Point(59, 391);
            this.termine_btn.Name = "termine_btn";
            this.termine_btn.Size = new System.Drawing.Size(178, 26);
            this.termine_btn.TabIndex = 4;
            this.termine_btn.Text = "Termine";
            this.termine_btn.UseVisualStyleBackColor = true;
            this.termine_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 512);
            this.Controls.Add(this.termine_btn);
            this.Controls.Add(this.loeschen_btn);
            this.Controls.Add(this.speichern_btn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button speichern_btn;
        private System.Windows.Forms.Button loeschen_btn;
        private System.Windows.Forms.Button termine_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

