
namespace I002
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPurchase = new System.Windows.Forms.Button();
            this.BtnProcurement = new System.Windows.Forms.Button();
            this.BtnProduct = new System.Windows.Forms.Button();
            this.BtnProvider = new System.Windows.Forms.Button();
            this.BtnProductOnStorage = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPurchase
            // 
            this.BtnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPurchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPurchase.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.BtnPurchase.ForeColor = System.Drawing.Color.Black;
            this.BtnPurchase.Location = new System.Drawing.Point(376, 208);
            this.BtnPurchase.Name = "BtnPurchase";
            this.BtnPurchase.Size = new System.Drawing.Size(248, 63);
            this.BtnPurchase.TabIndex = 6;
            this.BtnPurchase.Text = "Продажи";
            this.BtnPurchase.UseVisualStyleBackColor = true;
            this.BtnPurchase.Click += new System.EventHandler(this.BtnPurchase_Click);
            // 
            // BtnProcurement
            // 
            this.BtnProcurement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProcurement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnProcurement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcurement.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.BtnProcurement.ForeColor = System.Drawing.Color.Black;
            this.BtnProcurement.Location = new System.Drawing.Point(376, 86);
            this.BtnProcurement.Name = "BtnProcurement";
            this.BtnProcurement.Size = new System.Drawing.Size(248, 63);
            this.BtnProcurement.TabIndex = 5;
            this.BtnProcurement.Text = "Закупки";
            this.BtnProcurement.UseVisualStyleBackColor = true;
            this.BtnProcurement.Click += new System.EventHandler(this.BtnProcurement_Click);
            // 
            // BtnProduct
            // 
            this.BtnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProduct.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProduct.ForeColor = System.Drawing.Color.Black;
            this.BtnProduct.Location = new System.Drawing.Point(43, 86);
            this.BtnProduct.Name = "BtnProduct";
            this.BtnProduct.Size = new System.Drawing.Size(248, 63);
            this.BtnProduct.TabIndex = 3;
            this.BtnProduct.Text = "Товары";
            this.BtnProduct.UseVisualStyleBackColor = true;
            this.BtnProduct.Click += new System.EventHandler(this.BtnProduct_Click);
            // 
            // BtnProvider
            // 
            this.BtnProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProvider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProvider.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.BtnProvider.ForeColor = System.Drawing.Color.Black;
            this.BtnProvider.Location = new System.Drawing.Point(216, 328);
            this.BtnProvider.Name = "BtnProvider";
            this.BtnProvider.Size = new System.Drawing.Size(248, 63);
            this.BtnProvider.TabIndex = 2;
            this.BtnProvider.Text = "Контрагенты";
            this.BtnProvider.UseVisualStyleBackColor = true;
            this.BtnProvider.Click += new System.EventHandler(this.BtnProvider_Click);
            // 
            // BtnProductOnStorage
            // 
            this.BtnProductOnStorage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProductOnStorage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnProductOnStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductOnStorage.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.BtnProductOnStorage.ForeColor = System.Drawing.Color.Black;
            this.BtnProductOnStorage.Location = new System.Drawing.Point(43, 208);
            this.BtnProductOnStorage.Name = "BtnProductOnStorage";
            this.BtnProductOnStorage.Size = new System.Drawing.Size(248, 63);
            this.BtnProductOnStorage.TabIndex = 0;
            this.BtnProductOnStorage.Text = "Товары на складе";
            this.BtnProductOnStorage.UseVisualStyleBackColor = true;
            this.BtnProductOnStorage.Click += new System.EventHandler(this.BtnProductOnStorage_Click);
            // 
            // Close
            // 
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(587, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 27);
            this.Close.TabIndex = 7;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 425);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.BtnProcurement);
            this.Controls.Add(this.BtnPurchase);
            this.Controls.Add(this.BtnProductOnStorage);
            this.Controls.Add(this.BtnProvider);
            this.Controls.Add(this.BtnProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnProductOnStorage;
        private System.Windows.Forms.Button BtnProvider;
        private System.Windows.Forms.Button BtnPurchase;
        private System.Windows.Forms.Button BtnProcurement;
        private System.Windows.Forms.Button BtnProduct;
        private System.Windows.Forms.Button Close;
    }
}

