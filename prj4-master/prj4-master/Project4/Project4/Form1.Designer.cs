﻿namespace Project4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.TextBox();
            this.nocrs = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.Hybrid = new System.Windows.Forms.RadioButton();
            this.Online = new System.Windows.Forms.RadioButton();
            this.cname1 = new System.Windows.Forms.TextBox();
            this.nocrs1 = new System.Windows.Forms.TextBox();
            this.startdate = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.ctype = new System.Windows.Forms.TextBox();
            this.btnset = new System.Windows.Forms.Button();
            this.btnget = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.finaldbDataSet = new Project4.FinaldbDataSet();
            this.crsnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crsnoTableAdapter = new Project4.FinaldbDataSetTableAdapters.crsnoTableAdapter();
            this.tableAdapterManager = new Project4.FinaldbDataSetTableAdapters.TableAdapterManager();
            this.crsnoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.crsnoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.crsnoComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.finaldbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsnoBindingNavigator)).BeginInit();
            this.crsnoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NoOfCourses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Course Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "NoOfCourses";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Start Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Course Number";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(452, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Type";
            // 
            // cname
            // 
            this.cname.Location = new System.Drawing.Point(128, 36);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(100, 20);
            this.cname.TabIndex = 10;
            // 
            // nocrs
            // 
            this.nocrs.Location = new System.Drawing.Point(128, 89);
            this.nocrs.Name = "nocrs";
            this.nocrs.Size = new System.Drawing.Size(100, 20);
            this.nocrs.TabIndex = 11;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(128, 144);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 12;
            // 
            // Hybrid
            // 
            this.Hybrid.AutoSize = true;
            this.Hybrid.Location = new System.Drawing.Point(128, 227);
            this.Hybrid.Name = "Hybrid";
            this.Hybrid.Size = new System.Drawing.Size(55, 17);
            this.Hybrid.TabIndex = 14;
            this.Hybrid.TabStop = true;
            this.Hybrid.Text = "Hybrid";
            this.Hybrid.UseVisualStyleBackColor = true;
            // 
            // Online
            // 
            this.Online.AutoSize = true;
            this.Online.Location = new System.Drawing.Point(233, 227);
            this.Online.Name = "Online";
            this.Online.Size = new System.Drawing.Size(55, 17);
            this.Online.TabIndex = 15;
            this.Online.TabStop = true;
            this.Online.Text = "Online";
            this.Online.UseVisualStyleBackColor = true;
            // 
            // cname1
            // 
            this.cname1.Location = new System.Drawing.Point(533, 36);
            this.cname1.Name = "cname1";
            this.cname1.ReadOnly = true;
            this.cname1.Size = new System.Drawing.Size(100, 20);
            this.cname1.TabIndex = 16;
            // 
            // nocrs1
            // 
            this.nocrs1.Location = new System.Drawing.Point(533, 89);
            this.nocrs1.Name = "nocrs1";
            this.nocrs1.ReadOnly = true;
            this.nocrs1.Size = new System.Drawing.Size(100, 20);
            this.nocrs1.TabIndex = 17;
            // 
            // startdate
            // 
            this.startdate.Location = new System.Drawing.Point(533, 137);
            this.startdate.Name = "startdate";
            this.startdate.ReadOnly = true;
            this.startdate.Size = new System.Drawing.Size(100, 20);
            this.startdate.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(533, 186);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 19;
            // 
            // ctype
            // 
            this.ctype.Location = new System.Drawing.Point(533, 227);
            this.ctype.Name = "ctype";
            this.ctype.ReadOnly = true;
            this.ctype.Size = new System.Drawing.Size(100, 20);
            this.ctype.TabIndex = 20;
            // 
            // btnset
            // 
            this.btnset.Location = new System.Drawing.Point(138, 273);
            this.btnset.Name = "btnset";
            this.btnset.Size = new System.Drawing.Size(75, 23);
            this.btnset.TabIndex = 21;
            this.btnset.Text = "Set";
            this.btnset.UseVisualStyleBackColor = true;
            this.btnset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnget
            // 
            this.btnget.Location = new System.Drawing.Point(546, 273);
            this.btnget.Name = "btnget";
            this.btnget.Size = new System.Drawing.Size(75, 23);
            this.btnget.TabIndex = 22;
            this.btnget.Text = "Get";
            this.btnget.UseVisualStyleBackColor = true;
            this.btnget.Click += new System.EventHandler(this.btnget_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(334, 320);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 23;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // finaldbDataSet
            // 
            this.finaldbDataSet.DataSetName = "FinaldbDataSet";
            this.finaldbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crsnoBindingSource
            // 
            this.crsnoBindingSource.DataMember = "crsno";
            this.crsnoBindingSource.DataSource = this.finaldbDataSet;
            // 
            // crsnoTableAdapter
            // 
            this.crsnoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.crsnoTableAdapter = this.crsnoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project4.FinaldbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // crsnoBindingNavigator
            // 
            this.crsnoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.crsnoBindingNavigator.BindingSource = this.crsnoBindingSource;
            this.crsnoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.crsnoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.crsnoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.crsnoBindingNavigatorSaveItem});
            this.crsnoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.crsnoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.crsnoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.crsnoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.crsnoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.crsnoBindingNavigator.Name = "crsnoBindingNavigator";
            this.crsnoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.crsnoBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.crsnoBindingNavigator.TabIndex = 24;
            this.crsnoBindingNavigator.Text = "bindingNavigator1";
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
            // crsnoBindingNavigatorSaveItem
            // 
            this.crsnoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.crsnoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("crsnoBindingNavigatorSaveItem.Image")));
            this.crsnoBindingNavigatorSaveItem.Name = "crsnoBindingNavigatorSaveItem";
            this.crsnoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.crsnoBindingNavigatorSaveItem.Text = "Save Data";
            this.crsnoBindingNavigatorSaveItem.Click += new System.EventHandler(this.crsnoBindingNavigatorSaveItem_Click);
            // 
            // crsnoComboBox
            // 
            this.crsnoComboBox.DataSource = this.crsnoBindingSource;
            this.crsnoComboBox.DisplayMember = "courseno";
            this.crsnoComboBox.FormattingEnabled = true;
            this.crsnoComboBox.Location = new System.Drawing.Point(128, 181);
            this.crsnoComboBox.Name = "crsnoComboBox";
            this.crsnoComboBox.Size = new System.Drawing.Size(200, 21);
            this.crsnoComboBox.TabIndex = 25;
            this.crsnoComboBox.ValueMember = "courseno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crsnoComboBox);
            this.Controls.Add(this.crsnoBindingNavigator);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnget);
            this.Controls.Add(this.btnset);
            this.Controls.Add(this.ctype);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.nocrs1);
            this.Controls.Add(this.cname1);
            this.Controls.Add(this.Online);
            this.Controls.Add(this.Hybrid);
            this.Controls.Add(this.date);
            this.Controls.Add(this.nocrs);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finaldbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crsnoBindingNavigator)).EndInit();
            this.crsnoBindingNavigator.ResumeLayout(false);
            this.crsnoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cname;
        private System.Windows.Forms.TextBox nocrs;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.RadioButton Hybrid;
        private System.Windows.Forms.RadioButton Online;
        private System.Windows.Forms.TextBox cname1;
        private System.Windows.Forms.TextBox nocrs1;
        private System.Windows.Forms.TextBox startdate;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox ctype;
        private System.Windows.Forms.Button btnset;
        private System.Windows.Forms.Button btnget;
        private System.Windows.Forms.Button btnexit;
        private FinaldbDataSet finaldbDataSet;
        private System.Windows.Forms.BindingSource crsnoBindingSource;
        private FinaldbDataSetTableAdapters.crsnoTableAdapter crsnoTableAdapter;
        private FinaldbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator crsnoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton crsnoBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox crsnoComboBox;
    }
}

