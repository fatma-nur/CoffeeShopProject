using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace DesktopUI
{
    public partial class CustomerForm : Form
    {
        CoffeeShopManager coffeeShopManager = new CoffeeShopManager(new EfCoffeeShopDal());
        CustomerManager customerManager = new CustomerManager(new CustomerCheckManager(), new EfCustomerDal());

        public CustomerForm()
        {
            InitializeComponent();
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerTC = txtTC.Text;
            customer.CustomerName = txtName.Text;
            customer.CustomerSurname = txtSurname.Text;
            customer.CustomerBirthdate = dtpBirthdate.Value;
            customer.CoffeeShopId = Convert.ToInt32(cmbCoffeeShop.SelectedValue);
            if ((coffeeShopManager.CheckMernisByShop(cmbCoffeeShop.Text)) == true)
            {
                
                try
                {
                    customerManager.AddWithMernis(customer);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                if (customerManager.checkSave) MessageBox.Show("Eklendi");
                else MessageBox.Show("Mernis Kontrol Hatası");
            }
            else
            {
                try
                {
                    customerManager.Add(customer);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            var result = coffeeShopManager.GetCoffeeShops();
            cmbCoffeeShop.DataSource = coffeeShopManager.GetCoffeeShops().ToList();
            cmbCoffeeShop.DisplayMember = "CoffeeShopName";
            cmbCoffeeShop.ValueMember = "CoffeeShopId";
            


        }
    }
}
