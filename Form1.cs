using System.ComponentModel;
using System.IO;

namespace PhamAnhQuan_Bai2
{
    public partial class Form1 : Form
    {
        private BindingList<Product> products;
        private BindingSource source;
        private string selectedImagePath = "";

        public Form1()
        {
            InitializeComponent();

            products = new BindingList<Product>();
            source = new BindingSource();

            source.DataSource = products;

            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.DataSource = source;

            cboCategory.Items.AddRange(new string[]
            {
                "Laptop",
                "Điện thoại",
                "Máy tính bảng",
                "Phụ kiện"
            });

            timer1.Start();

            UpdateStatus();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter =
                "Image Files|*.jpg;*.png;*.bmp";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = dlg.FileName;

                picProductImage.Image =
                    Image.FromFile(dlg.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = new Product();

            p.ProductId = txtProductId.Text;
            p.ProductName = txtProductName.Text;
            p.Category = cboCategory.Text;
            p.Price = decimal.Parse(txtPrice.Text);
            p.Quantity = (int)numQuantity.Value;
            p.ImagePath = selectedImagePath;

            products.Add(p);

            UpdateStatus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (source.Current == null)
                return;

            DialogResult rs =
                MessageBox.Show(
                    "Bạn có muốn xóa không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo);

            if (rs == DialogResult.Yes)
            {
                source.RemoveCurrent();

                UpdateStatus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtPrice.Clear();

            cboCategory.SelectedIndex = -1;

            numQuantity.Value = 0;

            picProductImage.Image = null;

            selectedImagePath = "";
        }

        private void ExportCSV()
        {
            SaveFileDialog dlg =
                new SaveFileDialog();

            dlg.Filter = "CSV File|*.csv";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw =
                    new StreamWriter(dlg.FileName))
                {
                    foreach (Product p in products)
                    {
                        sw.WriteLine(
                            $"{p.ProductId}," +
                            $"{p.ProductName}," +
                            $"{p.Category}," +
                            $"{p.Price}," +
                            $"{p.Quantity}," +
                            $"{p.ImagePath}");
                    }
                }

                MessageBox.Show("Xuất thành công!");
            }
        }

        private void ImportCSV()
        {
            OpenFileDialog dlg =
                new OpenFileDialog();

            dlg.Filter = "CSV File|*.csv";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                products.Clear();

                string[] lines =
                    File.ReadAllLines(dlg.FileName);

                foreach (string line in lines)
                {
                    string[] data =
                        line.Split(',');

                    if (data.Length >= 6)
                    {
                        products.Add(new Product
                        {
                            ProductId = data[0],
                            ProductName = data[1],
                            Category = data[2],
                            Price = decimal.Parse(data[3]),
                            Quantity = int.Parse(data[4]),
                            ImagePath = data[5]
                        });
                    }
                }

                UpdateStatus();
            }
        }

        private void UpdateStatus()
        {
            int totalQuantity =
                products.Sum(x => x.Quantity);

            decimal totalValue =
                products.Sum(
                    x => x.Price * x.Quantity);

            lblTotalQty.Text =
                $"Tổng SL: {totalQuantity}";

            lblTotalValue.Text =
                $"Tổng giá trị: {totalValue:N0}";
        }

        private void openFileToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {
            ImportCSV();
        }

        private void saveReportToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {
            ExportCSV();
        }

        private void exitToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(
            object sender,
            EventArgs e)
        {
            lblTime.Text =
                DateTime.Now.ToString(
                    "dd/MM/yyyy HH:mm:ss");
        }

        private void Form1_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult rs =
                MessageBox.Show(
                    "Bạn có chắc muốn thoát?",
                    "Thoát",
                    MessageBoxButtons.YesNo);

            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}