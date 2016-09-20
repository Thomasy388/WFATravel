namespace WFATravel
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label iDPilgrimLabel;
            this.israel_3DataSet = new WFATravel.Israel_3DataSet();
            this.pilgrimsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilgrimsTableAdapter = new WFATravel.Israel_3DataSetTableAdapters.PilgrimsTableAdapter();
            this.tableAdapterManager = new WFATravel.Israel_3DataSetTableAdapters.TableAdapterManager();
            this.passportTableAdapter = new WFATravel.Israel_3DataSetTableAdapters.PassportTableAdapter();
            this.pilgrimsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pilgrimsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pilgrimsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnOverview = new System.Windows.Forms.Button();
            this.btnPassport = new System.Windows.Forms.Button();
            this.btnFlights = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.iDPilgrimTextBox = new System.Windows.Forms.TextBox();
            iDPilgrimLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.israel_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilgrimsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilgrimsBindingNavigator)).BeginInit();
            this.pilgrimsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilgrimsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // israel_3DataSet
            // 
            this.israel_3DataSet.DataSetName = "Israel_3DataSet";
            this.israel_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pilgrimsBindingSource
            // 
            this.pilgrimsBindingSource.DataMember = "Pilgrims";
            this.pilgrimsBindingSource.DataSource = this.israel_3DataSet;
            // 
            // pilgrimsTableAdapter
            // 
            this.pilgrimsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirportsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FlightsTableAdapter = null;
            this.tableAdapterManager.ItineraryTableAdapter = null;
            this.tableAdapterManager.LandTableAdapter = null;
            this.tableAdapterManager.PassportTableAdapter = this.passportTableAdapter;
            this.tableAdapterManager.PaymentMadeTableAdapter = null;
            this.tableAdapterManager.PaymentsDueTableAdapter = null;
            this.tableAdapterManager.PilgrimsTableAdapter = this.pilgrimsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WFATravel.Israel_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // passportTableAdapter
            // 
            this.passportTableAdapter.ClearBeforeFill = true;
            // 
            // pilgrimsBindingNavigator
            // 
            this.pilgrimsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pilgrimsBindingNavigator.BindingSource = this.pilgrimsBindingSource;
            this.pilgrimsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pilgrimsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pilgrimsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pilgrimsBindingNavigatorSaveItem});
            this.pilgrimsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pilgrimsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pilgrimsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pilgrimsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pilgrimsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pilgrimsBindingNavigator.Name = "pilgrimsBindingNavigator";
            this.pilgrimsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pilgrimsBindingNavigator.Size = new System.Drawing.Size(983, 25);
            this.pilgrimsBindingNavigator.TabIndex = 1;
            this.pilgrimsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pilgrimsBindingNavigatorSaveItem
            // 
            this.pilgrimsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pilgrimsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pilgrimsBindingNavigatorSaveItem.Image")));
            this.pilgrimsBindingNavigatorSaveItem.Name = "pilgrimsBindingNavigatorSaveItem";
            this.pilgrimsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pilgrimsBindingNavigatorSaveItem.Text = "Save Data";
            this.pilgrimsBindingNavigatorSaveItem.Click += new System.EventHandler(this.pilgrimsBindingNavigatorSaveItem_Click);
            // 
            // pilgrimsDataGridView
            // 
            this.pilgrimsDataGridView.AutoGenerateColumns = false;
            this.pilgrimsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pilgrimsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.pilgrimsDataGridView.DataSource = this.pilgrimsBindingSource;
            this.pilgrimsDataGridView.Location = new System.Drawing.Point(12, 41);
            this.pilgrimsDataGridView.Name = "pilgrimsDataGridView";
            this.pilgrimsDataGridView.Size = new System.Drawing.Size(753, 527);
            this.pilgrimsDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDPilgrim";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDPilgrim";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fName";
            this.dataGridViewTextBoxColumn2.HeaderText = "fName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lName";
            this.dataGridViewTextBoxColumn3.HeaderText = "lName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Airport";
            this.dataGridViewTextBoxColumn4.HeaderText = "Airport";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "eMail";
            this.dataGridViewTextBoxColumn6.HeaderText = "eMail";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Balance";
            this.dataGridViewTextBoxColumn7.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // passportBindingSource
            // 
            this.passportBindingSource.DataMember = "Passport";
            this.passportBindingSource.DataSource = this.israel_3DataSet;
            // 
            // btnOverview
            // 
            this.btnOverview.Location = new System.Drawing.Point(784, 41);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(130, 44);
            this.btnOverview.TabIndex = 3;
            this.btnOverview.Text = "Overview";
            this.btnOverview.UseVisualStyleBackColor = true;
            this.btnOverview.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPassport
            // 
            this.btnPassport.Location = new System.Drawing.Point(784, 91);
            this.btnPassport.Name = "btnPassport";
            this.btnPassport.Size = new System.Drawing.Size(130, 44);
            this.btnPassport.TabIndex = 4;
            this.btnPassport.Text = "Passport";
            this.btnPassport.UseVisualStyleBackColor = true;
            this.btnPassport.Click += new System.EventHandler(this.btnPassport_Click);
            // 
            // btnFlights
            // 
            this.btnFlights.Location = new System.Drawing.Point(784, 141);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.Size = new System.Drawing.Size(130, 44);
            this.btnFlights.TabIndex = 5;
            this.btnFlights.Text = "Flights";
            this.btnFlights.UseVisualStyleBackColor = true;
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(784, 191);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(130, 43);
            this.btnBilling.TabIndex = 6;
            this.btnBilling.Text = "Billing";
            this.btnBilling.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(784, 520);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 43);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // iDPilgrimLabel
            // 
            iDPilgrimLabel.AutoSize = true;
            iDPilgrimLabel.Location = new System.Drawing.Point(806, 344);
            iDPilgrimLabel.Name = "iDPilgrimLabel";
            iDPilgrimLabel.Size = new System.Drawing.Size(51, 13);
            iDPilgrimLabel.TabIndex = 7;
            iDPilgrimLabel.Text = "IDPilgrim:";
            // 
            // iDPilgrimTextBox
            // 
            this.iDPilgrimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pilgrimsBindingSource, "IDPilgrim", true));
            this.iDPilgrimTextBox.Location = new System.Drawing.Point(863, 341);
            this.iDPilgrimTextBox.Name = "iDPilgrimTextBox";
            this.iDPilgrimTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDPilgrimTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 588);
            this.Controls.Add(iDPilgrimLabel);
            this.Controls.Add(this.iDPilgrimTextBox);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBilling);
            this.Controls.Add(this.btnFlights);
            this.Controls.Add(this.btnPassport);
            this.Controls.Add(this.btnOverview);
            this.Controls.Add(this.pilgrimsDataGridView);
            this.Controls.Add(this.pilgrimsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.israel_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilgrimsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilgrimsBindingNavigator)).EndInit();
            this.pilgrimsBindingNavigator.ResumeLayout(false);
            this.pilgrimsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilgrimsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Israel_3DataSet israel_3DataSet;
        private System.Windows.Forms.BindingSource pilgrimsBindingSource;
        private Israel_3DataSetTableAdapters.PilgrimsTableAdapter pilgrimsTableAdapter;
        private Israel_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pilgrimsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pilgrimsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pilgrimsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Israel_3DataSetTableAdapters.PassportTableAdapter passportTableAdapter;
        private System.Windows.Forms.BindingSource passportBindingSource;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Button btnPassport;
        private System.Windows.Forms.Button btnFlights;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox iDPilgrimTextBox;
    }
}

