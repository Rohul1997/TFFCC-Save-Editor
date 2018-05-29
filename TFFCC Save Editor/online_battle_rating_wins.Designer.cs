namespace TFFCC_Save_Editor
{
    partial class online_battle_rating_wins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(online_battle_rating_wins));
            this.anyone_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.anyone_label = new System.Windows.Forms.Label();
            this.friends_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.friends_label = new System.Windows.Forms.Label();
            this.total_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.total_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.anyone_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friends_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // anyone_numericUpDown
            // 
            this.anyone_numericUpDown.Enabled = false;
            this.anyone_numericUpDown.Location = new System.Drawing.Point(199, 7);
            this.anyone_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.anyone_numericUpDown.Name = "anyone_numericUpDown";
            this.anyone_numericUpDown.Size = new System.Drawing.Size(51, 20);
            this.anyone_numericUpDown.TabIndex = 0;
            this.anyone_numericUpDown.ValueChanged += new System.EventHandler(this.Write_rating);
            // 
            // anyone_label
            // 
            this.anyone_label.AutoSize = true;
            this.anyone_label.Location = new System.Drawing.Point(147, 9);
            this.anyone_label.Name = "anyone_label";
            this.anyone_label.Size = new System.Drawing.Size(46, 13);
            this.anyone_label.TabIndex = 1;
            this.anyone_label.Text = "Anyone:";
            // 
            // friends_numericUpDown
            // 
            this.friends_numericUpDown.Enabled = false;
            this.friends_numericUpDown.Location = new System.Drawing.Point(319, 7);
            this.friends_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.friends_numericUpDown.Name = "friends_numericUpDown";
            this.friends_numericUpDown.Size = new System.Drawing.Size(51, 20);
            this.friends_numericUpDown.TabIndex = 0;
            this.friends_numericUpDown.ValueChanged += new System.EventHandler(this.Write_rating);
            // 
            // friends_label
            // 
            this.friends_label.AutoSize = true;
            this.friends_label.Location = new System.Drawing.Point(267, 9);
            this.friends_label.Name = "friends_label";
            this.friends_label.Size = new System.Drawing.Size(44, 13);
            this.friends_label.TabIndex = 1;
            this.friends_label.Text = "Friends:";
            // 
            // total_numericUpDown
            // 
            this.total_numericUpDown.Enabled = false;
            this.total_numericUpDown.Location = new System.Drawing.Point(79, 7);
            this.total_numericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.total_numericUpDown.Name = "total_numericUpDown";
            this.total_numericUpDown.Size = new System.Drawing.Size(51, 20);
            this.total_numericUpDown.TabIndex = 0;
            this.total_numericUpDown.ValueChanged += new System.EventHandler(this.Write_rating);
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Location = new System.Drawing.Point(12, 9);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(61, 13);
            this.total_label.TabIndex = 1;
            this.total_label.Text = "Total Wins:";
            // 
            // online_battle_rating_wins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 36);
            this.Controls.Add(this.friends_label);
            this.Controls.Add(this.friends_numericUpDown);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.total_numericUpDown);
            this.Controls.Add(this.anyone_label);
            this.Controls.Add(this.anyone_numericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "online_battle_rating_wins";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Battle Rating Wins";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.anyone_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friends_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown anyone_numericUpDown;
        private System.Windows.Forms.Label anyone_label;
        private System.Windows.Forms.NumericUpDown friends_numericUpDown;
        private System.Windows.Forms.Label friends_label;
        private System.Windows.Forms.NumericUpDown total_numericUpDown;
        private System.Windows.Forms.Label total_label;
    }
}