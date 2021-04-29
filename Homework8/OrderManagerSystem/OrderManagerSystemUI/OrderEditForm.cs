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
    public partial class OrderEditForm : Form
    {
        public OrderEditForm()
        {
            InitializeComponent();
        }
        private OrderService orderService;
        private bool editModel;

        public Order CurrentOrder { get; set; }
        public Action<OrderEditForm> CloseEditFrom { get; set; }

        public OrderEditForm(Order order, bool model, OrderService orderService)
        {
            InitializeComponent();
            bdsCustomer.Add(new Customer("1", "li"));
            bdsCustomer.Add(new Customer("2", "zhang"));
            this.orderService = orderService;
            this.editModel = model;

            //TODO 如果想实现不点保存只关窗口后订单不变化，需要把order深克隆给CurrentOrder
            this.CurrentOrder = order;
            bdsOrder.DataSource = CurrentOrder;

            textBox_ID.Enabled = !model;
            if (!model)
            {
                CurrentOrder.Customer = (Customer)bdsCustomer.Current;
            }
        }

        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_AddDetail_Click(object sender, EventArgs e)
        {
            DetailEditForm detailEditForm = new DetailEditForm(new OrderDetail());
            try
            {
                if (detailEditForm.ShowDialog() == DialogResult.OK)
                {
                    uint index = 0;
                    if (CurrentOrder.OrderDetails.Count != 0)
                    {
                        index = CurrentOrder.OrderDetails.Max(i => i.Index) + 1;
                    }
                    detailEditForm.Detail.Index = index;
                    CurrentOrder.AddItem(detailEditForm.Detail);
                    bdsDetails.ResetBindings(false);
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditDetail();
        }

        private void EditDetail()
        {
            OrderDetail detail = bdsDetails.Current as OrderDetail;
            if (detail == null)
            {
                MessageBox.Show("请选择一个订单项进行修改");
                return;
            }
            DetailEditForm detailEditForm = new DetailEditForm(detail);
            if (detailEditForm.ShowDialog() == DialogResult.OK)
            {
                bdsDetails.ResetBindings(false);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            OrderDetail detail = bdsDetails.Current as OrderDetail;
            if (detail == null)
            {
                MessageBox.Show("请选择一个订单项进行删除");
                return;
            }
            CurrentOrder.RemoveDetail(detail);
            bdsDetails.ResetBindings(false);
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.editModel)
                {
                    orderService.ModifyOrder(CurrentOrder);
                }
                else
                {
                    orderService.AddOrder(CurrentOrder);
                }
                CloseEditFrom(this);
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
        }
    }
}
