using System;
using System.ComponentModel;

namespace BaiKiemTra
{
    public partial class Form1 : Form
    {
        private List<Product> productList; // Danh sách sản phẩm có sẵn
        private ShoppingCart cart; // Giỏ hàng

        public Form1()
        {
            
            InitializeComponent();
            cart = new ShoppingCart();
            InitializeProducts(); 
            LoadProductsToGrid(); // Load dữ liệu vào grid
        }

        private void LoadProductsToGrid()
        {
            // Tạo một BindingList từ List để hỗ trợ cập nhật realtime
            BindingList<Product> bindingList = new BindingList<Product>(productList);
            dataGridView1.DataSource = bindingList;
        }
        private void InitializeProducts()
        {
            productList = new List<Product>
        {
            new Product("image1.jpg", "Laptop", 1000m, 10),
            new Product("image2.jpg", "Phone", 500m, 20),
            new Product("image3.jpg", "Tablet", 300m, 15)
        };

            // Hiển thị lên DataGridView1
            dataGridView1.DataSource = productList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateCartDisplay()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = cart.GetProducts();
        }

        private void UpdateTotal()
        {
            // p => p.Price tương tự như foreach(product p in cart.getproducts())
            decimal total = cart.GetProducts().Sum(p => p.Price);
            textBox_Total.Text = total.ToString("C");
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Product selectedProduct = (Product)dataGridView1.CurrentRow.DataBoundItem;

                if (selectedProduct.Quantity > 0)
                {
                    cart.AddProduct(selectedProduct);
                    selectedProduct.Quantity--; // Giảm số lượng sản phẩm gốc
                    UpdateCartDisplay();
                    UpdateTotal();
                }
                else
                {
                    MessageBox.Show("Sản phẩm đã hết hàng!");
                }
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                Product selectedProduct = (Product)dataGridView2.CurrentRow.DataBoundItem;
                cart.RemoveProduct(selectedProduct);

                // Tìm sản phẩm gốc và tăng số lượng
                var originalProduct = productList.Find(p => p.Name == selectedProduct.Name);
                if (originalProduct != null)
                    originalProduct.Quantity++;

                UpdateCartDisplay();
                UpdateTotal();
            }
        }

        private void button_Pay_Click(object sender, EventArgs e)
        {
            if (cart.GetProducts().Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống!");
                return;
            }

            // Kiểm tra số lượng tồn kho
            foreach (var cartItem in cart.GetProducts())
            {
                var stockItem = productList.Find(p => p.Name == cartItem.Name);
                if (stockItem.Quantity < cartItem.Quantity)
                {
                    MessageBox.Show($"Sản phẩm {cartItem.Name} không đủ số lượng!");
                    return;
                }
            }

            DialogResult result = MessageBox.Show(
                $"Xác nhận thanh toán {textBox_Total.Text}?",
                "Xác nhận",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Cập nhật số lượng trong kho
                foreach (var cartItem in cart.GetProducts())
                {
                    var stockItem = productList.Find(p => p.Name == cartItem.Name);
                    stockItem.Quantity -= cartItem.Quantity;
                }

                cart.Clear();
                UpdateCartDisplay();
                textBox_Total.Text = "0";
                MessageBox.Show("Thanh toán thành công!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RefreshData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productList;
            UpdateCartDisplay();
            UpdateTotal();
        }
    }
}
