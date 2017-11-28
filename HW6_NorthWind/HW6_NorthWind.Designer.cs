namespace HW6_NorthWind
{
    partial class HW6_NorthWind
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HW6_NorthWind));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtname = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.txtprice1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.txtprice2 = new System.Windows.Forms.ToolStripTextBox();
            this.SearchUnitPrice = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.AllProducttool = new System.Windows.Forms.ToolStripButton();
            this.AllCategory = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(909, 295);
            this.dataGridView1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.txtname,
            this.toolStripButton8,
            this.toolStripButton7,
            this.toolStripButton2,
            this.txtprice1,
            this.toolStripButton3,
            this.txtprice2,
            this.SearchUnitPrice,
            this.toolStripButton9,
            this.AllProducttool,
            this.AllCategory});
            this.toolStrip1.Location = new System.Drawing.Point(0, 494);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(920, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton1.Text = "Name:";
            // 
            // txtname
            // 
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton8.Text = "Search";
            this.toolStripButton8.Click += new System.EventHandler(this.SearchName_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(32, 22);
            this.toolStripButton7.Text = "       ";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(38, 22);
            this.toolStripButton2.Text = "Price";
            // 
            // txtprice1
            // 
            this.txtprice1.Name = "txtprice1";
            this.txtprice1.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "~";
            // 
            // txtprice2
            // 
            this.txtprice2.Name = "txtprice2";
            this.txtprice2.Size = new System.Drawing.Size(80, 25);
            // 
            // SearchUnitPrice
            // 
            this.SearchUnitPrice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SearchUnitPrice.Image = ((System.Drawing.Image)(resources.GetObject("SearchUnitPrice.Image")));
            this.SearchUnitPrice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchUnitPrice.Name = "SearchUnitPrice";
            this.SearchUnitPrice.Size = new System.Drawing.Size(49, 22);
            this.SearchUnitPrice.Text = "Search";
            this.SearchUnitPrice.Click += new System.EventHandler(this.SearchUnitPrice_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "    ";
            // 
            // AllProducttool
            // 
            this.AllProducttool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AllProducttool.Image = ((System.Drawing.Image)(resources.GetObject("AllProducttool.Image")));
            this.AllProducttool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AllProducttool.Name = "AllProducttool";
            this.AllProducttool.Size = new System.Drawing.Size(69, 22);
            this.AllProducttool.Text = "AllProduct";
            this.AllProducttool.Click += new System.EventHandler(this.AllProducttool_Click);
            // 
            // AllCategory
            // 
            this.AllCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AllCategory.Image = ((System.Drawing.Image)(resources.GetObject("AllCategory.Image")));
            this.AllCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AllCategory.Name = "AllCategory";
            this.AllCategory.Size = new System.Drawing.Size(81, 22);
            this.AllCategory.Text = "CategoryList";
            this.AllCategory.Click += new System.EventHandler(this.AllCategory_Click);
            // 
            // HW6_NorthWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 519);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HW6_NorthWind";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripTextBox txtname;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripTextBox txtprice1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripTextBox txtprice2;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton AllProducttool;
        private System.Windows.Forms.ToolStripButton AllCategory;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton SearchUnitPrice;
    }
}

