namespace Procurify.Sub_Controls
{
    partial class ControlFrame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.header = new System.Windows.Forms.Panel();
            this.locationName = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.header.Controls.Add(this.locationName);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1013, 55);
            this.header.TabIndex = 0;
            // 
            // locationName
            // 
            this.locationName.AutoSize = true;
            this.locationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationName.ForeColor = System.Drawing.Color.White;
            this.locationName.Location = new System.Drawing.Point(85, 15);
            this.locationName.Name = "locationName";
            this.locationName.Size = new System.Drawing.Size(81, 24);
            this.locationName.TabIndex = 0;
            this.locationName.Text = "Location";
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.White;
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 55);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1013, 564);
            this.content.TabIndex = 1;
            // 
            // ControlFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.content);
            this.Controls.Add(this.header);
            this.Name = "ControlFrame";
            this.Size = new System.Drawing.Size(1013, 619);
            this.Load += new System.EventHandler(this.ControlFrame_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label locationName;
        private System.Windows.Forms.Panel content;
    }
}
