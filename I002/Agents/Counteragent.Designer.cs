
namespace I002
{
    partial class Counteragent
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.bnClose = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.radioBuyer = new System.Windows.Forms.RadioButton();
            this.radioProvider = new System.Windows.Forms.RadioButton();
            this.labShow = new System.Windows.Forms.Label();
            this.BtnChange = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LabFind = new System.Windows.Forms.Label();
            this.TxtFind = new System.Windows.Forms.TextBox();
            this.tableForCounteragents = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableForCounteragents)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.MainPanel.Controls.Add(this.bnClose);
            this.MainPanel.Controls.Add(this.Close);
            this.MainPanel.Controls.Add(this.radioBuyer);
            this.MainPanel.Controls.Add(this.radioProvider);
            this.MainPanel.Controls.Add(this.labShow);
            this.MainPanel.Controls.Add(this.BtnChange);
            this.MainPanel.Controls.Add(this.BtnDelete);
            this.MainPanel.Controls.Add(this.LabFind);
            this.MainPanel.Controls.Add(this.TxtFind);
            this.MainPanel.Controls.Add(this.tableForCounteragents);
            this.MainPanel.Controls.Add(this.BtnAdd);
            this.MainPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1050, 677);
            this.MainPanel.TabIndex = 2;
            // 
            // bnClose
            // 
            this.bnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnClose.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnClose.Location = new System.Drawing.Point(12, 12);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(75, 27);
            this.bnClose.TabIndex = 18;
            this.bnClose.Text = "Назад";
            this.bnClose.UseVisualStyleBackColor = true;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // Close
            // 
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(115, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(87, 27);
            this.Close.TabIndex = 17;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // radioBuyer
            // 
            this.radioBuyer.AutoSize = true;
            this.radioBuyer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBuyer.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.radioBuyer.Location = new System.Drawing.Point(892, 137);
            this.radioBuyer.Name = "radioBuyer";
            this.radioBuyer.Size = new System.Drawing.Size(134, 29);
            this.radioBuyer.TabIndex = 13;
            this.radioBuyer.Text = "Покупатели";
            this.radioBuyer.UseVisualStyleBackColor = true;
            this.radioBuyer.Click += new System.EventHandler(this.radioBuyer_Click);
            // 
            // radioProvider
            // 
            this.radioProvider.AutoSize = true;
            this.radioProvider.Checked = true;
            this.radioProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioProvider.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.radioProvider.Location = new System.Drawing.Point(892, 102);
            this.radioProvider.Name = "radioProvider";
            this.radioProvider.Size = new System.Drawing.Size(140, 29);
            this.radioProvider.TabIndex = 12;
            this.radioProvider.TabStop = true;
            this.radioProvider.Text = "Поставщики";
            this.radioProvider.UseVisualStyleBackColor = true;
            this.radioProvider.Click += new System.EventHandler(this.radioProvider_Click);
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labShow.Location = new System.Drawing.Point(783, 102);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(88, 25);
            this.labShow.TabIndex = 11;
            this.labShow.Text = "Фильтр:";
            // 
            // BtnChange
            // 
            this.BtnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChange.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.BtnChange.ForeColor = System.Drawing.Color.Black;
            this.BtnChange.Location = new System.Drawing.Point(449, 534);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(200, 43);
            this.BtnChange.TabIndex = 8;
            this.BtnChange.Text = "Изменить";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.BtnDelete.ForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Location = new System.Drawing.Point(449, 592);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(200, 43);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LabFind
            // 
            this.LabFind.AutoSize = true;
            this.LabFind.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabFind.Location = new System.Drawing.Point(405, 58);
            this.LabFind.Name = "LabFind";
            this.LabFind.Size = new System.Drawing.Size(76, 25);
            this.LabFind.TabIndex = 6;
            this.LabFind.Text = "Поиск:";
            // 
            // TxtFind
            // 
            this.TxtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFind.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.TxtFind.Location = new System.Drawing.Point(496, 56);
            this.TxtFind.Name = "TxtFind";
            this.TxtFind.Size = new System.Drawing.Size(530, 33);
            this.TxtFind.TabIndex = 5;
            this.TxtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtFind.TextChanged += new System.EventHandler(this.TxtFind_TextChanged);
            // 
            // tableForCounteragents
            // 
            this.tableForCounteragents.AllowUserToAddRows = false;
            this.tableForCounteragents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tableForCounteragents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableForCounteragents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableForCounteragents.BackgroundColor = System.Drawing.Color.White;
            this.tableForCounteragents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableForCounteragents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableForCounteragents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableForCounteragents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableForCounteragents.Location = new System.Drawing.Point(24, 172);
            this.tableForCounteragents.MultiSelect = false;
            this.tableForCounteragents.Name = "tableForCounteragents";
            this.tableForCounteragents.ReadOnly = true;
            this.tableForCounteragents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableForCounteragents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableForCounteragents.RowHeadersVisible = false;
            this.tableForCounteragents.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.tableForCounteragents.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tableForCounteragents.RowTemplate.Height = 35;
            this.tableForCounteragents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableForCounteragents.Size = new System.Drawing.Size(1002, 272);
            this.tableForCounteragents.TabIndex = 4;
            this.tableForCounteragents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableForCounteragents_CellClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Malgun Gothic", 14.25F);
            this.BtnAdd.ForeColor = System.Drawing.Color.Black;
            this.BtnAdd.Location = new System.Drawing.Point(449, 475);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(200, 43);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Counteragent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 677);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Counteragent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список контрагентов";
            this.Load += new System.EventHandler(this.Counteragent_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableForCounteragents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LabFind;
        private System.Windows.Forms.TextBox TxtFind;
        private System.Windows.Forms.DataGridView tableForCounteragents;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.RadioButton radioBuyer;
        private System.Windows.Forms.RadioButton radioProvider;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button bnClose;
    }
}