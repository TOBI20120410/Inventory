using System.Text.RegularExpressions;

namespace Inventory
{
    public partial class frmAddProducts : Form
    {
        private string _ProductName;
        private string _Category;
        private string _MfgDate;
        private string _ExpDate;
        private string _Description;
        private int _Quantity;
        private double _SellPrice;

        BindingSource showProductList;
        public frmAddProducts()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }
        class NumberFormatException : Exception
        {
            public NumberFormatException(string quantity) : base(quantity) { }
        }
        class StringFormatException : Exception
        {
            public StringFormatException(string name) : base(name) { }
        }
        class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string price) : base(price) { }
        }

        private void frmAddProducts_Load(object sender, EventArgs e)
        {
            String[] ListOfProductCategory = new String[]
           {
                    "Beverages",
                    "Bread/Bakery",
                    "Canned/Jarred Goods",
                    "Dairy",
                    "Frozen Goods",
                    "Meat",
                    "Personal Care",
                    "Other"
           };
            foreach (string variableName in ListOfProductCategory)
            {
                cbCategory.Items.Add(variableName);
            }
        }
        public string Product_Name(string name)
        {
            try
            {
                if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                    throw new StringFormatException(name);
            }
            catch (StringFormatException SFE)
            {
                MessageBox.Show("Invalid Product" + SFE.Message);
            }
            finally
            {
                Console.WriteLine("Invalid Input, Letters only.");
            }
            return name;
        }
        public int Quantity(string qty)
        {
            try
            {
                if (!Regex.IsMatch(qty, @"^[0-9]"))
                {
                    throw new NumberFormatException(qty);
                }
            }
            catch (NumberFormatException NFE)
            {
                MessageBox.Show("Invalid Quantity" + NFE.Message);
            }
            finally
            {
                Console.WriteLine("Invalid Input, Numbers only.");
            }
            return Convert.ToInt32(qty);
        }
        public double SellingPrice(string price)
        {
            try
            {
                if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                {
                    throw new CurrencyFormatException(price);
                }

            }
            catch (CurrencyFormatException CFE)
            {
                MessageBox.Show("Invalid Price!" + CFE.Message);
            }
            finally
            {
                Console.WriteLine("Invalid Input, Numbers only.");
            }
            return Convert.ToDouble(price);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ProductName = Product_Name(txtProductName.Text);
            _Category = cbCategory.Text;
            _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
            _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
            _Description = richTxtDescription.Text;
            _Quantity = Quantity(txtQuantity.Text);
            _SellPrice = SellingPrice(txtSellPrice.Text);
            showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate,
            _ExpDate, _SellPrice, _Quantity, _Description));
            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.DataSource = showProductList;

            txtProductName.Text = "";
            cbCategory.SelectedIndex = -1;
            dtPickerMfgDate.Value = DateTime.Now;
            dtPickerExpDate.Value = DateTime.Now;
            richTxtDescription.Text = "";
            txtQuantity.Text = "";
            txtSellPrice.Text = "";
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}