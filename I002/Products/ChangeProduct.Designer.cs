
namespace I002
{
    partial class ChangeProduct
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
            this.BtnChangeProduct = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.bnClose);
            this.MainPanel.Controls.Add(this.TxtAddProduct);
            this.MainPanel.Controls.Add(this.LabNameProduct);
            this.MainPanel.Controls.Add(this.BtnChangeProduct);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(598, 256);
            this.MainPanel.TabIndex = 2;
            // 
            // bnClose
            // 
            this.bnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnClose.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnClose.Location = new System.Drawing.Point(12, 12);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(75, 27);
            this.bnClose.TabIndex = 18;
            this.bnClose.Text = "Назад";
            this.bnClose.UseVisualStyleBackColor = true;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // TxtAddProduct
            // 
            this.TxtAddProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAddProduct.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.TxtAddProduct.Location = new System.Drawing.Point(139, 113);
            this.TxtAddProduct.Name = "TxtAddProduct";
            this.TxtAddProduct.Size = new System.Drawing.Size(319, 33);
            this.TxtAddProduct.TabIndex = 8;
            this.TxtAddProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabNameProduct
            // 
            this.LabNameProduct.AutoSize = true;
            this.LabNameProduct.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNameProduct.Location = new System.Drawing.Point(121, 70);
            this.LabNameProduct.Name = "LabNameProduct";
            this.LabNameProduct.Size = new System.Drawing.Size(356, 25);
            this.LabNameProduct.TabIndex = 7;
            this.LabNameProduct.Text = "Введите уникальное наименование:";
            // 
            // BtnChangeProduct
            // 
            this.BtnChangeProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangeProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnChangeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeProduct.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.BtnChangeProduct.ForeColor = System.Drawing.Color.Black;
            this.BtnChangeProduct.Location = new System.Drawing.Point(221, 175);
            this.BtnChangeProduct.Name = "BtnChangeProduct";
            this.BtnChangeProduct.Size = new System.Drawing.Size(157, 39);
            this.BtnChangeProduct.TabIndex = 0;
            this.BtnChangeProduct.Text = "Изменить";
            this.BtnChangeProduct.UseVisualStyleBackColor = true;
            this.BtnChangeProduct.Click += new System.EventHandler(this.BtnChangeProduct_Click);
            // 
            // ChangeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 256);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangeProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование продукта";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox TxtAddProduct;
        private System.Windows.Forms.Label LabNameProduct;
        private System.Windows.Forms.Button BtnChangeProduct;
        private System.Windows.Forms.Button bnClose;
    }
}