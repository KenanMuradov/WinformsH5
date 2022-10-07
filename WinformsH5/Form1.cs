using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using WinformsH5.Model;
using WinformsH5.Models;

namespace WinformsH5;

public partial class Form1 : Form
{
    private double _totalPayment = 0;
    private double _returnMoney = 0;
    private double _enteredMoney = 0;
    public Action<double, bool> TotalPaymentChange { get; set; }


    public Form1()
    {
        InitializeComponent();

        TotalPaymentChange += (price, isAdd) =>
        {
            if (isAdd)
                _totalPayment += price;
            else
                _totalPayment -= price;

            lblTotalPayment.Text = _totalPayment.ToString() + '$';

            CalculateReturnMoney();
        };
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        for (int i = 0; i < FakeData.products.Count; i++)
        {
            UserControlProduct product = new(FakeData.products[i], TotalPaymentChange)
            {
                Dock = DockStyle.Top
            };

            panelProducts.Controls.Add(product);
        }

    }

    private void btnUSD_Click(object sender, EventArgs e)
    {
        var btn = sender as Button;

        _enteredMoney += double.Parse(btn!.Text.Split(' ')[0]);

        lblUserEnteredMoney.Text = _enteredMoney.ToString() + '$';

        _returnMoney = _enteredMoney - _totalPayment;

        CalculateReturnMoney();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        var txtBox = sender as TextBox;
        _returnMoney = _enteredMoney - _totalPayment;


        lblUserEnteredMoney.Text = _enteredMoney.ToString() + '$';
        if (_returnMoney > 0 && _totalPayment > 0)
            lblReturnedMoney.Text = _returnMoney.ToString() + '$';
        else
            lblReturnedMoney.Text = 0.ToString() + '$';

        _enteredMoney = 0;

        if (txtBox!.Text == String.Empty)
        {
            lblUserEnteredMoney.Text = _enteredMoney.ToString() + "$";
            return;
        }

        if (!Regex.Match(txtBox?.Text!, @"^([0-9]+([,][0-9]*)?|[,][0-9]+)$").Success)
        {
            txtBox!.Text = string.Empty;
            lblUserEnteredMoney.Text = _enteredMoney.ToString() + "$";
            MessageBox.Show("Only numbers allowed", "Informtaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }


        _enteredMoney = double.Parse(txtBox!.Text);
        CalculateReturnMoney();
    }

    private void btnPay_Click(object sender, EventArgs e)
    {
        if (_totalPayment == 0)
        {
            MessageBoxCustom("You Haven't bought anything");
            return;
        }


        if (_totalPayment > _enteredMoney)
        {
            MessageBoxCustom("you don't have enough money");
            return;
        }

        DirectoryInfo directoryInfo = new(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Operations");

        if (!directoryInfo.Exists)
            Directory.CreateDirectory(directoryInfo.FullName);

        List<string> boughtProducts = new();
        StringBuilder sb = new();
        sb.Append("You bought:\n");

        foreach (var control in panelProducts.Controls.OfType<UserControlProduct>())
        {
            if (control.cbProductCount.Checked)
            {
                sb.Append($"{control.lblProductName.Text}\n");
                boughtProducts.Add(control.lblProductName.Text);
            }
        }

        sb.Append($"\nYou paid: {_enteredMoney}\n");
        sb.Append($"You receive: {_returnMoney} USD back");

        DialogResult result = MessageBox.Show(sb.ToString(), "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

        if (result == DialogResult.Cancel)
            return;

        Operation operation = new(DateTime.Now, _enteredMoney, _returnMoney, boughtProducts);
        File.WriteAllText($@"{directoryInfo.FullName}\{operation.OperationDate:dd/MM/yyyy/HH/mm/ss}_Operation.json", JsonSerializer.Serialize(operation));

        foreach (var control in panelProducts.Controls.OfType<UserControlProduct>())
        {
            if (control.cbProductCount.Checked)
            {
                control.cbProductCount.Text = (int.Parse(control.cbProductCount.Text.Split()[0]) - 1).ToString() + " Left";
                control.cbProductCount.Checked = false;
            }
        }

        foreach (var label in panelOperation.Controls.OfType<Label>())
        {
            if (label.Text.Contains('$'))
                label.Text = "0$";
        }

        txtUserEnteredAmount.Text = String.Empty;
    }


    private void CalculateReturnMoney()
    {
        _returnMoney = _enteredMoney - _totalPayment;
        lblUserEnteredMoney.Text = _enteredMoney.ToString() + '$';
        if (_returnMoney > 0 && _totalPayment > 0)
            lblReturnedMoney.Text = _returnMoney.ToString() + '$';
        else
            lblReturnedMoney.Text = 0.ToString() + '$';
    }



    private static void MessageBoxCustom(string message) => MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
}