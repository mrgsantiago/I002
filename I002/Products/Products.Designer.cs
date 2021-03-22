
namespace I002
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BtnCha = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LabFind = new System.Windows.Forms.Label();
            this.TxtFind = new System.Windows.Forms.TextBox();
            this.tableForProducts = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.bnClose = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableForProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.bnClose);
            this.MainPanel.Controls.Add(this.Close);
            this.MainPanel.Controls.Add(this.BtnCha);
            this.MainPanel.Controls.Add(this.BtnDelete);
            this.MainPanel.Controls.Add(this.LabFind);
            this.MainPanel.Controls.Add(this.TxtFind);
            this.MainPanel.Controls.Add(this.tableForProducts);
            this.MainPanel.Controls.Add(this.BtnAdd);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(839, 522);
            this.MainPanel.TabIndex = 1;
            // 
            // BtnCha
            // 
            this.BtnCha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnCha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCha.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.BtnCha.ForeColor = System.Drawing.Color.Black;
            this.BtnCha.Location = new System.Drawing.Point(315, 424);
            this.BtnCha.Name = "BtnCha";
            this.BtnCha.Size = new System.Drawing.Size(200, 39);
            this.BtnCha.TabIndex = 8;
            this.BtnCha.Text = "Изменить товар";
            this.BtnCha.UseVisualStyleBackColor = true;
            this.BtnCha.Click += new System.EventHandler(this.BtnCha_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Location = new System.Drawing.Point(315, 471);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(200, 39);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Удалить товар";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LabFind
            // 
            this.LabFind.AutoSize = true;
            this.LabFind.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabFind.Location = new System.Drawing.Point(270, 41);
            this.LabFind.Name = "LabFind";
            this.LabFind.Size = new System.Drawing.Size(76, 25);
            this.LabFind.TabIndex = 6;
            this.LabFind.Text = "Поиск:";
            // 
            // TxtFind
            // 
            this.TxtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFind.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.TxtFind.Location = new System.Drawing.Point(362, 39);
            this.TxtFind.Name = "TxtFind";
            this.TxtFind.Size = new System.Drawing.Size(447, 33);
            this.TxtFind.TabIndex = 5;
            this.TxtFind.TextChanged += new System.EventHandler(this.TxtFind_TextChanged);
            // 
            // tableForProducts
            // 
            this.tableForProducts.AllowUserToAddRows = false;
            this.tableForProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.tableForProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tableForProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableForProducts.BackgroundColor = System.Drawing.Color.White;
            this.tableForProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableForProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tableForProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableForProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableForProducts.DefaultCellStyle = dataGridViewCellStyle8;
            this.tableForProducts.Location = new System.Drawing.Point(28, 98);
            this.tableForProducts.MultiSelect = false;
            this.tableForProducts.Name = "tableForProducts";
            this.tableForProducts.ReadOnly = true;
            this.tableForProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableForProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tableForProducts.RowHeadersVisible = false;
            this.tableForProducts.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.tableForProducts.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.tableForProducts.RowTemplate.Height = 35;
            this.tableForProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableForProducts.Size = new System.Drawing.Size(781, 272);
            this.tableForProducts.TabIndex = 4;
            this.tableForProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableForProducts_CellClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.BtnAdd.ForeColor = System.Drawing.Color.Black;
            this.BtnAdd.Location = new System.Drawing.Point(315, 376);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(200, 39);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Добавить товар";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Close
            // 
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(105, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 27);
            this.Close.TabIndex = 16;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // bnClose
            // 
            this.bnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnClose.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnClose.Location = new System.Drawing.Point(8, 12);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(75, 27);
            this.bnClose.TabIndex = 17;
            this.bnClose.Text = "Назад";
            this.bnClose.UseVisualStyleBackColor = true;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 522);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.Products_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableForProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView tableForProducts;
        private System.Windows.Forms.Label LabFind;
        private System.Windows.Forms.TextBox TxtFind;
        private System.Windows.Forms.Button BtnCha;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button bnClose;
    }
}