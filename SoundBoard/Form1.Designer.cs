namespace SoundBoard
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
            this.Crickets = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Frog = new System.Windows.Forms.Button();
            this.Disastah = new System.Windows.Forms.Button();
            this.CryBaby = new System.Windows.Forms.Button();
            this.Patience = new System.Windows.Forms.Button();
            this.Brutal = new System.Windows.Forms.Button();
            this.Ehto = new System.Windows.Forms.Button();
            this.AllDead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Crickets
            // 
            this.Crickets.Location = new System.Drawing.Point(55, 104);
            this.Crickets.Name = "Crickets";
            this.Crickets.Size = new System.Drawing.Size(75, 23);
            this.Crickets.TabIndex = 1;
            this.Crickets.Text = "Crickets";
            this.Crickets.UseVisualStyleBackColor = true;
            this.Crickets.Click += new System.EventHandler(this.Crickets_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dota 2 Sounds";
            // 
            // Frog
            // 
            this.Frog.Location = new System.Drawing.Point(191, 104);
            this.Frog.Name = "Frog";
            this.Frog.Size = new System.Drawing.Size(75, 23);
            this.Frog.TabIndex = 3;
            this.Frog.Text = "Frog";
            this.Frog.UseVisualStyleBackColor = true;
            this.Frog.Click += new System.EventHandler(this.Frog_Click);
            // 
            // Disastah
            // 
            this.Disastah.Location = new System.Drawing.Point(319, 104);
            this.Disastah.Name = "Disastah";
            this.Disastah.Size = new System.Drawing.Size(75, 23);
            this.Disastah.TabIndex = 4;
            this.Disastah.Text = "Disastah";
            this.Disastah.UseVisualStyleBackColor = true;
            this.Disastah.Click += new System.EventHandler(this.Disastah_Click);
            // 
            // CryBaby
            // 
            this.CryBaby.Location = new System.Drawing.Point(459, 104);
            this.CryBaby.Name = "CryBaby";
            this.CryBaby.Size = new System.Drawing.Size(75, 23);
            this.CryBaby.TabIndex = 5;
            this.CryBaby.Text = "Crybaby";
            this.CryBaby.UseVisualStyleBackColor = true;
            this.CryBaby.Click += new System.EventHandler(this.CryBaby_Click);
            // 
            // Patience
            // 
            this.Patience.Location = new System.Drawing.Point(599, 104);
            this.Patience.Name = "Patience";
            this.Patience.Size = new System.Drawing.Size(75, 23);
            this.Patience.TabIndex = 6;
            this.Patience.Text = "Patience";
            this.Patience.UseVisualStyleBackColor = true;
            this.Patience.Click += new System.EventHandler(this.Patience_Click);
            // 
            // Brutal
            // 
            this.Brutal.Location = new System.Drawing.Point(55, 177);
            this.Brutal.Name = "Brutal";
            this.Brutal.Size = new System.Drawing.Size(211, 23);
            this.Brutal.TabIndex = 7;
            this.Brutal.Text = "Brutal. Savage. Rekt";
            this.Brutal.UseVisualStyleBackColor = true;
            this.Brutal.Click += new System.EventHandler(this.Brutal_Click);
            // 
            // Ehto
            // 
            this.Ehto.Location = new System.Drawing.Point(459, 177);
            this.Ehto.Name = "Ehto";
            this.Ehto.Size = new System.Drawing.Size(215, 23);
            this.Ehto.TabIndex = 8;
            this.Ehto.Text = "Ehto GG";
            this.Ehto.UseVisualStyleBackColor = true;
            this.Ehto.Click += new System.EventHandler(this.Ehto_Click);
            // 
            // AllDead
            // 
            this.AllDead.Location = new System.Drawing.Point(319, 242);
            this.AllDead.Name = "AllDead";
            this.AllDead.Size = new System.Drawing.Size(75, 23);
            this.AllDead.TabIndex = 9;
            this.AllDead.Text = "All Dead";
            this.AllDead.UseVisualStyleBackColor = true;
            this.AllDead.Click += new System.EventHandler(this.AllDead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 621);
            this.Controls.Add(this.AllDead);
            this.Controls.Add(this.Ehto);
            this.Controls.Add(this.Brutal);
            this.Controls.Add(this.Patience);
            this.Controls.Add(this.CryBaby);
            this.Controls.Add(this.Disastah);
            this.Controls.Add(this.Frog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Crickets);
            this.Name = "Form1";
            this.Text = "SoundBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Crickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Frog;
        private System.Windows.Forms.Button Disastah;
        private System.Windows.Forms.Button CryBaby;
        private System.Windows.Forms.Button Patience;
        private System.Windows.Forms.Button Brutal;
        private System.Windows.Forms.Button Ehto;
        private System.Windows.Forms.Button AllDead;
    }
}

