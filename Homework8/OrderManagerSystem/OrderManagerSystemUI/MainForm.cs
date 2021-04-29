using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagerSystem;

namespace OrderManagerSystemUI
{
    public partial class MainForm : Form
    {
        OrderService orderService;
        BindingSource bdsFields = new BindingSource();
        public Action<OrderEditForm> ShowEditForm { get; set; }
        public string Keyword { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Query_Click(object sender, EventArgs e)
        {
            switch (comboBox_Kinds.SelectedIndex)
            {
                case 0://所有订单
                    bdsOrder.DataSource = orderService.Orders;
                    break;
                case 1://根据ID查询
                    int.TryParse(Keyword, out int id);
                    Order order = orderService.GetOrder(id);
                    List<Order> result = new List<Order>();
                    if (order != null) result.Add(order);
                    bdsOrder.DataSource = result;
                    break;
                case 2://根据客户查询
                    bdsOrder.DataSource = orderService.QueryOrdersByCustomerName(Keyword);
                    break;
            }
            bdsOrder.ResetBindings(false);

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            OrderEditForm orderEditForm = new OrderEditForm(new Order(), false, orderService);
            ShowEditForm(orderEditForm);
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            EditOrder();
        }



        private void EditOrder()
        {
            Order order = bdsOrder.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行修改");
                return;
            }
            OrderEditForm orderEditForm2 = new OrderEditForm(order, true, orderService);
            ShowEditForm(orderEditForm2);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            Order order = bdsOrder.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行删除");
                return;
            }
            orderService.DeleteOrder(order.OrderID);
            QueryAll();
        }

        public void QueryAll()
        {
            bdsOrder.DataSource = orderService.Orders;
            bdsOrder.ResetBindings(false);
        }

        private void button_Import_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = openFileDialog1.FileName;
                orderService.Import(fileName);
                QueryAll();
            }
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog1.FileName;
                orderService.Export(fileName);
            }
        }
    }
}
