
namespace Annons
{
    partial class Main
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
            this.comShowCategories = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cmdSpara = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdUpdateAd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdSearchAd = new System.Windows.Forms.Button();
            this.cmdShowAd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtUserNameInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdShowInfo = new System.Windows.Forms.Button();
            this.btnSortPrice = new System.Windows.Forms.Button();
            this.btnSortDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comShowCategories
            // 
            this.comShowCategories.FormattingEnabled = true;
            this.comShowCategories.Location = new System.Drawing.Point(590, 52);
            this.comShowCategories.Name = "comShowCategories";
            this.comShowCategories.Size = new System.Drawing.Size(295, 28);
            this.comShowCategories.TabIndex = 0;
            this.comShowCategories.SelectedIndexChanged += new System.EventHandler(this.comShowCategories_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1659, 606);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(909, 52);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(171, 26);
            this.txtTitle.TabIndex = 3;
            // 
            // cmdSpara
            // 
            this.cmdSpara.Location = new System.Drawing.Point(1139, 42);
            this.cmdSpara.Name = "cmdSpara";
            this.cmdSpara.Size = new System.Drawing.Size(190, 46);
            this.cmdSpara.TabIndex = 4;
            this.cmdSpara.Text = "Spara";
            this.cmdSpara.UseVisualStyleBackColor = true;
            this.cmdSpara.Click += new System.EventHandler(this.cmdSpara_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(1139, 181);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(190, 43);
            this.cmdDelete.TabIndex = 5;
            this.cmdDelete.Text = "Radera";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(905, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(905, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Beskrivning";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(909, 122);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(171, 26);
            this.txtDescription.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(909, 198);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(171, 26);
            this.txtPrice.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(905, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pris";
            // 
            // cmdUpdateAd
            // 
            this.cmdUpdateAd.Location = new System.Drawing.Point(1139, 108);
            this.cmdUpdateAd.Name = "cmdUpdateAd";
            this.cmdUpdateAd.Size = new System.Drawing.Size(190, 51);
            this.cmdUpdateAd.TabIndex = 11;
            this.cmdUpdateAd.Text = "Updatera";
            this.cmdUpdateAd.UseVisualStyleBackColor = true;
            this.cmdUpdateAd.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kategorier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sök annons";
            // 
            // cmdSearchAd
            // 
            this.cmdSearchAd.Location = new System.Drawing.Point(28, 42);
            this.cmdSearchAd.Name = "cmdSearchAd";
            this.cmdSearchAd.Size = new System.Drawing.Size(190, 43);
            this.cmdSearchAd.TabIndex = 16;
            this.cmdSearchAd.Text = "Sök annons";
            this.cmdSearchAd.UseVisualStyleBackColor = true;
            this.cmdSearchAd.Click += new System.EventHandler(this.cmdSearchAd_Click);
            // 
            // cmdShowAd
            // 
            this.cmdShowAd.Location = new System.Drawing.Point(28, 111);
            this.cmdShowAd.Name = "cmdShowAd";
            this.cmdShowAd.Size = new System.Drawing.Size(190, 44);
            this.cmdShowAd.TabIndex = 17;
            this.cmdShowAd.Text = "Visa annonser";
            this.cmdShowAd.UseVisualStyleBackColor = true;
            this.cmdShowAd.Click += new System.EventHandler(this.cmdShowAd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(260, 54);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(295, 26);
            this.txtSearch.TabIndex = 19;
            // 
            // txtUserNameInput
            // 
            this.txtUserNameInput.Location = new System.Drawing.Point(1381, 51);
            this.txtUserNameInput.Name = "txtUserNameInput";
            this.txtUserNameInput.Size = new System.Drawing.Size(186, 26);
            this.txtUserNameInput.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1377, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Verifiering användarnamn";
            // 
            // cmdShowInfo
            // 
            this.cmdShowInfo.Location = new System.Drawing.Point(28, 180);
            this.cmdShowInfo.Name = "cmdShowInfo";
            this.cmdShowInfo.Size = new System.Drawing.Size(190, 44);
            this.cmdShowInfo.TabIndex = 22;
            this.cmdShowInfo.Text = "Visa hela annonsen";
            this.cmdShowInfo.UseVisualStyleBackColor = true;
            this.cmdShowInfo.Click += new System.EventHandler(this.cmdShowInfo_Click);
            // 
            // btnSortPrice
            // 
            this.btnSortPrice.Location = new System.Drawing.Point(260, 111);
            this.btnSortPrice.Name = "btnSortPrice";
            this.btnSortPrice.Size = new System.Drawing.Size(192, 44);
            this.btnSortPrice.TabIndex = 23;
            this.btnSortPrice.Text = "Sortera på pris";
            this.btnSortPrice.UseVisualStyleBackColor = true;
            this.btnSortPrice.Click += new System.EventHandler(this.btnSortPrice_Click);
            // 
            // btnSortDate
            // 
            this.btnSortDate.Location = new System.Drawing.Point(260, 180);
            this.btnSortDate.Name = "btnSortDate";
            this.btnSortDate.Size = new System.Drawing.Size(192, 44);
            this.btnSortDate.TabIndex = 23;
            this.btnSortDate.Text = "Sortera på datum";
            this.btnSortDate.UseVisualStyleBackColor = true;
            this.btnSortDate.Click += new System.EventHandler(this.btnSortDate_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1719, 921);
            this.Controls.Add(this.btnSortDate);
            this.Controls.Add(this.btnSortPrice);
            this.Controls.Add(this.cmdShowInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUserNameInput);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmdShowAd);
            this.Controls.Add(this.cmdSearchAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdUpdateAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdSpara);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comShowCategories);
            this.Name = "Main";
            this.Text = "Annonser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comShowCategories;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button cmdSpara;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdUpdateAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdSearchAd;
        private System.Windows.Forms.Button cmdShowAd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtUserNameInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdShowInfo;
        private System.Windows.Forms.Button btnSortPrice;
        private System.Windows.Forms.Button btnSortDate;
    }
}

