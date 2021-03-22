
namespace I002
{
    partial class FormAddProduct
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.bnClose = new System.Windows.Forms.Button();
            this.TxtAddProduct = new System.Windows.Forms.TextBox();
            this.LabNameProduct = new System.Windows.Forms.Label();
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.bnClose);
            this.MainPanel.Controls.Add(this.TxtAddProduct);
            this.MainPanel.Controls.Add(this.LabNameProduct);
            this.MainPanel.Controls.Add(this.BtnAddProduct);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(479, 251);
            this.MainPanel.TabIndex = 1;
            // 
            // bnClose
            // 
            this.bnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnClose.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnClose.Location = new System.Drawing.Point(12, 12);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(75, 27);
            this.bnClose.TabIndex = 19;
            this.bnClose.Text = "Назад";
            this.bnClose.UseVisualStyleBackColor = true;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // TxtAddProduct
            // 
            this.TxtAddProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAddProduct.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.TxtAddProduct.Location = new System.Drawing.Point(75, 119);
            this.TxtAddProduct.Name = "TxtAddProduct";
            this.TxtAddProduct.Size = new System.Drawing.Size(319, 33);
            this.TxtAddProduct.TabIndex = 8;
            this.TxtAddProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabNameProduct
            // 
            this.LabNameProduct.AutoSize = true;
            this.LabNameProduct.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNameProduct.Location = new System.Drawing.Point(70, 73);
            this.LabNameProduct.Name = "LabNameProduct";
            this.LabNameProduct.Size = new System.Drawing.Size(351, 25);
            this.LabNameProduct.TabIndex = 7;
            this.LabNameProduct.Text = "Введите уникальное наименование\r\n";
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddProduct.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.BtnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.BtnAddProduct.Location = new System.Drawing.Point(163, 181);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(157, 39);
            this.BtnAddProduct.TabIndex = 0;
            this.BtnAddProduct.Text = "Добавить";
            this.BtnAddProduct.UseVisualStyleBackColor = true;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 251);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление товара";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Label LabNameProduct;
        private System.Windows.Forms.TextBox TxtAddProduct;
        private System.Windows.Forms.Button bnClose;
    }
}