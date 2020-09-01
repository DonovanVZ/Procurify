namespace Procurify.Sub_Controls
{
    partial class Stat
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
            this.pnlStatControls = new System.Windows.Forms.Panel();
            this.amount = new System.Windows.Forms.Label();
            this.bottomCaption = new System.Windows.Forms.Label();
            this.topCaption = new System.Windows.Forms.Label();
            this.pnlStatControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStatControls
            // 
            this.pnlStatControls.BackColor = System.Drawing.Color.White;
            this.pnlStatControls.Controls.Add(this.amount);
            this.pnlStatControls.Controls.Add(this.bottomCaption);
            this.pnlStatControls.Controls.Add(this.topCaption);
            this.pnlStatControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatControls.Location = new System.Drawing.Point(0, 0);
            this.pnlStatControls.Name = "pnlStatControls";
            this.pnlStatControls.Size = new System.Drawing.Size(115, 115);
            this.pnlStatControls.TabIndex = 0;
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ForeColor = System.Drawing.Color.Navy;
            this.amount.Location = new System.Drawing.Point(39, 10);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(34, 40);
            this.amount.TabIndex = 5;
            this.amount.Text = "0";
            // 
            // bottomCaption
            // 
            this.bottomCaption.AutoSize = true;
            this.bottomCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomCaption.Location = new System.Drawing.Point(28, 86);
            this.bottomCaption.Name = "bottomCaption";
            this.bottomCaption.Size = new System.Drawing.Size(56, 15);
            this.bottomCaption.TabIndex = 4;
            this.bottomCaption.Text = "Caption";
            // 
            // topCaption
            // 
            this.topCaption.AutoSize = true;
            this.topCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topCaption.Location = new System.Drawing.Point(28, 61);
            this.topCaption.Name = "topCaption";
            this.topCaption.Size = new System.Drawing.Size(56, 15);
            this.topCaption.TabIndex = 3;
            this.topCaption.Text = "Caption";
            // 
            // Stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlStatControls);
            this.Name = "Stat";
            this.Size = new System.Drawing.Size(115, 115);
            this.Load += new System.EventHandler(this.Stat_Load);
            this.pnlStatControls.ResumeLayout(false);
            this.pnlStatControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStatControls;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label bottomCaption;
        private System.Windows.Forms.Label topCaption;
    }
}
