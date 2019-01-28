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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonStopRecord
            // 
            this.ButtonStopRecord.Location = new System.Drawing.Point(747, 152);
            this.ButtonStopRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonStopRecord.Name = "ButtonStopRecord";
            this.ButtonStopRecord.Size = new System.Drawing.Size(339, 148);
            this.ButtonStopRecord.TabIndex = 0;
            this.ButtonStopRecord.Text = "Cut / Save";
            this.ButtonStopRecord.UseVisualStyleBackColor = true;
            this.ButtonStopRecord.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ButtonRecord
            // 
            this.ButtonRecord.Location = new System.Drawing.Point(111, 152);
            this.ButtonRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonRecord.Name = "ButtonRecord";
            this.ButtonRecord.Size = new System.Drawing.Size(266, 132);
            this.ButtonRecord.TabIndex = 1;
            this.ButtonRecord.Text = "Record";
            this.ButtonRecord.UseVisualStyleBackColor = true;
            this.ButtonRecord.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(49, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 231);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonRecord);
            this.Controls.Add(this.ButtonStopRecord);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonStopRecord;
        private System.Windows.Forms.Button ButtonRecord;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

