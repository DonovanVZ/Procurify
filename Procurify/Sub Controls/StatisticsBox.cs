using System;
using System.Drawing;
using System.Windows.Forms;

namespace Procurify.Sub_Controls
{
    public partial class StatisticsBox : UserControl
    {
        #region Property Values

        private protected string _headerCaption = "Header";
        private protected Image _headerIcon = null;

        private protected int _allRequisitionsValue = 0;
        private protected int _openRequisitionsValue = 0;
        private protected int _pendingRequisitionsValue = 0;
        private protected int _approvedRequisitionsValue = 0;
        private protected int _declinedRequisitionsValue = 0;
        private protected int _completedRequisitionsValue = 0;
        private protected int _RFQSent = 0;
        private protected int _quotationFinalized = 0;
        private protected int _vendorRecommended = 0;
        private protected int _vendorSelected = 0;
        private protected int _LPOGenerated = 0;

        #endregion

        #region Properties

        public string HeaderCaption
        {
            get => _headerCaption;
            set
            {
                _headerCaption = value;
                Invalidate();
            }
        }

        public Image HeaderIcon
        {
            get => _headerIcon;
            set
            {
                _headerIcon = value;
                Invalidate();
            }
        }

        public int AllRequisitionsValue
        {
            get => _allRequisitionsValue;
            set
            {
                _allRequisitionsValue = value;
                Invalidate();
            }
        }

        public int OpenRequisitionsValue
        {
            get => _openRequisitionsValue;
            set
            {
                _openRequisitionsValue = value;
                Invalidate();
            }
        }

        public int PendingRequisitionsValue
        {
            get => _pendingRequisitionsValue;
            set
            {
                _pendingRequisitionsValue = value;
                Invalidate();
            }
        }

        public int ApprovedRequisitionsValue
        {
            get => _approvedRequisitionsValue;
            set
            {
                _approvedRequisitionsValue = value;
                Invalidate();
            }
        }

        public int DeclinedRequisitionsValue
        {
            get => _declinedRequisitionsValue;
            set
            {
                _declinedRequisitionsValue = value;
                Invalidate();
            }
        }

        public int CompletedRequisitionsValue
        {
            get => _completedRequisitionsValue;
            set
            {
                _completedRequisitionsValue = value;
                Invalidate();
            }
        }

        public int RFQSentValue
        {
            get => _RFQSent;
            set
            {
                _RFQSent = value;
                Invalidate();
            }
        }

        public int QuotationFinalizedValue
        {
            get => _quotationFinalized;
            set
            {
                _quotationFinalized = value;
                Invalidate();
            }
        }

        public int VendorRecommendedValue
        {
            get => _vendorRecommended;
            set
            {
                _vendorRecommended = value;
                Invalidate();
            }
        }

        public int VendorSelectedValue
        {
            get => _vendorSelected;
            set
            {
                _vendorSelected = value;
                Invalidate();
            }
        }

        public int LPOGeneratedValue
        {
            get => _LPOGenerated;
            set
            {
                _LPOGenerated = value;
                Invalidate();
            }
        }

        #endregion

        public StatisticsBox()
        {
            InitializeComponent();
        }

        private void StatisticsBox_Load(object sender, EventArgs e)
        {
            statisticIcon.Image = _headerIcon;
            statisticHeader.Text = _headerCaption;

            statAllRequisitionsLocal.Amount = _allRequisitionsValue;
            statOpenRequisitionLocal.Amount = _openRequisitionsValue;
            statPendingRequisitionLocal.Amount = _pendingRequisitionsValue;
            statApprovedRequisitionLocal.Amount = _approvedRequisitionsValue;
            statDeclinedRequisitionLocal.Amount = _declinedRequisitionsValue;
            statCompletedRequisitionsLocal.Amount = _declinedRequisitionsValue;
            statRFQSentLocal.Amount = _RFQSent;
            statQuotationFinalizedLocal.Amount = _quotationFinalized;
            statVendorRecommendedLocal.Amount = _vendorRecommended;
            statVendorSelectedLocal.Amount = _vendorSelected;
            statLPOGeneratedLocal.Amount = _LPOGenerated;
        }
    }
}
