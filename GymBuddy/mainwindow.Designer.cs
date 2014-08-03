namespace GymBuddy
{
    partial class mainwindow
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
            this.addExercise = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.exerBox = new System.Windows.Forms.TextBox();
            this.repsBox = new System.Windows.Forms.TextBox();
            this.exerLabel = new System.Windows.Forms.Label();
            this.repsLabel = new System.Windows.Forms.Label();
            this.Announcer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addExercise
            // 
            this.addExercise.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addExercise.Location = new System.Drawing.Point(12, 61);
            this.addExercise.Name = "addExercise";
            this.addExercise.Size = new System.Drawing.Size(75, 57);
            this.addExercise.TabIndex = 0;
            this.addExercise.Text = "Lole";
            this.addExercise.UseVisualStyleBackColor = false;
            this.addExercise.Click += new System.EventHandler(this.addExer_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(124, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // exerBox
            // 
            this.exerBox.Location = new System.Drawing.Point(210, 61);
            this.exerBox.Name = "exerBox";
            this.exerBox.Size = new System.Drawing.Size(100, 20);
            this.exerBox.TabIndex = 2;
            this.exerBox.TextChanged += new System.EventHandler(this.exerBox_TextChanged);
            // 
            // repsBox
            // 
            this.repsBox.Location = new System.Drawing.Point(326, 61);
            this.repsBox.Name = "repsBox";
            this.repsBox.Size = new System.Drawing.Size(100, 20);
            this.repsBox.TabIndex = 3;
            this.repsBox.TextChanged += new System.EventHandler(this.repsBox_TextChanged);
            // 
            // exerLabel
            // 
            this.exerLabel.AutoSize = true;
            this.exerLabel.Location = new System.Drawing.Point(207, 45);
            this.exerLabel.Name = "exerLabel";
            this.exerLabel.Size = new System.Drawing.Size(47, 13);
            this.exerLabel.TabIndex = 4;
            this.exerLabel.Text = "Exercise";
            // 
            // repsLabel
            // 
            this.repsLabel.AutoSize = true;
            this.repsLabel.Location = new System.Drawing.Point(323, 45);
            this.repsLabel.Name = "repsLabel";
            this.repsLabel.Size = new System.Drawing.Size(32, 13);
            this.repsLabel.TabIndex = 5;
            this.repsLabel.Text = "Reps";
            // 
            // Announcer
            // 
            this.Announcer.Location = new System.Drawing.Point(12, 284);
            this.Announcer.Name = "Announcer";
            this.Announcer.Size = new System.Drawing.Size(925, 20);
            this.Announcer.TabIndex = 6;
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 316);
            this.Controls.Add(this.Announcer);
            this.Controls.Add(this.repsLabel);
            this.Controls.Add(this.exerLabel);
            this.Controls.Add(this.repsBox);
            this.Controls.Add(this.exerBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.addExercise);
            this.Name = "mainwindow";
            this.Text = "GymBuddy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addExercise;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox exerBox;
        private System.Windows.Forms.TextBox repsBox;
        private System.Windows.Forms.Label exerLabel;
        private System.Windows.Forms.Label repsLabel;
        private System.Windows.Forms.TextBox Announcer;
    }
}

