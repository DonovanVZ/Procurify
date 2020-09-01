using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procurify.Sub_Controls
{
    public partial class Stat : UserControl
    {
        private protected string _topCaption = "Caption";
        private protected string _bottomCaption = "Caption";
        private protected int _amount = 0;

        public Stat()
        {
            InitializeComponent();
        }

        public string TopCaption
        {
            get => _topCaption;
            set
            {
                _topCaption = value;
                Invalidate();
            }
        }

        public string BottomCaption
        {
            get => _bottomCaption;
            set
            {
                _bottomCaption = value;
                Invalidate();
            }
        }

        public int Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                Invalidate();
            }
        }

        private void Stat_Load(object sender, EventArgs e)
        {
            topCaption.Text = _topCaption;
            bottomCaption.Text = _bottomCaption;
            amount.Text = _amount.ToString();

            ArrangeControls();
        }

        private void ArrangeControls()
        {
            var x = pnlStatControls.Width / 2 - topCaption.Width / 2;
            var y = pnlStatControls.Height / 2;

            var x1 = pnlStatControls.Width / 2 - bottomCaption.Width / 2;

            var x2 = pnlStatControls.Width / 2 - amount.Width / 2 + 1;
          

            topCaption.Location = new Point(x, y);
            bottomCaption.Location = new Point(x1, 85);
            amount.Location = new Point(x2, 10);
        }
    }
}
