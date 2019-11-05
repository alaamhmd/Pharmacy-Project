namespace Pharmacy_Project
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label company_IDLabel;
            System.Windows.Forms.Label pharmacy_IDLabel;
            System.Windows.Forms.Label startdateLabel;
            System.Windows.Forms.Label enddateLabel;
            this.pharmacy_DBDataSet = new Pharmacy_Project.Pharmacy_DBDataSet();
            this.contractedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractedTableAdapter = new Pharmacy_Project.Pharmacy_DBDataSetTableAdapters.contractedTableAdapter();
            this.tableAdapterManager = new Pharmacy_Project.Pharmacy_DBDataSetTableAdapters.TableAdapterManager();
            this.contractedBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.contractedBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.company_IDTextBox = new System.Windows.Forms.TextBox();
            this.pharmacy_IDTextBox = new System.Windows.Forms.TextBox();
            this.startdateTextBox = new System.Windows.Forms.TextBox();
            this.enddateTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.companyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pharmacyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            company_IDLabel = new System.Windows.Forms.Label();
            pharmacy_IDLabel = new System.Windows.Forms.Label();
            startdateLabel = new System.Windows.Forms.Label();
            enddateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractedBindingNavigator)).BeginInit();
            this.contractedBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pharmacy_DBDataSet
            // 
            this.pharmacy_DBDataSet.DataSetName = "Pharmacy_DBDataSet";
            this.pharmacy_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractedBindingSource
            // 
            this.contractedBindingSource.DataMember = "contracted";
            this.contractedBindingSource.DataSource = this.pharmacy_DBDataSet;
            // 
            // contractedTableAdapter
            // 
            this.contractedTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.contractedTableAdapter = this.contractedTableAdapter;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.Drug_ManufactorTableAdapter = null;
            this.tableAdapterManager.DrugTableAdapter = null;
            this.tableAdapterManager.MakeTableAdapter = null;
            this.tableAdapterManager.patientTableAdapter = null;
            this.tableAdapterManager.PharmacistTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.prescribeTableAdapter = null;
            this.tableAdapterManager.seen_byTableAdapter = null;
            this.tableAdapterManager.sellTableAdapter = null;
            this.tableAdapterManager.testTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pharmacy_Project.Pharmacy_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workTableAdapter = null;
            // 
            // contractedBindingNavigator
            // 
            this.contractedBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contractedBindingNavigator.BindingSource = this.contractedBindingSource;
            this.contractedBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contractedBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contractedBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contractedBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.contractedBindingNavigatorSaveItem});
            this.contractedBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contractedBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contractedBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contractedBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contractedBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contractedBindingNavigator.Name = "contractedBindingNavigator";
            this.contractedBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contractedBindingNavigator.Size = new System.Drawing.Size(778, 31);
            this.contractedBindingNavigator.TabIndex = 0;
            this.contractedBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // contractedBindingNavigatorSaveItem
            // 
            this.contractedBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contractedBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contractedBindingNavigatorSaveItem.Image")));
            this.contractedBindingNavigatorSaveItem.Name = "contractedBindingNavigatorSaveItem";
            this.contractedBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.contractedBindingNavigatorSaveItem.Text = "Save Data";
            this.contractedBindingNavigatorSaveItem.Click += new System.EventHandler(this.contractedBindingNavigatorSaveItem_Click);
            // 
            // company_IDLabel
            // 
            company_IDLabel.AutoSize = true;
            company_IDLabel.Location = new System.Drawing.Point(11, 43);
            company_IDLabel.Name = "company_IDLabel";
            company_IDLabel.Size = new System.Drawing.Size(104, 19);
            company_IDLabel.TabIndex = 1;
            company_IDLabel.Text = "Company ID:";
            // 
            // company_IDTextBox
            // 
            this.company_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractedBindingSource, "Company_ID", true));
            this.company_IDTextBox.Location = new System.Drawing.Point(155, 43);
            this.company_IDTextBox.Name = "company_IDTextBox";
            this.company_IDTextBox.Size = new System.Drawing.Size(100, 27);
            this.company_IDTextBox.TabIndex = 2;
            // 
            // pharmacy_IDLabel
            // 
            pharmacy_IDLabel.AutoSize = true;
            pharmacy_IDLabel.Location = new System.Drawing.Point(11, 76);
            pharmacy_IDLabel.Name = "pharmacy_IDLabel";
            pharmacy_IDLabel.Size = new System.Drawing.Size(106, 19);
            pharmacy_IDLabel.TabIndex = 3;
            pharmacy_IDLabel.Text = "Pharmacy ID:";
            // 
            // pharmacy_IDTextBox
            // 
            this.pharmacy_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractedBindingSource, "Pharmacy_ID", true));
            this.pharmacy_IDTextBox.Location = new System.Drawing.Point(155, 76);
            this.pharmacy_IDTextBox.Name = "pharmacy_IDTextBox";
            this.pharmacy_IDTextBox.Size = new System.Drawing.Size(100, 27);
            this.pharmacy_IDTextBox.TabIndex = 4;
            // 
            // startdateLabel
            // 
            startdateLabel.AutoSize = true;
            startdateLabel.Location = new System.Drawing.Point(11, 109);
            startdateLabel.Name = "startdateLabel";
            startdateLabel.Size = new System.Drawing.Size(76, 19);
            startdateLabel.TabIndex = 5;
            startdateLabel.Text = "startdate:";
            // 
            // startdateTextBox
            // 
            this.startdateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractedBindingSource, "startdate", true));
            this.startdateTextBox.Location = new System.Drawing.Point(155, 109);
            this.startdateTextBox.Name = "startdateTextBox";
            this.startdateTextBox.Size = new System.Drawing.Size(100, 27);
            this.startdateTextBox.TabIndex = 6;
            // 
            // enddateLabel
            // 
            enddateLabel.AutoSize = true;
            enddateLabel.Location = new System.Drawing.Point(11, 142);
            enddateLabel.Name = "enddateLabel";
            enddateLabel.Size = new System.Drawing.Size(71, 19);
            enddateLabel.TabIndex = 7;
            enddateLabel.Text = "enddate:";
            // 
            // enddateTextBox
            // 
            this.enddateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractedBindingSource, "enddate", true));
            this.enddateTextBox.Location = new System.Drawing.Point(155, 142);
            this.enddateTextBox.Name = "enddateTextBox";
            this.enddateTextBox.Size = new System.Drawing.Size(100, 27);
            this.enddateTextBox.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(73, 284);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 33);
            this.button7.TabIndex = 32;
            this.button7.Text = "Exit";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(133, 235);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 33);
            this.button6.TabIndex = 31;
            this.button6.Text = "Close";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(133, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 33);
            this.button5.TabIndex = 30;
            this.button5.Text = "save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(19, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 33);
            this.button2.TabIndex = 29;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 33);
            this.button1.TabIndex = 28;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyIDDataGridViewTextBoxColumn,
            this.pharmacyIDDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contractedBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(314, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(444, 238);
            this.dataGridView1.TabIndex = 33;
            // 
            // companyIDDataGridViewTextBoxColumn
            // 
            this.companyIDDataGridViewTextBoxColumn.DataPropertyName = "Company_ID";
            this.companyIDDataGridViewTextBoxColumn.HeaderText = "Company_ID";
            this.companyIDDataGridViewTextBoxColumn.Name = "companyIDDataGridViewTextBoxColumn";
            // 
            // pharmacyIDDataGridViewTextBoxColumn
            // 
            this.pharmacyIDDataGridViewTextBoxColumn.DataPropertyName = "Pharmacy_ID";
            this.pharmacyIDDataGridViewTextBoxColumn.HeaderText = "Pharmacy_ID";
            this.pharmacyIDDataGridViewTextBoxColumn.Name = "pharmacyIDDataGridViewTextBoxColumn";
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "startdate";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "startdate";
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "enddate";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "enddate";
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(company_IDLabel);
            this.Controls.Add(this.company_IDTextBox);
            this.Controls.Add(pharmacy_IDLabel);
            this.Controls.Add(this.pharmacy_IDTextBox);
            this.Controls.Add(startdateLabel);
            this.Controls.Add(this.startdateTextBox);
            this.Controls.Add(enddateLabel);
            this.Controls.Add(this.enddateTextBox);
            this.Controls.Add(this.contractedBindingNavigator);
            this.Name = "Form5";
            this.Text = "contracted";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractedBindingNavigator)).EndInit();
            this.contractedBindingNavigator.ResumeLayout(false);
            this.contractedBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Pharmacy_DBDataSet pharmacy_DBDataSet;
        private System.Windows.Forms.BindingSource contractedBindingSource;
        private Pharmacy_DBDataSetTableAdapters.contractedTableAdapter contractedTableAdapter;
        private Pharmacy_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contractedBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton contractedBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox company_IDTextBox;
        private System.Windows.Forms.TextBox pharmacy_IDTextBox;
        private System.Windows.Forms.TextBox startdateTextBox;
        private System.Windows.Forms.TextBox enddateTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pharmacyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
    }
}