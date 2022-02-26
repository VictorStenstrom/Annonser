
namespace Annons
{
    partial class Main2
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comShowCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowAds = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSortPrice = new System.Windows.Forms.Button();
            this.btnSortDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(61, 61);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(258, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sök";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(365, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(183, 45);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Sök Annonser";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comShowCategories
            // 
            this.comShowCategories.FormattingEnabled = true;
            this.comShowCategories.Location = new System.Drawing.Point(61, 124);
            this.comShowCategories.Name = "comShowCategories";
            this.comShowCategories.Size = new System.Drawing.Size(258, 28);
            this.comShowCategories.TabIndex = 3;
            this.comShowCategories.SelectedIndexChanged += new System.EventHandler(this.comCategories_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategorier";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1416, 654);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnShowAds
            // 
            this.btnShowAds.Location = new System.Drawing.Point(1067, 124);
            this.btnShowAds.Name = "btnShowAds";
            this.btnShowAds.Size = new System.Drawing.Size(183, 45);
            this.btnShowAds.TabIndex = 5;
            this.btnShowAds.Text = "Visa annonser";
            this.btnShowAds.UseVisualStyleBackColor = true;
            this.btnShowAds.Click += new System.EventHandler(this.btnShowAds_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1067, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 45);
            this.button3.TabIndex = 6;
            this.button3.Text = "Visa hela annonsen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnShowAllInfo_Click);
            // 
            // btnSortPrice
            // 
            this.btnSortPrice.Location = new System.Drawing.Point(1290, 52);
            this.btnSortPrice.Name = "btnSortPrice";
            this.btnSortPrice.Size = new System.Drawing.Size(183, 45);
            this.btnSortPrice.TabIndex = 7;
            this.btnSortPrice.Text = "Sortera på pris";
            this.btnSortPrice.UseVisualStyleBackColor = true;
            this.btnSortPrice.Click += new System.EventHandler(this.btnSortPrice_Click);
            // 
            // btnSortDate
            // 
            this.btnSortDate.Location = new System.Drawing.Point(1290, 124);
            this.btnSortDate.Name = "btnSortDate";
            this.btnSortDate.Size = new System.Drawing.Size(183, 45);
            this.btnSortDate.TabIndex = 7;
            this.btnSortDate.Text = "Sortera på datum";
            this.btnSortDate.UseVisualStyleBackColor = true;
            this.btnSortDate.Click += new System.EventHandler(this.btnSortDate_Click);
            // 
            // Main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 919);
            this.Controls.Add(this.btnSortDate);
            this.Controls.Add(this.btnSortPrice);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnShowAds);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comShowCategories);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Name = "Main2";
            this.Text = "Main2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comShowCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowAds;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSortPrice;
        private System.Windows.Forms.Button btnSortDate;
    }
}