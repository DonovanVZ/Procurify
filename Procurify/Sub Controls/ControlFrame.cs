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

    public partial class ControlFrame : UserControl
    {
        private protected string _currentNavigationLocation = "Location";

        public ControlFrame()
        {
            InitializeComponent();
        }

        public string CurrentNavigationLocation
        {
            get => _currentNavigationLocation;
            set
            {
                _currentNavigationLocation = value;
                Invalidate();
            }
        }

        private void ControlFrame_Load(object sender, EventArgs e)
        {
            locationName.Text = _currentNavigationLocation;
        }
    }
}
