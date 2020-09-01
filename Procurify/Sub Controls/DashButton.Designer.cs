namespace Procurify.Sub_Controls
{
    partial class DashButton
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
            this.dashButtonControls = new System.Windows.Forms.Panel();
            this.bottomCaption = new System.Windows.Forms.Label();
            this.topCaption = new System.Windows.Forms.Label();
            this.buttonIcon = new System.Windows.Forms.PictureBox();
            this.dashButtonControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // dashButtonControls
            // 
            this.dashButtonControls.BackColor = System.Drawing.Color.White;
            this.dashButtonControls.Controls.Add(this.bottomCaption);
            this.dashButtonControls.Controls.Add(this.topCaption);
            this.dashButtonControls.Controls.Add(this.buttonIcon);
            this.dashButtonControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashButtonControls.Location = new System.Drawing.Point(0, 0);
            this.dashButtonControls.Name = "dashButtonControls";
            this.dashButtonControls.Size = new System.Drawing.Size(130, 130);
            this.dashButtonControls.TabIndex = 0;
            this.dashButtonControls.Click += new System.EventHandler(this.dashButtonControls_Click);
            // 
            // bottomCaption
            // 
            this.bottomCaption.AutoSize = true;
            this.bottomCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomCaption.ForeColor = System.Drawing.Color.Navy;
            this.bottomCaption.Location = new System.Drawing.Point(35, 106);
            this.bottomCaption.Name = "bottomCaption";
            this.bottomCaption.Size = new System.Drawing.Size(61, 16);
            this.bottomCaption.TabIndex = 3;
            this.bottomCaption.Text = "Caption";
            this.bottomCaption.Click += new System.EventHandler(this.dashButtonControls_Click);
            // 
            // topCaption
            // 
            this.topCaption.AutoSize = true;
            this.topCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topCaption.ForeColor = System.Drawing.Color.Navy;
            this.topCaption.Location = new System.Drawing.Point(35, 84);
            this.topCaption.Name = "topCaption";
            this.topCaption.Size = new System.Drawing.Size(61, 16);
            this.topCaption.TabIndex = 2;
            this.topCaption.Text = "Caption";
            this.topCaption.Click += new System.EventHandler(this.dashButtonControls_Click);
            // 
            // buttonIcon
            // 
            this.buttonIcon.Location = new System.Drawing.Point(33, 7);
            this.buttonIcon.Name = "buttonIcon";
            this.buttonIcon.Size = new System.Drawing.Size(65, 65);
            this.buttonIcon.TabIndex = 1;
            this.buttonIcon.TabStop = false;
            this.buttonIcon.Click += new System.EventHandler(this.dashButtonControls_Click);
            // 
            // DashButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dashButtonControls);
            this.Name = "DashButton";
            this.Size = new System.Drawing.Size(130, 130);
            this.Load += new System.EventHandler(this.DashButton_Load);
            this.dashButtonControls.ResumeLayout(false);
            this.dashButtonControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dashButtonControls;
        private System.Windows.Forms.Label bottomCaption;
        private System.Windows.Forms.Label topCaption;
        private System.Windows.Forms.PictureBox buttonIcon;
    }
}
