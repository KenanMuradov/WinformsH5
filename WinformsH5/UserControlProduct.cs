using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsH5.Model;

namespace WinformsH5;

public partial class UserControlProduct : UserControl
{
    public Action<double, bool> TotalPaymentChange { get; set; }


    public UserControlProduct(Product product, Action<double, bool> totalPaymentChange)
    {
        InitializeComponent();
        lblPrice.Text = product.Price.ToString() + '$';
        lblProductName.Text = product.Name;
        if (product.Count == 0)
            cbProductCount.Text = "No Stock";
        else
            cbProductCount.Text = product.Count.ToString() + " left";
        TotalPaymentChange = totalPaymentChange;
    }

    private void cbProductCount_CheckedChanged(object sender, EventArgs e)
    {
        if(cbProductCount.Text== "No Stock")
        {
            cbProductCount.Checked = false;
            return;
        }

        TotalPaymentChange(double.Parse(lblPrice.Text.Replace("$", String.Empty)), cbProductCount.Checked);
    }
}
