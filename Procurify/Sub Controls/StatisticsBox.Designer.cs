namespace Procurify.Sub_Controls
{
    partial class StatisticsBox
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
            this.flpLocalStatistics = new System.Windows.Forms.FlowLayoutPanel();
            this.statAllRequisitionsLocal = new Procurify.Sub_Controls.Stat();
            this.statOpenRequisitionLocal = new Procurify.Sub_Controls.Stat();
            this.statPendingRequisitionLocal = new Procurify.Sub_Controls.Stat();
            this.statApprovedRequisitionLocal = new Procurify.Sub_Controls.Stat();
            this.statDeclinedRequisitionLocal = new Procurify.Sub_Controls.Stat();
            this.statCompletedRequisitionsLocal = new Procurify.Sub_Controls.Stat();
            this.statRFQSentLocal = new Procurify.Sub_Controls.Stat();
            this.statQuotationFinalizedLocal = new Procurify.Sub_Controls.Stat();
            this.statVendorRecommendedLocal = new Procurify.Sub_Controls.Stat();
            this.statVendorSelectedLocal = new Procurify.Sub_Controls.Stat();
            this.statLPOGeneratedLocal = new Procurify.Sub_Controls.Stat();
            this.header = new System.Windows.Forms.Panel();
            this.statisticIcon = new System.Windows.Forms.PictureBox();
            this.statisticHeader = new System.Windows.Forms.Label();
            this.flpLocalStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // flpLocalStatistics
            // 
            this.flpLocalStatistics.Controls.Add(this.statAllRequisitionsLocal);
            this.flpLocalStatistics.Controls.Add(this.statOpenRequisitionLocal);
            this.flpLocalStatistics.Controls.Add(this.statPendingRequisitionLocal);
            this.flpLocalStatistics.Controls.Add(this.statApprovedRequisitionLocal);
            this.flpLocalStatistics.Controls.Add(this.statDeclinedRequisitionLocal);
            this.flpLocalStatistics.Controls.Add(this.statCompletedRequisitionsLocal);
            this.flpLocalStatistics.Controls.Add(this.statRFQSentLocal);
            this.flpLocalStatistics.Controls.Add(this.statQuotationFinalizedLocal);
            this.flpLocalStatistics.Controls.Add(this.statVendorRecommendedLocal);
            this.flpLocalStatistics.Controls.Add(this.statVendorSelectedLocal);
            this.flpLocalStatistics.Controls.Add(this.statLPOGeneratedLocal);
            this.flpLocalStatistics.Location = new System.Drawing.Point(12, 81);
            this.flpLocalStatistics.Name = "flpLocalStatistics";
            this.flpLocalStatistics.Size = new System.Drawing.Size(728, 244);
            this.flpLocalStatistics.TabIndex = 2;
            // 
            // statAllRequisitionsLocal
            // 
            this.statAllRequisitionsLocal.Amount = 2;
            this.statAllRequisitionsLocal.BottomCaption = "Requisitions";
            this.statAllRequisitionsLocal.Location = new System.Drawing.Point(3, 3);
            this.statAllRequisitionsLocal.Name = "statAllRequisitionsLocal";
            this.statAllRequisitionsLocal.Size = new System.Drawing.Size(115, 115);
            this.statAllRequisitionsLocal.TabIndex = 0;
            this.statAllRequisitionsLocal.TopCaption = "All";
            // 
            // statOpenRequisitionLocal
            // 
            this.statOpenRequisitionLocal.Amount = 2;
            this.statOpenRequisitionLocal.BottomCaption = "Requisitions";
            this.statOpenRequisitionLocal.Location = new System.Drawing.Point(124, 3);
            this.statOpenRequisitionLocal.Name = "statOpenRequisitionLocal";
            this.statOpenRequisitionLocal.Size = new System.Drawing.Size(115, 115);
            this.statOpenRequisitionLocal.TabIndex = 1;
            this.statOpenRequisitionLocal.TopCaption = "Open";
            // 
            // statPendingRequisitionLocal
            // 
            this.statPendingRequisitionLocal.Amount = 0;
            this.statPendingRequisitionLocal.BottomCaption = "Requisitions";
            this.statPendingRequisitionLocal.Location = new System.Drawing.Point(245, 3);
            this.statPendingRequisitionLocal.Name = "statPendingRequisitionLocal";
            this.statPendingRequisitionLocal.Size = new System.Drawing.Size(115, 115);
            this.statPendingRequisitionLocal.TabIndex = 2;
            this.statPendingRequisitionLocal.TopCaption = "Pending";
            // 
            // statApprovedRequisitionLocal
            // 
            this.statApprovedRequisitionLocal.Amount = 0;
            this.statApprovedRequisitionLocal.BottomCaption = "Requisitions";
            this.statApprovedRequisitionLocal.Location = new System.Drawing.Point(366, 3);
            this.statApprovedRequisitionLocal.Name = "statApprovedRequisitionLocal";
            this.statApprovedRequisitionLocal.Size = new System.Drawing.Size(115, 115);
            this.statApprovedRequisitionLocal.TabIndex = 3;
            this.statApprovedRequisitionLocal.TopCaption = "Approved";
            // 
            // statDeclinedRequisitionLocal
            // 
            this.statDeclinedRequisitionLocal.Amount = 4;
            this.statDeclinedRequisitionLocal.BottomCaption = "Requisitions";
            this.statDeclinedRequisitionLocal.Location = new System.Drawing.Point(487, 3);
            this.statDeclinedRequisitionLocal.Name = "statDeclinedRequisitionLocal";
            this.statDeclinedRequisitionLocal.Size = new System.Drawing.Size(115, 115);
            this.statDeclinedRequisitionLocal.TabIndex = 4;
            this.statDeclinedRequisitionLocal.TopCaption = "Declined";
            // 
            // statCompletedRequisitionsLocal
            // 
            this.statCompletedRequisitionsLocal.Amount = 6;
            this.statCompletedRequisitionsLocal.BottomCaption = "Requisitions";
            this.statCompletedRequisitionsLocal.Location = new System.Drawing.Point(608, 3);
            this.statCompletedRequisitionsLocal.Name = "statCompletedRequisitionsLocal";
            this.statCompletedRequisitionsLocal.Size = new System.Drawing.Size(115, 115);
            this.statCompletedRequisitionsLocal.TabIndex = 10;
            this.statCompletedRequisitionsLocal.TopCaption = "Completed";
            // 
            // statRFQSentLocal
            // 
            this.statRFQSentLocal.Amount = 3;
            this.statRFQSentLocal.BottomCaption = "Sent";
            this.statRFQSentLocal.Location = new System.Drawing.Point(3, 124);
            this.statRFQSentLocal.Name = "statRFQSentLocal";
            this.statRFQSentLocal.Size = new System.Drawing.Size(115, 115);
            this.statRFQSentLocal.TabIndex = 5;
            this.statRFQSentLocal.TopCaption = "RFQ";
            // 
            // statQuotationFinalizedLocal
            // 
            this.statQuotationFinalizedLocal.Amount = 0;
            this.statQuotationFinalizedLocal.BottomCaption = "Finalized";
            this.statQuotationFinalizedLocal.Location = new System.Drawing.Point(124, 124);
            this.statQuotationFinalizedLocal.Name = "statQuotationFinalizedLocal";
            this.statQuotationFinalizedLocal.Size = new System.Drawing.Size(115, 115);
            this.statQuotationFinalizedLocal.TabIndex = 6;
            this.statQuotationFinalizedLocal.TopCaption = "Quotation";
            // 
            // statVendorRecommendedLocal
            // 
            this.statVendorRecommendedLocal.Amount = 0;
            this.statVendorRecommendedLocal.BottomCaption = "Recommended";
            this.statVendorRecommendedLocal.Location = new System.Drawing.Point(245, 124);
            this.statVendorRecommendedLocal.Name = "statVendorRecommendedLocal";
            this.statVendorRecommendedLocal.Size = new System.Drawing.Size(115, 115);
            this.statVendorRecommendedLocal.TabIndex = 7;
            this.statVendorRecommendedLocal.TopCaption = "Vendor";
            // 
            // statVendorSelectedLocal
            // 
            this.statVendorSelectedLocal.Amount = 1;
            this.statVendorSelectedLocal.BottomCaption = "Selected";
            this.statVendorSelectedLocal.Location = new System.Drawing.Point(366, 124);
            this.statVendorSelectedLocal.Name = "statVendorSelectedLocal";
            this.statVendorSelectedLocal.Size = new System.Drawing.Size(115, 115);
            this.statVendorSelectedLocal.TabIndex = 8;
            this.statVendorSelectedLocal.TopCaption = "Vendor";
            // 
            // statLPOGeneratedLocal
            // 
            this.statLPOGeneratedLocal.Amount = 0;
            this.statLPOGeneratedLocal.BottomCaption = "Generated";
            this.statLPOGeneratedLocal.Location = new System.Drawing.Point(487, 124);
            this.statLPOGeneratedLocal.Name = "statLPOGeneratedLocal";
            this.statLPOGeneratedLocal.Size = new System.Drawing.Size(115, 115);
            this.statLPOGeneratedLocal.TabIndex = 9;
            this.statLPOGeneratedLocal.TopCaption = "LPO";
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(0, 66);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(753, 3);
            this.header.TabIndex = 3;
            // 
            // statisticIcon
            // 
            this.statisticIcon.Location = new System.Drawing.Point(12, 9);
            this.statisticIcon.Name = "statisticIcon";
            this.statisticIcon.Size = new System.Drawing.Size(35, 35);
            this.statisticIcon.TabIndex = 4;
            this.statisticIcon.TabStop = false;
            // 
            // statisticHeader
            // 
            this.statisticHeader.AutoSize = true;
            this.statisticHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticHeader.Location = new System.Drawing.Point(62, 17);
            this.statisticHeader.Name = "statisticHeader";
            this.statisticHeader.Size = new System.Drawing.Size(68, 20);
            this.statisticHeader.TabIndex = 5;
            this.statisticHeader.Text = "Header";
            // 
            // StatisticsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.statisticHeader);
            this.Controls.Add(this.statisticIcon);
            this.Controls.Add(this.header);
            this.Controls.Add(this.flpLocalStatistics);
            this.Name = "StatisticsBox";
            this.Size = new System.Drawing.Size(753, 336);
            this.Load += new System.EventHandler(this.StatisticsBox_Load);
            this.flpLocalStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statisticIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpLocalStatistics;
        private Stat statAllRequisitionsLocal;
        private Stat statOpenRequisitionLocal;
        private Stat statPendingRequisitionLocal;
        private Stat statApprovedRequisitionLocal;
        private Stat statDeclinedRequisitionLocal;
        private Stat statCompletedRequisitionsLocal;
        private Stat statRFQSentLocal;
        private Stat statQuotationFinalizedLocal;
        private Stat statVendorRecommendedLocal;
        private Stat statVendorSelectedLocal;
        private Stat statLPOGeneratedLocal;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox statisticIcon;
        private System.Windows.Forms.Label statisticHeader;
    }
}
