namespace wfUI
{
    partial class frmBreeder
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.cboBreederName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBreederDetails = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBreederId = new System.Windows.Forms.Label();
            this.txtBreederName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDetailHeader = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtBreederPhone = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBreederLUid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBreederLUTS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBreederAddress = new System.Windows.Forms.TextBox();
            this.txtBreederWebsite = new System.Windows.Forms.TextBox();
            this.lblc = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBreederCity = new System.Windows.Forms.TextBox();
            this.txtBreederKennel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBreederState = new System.Windows.Forms.TextBox();
            this.txtBreederEmail = new System.Windows.Forms.TextBox();
            this.labelzip = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.txtBreederZip = new System.Windows.Forms.TextBox();
            this.dgvBreeder = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreeder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Breeder";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnAll);
            this.groupBox1.Controls.Add(this.cboBreederName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(24, 62);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(221, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(436, 22);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "View All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // cboBreederName
            // 
            this.cboBreederName.FormattingEnabled = true;
            this.cboBreederName.Location = new System.Drawing.Point(221, 22);
            this.cboBreederName.Name = "cboBreederName";
            this.cboBreederName.Size = new System.Drawing.Size(121, 24);
            this.cboBreederName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Breeder Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBreederDetails);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblBreederId);
            this.groupBox2.Controls.Add(this.txtBreederName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblDetailHeader);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.chkActive);
            this.groupBox2.Controls.Add(this.txtBreederPhone);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtBreederLUid);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtBreederLUTS);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtBreederAddress);
            this.groupBox2.Controls.Add(this.txtBreederWebsite);
            this.groupBox2.Controls.Add(this.lblc);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBreederCity);
            this.groupBox2.Controls.Add(this.txtBreederKennel);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtBreederState);
            this.groupBox2.Controls.Add(this.txtBreederEmail);
            this.groupBox2.Controls.Add(this.labelzip);
            this.groupBox2.Controls.Add(this.lbl11);
            this.groupBox2.Controls.Add(this.txtBreederZip);
            this.groupBox2.Location = new System.Drawing.Point(31, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 551);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Breeder Details";
            // 
            // lblBreederDetails
            // 
            this.lblBreederDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBreederDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreederDetails.Location = new System.Drawing.Point(20, 49);
            this.lblBreederDetails.Name = "lblBreederDetails";
            this.lblBreederDetails.Size = new System.Drawing.Size(150, 170);
            this.lblBreederDetails.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, -12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 19);
            this.label3.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 79;
            this.label4.Text = "Name";
            // 
            // lblBreederId
            // 
            this.lblBreederId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBreederId.Enabled = false;
            this.lblBreederId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreederId.Location = new System.Drawing.Point(320, 9);
            this.lblBreederId.MinimumSize = new System.Drawing.Size(10, 2);
            this.lblBreederId.Name = "lblBreederId";
            this.lblBreederId.Size = new System.Drawing.Size(51, 34);
            this.lblBreederId.TabIndex = 82;
            // 
            // txtBreederName
            // 
            this.txtBreederName.Location = new System.Drawing.Point(320, 46);
            this.txtBreederName.MaxLength = 100;
            this.txtBreederName.Name = "txtBreederName";
            this.txtBreederName.Size = new System.Drawing.Size(162, 22);
            this.txtBreederName.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 81;
            this.label6.Text = "Breeder ID";
            // 
            // lblDetailHeader
            // 
            this.lblDetailHeader.AutoSize = true;
            this.lblDetailHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDetailHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailHeader.Location = new System.Drawing.Point(427, -99);
            this.lblDetailHeader.Name = "lblDetailHeader";
            this.lblDetailHeader.Size = new System.Drawing.Size(2, 19);
            this.lblDetailHeader.TabIndex = 78;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(479, 505);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 25);
            this.btnDelete.TabIndex = 77;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(387, 508);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 76;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(265, 508);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 75;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(323, 392);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(18, 17);
            this.chkActive.TabIndex = 74;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtBreederPhone
            // 
            this.txtBreederPhone.Location = new System.Drawing.Point(320, 353);
            this.txtBreederPhone.MaxLength = 12;
            this.txtBreederPhone.Name = "txtBreederPhone";
            this.txtBreederPhone.Size = new System.Drawing.Size(126, 22);
            this.txtBreederPhone.TabIndex = 73;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(199, 358);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 17);
            this.label21.TabIndex = 72;
            this.label21.Text = "Phone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(205, 397);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 17);
            this.label14.TabIndex = 71;
            this.label14.Text = "Active";
            // 
            // txtBreederLUid
            // 
            this.txtBreederLUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBreederLUid.Enabled = false;
            this.txtBreederLUid.Location = new System.Drawing.Point(323, 431);
            this.txtBreederLUid.Name = "txtBreederLUid";
            this.txtBreederLUid.Size = new System.Drawing.Size(100, 22);
            this.txtBreederLUid.TabIndex = 70;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(202, 436);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 17);
            this.label12.TabIndex = 69;
            this.label12.Text = "LastUpdateID";
            // 
            // txtBreederLUTS
            // 
            this.txtBreederLUTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBreederLUTS.Enabled = false;
            this.txtBreederLUTS.Location = new System.Drawing.Point(323, 470);
            this.txtBreederLUTS.Name = "txtBreederLUTS";
            this.txtBreederLUTS.Size = new System.Drawing.Size(159, 22);
            this.txtBreederLUTS.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 475);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 17);
            this.label11.TabIndex = 67;
            this.label11.Text = "LastUpdateTimeStamp";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(199, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 17);
            this.label15.TabIndex = 51;
            this.label15.Text = "Breeder Address";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(206, -41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 17);
            this.label16.TabIndex = 49;
            this.label16.Text = "Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(202, -78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 17);
            this.label17.TabIndex = 65;
            this.label17.Text = "Breeder ID";
            // 
            // txtBreederAddress
            // 
            this.txtBreederAddress.Location = new System.Drawing.Point(320, 80);
            this.txtBreederAddress.MaxLength = 100;
            this.txtBreederAddress.Name = "txtBreederAddress";
            this.txtBreederAddress.Size = new System.Drawing.Size(162, 22);
            this.txtBreederAddress.TabIndex = 52;
            // 
            // txtBreederWebsite
            // 
            this.txtBreederWebsite.Location = new System.Drawing.Point(320, 314);
            this.txtBreederWebsite.MaxLength = 100;
            this.txtBreederWebsite.Name = "txtBreederWebsite";
            this.txtBreederWebsite.Size = new System.Drawing.Size(162, 22);
            this.txtBreederWebsite.TabIndex = 64;
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(202, 119);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(31, 17);
            this.lblc.TabIndex = 53;
            this.lblc.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 63;
            this.label9.Text = "Website";
            // 
            // txtBreederCity
            // 
            this.txtBreederCity.Location = new System.Drawing.Point(320, 119);
            this.txtBreederCity.MaxLength = 50;
            this.txtBreederCity.Name = "txtBreederCity";
            this.txtBreederCity.Size = new System.Drawing.Size(162, 22);
            this.txtBreederCity.TabIndex = 54;
            // 
            // txtBreederKennel
            // 
            this.txtBreederKennel.Location = new System.Drawing.Point(320, 275);
            this.txtBreederKennel.MaxLength = 100;
            this.txtBreederKennel.Name = "txtBreederKennel";
            this.txtBreederKennel.Size = new System.Drawing.Size(162, 22);
            this.txtBreederKennel.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(202, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 55;
            this.label13.Text = "State";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(202, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 61;
            this.label10.Text = "Kennel";
            // 
            // txtBreederState
            // 
            this.txtBreederState.Location = new System.Drawing.Point(320, 158);
            this.txtBreederState.MaxLength = 25;
            this.txtBreederState.Name = "txtBreederState";
            this.txtBreederState.Size = new System.Drawing.Size(100, 22);
            this.txtBreederState.TabIndex = 56;
            // 
            // txtBreederEmail
            // 
            this.txtBreederEmail.Location = new System.Drawing.Point(320, 236);
            this.txtBreederEmail.MaxLength = 50;
            this.txtBreederEmail.Name = "txtBreederEmail";
            this.txtBreederEmail.Size = new System.Drawing.Size(162, 22);
            this.txtBreederEmail.TabIndex = 60;
            // 
            // labelzip
            // 
            this.labelzip.AutoSize = true;
            this.labelzip.Location = new System.Drawing.Point(199, 202);
            this.labelzip.Name = "labelzip";
            this.labelzip.Size = new System.Drawing.Size(28, 17);
            this.labelzip.TabIndex = 57;
            this.labelzip.Text = "Zip";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Location = new System.Drawing.Point(199, 241);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(42, 17);
            this.lbl11.TabIndex = 59;
            this.lbl11.Text = "Email";
            // 
            // txtBreederZip
            // 
            this.txtBreederZip.Location = new System.Drawing.Point(320, 197);
            this.txtBreederZip.MaxLength = 11;
            this.txtBreederZip.Name = "txtBreederZip";
            this.txtBreederZip.Size = new System.Drawing.Size(100, 22);
            this.txtBreederZip.TabIndex = 58;
            // 
            // dgvBreeder
            // 
            this.dgvBreeder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBreeder.Location = new System.Drawing.Point(31, 704);
            this.dgvBreeder.Name = "dgvBreeder";
            this.dgvBreeder.RowTemplate.Height = 24;
            this.dgvBreeder.Size = new System.Drawing.Size(1397, 246);
            this.dgvBreeder.TabIndex = 3;
            this.dgvBreeder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBreeder_CellContentClick);
            this.dgvBreeder.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBreeder_ColumnHeaderMouseClick);
            // 
            // frmBreeder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 963);
            this.Controls.Add(this.dgvBreeder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmBreeder";
            this.Text = "frmBreeder";
            this.Load += new System.EventHandler(this.frmBreeder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreeder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboBreederName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBreeder;
        private System.Windows.Forms.Label lblDetailHeader;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.TextBox txtBreederPhone;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBreederLUid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBreederLUTS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBreederAddress;
        private System.Windows.Forms.TextBox txtBreederWebsite;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBreederCity;
        private System.Windows.Forms.TextBox txtBreederKennel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBreederState;
        private System.Windows.Forms.TextBox txtBreederEmail;
        private System.Windows.Forms.Label labelzip;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.TextBox txtBreederZip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBreederId;
        private System.Windows.Forms.TextBox txtBreederName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBreederDetails;
        private System.Windows.Forms.Button btnAddNew;
    }
}