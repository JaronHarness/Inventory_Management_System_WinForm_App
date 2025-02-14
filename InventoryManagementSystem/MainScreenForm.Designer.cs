namespace InventoryManagementSystem
{
    partial class MainScreenForm
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
            this.MainScreenPartsDGV = new System.Windows.Forms.DataGridView();
            this.MainScreenProductsDGV = new System.Windows.Forms.DataGridView();
            this.MainScreenAddPartButton = new System.Windows.Forms.Button();
            this.MainScreenModifyPartButton = new System.Windows.Forms.Button();
            this.MainScreenDeletePartButton = new System.Windows.Forms.Button();
            this.MainScreenAddProductButton = new System.Windows.Forms.Button();
            this.MainScreenModifyProductButton = new System.Windows.Forms.Button();
            this.MainScreenDeleteProductButton = new System.Windows.Forms.Button();
            this.MainScreenTitleLabel = new System.Windows.Forms.Label();
            this.MainScreenPartsLabel = new System.Windows.Forms.Label();
            this.MainScreenProductsLabel = new System.Windows.Forms.Label();
            this.MainScreenExitButton = new System.Windows.Forms.Button();
            this.MainScreenPartsSearchButton = new System.Windows.Forms.Button();
            this.MainScreenPartsSearchTextBox = new System.Windows.Forms.TextBox();
            this.MainScreenProductsSearchTextBox = new System.Windows.Forms.TextBox();
            this.MainScreenProductsSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainScreenPartsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainScreenProductsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MainScreenPartsDGV
            // 
            this.MainScreenPartsDGV.AllowUserToAddRows = false;
            this.MainScreenPartsDGV.AllowUserToDeleteRows = false;
            this.MainScreenPartsDGV.AllowUserToOrderColumns = true;
            this.MainScreenPartsDGV.AllowUserToResizeColumns = false;
            this.MainScreenPartsDGV.AllowUserToResizeRows = false;
            this.MainScreenPartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainScreenPartsDGV.Location = new System.Drawing.Point(23, 154);
            this.MainScreenPartsDGV.MultiSelect = false;
            this.MainScreenPartsDGV.Name = "MainScreenPartsDGV";
            this.MainScreenPartsDGV.ReadOnly = true;
            this.MainScreenPartsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainScreenPartsDGV.Size = new System.Drawing.Size(525, 287);
            this.MainScreenPartsDGV.TabIndex = 0;
            this.MainScreenPartsDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
            // 
            // MainScreenProductsDGV
            // 
            this.MainScreenProductsDGV.AllowUserToAddRows = false;
            this.MainScreenProductsDGV.AllowUserToDeleteRows = false;
            this.MainScreenProductsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainScreenProductsDGV.Location = new System.Drawing.Point(607, 154);
            this.MainScreenProductsDGV.MultiSelect = false;
            this.MainScreenProductsDGV.Name = "MainScreenProductsDGV";
            this.MainScreenProductsDGV.ReadOnly = true;
            this.MainScreenProductsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainScreenProductsDGV.Size = new System.Drawing.Size(525, 287);
            this.MainScreenProductsDGV.TabIndex = 1;
            this.MainScreenProductsDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete2);
            // 
            // MainScreenAddPartButton
            // 
            this.MainScreenAddPartButton.Location = new System.Drawing.Point(23, 463);
            this.MainScreenAddPartButton.Name = "MainScreenAddPartButton";
            this.MainScreenAddPartButton.Size = new System.Drawing.Size(82, 23);
            this.MainScreenAddPartButton.TabIndex = 2;
            this.MainScreenAddPartButton.Text = "Add";
            this.MainScreenAddPartButton.UseVisualStyleBackColor = true;
            this.MainScreenAddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // MainScreenModifyPartButton
            // 
            this.MainScreenModifyPartButton.Location = new System.Drawing.Point(111, 463);
            this.MainScreenModifyPartButton.Name = "MainScreenModifyPartButton";
            this.MainScreenModifyPartButton.Size = new System.Drawing.Size(75, 23);
            this.MainScreenModifyPartButton.TabIndex = 3;
            this.MainScreenModifyPartButton.Text = "Modify";
            this.MainScreenModifyPartButton.UseVisualStyleBackColor = true;
            this.MainScreenModifyPartButton.Click += new System.EventHandler(this.MainScreenModifyPartButton_Click);
            // 
            // MainScreenDeletePartButton
            // 
            this.MainScreenDeletePartButton.Location = new System.Drawing.Point(192, 463);
            this.MainScreenDeletePartButton.Name = "MainScreenDeletePartButton";
            this.MainScreenDeletePartButton.Size = new System.Drawing.Size(75, 23);
            this.MainScreenDeletePartButton.TabIndex = 4;
            this.MainScreenDeletePartButton.Text = "Delete";
            this.MainScreenDeletePartButton.UseVisualStyleBackColor = true;
            this.MainScreenDeletePartButton.Click += new System.EventHandler(this.MainScreenDeletePartButton_Click);
            // 
            // MainScreenAddProductButton
            // 
            this.MainScreenAddProductButton.Location = new System.Drawing.Point(607, 463);
            this.MainScreenAddProductButton.Name = "MainScreenAddProductButton";
            this.MainScreenAddProductButton.Size = new System.Drawing.Size(75, 23);
            this.MainScreenAddProductButton.TabIndex = 5;
            this.MainScreenAddProductButton.Text = "Add";
            this.MainScreenAddProductButton.UseVisualStyleBackColor = true;
            this.MainScreenAddProductButton.Click += new System.EventHandler(this.MainScreenAddProductButton_Click);
            // 
            // MainScreenModifyProductButton
            // 
            this.MainScreenModifyProductButton.Location = new System.Drawing.Point(688, 463);
            this.MainScreenModifyProductButton.Name = "MainScreenModifyProductButton";
            this.MainScreenModifyProductButton.Size = new System.Drawing.Size(75, 23);
            this.MainScreenModifyProductButton.TabIndex = 6;
            this.MainScreenModifyProductButton.Text = "Modify";
            this.MainScreenModifyProductButton.UseVisualStyleBackColor = true;
            this.MainScreenModifyProductButton.Click += new System.EventHandler(this.MainScreenModifyProductButton_Click);
            // 
            // MainScreenDeleteProductButton
            // 
            this.MainScreenDeleteProductButton.Location = new System.Drawing.Point(769, 463);
            this.MainScreenDeleteProductButton.Name = "MainScreenDeleteProductButton";
            this.MainScreenDeleteProductButton.Size = new System.Drawing.Size(75, 23);
            this.MainScreenDeleteProductButton.TabIndex = 7;
            this.MainScreenDeleteProductButton.Text = "Delete";
            this.MainScreenDeleteProductButton.UseVisualStyleBackColor = true;
            this.MainScreenDeleteProductButton.Click += new System.EventHandler(this.MainScreenDeleteProductButton_Click);
            // 
            // MainScreenTitleLabel
            // 
            this.MainScreenTitleLabel.AutoSize = true;
            this.MainScreenTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainScreenTitleLabel.Location = new System.Drawing.Point(18, 27);
            this.MainScreenTitleLabel.Name = "MainScreenTitleLabel";
            this.MainScreenTitleLabel.Size = new System.Drawing.Size(314, 26);
            this.MainScreenTitleLabel.TabIndex = 8;
            this.MainScreenTitleLabel.Text = "Inventory Management System";
            // 
            // MainScreenPartsLabel
            // 
            this.MainScreenPartsLabel.AutoSize = true;
            this.MainScreenPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainScreenPartsLabel.Location = new System.Drawing.Point(19, 121);
            this.MainScreenPartsLabel.Name = "MainScreenPartsLabel";
            this.MainScreenPartsLabel.Size = new System.Drawing.Size(46, 20);
            this.MainScreenPartsLabel.TabIndex = 9;
            this.MainScreenPartsLabel.Text = "Parts";
            // 
            // MainScreenProductsLabel
            // 
            this.MainScreenProductsLabel.AutoSize = true;
            this.MainScreenProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainScreenProductsLabel.Location = new System.Drawing.Point(603, 121);
            this.MainScreenProductsLabel.Name = "MainScreenProductsLabel";
            this.MainScreenProductsLabel.Size = new System.Drawing.Size(72, 20);
            this.MainScreenProductsLabel.TabIndex = 10;
            this.MainScreenProductsLabel.Text = "Products";
            // 
            // MainScreenExitButton
            // 
            this.MainScreenExitButton.Location = new System.Drawing.Point(1057, 27);
            this.MainScreenExitButton.Name = "MainScreenExitButton";
            this.MainScreenExitButton.Size = new System.Drawing.Size(75, 23);
            this.MainScreenExitButton.TabIndex = 11;
            this.MainScreenExitButton.Text = "Exit";
            this.MainScreenExitButton.UseVisualStyleBackColor = true;
            this.MainScreenExitButton.Click += new System.EventHandler(this.MainScreenExitButton_Click);
            // 
            // MainScreenPartsSearchButton
            // 
            this.MainScreenPartsSearchButton.Location = new System.Drawing.Point(296, 118);
            this.MainScreenPartsSearchButton.Name = "MainScreenPartsSearchButton";
            this.MainScreenPartsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.MainScreenPartsSearchButton.TabIndex = 12;
            this.MainScreenPartsSearchButton.Text = "Search";
            this.MainScreenPartsSearchButton.UseVisualStyleBackColor = true;
            this.MainScreenPartsSearchButton.Click += new System.EventHandler(this.MainScreenPartsSearchButton_Click);
            // 
            // MainScreenPartsSearchTextBox
            // 
            this.MainScreenPartsSearchTextBox.Location = new System.Drawing.Point(377, 118);
            this.MainScreenPartsSearchTextBox.Name = "MainScreenPartsSearchTextBox";
            this.MainScreenPartsSearchTextBox.Size = new System.Drawing.Size(171, 20);
            this.MainScreenPartsSearchTextBox.TabIndex = 13;
            // 
            // MainScreenProductsSearchTextBox
            // 
            this.MainScreenProductsSearchTextBox.Location = new System.Drawing.Point(961, 123);
            this.MainScreenProductsSearchTextBox.Name = "MainScreenProductsSearchTextBox";
            this.MainScreenProductsSearchTextBox.Size = new System.Drawing.Size(171, 20);
            this.MainScreenProductsSearchTextBox.TabIndex = 14;
            // 
            // MainScreenProductsSearchButton
            // 
            this.MainScreenProductsSearchButton.Location = new System.Drawing.Point(880, 121);
            this.MainScreenProductsSearchButton.Name = "MainScreenProductsSearchButton";
            this.MainScreenProductsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.MainScreenProductsSearchButton.TabIndex = 15;
            this.MainScreenProductsSearchButton.Text = "Search";
            this.MainScreenProductsSearchButton.UseVisualStyleBackColor = true;
            this.MainScreenProductsSearchButton.Click += new System.EventHandler(this.MainScreenProductsSearchButton_Click);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 582);
            this.Controls.Add(this.MainScreenProductsSearchButton);
            this.Controls.Add(this.MainScreenProductsSearchTextBox);
            this.Controls.Add(this.MainScreenPartsSearchTextBox);
            this.Controls.Add(this.MainScreenPartsSearchButton);
            this.Controls.Add(this.MainScreenExitButton);
            this.Controls.Add(this.MainScreenProductsLabel);
            this.Controls.Add(this.MainScreenPartsLabel);
            this.Controls.Add(this.MainScreenTitleLabel);
            this.Controls.Add(this.MainScreenDeleteProductButton);
            this.Controls.Add(this.MainScreenModifyProductButton);
            this.Controls.Add(this.MainScreenAddProductButton);
            this.Controls.Add(this.MainScreenDeletePartButton);
            this.Controls.Add(this.MainScreenModifyPartButton);
            this.Controls.Add(this.MainScreenAddPartButton);
            this.Controls.Add(this.MainScreenProductsDGV);
            this.Controls.Add(this.MainScreenPartsDGV);
            this.Name = "MainScreenForm";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.MainScreenPartsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainScreenProductsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainScreenPartsDGV;
        private System.Windows.Forms.DataGridView MainScreenProductsDGV;
        private System.Windows.Forms.Button MainScreenAddPartButton;
        private System.Windows.Forms.Button MainScreenModifyPartButton;
        private System.Windows.Forms.Button MainScreenDeletePartButton;
        private System.Windows.Forms.Button MainScreenAddProductButton;
        private System.Windows.Forms.Button MainScreenModifyProductButton;
        private System.Windows.Forms.Button MainScreenDeleteProductButton;
        private System.Windows.Forms.Label MainScreenTitleLabel;
        private System.Windows.Forms.Label MainScreenPartsLabel;
        private System.Windows.Forms.Label MainScreenProductsLabel;
        private System.Windows.Forms.Button MainScreenExitButton;
        private System.Windows.Forms.Button MainScreenPartsSearchButton;
        private System.Windows.Forms.TextBox MainScreenPartsSearchTextBox;
        private System.Windows.Forms.TextBox MainScreenProductsSearchTextBox;
        private System.Windows.Forms.Button MainScreenProductsSearchButton;
    }
}

