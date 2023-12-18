namespace Stundenplanner
{
    partial class View
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
            this.Calender = new System.Windows.Forms.MonthCalendar();
            this.Terminbeschreibung = new System.Windows.Forms.RichTextBox();
            this.speichern_btn = new System.Windows.Forms.Button();
            this.loeschen_btn = new System.Windows.Forms.Button();
            this.termine_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.laufende = new System.Windows.Forms.Button();
            this.abgelaufende = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calender
            // 
            this.Calender.Location = new System.Drawing.Point(59, 36);
            this.Calender.Name = "Calender";
            this.Calender.TabIndex = 0;
            // 
            // Terminbeschreibung
            // 
            this.Terminbeschreibung.Location = new System.Drawing.Point(59, 226);
            this.Terminbeschreibung.Name = "Terminbeschreibung";
            this.Terminbeschreibung.Size = new System.Drawing.Size(178, 97);
            this.Terminbeschreibung.TabIndex = 1;
            this.Terminbeschreibung.Text = "";
            // 
            // speichern_btn
            // 
            this.speichern_btn.Location = new System.Drawing.Point(59, 347);
            this.speichern_btn.Name = "speichern_btn";
            this.speichern_btn.Size = new System.Drawing.Size(75, 23);
            this.speichern_btn.TabIndex = 2;
            this.speichern_btn.Text = "Speichern";
            this.speichern_btn.UseVisualStyleBackColor = true;
            this.speichern_btn.Click += new System.EventHandler(this.speichern_btn_Click);
            // 
            // loeschen_btn
            // 
            this.loeschen_btn.Location = new System.Drawing.Point(162, 347);
            this.loeschen_btn.Name = "loeschen_btn";
            this.loeschen_btn.Size = new System.Drawing.Size(75, 23);
            this.loeschen_btn.TabIndex = 3;
            this.loeschen_btn.Text = "Loeschen";
            this.loeschen_btn.UseVisualStyleBackColor = true;
            this.loeschen_btn.Click += new System.EventHandler(this.loeschen_btn_Click);
            // 
            // termine_btn
            // 
            this.termine_btn.Location = new System.Drawing.Point(59, 391);
            this.termine_btn.Name = "termine_btn";
            this.termine_btn.Size = new System.Drawing.Size(178, 26);
            this.termine_btn.TabIndex = 4;
            this.termine_btn.Text = "Termine";
            this.termine_btn.UseVisualStyleBackColor = true;
            this.termine_btn.Click += new System.EventHandler(this.termine_btn_Click);
            // 
            // laufende
            // 
            this.laufende.Location = new System.Drawing.Point(59, 435);
            this.laufende.Name = "laufende";
            this.laufende.Size = new System.Drawing.Size(178, 23);
            this.laufende.TabIndex = 5;
            this.laufende.Text = "laufende Aufgaben";
            this.laufende.UseVisualStyleBackColor = true;
            this.laufende.Click += new System.EventHandler(this.laufende_Click);
            // 
            // abgelaufende
            // 
            this.abgelaufende.Location = new System.Drawing.Point(59, 464);
            this.abgelaufende.Name = "abgelaufende";
            this.abgelaufende.Size = new System.Drawing.Size(178, 23);
            this.abgelaufende.TabIndex = 6;
            this.abgelaufende.Text = "abgelaufene Aufgaben";
            this.abgelaufende.UseVisualStyleBackColor = true;
            this.abgelaufende.Click += new System.EventHandler(this.abgelaufende_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 512);
            this.Controls.Add(this.abgelaufende);
            this.Controls.Add(this.laufende);
            this.Controls.Add(this.termine_btn);
            this.Controls.Add(this.loeschen_btn);
            this.Controls.Add(this.speichern_btn);
            this.Controls.Add(this.Terminbeschreibung);
            this.Controls.Add(this.Calender);
            this.Name = "View";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calender;
        private System.Windows.Forms.RichTextBox Terminbeschreibung;
        private System.Windows.Forms.Button speichern_btn;
        private System.Windows.Forms.Button loeschen_btn;
        private System.Windows.Forms.Button termine_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button laufende;
        private System.Windows.Forms.Button abgelaufende;
    }
}

