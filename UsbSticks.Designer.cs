namespace Lockers
{
    partial class UsbSticks
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBWWID = new System.Windows.Forms.TextBox();
            this.TBSerialNumber = new System.Windows.Forms.TextBox();
            this.TBKeyNumber = new System.Windows.Forms.TextBox();
            this.TBColor = new System.Windows.Forms.TextBox();
            this.TBDayReturned = new System.Windows.Forms.TextBox();
            this.brn_confirm = new System.Windows.Forms.Button();
            this.labeloOutput = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBLocation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TBWWIDSearch = new System.Windows.Forms.TextBox();
            this.TBKeyNumberSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TBColorSearch = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lockerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lockersDataSet = new Lockers.LockersDataSet();
            this.lockerTableAdapter = new Lockers.LockersDataSetTableAdapters.LockerTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Returning Usb Stick";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "WWID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Serial Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Key Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(156, 299);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Day Returned:";
            // 
            // TBWWID
            // 
            this.TBWWID.Location = new System.Drawing.Point(381, 103);
            this.TBWWID.Margin = new System.Windows.Forms.Padding(4);
            this.TBWWID.Name = "TBWWID";
            this.TBWWID.Size = new System.Drawing.Size(171, 22);
            this.TBWWID.TabIndex = 6;
            // 
            // TBSerialNumber
            // 
            this.TBSerialNumber.Location = new System.Drawing.Point(381, 151);
            this.TBSerialNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TBSerialNumber.Name = "TBSerialNumber";
            this.TBSerialNumber.Size = new System.Drawing.Size(171, 22);
            this.TBSerialNumber.TabIndex = 7;
            // 
            // TBKeyNumber
            // 
            this.TBKeyNumber.Location = new System.Drawing.Point(381, 201);
            this.TBKeyNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TBKeyNumber.Name = "TBKeyNumber";
            this.TBKeyNumber.Size = new System.Drawing.Size(171, 22);
            this.TBKeyNumber.TabIndex = 8;
            // 
            // TBColor
            // 
            this.TBColor.Location = new System.Drawing.Point(381, 249);
            this.TBColor.Margin = new System.Windows.Forms.Padding(4);
            this.TBColor.Name = "TBColor";
            this.TBColor.Size = new System.Drawing.Size(171, 22);
            this.TBColor.TabIndex = 9;
            // 
            // TBDayReturned
            // 
            this.TBDayReturned.Location = new System.Drawing.Point(381, 299);
            this.TBDayReturned.Margin = new System.Windows.Forms.Padding(4);
            this.TBDayReturned.Name = "TBDayReturned";
            this.TBDayReturned.Size = new System.Drawing.Size(171, 22);
            this.TBDayReturned.TabIndex = 10;
            // 
            // brn_confirm
            // 
            this.brn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_confirm.Location = new System.Drawing.Point(644, 102);
            this.brn_confirm.Margin = new System.Windows.Forms.Padding(4);
            this.brn_confirm.Name = "brn_confirm";
            this.brn_confirm.Size = new System.Drawing.Size(152, 36);
            this.brn_confirm.TabIndex = 11;
            this.brn_confirm.Text = "Confirm";
            this.brn_confirm.UseVisualStyleBackColor = true;
            this.brn_confirm.Click += new System.EventHandler(this.brn_confirm_Click);
            // 
            // labeloOutput
            // 
            this.labeloOutput.AutoSize = true;
            this.labeloOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeloOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeloOutput.Location = new System.Drawing.Point(644, 190);
            this.labeloOutput.Name = "labeloOutput";
            this.labeloOutput.Size = new System.Drawing.Size(2, 31);
            this.labeloOutput.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(161, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Location:";
            // 
            // TBLocation
            // 
            this.TBLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBLocation.Location = new System.Drawing.Point(381, 352);
            this.TBLocation.Name = "TBLocation";
            this.TBLocation.Size = new System.Drawing.Size(171, 24);
            this.TBLocation.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(641, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Search by:";
            // 
            // TBWWIDSearch
            // 
            this.TBWWIDSearch.Location = new System.Drawing.Point(763, 311);
            this.TBWWIDSearch.Name = "TBWWIDSearch";
            this.TBWWIDSearch.Size = new System.Drawing.Size(127, 22);
            this.TBWWIDSearch.TabIndex = 16;
            // 
            // TBKeyNumberSearch
            // 
            this.TBKeyNumberSearch.Location = new System.Drawing.Point(763, 363);
            this.TBKeyNumberSearch.Name = "TBKeyNumberSearch";
            this.TBKeyNumberSearch.Size = new System.Drawing.Size(127, 22);
            this.TBKeyNumberSearch.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(642, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "WWID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(642, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Key Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(920, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "AND";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(644, 415);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 18);
            this.label12.TabIndex = 21;
            this.label12.Text = "Color";
            // 
            // TBColorSearch
            // 
            this.TBColorSearch.Location = new System.Drawing.Point(763, 415);
            this.TBColorSearch.Name = "TBColorSearch";
            this.TBColorSearch.Size = new System.Drawing.Size(127, 22);
            this.TBColorSearch.TabIndex = 22;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(644, 473);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 23;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 415);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(568, 184);
            this.dataGridView1.TabIndex = 24;
            // 
            // lockerBindingSource
            // 
            this.lockerBindingSource.DataMember = "Locker";
            this.lockerBindingSource.DataSource = this.lockersDataSet;
            // 
            // lockersDataSet
            // 
            this.lockersDataSet.DataSetName = "LockersDataSet";
            this.lockersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lockerTableAdapter
            // 
            this.lockerTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(644, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 37);
            this.button1.TabIndex = 25;
            this.button1.Text = "Assets section";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(980, 603);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 26;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // UsbSticks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 638);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.TBColorSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TBKeyNumberSearch);
            this.Controls.Add(this.TBWWIDSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBLocation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labeloOutput);
            this.Controls.Add(this.brn_confirm);
            this.Controls.Add(this.TBDayReturned);
            this.Controls.Add(this.TBColor);
            this.Controls.Add(this.TBKeyNumber);
            this.Controls.Add(this.TBSerialNumber);
            this.Controls.Add(this.TBWWID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsbSticks";
            this.Text = "Usb Stick";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lockersDataSet)).EndInit();
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
        private System.Windows.Forms.TextBox TBWWID;
        private System.Windows.Forms.TextBox TBSerialNumber;
        private System.Windows.Forms.TextBox TBKeyNumber;
        private System.Windows.Forms.TextBox TBColor;
        private System.Windows.Forms.TextBox TBDayReturned;
        private System.Windows.Forms.Button brn_confirm;
        private System.Windows.Forms.Label labeloOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBWWIDSearch;
        private System.Windows.Forms.TextBox TBKeyNumberSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TBColorSearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LockersDataSet lockersDataSet;
        private System.Windows.Forms.BindingSource lockerBindingSource;
        private LockersDataSetTableAdapters.LockerTableAdapter lockerTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_exit;
    }
}

