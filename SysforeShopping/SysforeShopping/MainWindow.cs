using DataLibrary;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace SysforeShopping
{
    public partial class MainWindow : Form
    {
        public List<ProductCategory> listOfProductCategories = new List<ProductCategory>();
        public List<ProductSubCategory> listOfSubProductCategories = new List<ProductSubCategory>();
        public List<ProductItems> listOfProductItems = new List<ProductItems>();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = Guid.NewGuid().ToString();
            txtOrderId.Select(txtOrderId.Text.Length, 1);
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            txtTotalPrice.Clear();

            listOfProductCategories.Add(new ProductCategory()
            {
                CategoryId = 0,
                CategoryName = "--Select--",
                CategoryDescription = ""
            });

            foreach (ProductCategory category in DataUtils.FillProductCategories())
            {
                listOfProductCategories.Add(category);
            }
            cboCategories.DataSource = listOfProductCategories;
            cboCategories.DisplayMember = "CategoryName";
            cboCategories.ValueMember = "CategoryId";
        }
              

        private void cboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            txtTotalPrice.Clear();
            
            int selectedId = Convert.ToInt32(((ProductCategory)cboCategories.SelectedItem).CategoryId);
            if (selectedId == 0)
            {
                cboSubCategories.DataSource = null;
                cboSubCategories.Items.Clear();
                cboProductItems.DataSource = null;
                cboProductItems.Items.Clear();
                return;
            }

            listOfSubProductCategories = new List<ProductSubCategory>();

            listOfSubProductCategories.Add(new ProductSubCategory()
            {
                SubCategoryId = 0,
                SubCategoryName = "--Select--",
                SubCategoryDescription = ""
            });

            foreach (ProductSubCategory subCategory in DataUtils.FillProductSubCategories())
            {
                if (subCategory.CategoryId == selectedId)
                {
                    listOfSubProductCategories.Add(subCategory);
                }              
            }

            cboSubCategories.DisplayMember = "SubCategoryName";
            cboSubCategories.ValueMember = "SubCategoryId";
            cboSubCategories.DataSource = listOfSubProductCategories;            
        }


        private void cboSubCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            txtTotalPrice.Clear();

            int selectedId = Convert.ToInt32(((ProductSubCategory)cboSubCategories.SelectedItem).SubCategoryId);

            if (selectedId == 0)
            {
                cboProductItems.DataSource = null;
                cboProductItems.Items.Clear();
                return;
            }
            listOfProductItems = new List<ProductItems>();

            listOfProductItems.Add(new ProductItems()
            {
                SubCategoryId = selectedId,
                ProductId = 0,
                ProductName = "--Select--",
                ProductDescription = ""
            });

            foreach (ProductItems product in DataUtils.FillProductItems())
            {
                if (product.SubCategoryId == selectedId)
                {
                    listOfProductItems.Add(product);
                }               
            }

            cboProductItems.DisplayMember = "ProductName";
            cboProductItems.ValueMember = "ProductId";
            cboProductItems.DataSource = listOfProductItems;            
        }

        private void cboProductItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            txtQuantity.Clear();
            txtTotalPrice.Clear();
            int selectedID = Convert.ToInt32(cboProductItems.SelectedValue);

            foreach (ProductItems product in DataUtils.FillProductItems())
            {
                if (product.ProductId == selectedID)
                {
                    double Price = Convert.ToDouble(product.Price);
                    System.Globalization.CultureInfo info = System.Globalization.CultureInfo.GetCultureInfo("hi-IN");
                    txtUnitPrice.Text = Price.ToString("N2", info);
                    txtUnitPrice.Select(txtUnitPrice.Text.Length, 1);
                }
            }
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                double unitPrice = Convert.ToDouble(txtUnitPrice.Text);
                double unitQuantity = Convert.ToDouble(txtQuantity.Text);
                double totalPrice = unitPrice * unitQuantity;
                System.Globalization.CultureInfo info = System.Globalization.CultureInfo.GetCultureInfo("hi-IN");
                txtTotalPrice.Text = totalPrice.ToString("N2", info); 
            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {
        }


        private void cboCategories_DropDownClosed(object sender, EventArgs e)
        {

        }
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit? Please confirm", "Confirm exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.ExitThread();
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Not going anywhere!!!");
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("Cancelled!");
                e.Cancel = true;
            }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtOrderId.Text = Guid.NewGuid().ToString();
            cboCategories.SelectedIndex = 1;
            cboSubCategories.SelectedIndex = 0;
            cboProductItems.Items.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            txtTotalPrice.Clear();
        }

        private void btnGenerateOrder_Click(object sender, EventArgs e)
        {
            Print_Form f2 = new Print_Form();           
            this.Hide();            
            f2.label1.Text = txtOrderId.Text.ToString();           
            f2.label2.Text = cboProductItems.Text.ToString();           
            f2.label3.Text = txtQuantity.Text.ToString();
            f2.label5.Text = txtTotalPrice.Text.ToString(); 

            f2.Show();

        }
    }
}
