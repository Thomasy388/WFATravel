namespace WFATravel
{
    partial class Passport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passport));
            System.Windows.Forms.Label iDPassportLabel;
            System.Windows.Forms.Label iDPilgrimLabel;
            System.Windows.Forms.Label pNameLabel;
            System.Windows.Forms.Label pNumberLabel;
            System.Windows.Forms.Label pExpireLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label pictureLabel;
            this.israel_3DataSet = new WFATravel.Israel_3DataSet();
            this.passportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passportTableAdapter = new WFATravel.Israel_3DataSetTableAdapters.PassportTableAdapter();
            this.tableAdapterManager = new WFATravel.Israel_3DataSetTableAdapters.TableAdapterManager();
            this.passportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.passportBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDPassportTextBox = new System.Windows.Forms.TextBox();
            this.iDPilgrimTextBox = new System.Windows.Forms.TextBox();
            this.pNameTextBox = new System.Windows.Forms.TextBox();
            this.pNumberTextBox = new System.Windows.Forms.TextBox();
            this.pExpireDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureTextBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            iDPassportLabel = new System.Windows.Forms.Label();
            iDPilgrimLabel = new System.Windows.Forms.Label();
            pNameLabel = new System.Windows.Forms.Label();
            pNumberLabel = new System.Windows.Forms.Label();
            pExpireLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            pictureLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.israel_3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportBindingNavigator)).BeginInit();
            this.passportBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // israel_3DataSet
            // 
            this.israel_3DataSet.DataSetName = "Israel_3DataSet";
            this.israel_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passportBindingSource
            // 
            this.passportBindingSource.DataMember = "Passport";
            this.passportBindingSource.DataSource = this.israel_3DataSet;
            // 
            // passportTableAdapter
            // 
            this.passportTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PilgrimsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WFATravel.Israel_3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // passportBindingNavigator
            // 
            this.passportBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.passportBindingNavigator.BindingSource = this.passportBindingSource;
            this.passportBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.passportBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.passportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.passportBindingNavigatorSaveItem});
            this.passportBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.passportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.passportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.passportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.passportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.passportBindingNavigator.Name = "passportBindingNavigator";
            this.passportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.passportBindingNavigator.Size = new System.Drawing.Size(625, 25);
            this.passportBindingNavigator.TabIndex = 0;
            this.passportBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // passportBindingNavigatorSaveItem
            // 
            this.passportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.passportBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("passportBindingNavigatorSaveItem.Image")));
            this.passportBindingNavigatorSaveItem.Name = "passportBindingNavigatorSaveItem";
            this.passportBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.passportBindingNavigatorSaveItem.Text = "Save Data";
            this.passportBindingNavigatorSaveItem.Click += new System.EventHandler(this.passportBindingNavigatorSaveItem_Click);
            // 
            // iDPassportLabel
            // 
            iDPassportLabel.AutoSize = true;
            iDPassportLabel.Location = new System.Drawing.Point(47, 52);
            iDPassportLabel.Name = "iDPassportLabel";
            iDPassportLabel.Size = new System.Drawing.Size(62, 13);
            iDPassportLabel.TabIndex = 1;
            iDPassportLabel.Text = "IDPassport:";
            // 
            // iDPassportTextBox
            // 
            this.iDPassportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passportBindingSource, "IDPassport", true));
            this.iDPassportTextBox.Location = new System.Drawing.Point(119, 52);
            this.iDPassportTextBox.Name = "iDPassportTextBox";
            this.iDPassportTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDPassportTextBox.TabIndex = 2;
            // 
            // iDPilgrimLabel
            // 
            iDPilgrimLabel.AutoSize = true;
            iDPilgrimLabel.Location = new System.Drawing.Point(58, 85);
            iDPilgrimLabel.Name = "iDPilgrimLabel";
            iDPilgrimLabel.Size = new System.Drawing.Size(51, 13);
            iDPilgrimLabel.TabIndex = 3;
            iDPilgrimLabel.Text = "IDPilgrim:";
            // 
            // iDPilgrimTextBox
            // 
            this.iDPilgrimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passportBindingSource, "IDPilgrim", true));
            this.iDPilgrimTextBox.Location = new System.Drawing.Point(119, 82);
            this.iDPilgrimTextBox.Name = "iDPilgrimTextBox";
            this.iDPilgrimTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDPilgrimTextBox.TabIndex = 4;
            // 
            // pNameLabel
            // 
            pNameLabel.AutoSize = true;
            pNameLabel.Location = new System.Drawing.Point(64, 122);
            pNameLabel.Name = "pNameLabel";
            pNameLabel.Size = new System.Drawing.Size(45, 13);
            pNameLabel.TabIndex = 5;
            pNameLabel.Text = "PName:";
            // 
            // pNameTextBox
            // 
            this.pNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passportBindingSource, "PName", true));
            this.pNameTextBox.Location = new System.Drawing.Point(119, 119);
            this.pNameTextBox.Name = "pNameTextBox";
            this.pNameTextBox.Size = new System.Drawing.Size(288, 20);
            this.pNameTextBox.TabIndex = 6;
            // 
            // pNumberLabel
            // 
            pNumberLabel.AutoSize = true;
            pNumberLabel.Location = new System.Drawing.Point(55, 157);
            pNumberLabel.Name = "pNumberLabel";
            pNumberLabel.Size = new System.Drawing.Size(54, 13);
            pNumberLabel.TabIndex = 7;
            pNumberLabel.Text = "PNumber:";
            // 
            // pNumberTextBox
            // 
            this.pNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passportBindingSource, "PNumber", true));
            this.pNumberTextBox.Location = new System.Drawing.Point(118, 154);
            this.pNumberTextBox.Name = "pNumberTextBox";
            this.pNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.pNumberTextBox.TabIndex = 8;
            // 
            // pExpireLabel
            // 
            pExpireLabel.AutoSize = true;
            pExpireLabel.Location = new System.Drawing.Point(63, 203);
            pExpireLabel.Name = "pExpireLabel";
            pExpireLabel.Size = new System.Drawing.Size(46, 13);
            pExpireLabel.TabIndex = 9;
            pExpireLabel.Text = "PExpire:";
            // 
            // pExpireDateTimePicker
            // 
            this.pExpireDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.passportBindingSource, "PExpire", true));
            this.pExpireDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pExpireDateTimePicker.Location = new System.Drawing.Point(119, 197);
            this.pExpireDateTimePicker.Name = "pExpireDateTimePicker";
            this.pExpireDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.pExpireDateTimePicker.TabIndex = 10;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(61, 243);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(48, 13);
            birthdayLabel.TabIndex = 11;
            birthdayLabel.Text = "Birthday:";
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.passportBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(118, 237);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.birthdayDateTimePicker.TabIndex = 12;
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Location = new System.Drawing.Point(66, 276);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new System.Drawing.Size(43, 13);
            pictureLabel.TabIndex = 13;
            pictureLabel.Text = "Picture:";
            // 
            // pictureTextBox
            // 
            this.pictureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passportBindingSource, "Picture", true));
            this.pictureTextBox.Location = new System.Drawing.Point(119, 273);
            this.pictureTextBox.Name = "pictureTextBox";
            this.pictureTextBox.Size = new System.Drawing.Size(100, 20);
            this.pictureTextBox.TabIndex = 14;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(483, 269);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 43);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Passport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 324);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(pictureLabel);
            this.Controls.Add(this.pictureTextBox);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(pExpireLabel);
            this.Controls.Add(this.pExpireDateTimePicker);
            this.Controls.Add(pNumberLabel);
            this.Controls.Add(this.pNumberTextBox);
            this.Controls.Add(pNameLabel);
            this.Controls.Add(this.pNameTextBox);
            this.Controls.Add(iDPilgrimLabel);
            this.Controls.Add(this.iDPilgrimTextBox);
            this.Controls.Add(iDPassportLabel);
            this.Controls.Add(this.iDPassportTextBox);
            this.Controls.Add(this.passportBindingNavigator);
            this.Name = "Passport";
            this.Text = "Passport";
            this.Load += new System.EventHandler(this.Passport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.israel_3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportBindingNavigator)).EndInit();
            this.passportBindingNavigator.ResumeLayout(false);
            this.passportBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Israel_3DataSet israel_3DataSet;
        private System.Windows.Forms.BindingSource passportBindingSource;
        private Israel_3DataSetTableAdapters.PassportTableAdapter passportTableAdapter;
        private Israel_3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator passportBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton passportBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDPassportTextBox;
        private System.Windows.Forms.TextBox iDPilgrimTextBox;
        private System.Windows.Forms.TextBox pNameTextBox;
        private System.Windows.Forms.TextBox pNumberTextBox;
        private System.Windows.Forms.DateTimePicker pExpireDateTimePicker;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox pictureTextBox;
        private System.Windows.Forms.Button btnClose;
    }
}