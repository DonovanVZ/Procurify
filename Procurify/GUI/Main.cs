using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procurify
{
    public partial class Main : Form
    {
        private bool IsMenuOpen;
        public Main()
        {
            InitializeComponent();
        }

        private void controlFrame1_Load(object sender, EventArgs e)
        {
            foreach (var control in pnlControlsContainer.Controls)
            {
                SetDoubleBuffering((Control)control, true);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (IsMenuOpen)
            {
                closeMenu.Start();
            }
            else
            {
                openMenu.Start();
            }

            Task.Factory.StartNew(() =>
            {
                btnMenu.Image = Properties.Resources.MenuClicked;
                Thread.Sleep(100);
                btnMenu.Image = Properties.Resources.Menu;
            });
        }

        private void openMenu_Tick(object sender, EventArgs e)
        {
            pnlMenu.Left += 100;
            frame.Left += 100;

            controls.Left += 100;
            controls.Width -= 100;

            controls1.Left += 100;
            controls1.Width -= 100;

            flpFunctionButtons.Left += 100;

            if (pnlMenu.Left >= 0)
                openMenu.Stop();

            IsMenuOpen = true;
        }

        private void closeMenu_Tick(object sender, EventArgs e)
        {
            pnlMenu.Left -= 100;
            frame.Left -= 100;

            controls.Width += 100;
            controls.Left -= 100;

            controls1.Width += 100;
            controls1.Left -= 100;

            flpFunctionButtons.Left -= 100;

            if (pnlMenu.Right <= 0)
                closeMenu.Stop();

            IsMenuOpen = false;
        }

        
        public static void SetDoubleBuffering(Control control, bool value)
        {
            System.Reflection.PropertyInfo controlProperty = typeof(Control)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            controlProperty.SetValue(control, value, null);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            closeMenu.Start();
        }
    }
}
