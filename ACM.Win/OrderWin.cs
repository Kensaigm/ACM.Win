using ACM.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACM.Win
{
    public partial class OrderWin : Form
    {
        public OrderWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlaceOrder();
        }

        private void PlaceOrder()
        {
            var customer = new Customer();
            // Get the Customer data from the windows form controls.
            // Populate the customer instance

            var order = new Order();
            // order.text = OrderWin.UI.Form.Order.text
            // Populate the order instance

            // Get value for OrderWin.UI.Form.Order.AllowSplit.Checkbox
            // var allowSplitOrders = true;
            // Get value for OrderWind.UI.Form.Order.EmailReceipt.Checkbox
            // var emailReceipt = true;

            var payment = new Payment();
            // Populate the payment info from OrderWin.UI.Form.BillingInfo

            var orderController = new OrderController();
            orderController.PlaceOrder(customer, order, payment, allowSplitOrders:false, emailReceipt:true);
        }

    }
}
