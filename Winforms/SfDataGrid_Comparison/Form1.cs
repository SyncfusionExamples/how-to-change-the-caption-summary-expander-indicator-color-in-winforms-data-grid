using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SfDataGrid_Comparison
{
    public partial class Form1 : Form
    {
        OrderInfoCollection infoCollection;
        public Form1()
        {
            InitializeComponent();
            infoCollection = new OrderInfoCollection();
            sfDataGrid1.DataSource = infoCollection.Orders;
            sfDataGrid1.AllowGrouping = true;
            sfDataGrid1.ShowGroupDropArea = true;
            sfDataGrid1.Style.CaptionSummaryRowStyle.ExpanderColor = Color.Red;
        }
    }
}
