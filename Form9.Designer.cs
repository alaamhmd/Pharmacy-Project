namespace Pharmacy_Project
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            System.Windows.Forms.Label pIDLabel;
            System.Windows.Forms.Label dIDLabel;
            System.Windows.Forms.Label drugLabel;
            System.Windows.Forms.Label date_Label;
            System.Windows.Forms.Label quantityLabel;
            this.pharmacy_DBDataSet = new Pharmacy_Project.Pharmacy_DBDataSet();
            this.prescribeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prescribeTableAdapter = new Pharmacy_Project.Pharmacy_DBDataSetTableAdapters.prescribeTableAdapter();
            this.tableAdapterManager = new Pharmacy_Project.Pharmacy_DBDataSetTableAdapters.TableAdapterManager();
            this.prescribeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.prescribeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pIDTextBox = new System.Windows.Forms.TextBox();
            this.dIDTextBox = new System.Windows.Forms.TextBox();
            this.drugTextBox = new System.Windows.Forms.TextBox();
            this.date_TextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pIDLabel = new System.Windows.Forms.Label();
            dIDLabel = new System.Windows.Forms.Label();
            drugLabel = new System.Windows.Forms.Label();
            date_Label = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescribeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescribeBindingNavigator)).BeginInit();
            this.prescribeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pharmacy_DBDataSet
            // 
            this.pharmacy_DBDataSet.DataSetName = "Pharmacy_DBDataSet";
            this.pharmacy_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prescribeBindingSource
            // 
            this.prescribeBindingSource.DataMember = "prescribe";
            this.prescribeBindingSource.DataSource = this.pharmacy_DBDataSet;
            // 
            // prescribeTableAdapter
            // 
            this.prescribeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.contractedTableAdapter = null;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.Drug_ManufactorTableAdapter = null;
            this.tableAdapterManager.DrugTableAdapter = null;
            this.tableAdapterManager.MakeTableAdapter = null;
            this.tableAdapterManager.patientTableAdapter = null;
            this.tableAdapterManager.PharmacistTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.prescribeTableAdapter = this.prescribeTableAdapter;
            this.tableAdapterManager.seen_byTableAdapter = null;
            this.tableAdapterManager.sellTableAdapter = null;
            this.tableAdapterManager.testTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pharmacy_Project.Pharmacy_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workTableAdapter = null;
            // 
            // prescribeBindingNavigator
            // 
            this.prescribeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prescribeBindingNavigator.BindingSource = this.prescribeBindingSource;
            this.prescribeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prescribeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prescribeBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.prescribeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.prescribeBindingNavigatorSaveItem});
            this.prescribeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prescribeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prescribeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prescribeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prescribeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prescribeBindingNavigator.Name = "prescribeBindingNavigator";
            this.prescribeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prescribeBindingNavigator.Size = new System.Drawing.Size(778, 31);
            this.prescribeBindingNavigator.TabIndex = 0;
            this.prescribeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // prescribeBindingNavigatorSaveItem
            // 
            this.prescribeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prescribeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prescribeBindingNavigatorSaveItem.Image")));
            this.prescribeBindingNavigatorSaveItem.Name = "prescribeBindingNavigatorSaveItem";
            this.prescribeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.prescribeBindingNavigatorSaveItem.Text = "Save Data";
            this.prescribeBindingNavigatorSaveItem.Click += new System.EventHandler(this.prescribeBindingNavigatorSaveItem_Click);
            // 
            // pIDLabel
            // 
            pIDLabel.AutoSize = true;
            pIDLabel.Location = new System.Drawing.Point(12, 39);
            pIDLabel.Name = "pIDLabel";
            pIDLabel.Size = new System.Drawing.Size(41, 19);
            pIDLabel.TabIndex = 1;
            pIDLabel.Text = "PID:";
            // 
            // pIDTextBox
            // 
            this.pIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescribeBindingSource, "PID", true));
            this.pIDTextBox.Location = new System.Drawing.Point(90, 36);
            this.pIDTextBox.Name = "pIDTextBox";
            this.pIDTextBox.Size = new System.Drawing.Size(100, 27);
            this.pIDTextBox.TabIndex = 2;
            // 
            // dIDLabel
            // 
            dIDLabel.AutoSize = true;
            dIDLabel.Location = new System.Drawing.Point(12, 72);
            dIDLabel.Name = "dIDLabel";
            dIDLabel.Size = new System.Drawing.Size(43, 19);
            dIDLabel.TabIndex = 3;
            dIDLabel.Text = "DID:";
            // 
            // dIDTextBox
            // 
            this.dIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescribeBindingSource, "DID", true));
            this.dIDTextBox.Location = new System.Drawing.Point(90, 69);
            this.dIDTextBox.Name = "dIDTextBox";
            this.dIDTextBox.Size = new System.Drawing.Size(100, 27);
            this.dIDTextBox.TabIndex = 4;
            // 
            // drugLabel
            // 
            drugLabel.AutoSize = true;
            drugLabel.Location = new System.Drawing.Point(12, 105);
            drugLabel.Name = "drugLabel";
            drugLabel.Size = new System.Drawing.Size(50, 19);
            drugLabel.TabIndex = 5;
            drugLabel.Text = "Drug:";
            // 
            // drugTextBox
            // 
            this.drugTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescribeBindingSource, "Drug", true));
            this.drugTextBox.Location = new System.Drawing.Point(90, 102);
            this.drugTextBox.Name = "drugTextBox";
            this.drugTextBox.Size = new System.Drawing.Size(100, 27);
            this.drugTextBox.TabIndex = 6;
            // 
            // date_Label
            // 
            date_Label.AutoSize = true;
            date_Label.Location = new System.Drawing.Point(12, 138);
            date_Label.Name = "date_Label";
            date_Label.Size = new System.Drawing.Size(52, 19);
            date_Label.TabIndex = 7;
            date_Label.Text = "Date :";
            // 
            // date_TextBox
            // 
            this.date_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescribeBindingSource, "Date_", true));
            this.date_TextBox.Location = new System.Drawing.Point(90, 135);
            this.date_TextBox.Name = "date_TextBox";
            this.date_TextBox.Size = new System.Drawing.Size(100, 27);
            this.date_TextBox.TabIndex = 8;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(12, 171);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(72, 19);
            quantityLabel.TabIndex = 9;
            quantityLabel.Text = "quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescribeBindingSource, "quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(90, 168);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 27);
            this.quantityTextBox.TabIndex = 10;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(66, 298);
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
            this.button6.Location = new System.Drawing.Point(126, 249);
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
            this.button5.Location = new System.Drawing.Point(126, 210);
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
            this.button2.Location = new System.Drawing.Point(12, 249);
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
            this.button1.Location = new System.Drawing.Point(12, 210);
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
            this.pIDDataGridViewTextBoxColumn,
            this.dIDDataGridViewTextBoxColumn,
            this.drugDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prescribeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(298, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(450, 225);
            this.dataGridView1.TabIndex = 33;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "PID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "PID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            // 
            // dIDDataGridViewTextBoxColumn
            // 
            this.dIDDataGridViewTextBoxColumn.DataPropertyName = "DID";
            this.dIDDataGridViewTextBoxColumn.HeaderText = "DID";
            this.dIDDataGridViewTextBoxColumn.Name = "dIDDataGridViewTextBoxColumn";
            // 
            // drugDataGridViewTextBoxColumn
            // 
            this.drugDataGridViewTextBoxColumn.DataPropertyName = "Drug";
            this.drugDataGridViewTextBoxColumn.HeaderText = "Drug";
            this.drugDataGridViewTextBoxColumn.Name = "drugDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date_";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date_";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // Form9
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
            this.Controls.Add(pIDLabel);
            this.Controls.Add(this.pIDTextBox);
            this.Controls.Add(dIDLabel);
            this.Controls.Add(this.dIDTextBox);
            this.Controls.Add(drugLabel);
            this.Controls.Add(this.drugTextBox);
            this.Controls.Add(date_Label);
            this.Controls.Add(this.date_TextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.prescribeBindingNavigator);
            this.Name = "Form9";
            this.Text = "prescribe";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescribeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescribeBindingNavigator)).EndInit();
            this.prescribeBindingNavigator.ResumeLayout(false);
            this.prescribeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Pharmacy_DBDataSet pharmacy_DBDataSet;
        private System.Windows.Forms.BindingSource prescribeBindingSource;
        private Pharmacy_DBDataSetTableAdapters.prescribeTableAdapter prescribeTableAdapter;
        private Pharmacy_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prescribeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton prescribeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox pIDTextBox;
        private System.Windows.Forms.TextBox dIDTextBox;
        private System.Windows.Forms.TextBox drugTextBox;
        private System.Windows.Forms.TextBox date_TextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}