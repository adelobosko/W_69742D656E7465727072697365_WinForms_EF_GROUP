namespace WinForm_EF
{
    partial class TestCSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestCSForm));
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.managerCheckBox = new System.Windows.Forms.CheckBox();
            this.countryCheckBox = new System.Windows.Forms.CheckBox();
            this.cityCheckBox = new System.Windows.Forms.CheckBox();
            this.organizationCheckBox = new System.Windows.Forms.CheckBox();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.groupBox);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.tableDataGridView);
            this.mainSplitContainer.Size = new System.Drawing.Size(800, 450);
            this.mainSplitContainer.SplitterDistance = 150;
            this.mainSplitContainer.TabIndex = 0;
            this.mainSplitContainer.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.managerCheckBox);
            this.groupBox.Controls.Add(this.countryCheckBox);
            this.groupBox.Controls.Add(this.cityCheckBox);
            this.groupBox.Controls.Add(this.organizationCheckBox);
            this.groupBox.Controls.Add(this.dateCheckBox);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 150);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Групировка по:";
            // 
            // managerCheckBox
            // 
            this.managerCheckBox.AutoSize = true;
            this.managerCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.managerCheckBox.Location = new System.Drawing.Point(3, 84);
            this.managerCheckBox.Name = "managerCheckBox";
            this.managerCheckBox.Size = new System.Drawing.Size(194, 17);
            this.managerCheckBox.TabIndex = 12;
            this.managerCheckBox.Text = "Менеджер";
            this.managerCheckBox.UseVisualStyleBackColor = true;
            this.managerCheckBox.CheckedChanged += new System.EventHandler(this.dateGroupCheckBox_CheckedChanged);
            // 
            // countryCheckBox
            // 
            this.countryCheckBox.AutoSize = true;
            this.countryCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.countryCheckBox.Location = new System.Drawing.Point(3, 67);
            this.countryCheckBox.Name = "countryCheckBox";
            this.countryCheckBox.Size = new System.Drawing.Size(194, 17);
            this.countryCheckBox.TabIndex = 11;
            this.countryCheckBox.Text = "Страна";
            this.countryCheckBox.UseVisualStyleBackColor = true;
            this.countryCheckBox.CheckedChanged += new System.EventHandler(this.dateGroupCheckBox_CheckedChanged);
            // 
            // cityCheckBox
            // 
            this.cityCheckBox.AutoSize = true;
            this.cityCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.cityCheckBox.Location = new System.Drawing.Point(3, 50);
            this.cityCheckBox.Name = "cityCheckBox";
            this.cityCheckBox.Size = new System.Drawing.Size(194, 17);
            this.cityCheckBox.TabIndex = 10;
            this.cityCheckBox.Text = "Город";
            this.cityCheckBox.UseVisualStyleBackColor = true;
            this.cityCheckBox.CheckedChanged += new System.EventHandler(this.dateGroupCheckBox_CheckedChanged);
            // 
            // organizationCheckBox
            // 
            this.organizationCheckBox.AutoSize = true;
            this.organizationCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.organizationCheckBox.Location = new System.Drawing.Point(3, 33);
            this.organizationCheckBox.Name = "organizationCheckBox";
            this.organizationCheckBox.Size = new System.Drawing.Size(194, 17);
            this.organizationCheckBox.TabIndex = 9;
            this.organizationCheckBox.Text = "Организация";
            this.organizationCheckBox.UseVisualStyleBackColor = true;
            this.organizationCheckBox.CheckedChanged += new System.EventHandler(this.dateGroupCheckBox_CheckedChanged);
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateCheckBox.Location = new System.Drawing.Point(3, 16);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(194, 17);
            this.dateCheckBox.TabIndex = 8;
            this.dateCheckBox.Text = "Дата";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            this.dateCheckBox.CheckedChanged += new System.EventHandler(this.dateGroupCheckBox_CheckedChanged);
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AllowUserToAddRows = false;
            this.tableDataGridView.AllowUserToDeleteRows = false;
            this.tableDataGridView.AllowUserToResizeColumns = false;
            this.tableDataGridView.AllowUserToResizeRows = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateColumn,
            this.organizationColumn,
            this.cityColumn,
            this.countryColumn,
            this.managerColumn,
            this.amountColumn,
            this.summColumn});
            this.tableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tableDataGridView.Size = new System.Drawing.Size(800, 296);
            this.tableDataGridView.TabIndex = 0;
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "Дата";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            // 
            // organizationColumn
            // 
            this.organizationColumn.HeaderText = "Организация";
            this.organizationColumn.Name = "organizationColumn";
            this.organizationColumn.ReadOnly = true;
            // 
            // cityColumn
            // 
            this.cityColumn.HeaderText = "Город";
            this.cityColumn.Name = "cityColumn";
            this.cityColumn.ReadOnly = true;
            // 
            // countryColumn
            // 
            this.countryColumn.HeaderText = "Страна";
            this.countryColumn.Name = "countryColumn";
            this.countryColumn.ReadOnly = true;
            // 
            // managerColumn
            // 
            this.managerColumn.HeaderText = "Менеджер";
            this.managerColumn.Name = "managerColumn";
            this.managerColumn.ReadOnly = true;
            // 
            // amountColumn
            // 
            this.amountColumn.HeaderText = "Количество";
            this.amountColumn.Name = "amountColumn";
            this.amountColumn.ReadOnly = true;
            // 
            // summColumn
            // 
            this.summColumn.HeaderText = "Сумма";
            this.summColumn.Name = "summColumn";
            this.summColumn.ReadOnly = true;
            // 
            // TestCSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainSplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestCSForm";
            this.Text = "TestCSForm";
            this.Load += new System.EventHandler(this.TestCSForm_Load);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.CheckBox managerCheckBox;
        private System.Windows.Forms.CheckBox countryCheckBox;
        private System.Windows.Forms.CheckBox cityCheckBox;
        private System.Windows.Forms.CheckBox organizationCheckBox;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summColumn;
    }
}

