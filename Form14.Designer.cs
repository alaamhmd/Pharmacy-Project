namespace Pharmacy_Project
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            System.Windows.Forms.Label pharmacist_IDLabel;
            System.Windows.Forms.Label pharmacy_IDLabel;
            System.Windows.Forms.Label start_shiftLabel;
            System.Windows.Forms.Label end_shiftLabel;
            this.pharmacy_DBDataSet = new Pharmacy_Project.Pharmacy_DBDataSet();
            this.workBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workTableAdapter = new Pharmacy_Project.Pharmacy_DBDataSetTableAdapters.workTableAdapter();
            this.tableAdapterManager = new Pharmacy_Project.Pharmacy_DBDataSetTableAdapters.TableAdapterManager();
            this.workBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.workBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pharmacist_IDTextBox = new System.Windows.Forms.TextBox();
            this.pharmacy_IDTextBox = new System.Windows.Forms.TextBox();
            this.start_shiftTextBox = new System.Windows.Forms.TextBox();
            this.end_shiftTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pharmacistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pharmacyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startshiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endshiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.patientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.patientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            pharmacist_IDLabel = new System.Windows.Forms.Label();
            pharmacy_IDLabel = new System.Windows.Forms.Label();
            start_shiftLabel = new System.Windows.Forms.Label();
            end_shiftLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingNavigator)).BeginInit();
            this.workBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingNavigator)).BeginInit();
            this.patientBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pharmacy_DBDataSet
            // 
            this.pharmacy_DBDataSet.DataSetName = "Pharmacy_DBDataSet";
            this.pharmacy_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workBindingSource
            // 
            this.workBindingSource.DataMember = "work";
            this.workBindingSource.DataSource = this.pharmacy_DBDataSet;
            // 
            // workTableAdapter
            // 
            this.workTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.prescribeTableAdapter = null;
            this.tableAdapterManager.seen_byTableAdapter = null;
            this.tableAdapterManager.sellTableAdapter = null;
            this.tableAdapterManager.testTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pharmacy_Project.Pharmacy_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.workTableAdapter = this.workTableAdapter;
            // 
            // workBindingNavigator
            // 
            this.workBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.workBindingNavigator.BindingSource = this.workBindingSource;
            this.workBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.workBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.workBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.workBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.workBindingNavigatorSaveItem});
            this.workBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.workBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.workBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.workBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.workBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.workBindingNavigator.Name = "workBindingNavigator";
            this.workBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.workBindingNavigator.Size = new System.Drawing.Size(778, 31);
            this.workBindingNavigator.TabIndex = 0;
            this.workBindingNavigator.Text = "bindingNavigator1";
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
            // workBindingNavigatorSaveItem
            // 
            this.workBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.workBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("workBindingNavigatorSaveItem.Image")));
            this.workBindingNavigatorSaveItem.Name = "workBindingNavigatorSaveItem";
            this.workBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.workBindingNavigatorSaveItem.Text = "Save Data";
            this.workBindingNavigatorSaveItem.Click += new System.EventHandler(this.workBindingNavigatorSaveItem_Click);
            // 
            // pharmacist_IDLabel
            // 
            pharmacist_IDLabel.AutoSize = true;
            pharmacist_IDLabel.Location = new System.Drawing.Point(12, 47);
            pharmacist_IDLabel.Name = "pharmacist_IDLabel";
            pharmacist_IDLabel.Size = new System.Drawing.Size(114, 19);
            pharmacist_IDLabel.TabIndex = 1;
            pharmacist_IDLabel.Text = "Pharmacist ID:";
            // 
            // pharmacist_IDTextBox
            // 
            this.pharmacist_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workBindingSource, "Pharmacist_ID", true));
            this.pharmacist_IDTextBox.Location = new System.Drawing.Point(132, 44);
            this.pharmacist_IDTextBox.Name = "pharmacist_IDTextBox";
            this.pharmacist_IDTextBox.Size = new System.Drawing.Size(100, 27);
            this.pharmacist_IDTextBox.TabIndex = 2;
            // 
            // pharmacy_IDLabel
            // 
            pharmacy_IDLabel.AutoSize = true;
            pharmacy_IDLabel.Location = new System.Drawing.Point(12, 80);
            pharmacy_IDLabel.Name = "pharmacy_IDLabel";
            pharmacy_IDLabel.Size = new System.Drawing.Size(106, 19);
            pharmacy_IDLabel.TabIndex = 3;
            pharmacy_IDLabel.Text = "Pharmacy ID:";
            // 
            // pharmacy_IDTextBox
            // 
            this.pharmacy_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workBindingSource, "Pharmacy_ID", true));
            this.pharmacy_IDTextBox.Location = new System.Drawing.Point(132, 77);
            this.pharmacy_IDTextBox.Name = "pharmacy_IDTextBox";
            this.pharmacy_IDTextBox.Size = new System.Drawing.Size(100, 27);
            this.pharmacy_IDTextBox.TabIndex = 4;
            // 
            // start_shiftLabel
            // 
            start_shiftLabel.AutoSize = true;
            start_shiftLabel.Location = new System.Drawing.Point(12, 113);
            start_shiftLabel.Name = "start_shiftLabel";
            start_shiftLabel.Size = new System.Drawing.Size(81, 19);
            start_shiftLabel.TabIndex = 5;
            start_shiftLabel.Text = "start shift:";
            // 
            // start_shiftTextBox
            // 
            this.start_shiftTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workBindingSource, "start_shift", true));
            this.start_shiftTextBox.Location = new System.Drawing.Point(132, 110);
            this.start_shiftTextBox.Name = "start_shiftTextBox";
            this.start_shiftTextBox.Size = new System.Drawing.Size(100, 27);
            this.start_shiftTextBox.TabIndex = 6;
            // 
            // end_shiftLabel
            // 
            end_shiftLabel.AutoSize = true;
            end_shiftLabel.Location = new System.Drawing.Point(12, 146);
            end_shiftLabel.Name = "end_shiftLabel";
            end_shiftLabel.Size = new System.Drawing.Size(76, 19);
            end_shiftLabel.TabIndex = 7;
            end_shiftLabel.Text = "end shift:";
            // 
            // end_shiftTextBox
            // 
            this.end_shiftTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workBindingSource, "end_shift", true));
            this.end_shiftTextBox.Location = new System.Drawing.Point(132, 143);
            this.end_shiftTextBox.Name = "end_shiftTextBox";
            this.end_shiftTextBox.Size = new System.Drawing.Size(100, 27);
            this.end_shiftTextBox.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pharmacistIDDataGridViewTextBoxColumn,
            this.pharmacyIDDataGridViewTextBoxColumn,
            this.startshiftDataGridViewTextBoxColumn,
            this.endshiftDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(324, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(442, 267);
            this.dataGridView1.TabIndex = 9;
            // 
            // pharmacistIDDataGridViewTextBoxColumn
            // 
            this.pharmacistIDDataGridViewTextBoxColumn.DataPropertyName = "Pharmacist_ID";
            this.pharmacistIDDataGridViewTextBoxColumn.HeaderText = "Pharmacist_ID";
            this.pharmacistIDDataGridViewTextBoxColumn.Name = "pharmacistIDDataGridViewTextBoxColumn";
            // 
            // pharmacyIDDataGridViewTextBoxColumn
            // 
            this.pharmacyIDDataGridViewTextBoxColumn.DataPropertyName = "Pharmacy_ID";
            this.pharmacyIDDataGridViewTextBoxColumn.HeaderText = "Pharmacy_ID";
            this.pharmacyIDDataGridViewTextBoxColumn.Name = "pharmacyIDDataGridViewTextBoxColumn";
            // 
            // startshiftDataGridViewTextBoxColumn
            // 
            this.startshiftDataGridViewTextBoxColumn.DataPropertyName = "start_shift";
            this.startshiftDataGridViewTextBoxColumn.HeaderText = "start_shift";
            this.startshiftDataGridViewTextBoxColumn.Name = "startshiftDataGridViewTextBoxColumn";
            // 
            // endshiftDataGridViewTextBoxColumn
            // 
            this.endshiftDataGridViewTextBoxColumn.DataPropertyName = "end_shift";
            this.endshiftDataGridViewTextBoxColumn.HeaderText = "end_shift";
            this.endshiftDataGridViewTextBoxColumn.Name = "endshiftDataGridViewTextBoxColumn";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(89, 298);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 33);
            this.button7.TabIndex = 30;
            this.button7.Text = "Exit";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(149, 232);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 33);
            this.button6.TabIndex = 29;
            this.button6.Text = "Close";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(149, 193);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 33);
            this.button5.TabIndex = 28;
            this.button5.Text = "save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(30, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 33);
            this.button2.TabIndex = 27;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 33);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // patientBindingNavigator
            // 
            this.patientBindingNavigator.AddNewItem = this.toolStripButton1;
            this.patientBindingNavigator.CountItem = this.toolStripLabel1;
            this.patientBindingNavigator.DeleteItem = this.toolStripButton2;
            this.patientBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.patientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.patientBindingNavigatorSaveItem});
            this.patientBindingNavigator.Location = new System.Drawing.Point(0, 31);
            this.patientBindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.patientBindingNavigator.MoveLastItem = this.toolStripButton6;
            this.patientBindingNavigator.MoveNextItem = this.toolStripButton5;
            this.patientBindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.patientBindingNavigator.Name = "patientBindingNavigator";
            this.patientBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.patientBindingNavigator.Size = new System.Drawing.Size(778, 31);
            this.patientBindingNavigator.TabIndex = 25;
            this.patientBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 28);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "Delete";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 31);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // patientBindingNavigatorSaveItem
            // 
            this.patientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientBindingNavigatorSaveItem.Image")));
            this.patientBindingNavigatorSaveItem.Name = "patientBindingNavigatorSaveItem";
            this.patientBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.patientBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.patientBindingNavigator);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(pharmacist_IDLabel);
            this.Controls.Add(this.pharmacist_IDTextBox);
            this.Controls.Add(pharmacy_IDLabel);
            this.Controls.Add(this.pharmacy_IDTextBox);
            this.Controls.Add(start_shiftLabel);
            this.Controls.Add(this.start_shiftTextBox);
            this.Controls.Add(end_shiftLabel);
            this.Controls.Add(this.end_shiftTextBox);
            this.Controls.Add(this.workBindingNavigator);
            this.Name = "Form14";
            this.Text = "work";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workBindingNavigator)).EndInit();
            this.workBindingNavigator.ResumeLayout(false);
            this.workBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingNavigator)).EndInit();
            this.patientBindingNavigator.ResumeLayout(false);
            this.patientBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Pharmacy_DBDataSet pharmacy_DBDataSet;
        private System.Windows.Forms.BindingSource workBindingSource;
        private Pharmacy_DBDataSetTableAdapters.workTableAdapter workTableAdapter;
        private Pharmacy_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator workBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton workBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox pharmacist_IDTextBox;
        private System.Windows.Forms.TextBox pharmacy_IDTextBox;
        private System.Windows.Forms.TextBox start_shiftTextBox;
        private System.Windows.Forms.TextBox end_shiftTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pharmacistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pharmacyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startshiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endshiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingNavigator patientBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton patientBindingNavigatorSaveItem;
    }
}