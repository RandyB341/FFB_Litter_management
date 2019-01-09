using System;

namespace wfUI
{
    partial class frmDog
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
            this.lblFormHeading = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBirthDate = new System.Windows.Forms.CheckBox();
            this.chkDogName = new System.Windows.Forms.CheckBox();
            this.cboBirthDate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDogName = new System.Windows.Forms.ComboBox();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDogOwner = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboBreeder = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.bnDelete = new System.Windows.Forms.Button();
            this.bnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLUTS = new System.Windows.Forms.Label();
            this.lblLastUpdateID = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.dtpDeceasedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRegCertDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEarsStayUp = new System.Windows.Forms.DateTimePicker();
            this.txtMarkings = new System.Windows.Forms.TextBox();
            this.txtCoatColor = new System.Windows.Forms.TextBox();
            this.txtMicrochipNum = new System.Windows.Forms.TextBox();
            this.txtAKCDogName = new System.Windows.Forms.TextBox();
            this.txtAKCDogID = new System.Windows.Forms.TextBox();
            this.txtDogName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDogID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cboLitter = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormHeading
            // 
            this.lblFormHeading.AutoSize = true;
            this.lblFormHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeading.Location = new System.Drawing.Point(298, 13);
            this.lblFormHeading.Name = "lblFormHeading";
            this.lblFormHeading.Size = new System.Drawing.Size(87, 29);
            this.lblFormHeading.TabIndex = 0;
            this.lblFormHeading.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBirthDate);
            this.groupBox1.Controls.Add(this.chkDogName);
            this.groupBox1.Controls.Add(this.cboBirthDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboDogName);
            this.groupBox1.Controls.Add(this.btnViewAll);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // chkBirthDate
            // 
            this.chkBirthDate.AutoSize = true;
            this.chkBirthDate.Location = new System.Drawing.Point(355, 86);
            this.chkBirthDate.Name = "chkBirthDate";
            this.chkBirthDate.Size = new System.Drawing.Size(75, 21);
            this.chkBirthDate.TabIndex = 11;
            this.chkBirthDate.Text = "Include";
            this.chkBirthDate.UseVisualStyleBackColor = true;
            // 
            // chkDogName
            // 
            this.chkDogName.AutoSize = true;
            this.chkDogName.Checked = true;
            this.chkDogName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDogName.Location = new System.Drawing.Point(453, 25);
            this.chkDogName.Name = "chkDogName";
            this.chkDogName.Size = new System.Drawing.Size(75, 21);
            this.chkDogName.TabIndex = 9;
            this.chkDogName.Text = "Include";
            this.chkDogName.UseVisualStyleBackColor = true;
            // 
            // cboBirthDate
            // 
            this.cboBirthDate.FormattingEnabled = true;
            this.cboBirthDate.Location = new System.Drawing.Point(200, 82);
            this.cboBirthDate.Name = "cboBirthDate";
            this.cboBirthDate.Size = new System.Drawing.Size(121, 24);
            this.cboBirthDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(112, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birth Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboDogName
            // 
            this.cboDogName.FormattingEnabled = true;
            this.cboDogName.Location = new System.Drawing.Point(200, 22);
            this.cboDogName.Name = "cboDogName";
            this.cboDogName.Size = new System.Drawing.Size(244, 24);
            this.cboDogName.TabIndex = 4;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(568, 25);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(92, 27);
            this.btnViewAll.TabIndex = 3;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(230, 121);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(176, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(6, 111);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(146, 33);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(91, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dog Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboDogOwner
            // 
            this.cboDogOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDogOwner.FormattingEnabled = true;
            this.cboDogOwner.Location = new System.Drawing.Point(490, 19);
            this.cboDogOwner.Name = "cboDogOwner";
            this.cboDogOwner.Size = new System.Drawing.Size(244, 37);
            this.cboDogOwner.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(372, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dog Owner";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboLitter);
            this.groupBox2.Controls.Add(this.cboBreeder);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.bnDelete);
            this.groupBox2.Controls.Add(this.bnCancel);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.lblLUTS);
            this.groupBox2.Controls.Add(this.cboDogOwner);
            this.groupBox2.Controls.Add(this.lblLastUpdateID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.chkActive);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dtpDeceasedDate);
            this.groupBox2.Controls.Add(this.dtpBirthDate);
            this.groupBox2.Controls.Add(this.dtpRegCertDate);
            this.groupBox2.Controls.Add(this.dtpEarsStayUp);
            this.groupBox2.Controls.Add(this.txtMarkings);
            this.groupBox2.Controls.Add(this.txtCoatColor);
            this.groupBox2.Controls.Add(this.txtMicrochipNum);
            this.groupBox2.Controls.Add(this.txtAKCDogName);
            this.groupBox2.Controls.Add(this.txtAKCDogID);
            this.groupBox2.Controls.Add(this.txtDogName);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblDogID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(18, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 472);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // cboBreeder
            // 
            this.cboBreeder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBreeder.FormattingEnabled = true;
            this.cboBreeder.Location = new System.Drawing.Point(489, 66);
            this.cboBreeder.Name = "cboBreeder";
            this.cboBreeder.Size = new System.Drawing.Size(245, 37);
            this.cboBreeder.TabIndex = 87;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(419, 73);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 17);
            this.label21.TabIndex = 86;
            this.label21.Text = "Breeder";
            // 
            // bnDelete
            // 
            this.bnDelete.Location = new System.Drawing.Point(630, 398);
            this.bnDelete.Name = "bnDelete";
            this.bnDelete.Size = new System.Drawing.Size(103, 37);
            this.bnDelete.TabIndex = 83;
            this.bnDelete.Text = "Delete";
            this.bnDelete.UseVisualStyleBackColor = true;
            this.bnDelete.Click += new System.EventHandler(this.bnDelete_Click);
            // 
            // bnCancel
            // 
            this.bnCancel.Location = new System.Drawing.Point(514, 398);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(96, 38);
            this.bnCancel.TabIndex = 82;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            this.bnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(431, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 39);
            this.btnSave.TabIndex = 81;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLUTS
            // 
            this.lblLUTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLUTS.Location = new System.Drawing.Point(530, 355);
            this.lblLUTS.Name = "lblLUTS";
            this.lblLUTS.Size = new System.Drawing.Size(189, 30);
            this.lblLUTS.TabIndex = 32;
            // 
            // lblLastUpdateID
            // 
            this.lblLastUpdateID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastUpdateID.Location = new System.Drawing.Point(533, 309);
            this.lblLastUpdateID.Name = "lblLastUpdateID";
            this.lblLastUpdateID.Size = new System.Drawing.Size(145, 23);
            this.lblLastUpdateID.TabIndex = 31;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(533, 277);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(18, 17);
            this.chkActive.TabIndex = 30;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoFemale);
            this.groupBox3.Controls.Add(this.rdoMale);
            this.groupBox3.Location = new System.Drawing.Point(199, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 32);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(88, 11);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(75, 21);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(7, 11);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(59, 21);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // dtpDeceasedDate
            // 
            this.dtpDeceasedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeceasedDate.Location = new System.Drawing.Point(192, 441);
            this.dtpDeceasedDate.Name = "dtpDeceasedDate";
            this.dtpDeceasedDate.Size = new System.Drawing.Size(175, 22);
            this.dtpDeceasedDate.TabIndex = 28;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(193, 376);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(174, 22);
            this.dtpBirthDate.TabIndex = 27;
            // 
            // dtpRegCertDate
            // 
            this.dtpRegCertDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegCertDate.Location = new System.Drawing.Point(193, 171);
            this.dtpRegCertDate.Name = "dtpRegCertDate";
            this.dtpRegCertDate.Size = new System.Drawing.Size(174, 22);
            this.dtpRegCertDate.TabIndex = 26;
            // 
            // dtpEarsStayUp
            // 
            this.dtpEarsStayUp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEarsStayUp.Location = new System.Drawing.Point(192, 408);
            this.dtpEarsStayUp.Name = "dtpEarsStayUp";
            this.dtpEarsStayUp.Size = new System.Drawing.Size(175, 22);
            this.dtpEarsStayUp.TabIndex = 25;
            // 
            // txtMarkings
            // 
            this.txtMarkings.Location = new System.Drawing.Point(193, 282);
            this.txtMarkings.MaxLength = 20;
            this.txtMarkings.Name = "txtMarkings";
            this.txtMarkings.Size = new System.Drawing.Size(213, 22);
            this.txtMarkings.TabIndex = 23;
            // 
            // txtCoatColor
            // 
            this.txtCoatColor.Location = new System.Drawing.Point(193, 252);
            this.txtCoatColor.MaxLength = 20;
            this.txtCoatColor.Name = "txtCoatColor";
            this.txtCoatColor.Size = new System.Drawing.Size(213, 22);
            this.txtCoatColor.TabIndex = 22;
            // 
            // txtMicrochipNum
            // 
            this.txtMicrochipNum.Location = new System.Drawing.Point(193, 216);
            this.txtMicrochipNum.MaxLength = 50;
            this.txtMicrochipNum.Name = "txtMicrochipNum";
            this.txtMicrochipNum.Size = new System.Drawing.Size(100, 22);
            this.txtMicrochipNum.TabIndex = 21;
            // 
            // txtAKCDogName
            // 
            this.txtAKCDogName.Location = new System.Drawing.Point(193, 126);
            this.txtAKCDogName.Name = "txtAKCDogName";
            this.txtAKCDogName.Size = new System.Drawing.Size(213, 22);
            this.txtAKCDogName.TabIndex = 20;
            // 
            // txtAKCDogID
            // 
            this.txtAKCDogID.Location = new System.Drawing.Point(200, 93);
            this.txtAKCDogID.Name = "txtAKCDogID";
            this.txtAKCDogID.Size = new System.Drawing.Size(100, 22);
            this.txtAKCDogID.TabIndex = 19;
            // 
            // txtDogName
            // 
            this.txtDogName.Location = new System.Drawing.Point(200, 50);
            this.txtDogName.MaxLength = 50;
            this.txtDogName.Name = "txtDogName";
            this.txtDogName.Size = new System.Drawing.Size(167, 22);
            this.txtDogName.TabIndex = 17;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(396, 341);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 44);
            this.label20.TabIndex = 16;
            this.label20.Text = "Last Update Time Stamp";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(97, 349);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 17);
            this.label19.TabIndex = 15;
            this.label19.Text = "Litter ID";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(54, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 17);
            this.label18.TabIndex = 14;
            this.label18.Text = "AKC Dog Name";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(7, 158);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(179, 48);
            this.label17.TabIndex = 13;
            this.label17.Text = "AKC Registration Certificate Date";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(51, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 17);
            this.label16.TabIndex = 12;
            this.label16.Text = "Microchip Number";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(57, 253);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "Coat Color";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(91, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "Markings";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(94, 317);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 17);
            this.label13.TabIndex = 9;
            this.label13.Text = "Gender";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(94, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Dog Name";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(68, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Birth Date";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(71, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Deceased Date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(60, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ears Stay Up Date";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(431, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Active";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(372, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Last Update ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(86, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "AKC Dog ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDogID
            // 
            this.lblDogID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDogID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogID.Location = new System.Drawing.Point(203, 18);
            this.lblDogID.Name = "lblDogID";
            this.lblDogID.Size = new System.Drawing.Size(100, 23);
            this.lblDogID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(86, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dog ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(13, 691);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1583, 219);
            this.dgv.TabIndex = 3;
            // 
            // cboLitter
            // 
            this.cboLitter.FormattingEnabled = true;
            this.cboLitter.Location = new System.Drawing.Point(193, 340);
            this.cboLitter.Name = "cboLitter";
            this.cboLitter.Size = new System.Drawing.Size(213, 24);
            this.cboLitter.TabIndex = 88;
            // 
            // frmDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 921);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFormHeading);
            this.Name = "frmDog";
            this.Text = "frmDog";
            this.Load += new System.EventHandler(this.frmDog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.Label lblFormHeading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboDogName;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBirthDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboDogOwner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDogID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLUTS;
        private System.Windows.Forms.Label lblLastUpdateID;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.DateTimePicker dtpDeceasedDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.DateTimePicker dtpRegCertDate;
        private System.Windows.Forms.DateTimePicker dtpEarsStayUp;
        private System.Windows.Forms.TextBox txtMarkings;
        private System.Windows.Forms.TextBox txtCoatColor;
        private System.Windows.Forms.TextBox txtMicrochipNum;
        private System.Windows.Forms.TextBox txtAKCDogName;
        private System.Windows.Forms.TextBox txtAKCDogID;
        private System.Windows.Forms.TextBox txtDogName;
        private System.Windows.Forms.Label label20;
        //private System.Windows.Forms.Button btnDelete;
        //private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkBirthDate;
        private System.Windows.Forms.CheckBox chkDogName;
        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.Button bnDelete;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cboBreeder;
        private System.Windows.Forms.ComboBox cboLitter;
    }
}