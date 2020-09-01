using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Procurify.Sub_Controls
{
    public partial class DashButton : UserControl
    {
        private protected string _topCaption = "Caption";
        private protected string _bottomCaption = "Caption";
        private protected Color _clickColor = Color.FromArgb(80,80,80);
        private protected Image _icon = null;

        public DashButton()
        {
            InitializeComponent();
        }

        private void DashButton_Load(object sender, EventArgs e)
        {
            topCaption.Text = _topCaption;
            bottomCaption.Text = _bottomCaption;
            buttonIcon.Image = _icon;

            ArrangeControls();
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

        public Color ClickedColor
        {
            get => _clickColor;
            set
            {
                _clickColor = value;
                Invalidate();
            }
        }

        public Image ButtonIcom
        {
            get => _icon;
            set
            {
                _icon = value;
                Invalidate();
            }
        }

        private void ArrangeControls()
        {
            var x = dashButtonControls.Width / 2 - topCaption.Width / 2;

            var x1 = dashButtonControls.Width / 2 - bottomCaption.Width / 2;

            topCaption.Location = new Point(x, 85);
            bottomCaption.Location = new Point(x1, 105);
        }

        private void dashButtonControls_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                dashButtonControls.BackColor = _clickColor;
                Thread.Sleep(100);
                dashButtonControls.BackColor = this.BackColor;
            });
        }
    }
}
