
namespace I002
{
    partial class SellProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabForProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCounteeragent = new System.Windows.Forms.TextBox();
            this.ChooseCounteragent = new System.Windows.Forms.Button();
            this.tableForProducts = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSell = new System.Windows.Forms.Button();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.bnClose = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableForProducts)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabForProduct
            // 
            this.LabForProduct.Location = new System.Drawing.Point(0, 0);
            this.LabForProduct.Name = "LabForProduct";
            this.LabForProduct.Size = new System.Drawing.Size(990, 49);
            this.LabForProduct.TabIndex = 28;
            this.LabForProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.label1.Location = new System.Drawing.Point(35, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Покупатель";
            // 
            // TxtCounteeragent
            // 
            this.TxtCounteeragent.BackColor = System.Drawing.Color.White;
            this.TxtCounteeragent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCounteeragent.Enabled = false;
            this.TxtCounteeragent.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.TxtCounteeragent.Location = new System.Drawing.Point(40, 96);
            this.TxtCounteeragent.Name = "TxtCounteeragent";
            this.TxtCounteeragent.ReadOnly = true;
            this.TxtCounteeragent.Size = new System.Drawing.Size(352, 33);
            this.TxtCounteeragent.TabIndex = 31;
            // 
            // ChooseCounteragent
            // 
            this.ChooseCounteragent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseCounteragent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.ChooseCounteragent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseCounteragent.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.ChooseCounteragent.ForeColor = System.Drawing.Color.Black;
            this.ChooseCounteragent.Location = new System.Drawing.Point(410, 96);
            this.ChooseCounteragent.Name = "ChooseCounteragent";
            this.ChooseCounteragent.Size = new System.Drawing.Size(52, 33);
            this.ChooseCounteragent.TabIndex = 32;
            this.ChooseCounteragent.Text = "...";
            this.ChooseCounteragent.UseVisualStyleBackColor = true;
            this.ChooseCounteragent.Click += new System.EventHandler(this.ChooseCounteragent_Click);
            // 
            // tableForProducts
            // 
            this.tableForProducts.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tableForProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableForProducts.BackgroundColor = System.Drawing.Color.White;
            this.tableForProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableForProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableForProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableForProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nameP,
            this.price,
            this.quantity});
            this.tableForProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableForProducts.Location = new System.Drawing.Point(40, 153);
            this.tableForProducts.MultiSelect = false;
            this.tableForProducts.Name = "tableForProducts";
            this.tableForProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableForProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableForProducts.RowHeadersVisible = false;
            this.tableForProducts.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.tableForProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableForProducts.RowTemplate.Height = 35;
            this.tableForProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableForProducts.Size = new System.Drawing.Size(687, 213);
            this.tableForProducts.TabIndex = 33;
            // 
            // id
            // 
            this.id.HeaderText = "IdProduct";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 228;
            // 
            // nameP
            // 
            this.nameP.FillWeight = 280.7487F;
            this.nameP.HeaderText = "Наименование";
            this.nameP.MinimumWidth = 6;
            this.nameP.Name = "nameP";
            this.nameP.Width = 228;
            // 
            // price
            // 
            this.price.FillWeight = 1.16321F;
            this.price.HeaderText = "Цена (руб)";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 228;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 18.08813F;
            this.quantity.HeaderText = "Количество";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Width = 228;
            // 
            // BtnSell
            // 
            this.BtnSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSell.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.BtnSell.ForeColor = System.Drawing.Color.Black;
            this.BtnSell.Location = new System.Drawing.Point(410, 390);
            this.BtnSell.Name = "BtnSell";
            this.BtnSell.Size = new System.Drawing.Size(226, 39);
            this.BtnSell.TabIndex = 34;
            this.BtnSell.Text = "Продать";
            this.BtnSell.UseVisualStyleBackColor = true;
            this.BtnSell.Click += new System.EventHandler(this.BtnSell_Click);
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddProduct.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.BtnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.BtnAddProduct.Location = new System.Drawing.Point(752, 153);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(204, 34);
            this.BtnAddProduct.TabIndex = 35;
            this.BtnAddProduct.Text = "Добавить товар";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.bnClose);
            this.MainPanel.Controls.Add(this.Close);
            this.MainPanel.Controls.Add(this.BtnDelete);
            this.MainPanel.Controls.Add(this.BtnAddProduct);
            this.MainPanel.Controls.Add(this.BtnSell);
            this.MainPanel.Controls.Add(this.tableForProducts);
            this.MainPanel.Controls.Add(this.ChooseCounteragent);
            this.MainPanel.Controls.Add(this.TxtCounteeragent);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.LabForProduct);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(990, 470);
            this.MainPanel.TabIndex = 4;
            // 
            // bnClose
            // 
            this.bnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnClose.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnClose.Location = new System.Drawing.Point(12, 12);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(75, 27);
            this.bnClose.TabIndex = 37;
            this.bnClose.Text = "Назад";
            this.bnClose.UseVisualStyleBackColor = true;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // Close
            // 
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(891, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(87, 27);
            this.Close.TabIndex = 36;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Location = new System.Drawing.Point(752, 211);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(204, 34);
            this.BtnDelete.TabIndex = 33;
            this.BtnDelete.Text = "Удалить товар";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // SellProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 470);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SellProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажа товара";
            ((System.ComponentModel.ISupportInitialize)(this.tableForProducts)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabForProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCounteeragent;
        private System.Windows.Forms.Button ChooseCounteragent;
        private System.Windows.Forms.DataGridView tableForProducts;
        private System.Windows.Forms.Button BtnSell;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameP;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button bnClose;
    }
}