namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonStopRecord = new System.Windows.Forms.Button();
            this.ButtonRecord = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PathFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonStopRecord
            // 
            this.ButtonStopRecord.Location = new System.Drawing.Point(498, 99);
            this.ButtonStopRecord.Name = "ButtonStopRecord";
            this.ButtonStopRecord.Size = new System.Drawing.Size(226, 96);
            this.ButtonStopRecord.TabIndex = 0;
            this.ButtonStopRecord.Text = "Cut / Save";
            this.ButtonStopRecord.UseVisualStyleBackColor = true;
            this.ButtonStopRecord.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ButtonRecord
            // 
            this.ButtonRecord.Location = new System.Drawing.Point(74, 99);
            this.ButtonRecord.Name = "ButtonRecord";
            this.ButtonRecord.Size = new System.Drawing.Size(177, 86);
            this.ButtonRecord.TabIndex = 1;
            this.ButtonRecord.Text = "Record";
            this.ButtonRecord.UseVisualStyleBackColor = true;
            this.ButtonRecord.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 190);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 150);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PathFile
            // 
            this.PathFile.Location = new System.Drawing.Point(386, 395);
            this.PathFile.Name = "PathFile";
            this.PathFile.Size = new System.Drawing.Size(338, 20);
            this.PathFile.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Définissez le path du fichier à modifier";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonRecord);
            this.Controls.Add(this.ButtonStopRecord);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStopRecord;
        private System.Windows.Forms.Button ButtonRecord;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PathFile;
        private System.Windows.Forms.Label label1;
    }
}

