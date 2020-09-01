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
    public partial class StatisticsList : UserControl
    {
        private protected string _headerCaption = "Header";
        private protected int _amount = 0;

        public StatisticsList()
        {
            InitializeComponent();
        }

        private void StatisticsList_Load(object sender, EventArgs e)
        {
                dataGridView1.Rows.Add(new object[] { "9/30/2020 12:08 AM", "9166 - 37", "Requisition Approval" });
                dataGridView1.Rows.Add(new object[] { "8/25/2020 12:08 AM", "9166 - 37", "Requisition Approval Request" });

            statisticHeader.Text = _headerCaption;
        }

        public string HeaderText
        {
            get => _headerCaption;
            set
            {
                _headerCaption = value;
                Invalidate();
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridView1.ClearSelection();
        }
    }
}
