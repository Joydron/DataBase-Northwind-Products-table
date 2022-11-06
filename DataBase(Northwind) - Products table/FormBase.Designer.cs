namespace DataBase_Northwind____Products_table
{
    partial class ProductsTable
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
            this.dataGridView_Add = new System.Windows.Forms.DataGridView();
            this.dataGridView_Base = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.nameSearch = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pctSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Add
            // 
            this.dataGridView_Add.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Add.Location = new System.Drawing.Point(1, 263);
            this.dataGridView_Add.Name = "dataGridView_Add";
            this.dataGridView_Add.Size = new System.Drawing.Size(787, 186);
            this.dataGridView_Add.TabIndex = 0;
            // 
            // dataGridView_Base
            // 
            this.dataGridView_Base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Base.Location = new System.Drawing.Point(1, 40);
            this.dataGridView_Base.Name = "dataGridView_Base";
            this.dataGridView_Base.Size = new System.Drawing.Size(787, 186);
            this.dataGridView_Base.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(652, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(136, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // nameSearch
            // 
            this.nameSearch.AutoSize = true;
            this.nameSearch.Location = new System.Drawing.Point(552, 15);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(94, 13);
            this.nameSearch.TabIndex = 3;
            this.nameSearch.Text = "Поиск продуктов";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::DataBase_Northwind____Products_table.Properties.Resources.Save_icon;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(103, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить данные";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::DataBase_Northwind____Products_table.Properties.Resources.add_icon;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(13, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 25);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pctSearch
            // 
            this.pctSearch.Image = global::DataBase_Northwind____Products_table.Properties.Resources.search_icon;
            this.pctSearch.Location = new System.Drawing.Point(522, 12);
            this.pctSearch.Name = "pctSearch";
            this.pctSearch.Size = new System.Drawing.Size(24, 22);
            this.pctSearch.TabIndex = 6;
            this.pctSearch.TabStop = false;
            // 
            // ProductsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nameSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView_Base);
            this.Controls.Add(this.dataGridView_Add);
            this.Name = "ProductsTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Add;
        private System.Windows.Forms.DataGridView dataGridView_Base;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label nameSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pctSearch;
    }
}

