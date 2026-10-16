namespace PhamAnhQuan_Bai2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtProductId;
        private TextBox txtProductName;
        private TextBox txtPrice;

        private ComboBox cboCategory;
        private NumericUpDown numQuantity;

        private PictureBox picProductImage;

        private Button btnChooseImage;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;

        private DataGridView dgvProducts;

        private MenuStrip menuStrip1;

        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveReportToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;

        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem importCSVToolStripMenuItem;
        private ToolStripMenuItem exportCSVToolStripMenuItem;

        private StatusStrip statusStrip1;

        private ToolStripStatusLabel lblTotalQty;
        private ToolStripStatusLabel lblTotalValue;
        private ToolStripStatusLabel lblTime;

        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            txtProductId = new TextBox();
            txtProductName = new TextBox();
            txtPrice = new TextBox();

            cboCategory = new ComboBox();
            numQuantity = new NumericUpDown();

            picProductImage = new PictureBox();

            btnChooseImage = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnClear = new Button();

            dgvProducts = new DataGridView();

            menuStrip1 = new MenuStrip();

            systemToolStripMenuItem =
                new ToolStripMenuItem();

            openFileToolStripMenuItem =
                new ToolStripMenuItem();

            saveReportToolStripMenuItem =
                new ToolStripMenuItem();

            exitToolStripMenuItem =
                new ToolStripMenuItem();

            toolsToolStripMenuItem =
                new ToolStripMenuItem();

            importCSVToolStripMenuItem =
                new ToolStripMenuItem();

            exportCSVToolStripMenuItem =
                new ToolStripMenuItem();

            statusStrip1 = new StatusStrip();

            lblTotalQty =
                new ToolStripStatusLabel();

            lblTotalValue =
                new ToolStripStatusLabel();

            lblTime =
                new ToolStripStatusLabel();

            timer1 = new System.Windows.Forms.Timer(components);

            SuspendLayout();

            // MenuStrip

            systemToolStripMenuItem.Text = "System";

            openFileToolStripMenuItem.Text = "Open File";
            saveReportToolStripMenuItem.Text = "Save Report";
            exitToolStripMenuItem.Text = "Exit";

            openFileToolStripMenuItem.Click +=
                openFileToolStripMenuItem_Click;

            saveReportToolStripMenuItem.Click +=
                saveReportToolStripMenuItem_Click;

            exitToolStripMenuItem.Click +=
                exitToolStripMenuItem_Click;

            systemToolStripMenuItem.DropDownItems.AddRange(
                new ToolStripItem[]
                {
                    openFileToolStripMenuItem,
                    saveReportToolStripMenuItem,
                    exitToolStripMenuItem
                });

            toolsToolStripMenuItem.Text = "Tools";

            importCSVToolStripMenuItem.Text =
                "Import CSV";

            exportCSVToolStripMenuItem.Text =
                "Export CSV";

            importCSVToolStripMenuItem.Click +=
                openFileToolStripMenuItem_Click;

            exportCSVToolStripMenuItem.Click +=
                saveReportToolStripMenuItem_Click;

            toolsToolStripMenuItem.DropDownItems.AddRange(
                new ToolStripItem[]
                {
                    importCSVToolStripMenuItem,
                    exportCSVToolStripMenuItem
                });

            menuStrip1.Items.AddRange(
                new ToolStripItem[]
                {
                    systemToolStripMenuItem,
                    toolsToolStripMenuItem
                });

            // Product ID

            txtProductId.Location =
                new Point(20, 50);

            txtProductId.Size =
                new Size(200, 23);

            // Product Name

            txtProductName.Location =
                new Point(20, 90);

            txtProductName.Size =
                new Size(250, 23);

            // Category

            cboCategory.Location =
                new Point(20, 130);

            cboCategory.Size =
                new Size(200, 23);

            // Price

            txtPrice.Location =
                new Point(20, 170);

            txtPrice.Size =
                new Size(150, 23);

            // Quantity

            numQuantity.Location =
                new Point(20, 210);

            numQuantity.Size =
                new Size(120, 23);

            // Picture

            picProductImage.Location =
                new Point(320, 50);

            picProductImage.Size =
                new Size(160, 160);

            picProductImage.BorderStyle =
                BorderStyle.FixedSingle;

            picProductImage.SizeMode =
                PictureBoxSizeMode.StretchImage;

            // Choose Image

            btnChooseImage.Location =
                new Point(320, 220);

            btnChooseImage.Size =
                new Size(160, 35);

            btnChooseImage.Text =
                "Chọn ảnh";

            btnChooseImage.Click +=
                btnChooseImage_Click;

            // Add

            btnAdd.Location =
                new Point(520, 50);

            btnAdd.Size =
                new Size(120, 35);

            btnAdd.Text =
                "Thêm";

            btnAdd.Click +=
                btnAdd_Click;

            // Delete

            btnDelete.Location =
                new Point(520, 95);

            btnDelete.Size =
                new Size(120, 35);

            btnDelete.Text =
                "Xóa";

            btnDelete.Click +=
                btnDelete_Click;

            // Clear

            btnClear.Location =
                new Point(520, 140);

            btnClear.Size =
                new Size(120, 35);

            btnClear.Text =
                "Làm mới";

            btnClear.Click +=
                btnClear_Click;

            // DataGridView

            dgvProducts.Location =
                new Point(20, 280);

            dgvProducts.Size =
                new Size(940, 260);

            // StatusStrip

            statusStrip1.Items.AddRange(
                new ToolStripItem[]
                {
                    lblTotalQty,
                    lblTotalValue,
                    lblTime
                });

            lblTotalQty.Text =
                "Tổng SL: 0";

            lblTotalValue.Text =
                "Tổng giá trị: 0";

            lblTime.Text =
                "";

            // Timer

            timer1.Interval = 1000;

            timer1.Tick += timer1_Tick;

            // Form

            AutoScaleDimensions =
                new SizeF(7F, 15F);

            AutoScaleMode =
                AutoScaleMode.Font;

            ClientSize =
                new Size(1000, 600);

            Controls.Add(txtProductId);
            Controls.Add(txtProductName);
            Controls.Add(cboCategory);
            Controls.Add(txtPrice);
            Controls.Add(numQuantity);

            Controls.Add(picProductImage);

            Controls.Add(btnChooseImage);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);

            Controls.Add(dgvProducts);

            Controls.Add(menuStrip1);
            Controls.Add(statusStrip1);

            MainMenuStrip = menuStrip1;

            Text =
                "Quản Lý Kho Hàng";

            FormClosing +=
                Form1_FormClosing;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
