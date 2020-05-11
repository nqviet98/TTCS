namespace GameDoMin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.paldomin = new System.Windows.Forms.Panel();
            this.lbsoo = new System.Windows.Forms.Label();
            this.lbsomin = new System.Windows.Forms.Label();
            this.btnplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paldomin
            // 
            this.paldomin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paldomin.Location = new System.Drawing.Point(12, 56);
            this.paldomin.Name = "paldomin";
            this.paldomin.Size = new System.Drawing.Size(299, 304);
            this.paldomin.TabIndex = 0;
            // 
            // lbsoo
            // 
            this.lbsoo.AutoSize = true;
            this.lbsoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsoo.Location = new System.Drawing.Point(12, 9);
            this.lbsoo.Name = "lbsoo";
            this.lbsoo.Size = new System.Drawing.Size(30, 24);
            this.lbsoo.TabIndex = 1;
            this.lbsoo.Text = "00";
            // 
            // lbsomin
            // 
            this.lbsomin.AutoSize = true;
            this.lbsomin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsomin.Location = new System.Drawing.Point(281, 9);
            this.lbsomin.Name = "lbsomin";
            this.lbsomin.Size = new System.Drawing.Size(30, 24);
            this.lbsomin.TabIndex = 1;
            this.lbsomin.Text = "00";
            // 
            // btnplay
            // 
            this.btnplay.Image = global::GameDoMin.Properties.Resources.smiley1;
            this.btnplay.Location = new System.Drawing.Point(141, 12);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(35, 35);
            this.btnplay.TabIndex = 2;
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnplay_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 372);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.lbsomin);
            this.Controls.Add(this.lbsoo);
            this.Controls.Add(this.paldomin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paldomin;
        private System.Windows.Forms.Label lbsoo;
        private System.Windows.Forms.Label lbsomin;
        private System.Windows.Forms.Button btnplay;
    }
}

