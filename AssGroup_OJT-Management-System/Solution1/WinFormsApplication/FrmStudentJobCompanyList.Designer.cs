
namespace WinFormsApplication
{
    partial class FrmStudentJobCompanyList
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
            this.PnFilter = new System.Windows.Forms.Panel();
            this.LbFilterJobCompanyList = new System.Windows.Forms.Label();
            this.CbFilterJobCompanyList = new System.Windows.Forms.ComboBox();
            this.BtnSearchJobList = new FontAwesome.Sharp.IconButton();
            this.TxtSearchJobCompanyName = new System.Windows.Forms.TextBox();
            this.PnLayout = new System.Windows.Forms.Panel();
            this.DgvCompaniesList = new System.Windows.Forms.DataGridView();
            this.PnFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompaniesList)).BeginInit();
            this.SuspendLayout();
            // 
            // PnFilter
            // 
            this.PnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.PnFilter.Controls.Add(this.LbFilterJobCompanyList);
            this.PnFilter.Controls.Add(this.CbFilterJobCompanyList);
            this.PnFilter.Controls.Add(this.BtnSearchJobList);
            this.PnFilter.Controls.Add(this.TxtSearchJobCompanyName);
            this.PnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnFilter.Location = new System.Drawing.Point(0, 0);
            this.PnFilter.Name = "PnFilter";
            this.PnFilter.Size = new System.Drawing.Size(1093, 91);
            this.PnFilter.TabIndex = 1;
            // 
            // LbFilterJobCompanyList
            // 
            this.LbFilterJobCompanyList.AutoSize = true;
            this.LbFilterJobCompanyList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbFilterJobCompanyList.Location = new System.Drawing.Point(93, 45);
            this.LbFilterJobCompanyList.Name = "LbFilterJobCompanyList";
            this.LbFilterJobCompanyList.Size = new System.Drawing.Size(100, 24);
            this.LbFilterJobCompanyList.TabIndex = 3;
            this.LbFilterJobCompanyList.Text = "Search By: ";
            // 
            // CbFilterJobCompanyList
            // 
            this.CbFilterJobCompanyList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbFilterJobCompanyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterJobCompanyList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbFilterJobCompanyList.FormattingEnabled = true;
            this.CbFilterJobCompanyList.Items.AddRange(new object[] {
            "Company name",
            "Company Address",
            "Job name",
            "Status"});
            this.CbFilterJobCompanyList.Location = new System.Drawing.Point(199, 37);
            this.CbFilterJobCompanyList.Name = "CbFilterJobCompanyList";
            this.CbFilterJobCompanyList.Size = new System.Drawing.Size(178, 32);
            this.CbFilterJobCompanyList.TabIndex = 2;
            // 
            // BtnSearchJobList
            // 
            this.BtnSearchJobList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchJobList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchJobList.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearchJobList.IconColor = System.Drawing.Color.Black;
            this.BtnSearchJobList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSearchJobList.IconSize = 25;
            this.BtnSearchJobList.Location = new System.Drawing.Point(934, 37);
            this.BtnSearchJobList.Name = "BtnSearchJobList";
            this.BtnSearchJobList.Size = new System.Drawing.Size(64, 32);
            this.BtnSearchJobList.TabIndex = 1;
            this.BtnSearchJobList.UseVisualStyleBackColor = true;
            this.BtnSearchJobList.Click += new System.EventHandler(this.BtnSearchJobList_Click);
            // 
            // TxtSearchJobCompanyName
            // 
            this.TxtSearchJobCompanyName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearchJobCompanyName.Location = new System.Drawing.Point(411, 37);
            this.TxtSearchJobCompanyName.Name = "TxtSearchJobCompanyName";
            this.TxtSearchJobCompanyName.Size = new System.Drawing.Size(490, 32);
            this.TxtSearchJobCompanyName.TabIndex = 0;
            // 
            // PnLayout
            // 
            this.PnLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLayout.Location = new System.Drawing.Point(0, 91);
            this.PnLayout.Name = "PnLayout";
            this.PnLayout.Size = new System.Drawing.Size(1093, 1);
            this.PnLayout.TabIndex = 2;
            // 
            // DgvCompaniesList
            // 
            this.DgvCompaniesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCompaniesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCompaniesList.Location = new System.Drawing.Point(0, 92);
            this.DgvCompaniesList.Name = "DgvCompaniesList";
            this.DgvCompaniesList.RowHeadersWidth = 51;
            this.DgvCompaniesList.RowTemplate.Height = 29;
            this.DgvCompaniesList.Size = new System.Drawing.Size(1093, 459);
            this.DgvCompaniesList.TabIndex = 3;
            this.DgvCompaniesList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCompaniesList_CellDoubleClick);
            // 
            // FrmStudentJobCompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 551);
            this.Controls.Add(this.DgvCompaniesList);
            this.Controls.Add(this.PnLayout);
            this.Controls.Add(this.PnFilter);
            this.MaximumSize = new System.Drawing.Size(1332, 747);
            this.MinimumSize = new System.Drawing.Size(1111, 598);
            this.Name = "FrmStudentJobCompanyList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jobs List";
            this.Load += new System.EventHandler(this.FrmStudentJobCompanyList_Load);
            this.PnFilter.ResumeLayout(false);
            this.PnFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompaniesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnFilter;
        private System.Windows.Forms.TextBox TxtSearchJobCompanyName;
        private FontAwesome.Sharp.IconButton BtnSearchJobList;
        private System.Windows.Forms.Panel PnLayout;
        private System.Windows.Forms.Label LbFilterJobCompanyList;
        private System.Windows.Forms.ComboBox CbFilterJobCompanyList;
        private System.Windows.Forms.DataGridView DgvCompaniesList;
    }
}