namespace wfUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabBreeder = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnAllBreeders = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.cboBreederName = new System.Windows.Forms.ComboBox();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.lblDetailHeader = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtBreederPhone = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBreederLUid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBreederLUTS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBreederId = new System.Windows.Forms.Label();
            this.txtBreederName = new System.Windows.Forms.TextBox();
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
            this.tabDogOwner = new System.Windows.Forms.TabPage();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvBreeders = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.TabBreeder.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.tabDogOwner.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreeders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabBreeder);
            this.tabControl1.Controls.Add(this.tabDogOwner);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 953);
            this.tabControl1.TabIndex = 0;
            // 
            // TabBreeder
            // 
            this.TabBreeder.Controls.Add(this.dgvBreeders);
            this.TabBreeder.Controls.Add(this.pnlGrid);
            this.TabBreeder.Controls.Add(this.label19);
            this.TabBreeder.Controls.Add(this.pnlSearch);
            this.TabBreeder.Controls.Add(this.pnlDetail);
            this.TabBreeder.Location = new System.Drawing.Point(4, 25);
            this.TabBreeder.Name = "TabBreeder";
            this.TabBreeder.Padding = new System.Windows.Forms.Padding(3);
            this.TabBreeder.Size = new System.Drawing.Size(792, 924);
            this.TabBreeder.TabIndex = 0;
            this.TabBreeder.Text = "Breeders";
            this.TabBreeder.UseVisualStyleBackColor = true;
            this.TabBreeder.Enter += new System.EventHandler(this.TabBreeder_Enter);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(183, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 25);
            this.label19.TabIndex = 38;
            this.label19.Text = "Breeders";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnAllBreeders);
            this.pnlSearch.Controls.Add(this.btnAddNew);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.label20);
            this.pnlSearch.Controls.Add(this.cboBreederName);
            this.pnlSearch.Location = new System.Drawing.Point(9, 28);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(775, 96);
            this.pnlSearch.TabIndex = 37;
            // 
            // btnAllBreeders
            // 
            this.btnAllBreeders.Location = new System.Drawing.Point(439, 15);
            this.btnAllBreeders.Name = "btnAllBreeders";
            this.btnAllBreeders.Size = new System.Drawing.Size(116, 23);
            this.btnAllBreeders.TabIndex = 4;
            this.btnAllBreeders.Text = "All Breeders";
            this.btnAllBreeders.UseVisualStyleBackColor = true;
            this.btnAllBreeders.Click += new System.EventHandler(this.btnAllBreeders_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(298, 60);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(142, 23);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add New Breeder";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(179, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(104, 14);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 17);
            this.label20.TabIndex = 1;
            this.label20.Text = "Breeder Name";
            // 
            // cboBreederName
            // 
            this.cboBreederName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBreederName.FormattingEnabled = true;
            this.cboBreederName.Location = new System.Drawing.Point(222, 14);
            this.cboBreederName.MaxLength = 100;
            this.cboBreederName.Name = "cboBreederName";
            this.cboBreederName.Size = new System.Drawing.Size(170, 24);
            this.cboBreederName.TabIndex = 0;
            this.cboBreederName.SelectedIndexChanged += new System.EventHandler(this.cboBreederName_SelectedIndexChanged);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.lblDetailHeader);
            this.pnlDetail.Controls.Add(this.btnDelete);
            this.pnlDetail.Controls.Add(this.btnCancel);
            this.pnlDetail.Controls.Add(this.btnSave);
            this.pnlDetail.Controls.Add(this.button1);
            this.pnlDetail.Controls.Add(this.chkActive);
            this.pnlDetail.Controls.Add(this.txtBreederPhone);
            this.pnlDetail.Controls.Add(this.label21);
            this.pnlDetail.Controls.Add(this.label14);
            this.pnlDetail.Controls.Add(this.txtBreederLUid);
            this.pnlDetail.Controls.Add(this.label12);
            this.pnlDetail.Controls.Add(this.txtBreederLUTS);
            this.pnlDetail.Controls.Add(this.label11);
            this.pnlDetail.Controls.Add(this.label15);
            this.pnlDetail.Controls.Add(this.label18);
            this.pnlDetail.Controls.Add(this.label16);
            this.pnlDetail.Controls.Add(this.lblBreederId);
            this.pnlDetail.Controls.Add(this.txtBreederName);
            this.pnlDetail.Controls.Add(this.label17);
            this.pnlDetail.Controls.Add(this.txtBreederAddress);
            this.pnlDetail.Controls.Add(this.txtBreederWebsite);
            this.pnlDetail.Controls.Add(this.lblc);
            this.pnlDetail.Controls.Add(this.label9);
            this.pnlDetail.Controls.Add(this.txtBreederCity);
            this.pnlDetail.Controls.Add(this.txtBreederKennel);
            this.pnlDetail.Controls.Add(this.label13);
            this.pnlDetail.Controls.Add(this.label10);
            this.pnlDetail.Controls.Add(this.txtBreederState);
            this.pnlDetail.Controls.Add(this.txtBreederEmail);
            this.pnlDetail.Controls.Add(this.labelzip);
            this.pnlDetail.Controls.Add(this.lbl11);
            this.pnlDetail.Controls.Add(this.txtBreederZip);
            this.pnlDetail.Location = new System.Drawing.Point(13, 130);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(771, 555);
            this.pnlDetail.TabIndex = 36;
            this.pnlDetail.Visible = false;
            // 
            // lblDetailHeader
            // 
            this.lblDetailHeader.AutoSize = true;
            this.lblDetailHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDetailHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailHeader.Location = new System.Drawing.Point(347, 4);
            this.lblDetailHeader.Name = "lblDetailHeader";
            this.lblDetailHeader.Size = new System.Drawing.Size(2, 19);
            this.lblDetailHeader.TabIndex = 48;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(399, 526);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 25);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(307, 529);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(185, 529);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(243, 413);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(18, 17);
            this.chkActive.TabIndex = 44;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtBreederPhone
            // 
            this.txtBreederPhone.Location = new System.Drawing.Point(240, 374);
            this.txtBreederPhone.MaxLength = 12;
            this.txtBreederPhone.Name = "txtBreederPhone";
            this.txtBreederPhone.Size = new System.Drawing.Size(126, 22);
            this.txtBreederPhone.TabIndex = 43;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(119, 379);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 17);
            this.label21.TabIndex = 42;
            this.label21.Text = "Phone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(125, 418);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 17);
            this.label14.TabIndex = 40;
            this.label14.Text = "Active";
            // 
            // txtBreederLUid
            // 
            this.txtBreederLUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBreederLUid.Enabled = false;
            this.txtBreederLUid.Location = new System.Drawing.Point(243, 452);
            this.txtBreederLUid.Name = "txtBreederLUid";
            this.txtBreederLUid.Size = new System.Drawing.Size(100, 22);
            this.txtBreederLUid.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(122, 457);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 17);
            this.label12.TabIndex = 38;
            this.label12.Text = "LastUpdateID";
            // 
            // txtBreederLUTS
            // 
            this.txtBreederLUTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBreederLUTS.Enabled = false;
            this.txtBreederLUTS.Location = new System.Drawing.Point(243, 491);
            this.txtBreederLUTS.Name = "txtBreederLUTS";
            this.txtBreederLUTS.Size = new System.Drawing.Size(159, 22);
            this.txtBreederLUTS.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 496);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "LastUpdateTimeStamp";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(119, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Breeder Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(241, -25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 25);
            this.label18.TabIndex = 35;
            this.label18.Text = "Breeders";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(126, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 17);
            this.label16.TabIndex = 17;
            this.label16.Text = "Name";
            // 
            // lblBreederId
            // 
            this.lblBreederId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBreederId.Enabled = false;
            this.lblBreederId.Location = new System.Drawing.Point(240, 25);
            this.lblBreederId.MinimumSize = new System.Drawing.Size(10, 2);
            this.lblBreederId.Name = "lblBreederId";
            this.lblBreederId.Size = new System.Drawing.Size(51, 17);
            this.lblBreederId.TabIndex = 34;
            // 
            // txtBreederName
            // 
            this.txtBreederName.Location = new System.Drawing.Point(240, 62);
            this.txtBreederName.MaxLength = 100;
            this.txtBreederName.Name = "txtBreederName";
            this.txtBreederName.Size = new System.Drawing.Size(162, 22);
            this.txtBreederName.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(122, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 17);
            this.label17.TabIndex = 33;
            this.label17.Text = "Breeder ID";
            // 
            // txtBreederAddress
            // 
            this.txtBreederAddress.Location = new System.Drawing.Point(240, 101);
            this.txtBreederAddress.MaxLength = 100;
            this.txtBreederAddress.Name = "txtBreederAddress";
            this.txtBreederAddress.Size = new System.Drawing.Size(162, 22);
            this.txtBreederAddress.TabIndex = 20;
            // 
            // txtBreederWebsite
            // 
            this.txtBreederWebsite.Location = new System.Drawing.Point(240, 335);
            this.txtBreederWebsite.MaxLength = 100;
            this.txtBreederWebsite.Name = "txtBreederWebsite";
            this.txtBreederWebsite.Size = new System.Drawing.Size(162, 22);
            this.txtBreederWebsite.TabIndex = 32;
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(122, 140);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(31, 17);
            this.lblc.TabIndex = 21;
            this.lblc.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(119, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Website";
            // 
            // txtBreederCity
            // 
            this.txtBreederCity.Location = new System.Drawing.Point(240, 140);
            this.txtBreederCity.MaxLength = 50;
            this.txtBreederCity.Name = "txtBreederCity";
            this.txtBreederCity.Size = new System.Drawing.Size(162, 22);
            this.txtBreederCity.TabIndex = 22;
            // 
            // txtBreederKennel
            // 
            this.txtBreederKennel.Location = new System.Drawing.Point(240, 296);
            this.txtBreederKennel.MaxLength = 100;
            this.txtBreederKennel.Name = "txtBreederKennel";
            this.txtBreederKennel.Size = new System.Drawing.Size(162, 22);
            this.txtBreederKennel.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(122, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "State";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Kennel";
            // 
            // txtBreederState
            // 
            this.txtBreederState.Location = new System.Drawing.Point(240, 179);
            this.txtBreederState.MaxLength = 25;
            this.txtBreederState.Name = "txtBreederState";
            this.txtBreederState.Size = new System.Drawing.Size(100, 22);
            this.txtBreederState.TabIndex = 24;
            // 
            // txtBreederEmail
            // 
            this.txtBreederEmail.Location = new System.Drawing.Point(240, 257);
            this.txtBreederEmail.MaxLength = 50;
            this.txtBreederEmail.Name = "txtBreederEmail";
            this.txtBreederEmail.Size = new System.Drawing.Size(162, 22);
            this.txtBreederEmail.TabIndex = 28;
            // 
            // labelzip
            // 
            this.labelzip.AutoSize = true;
            this.labelzip.Location = new System.Drawing.Point(119, 223);
            this.labelzip.Name = "labelzip";
            this.labelzip.Size = new System.Drawing.Size(28, 17);
            this.labelzip.TabIndex = 25;
            this.labelzip.Text = "Zip";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Location = new System.Drawing.Point(119, 262);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(42, 17);
            this.lbl11.TabIndex = 27;
            this.lbl11.Text = "Email";
            // 
            // txtBreederZip
            // 
            this.txtBreederZip.Location = new System.Drawing.Point(240, 218);
            this.txtBreederZip.MaxLength = 11;
            this.txtBreederZip.Name = "txtBreederZip";
            this.txtBreederZip.Size = new System.Drawing.Size(100, 22);
            this.txtBreederZip.TabIndex = 26;
            // 
            // tabDogOwner
            // 
            this.tabDogOwner.Controls.Add(this.textBox8);
            this.tabDogOwner.Controls.Add(this.label8);
            this.tabDogOwner.Controls.Add(this.textBox7);
            this.tabDogOwner.Controls.Add(this.label7);
            this.tabDogOwner.Controls.Add(this.textBox6);
            this.tabDogOwner.Controls.Add(this.label6);
            this.tabDogOwner.Controls.Add(this.textBox5);
            this.tabDogOwner.Controls.Add(this.label5);
            this.tabDogOwner.Controls.Add(this.textBox4);
            this.tabDogOwner.Controls.Add(this.label4);
            this.tabDogOwner.Controls.Add(this.textBox3);
            this.tabDogOwner.Controls.Add(this.label3);
            this.tabDogOwner.Controls.Add(this.textBox2);
            this.tabDogOwner.Controls.Add(this.label2);
            this.tabDogOwner.Controls.Add(this.textBox1);
            this.tabDogOwner.Controls.Add(this.label1);
            this.tabDogOwner.Controls.Add(this.menuStrip1);
            this.tabDogOwner.Location = new System.Drawing.Point(4, 25);
            this.tabDogOwner.Name = "tabDogOwner";
            this.tabDogOwner.Padding = new System.Windows.Forms.Padding(3);
            this.tabDogOwner.Size = new System.Drawing.Size(792, 924);
            this.tabDogOwner.TabIndex = 1;
            this.tabDogOwner.Text = "DogOwners";
            this.tabDogOwner.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(148, 374);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(148, 339);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(148, 300);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(148, 245);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(148, 193);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.addNewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.addNewToolStripMenuItem.Text = "Add New";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Location = new System.Drawing.Point(408, 709);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(200, 100);
            this.pnlGrid.TabIndex = 39;
            // 
            // dgvBreeders
            // 
            this.dgvBreeders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBreeders.Location = new System.Drawing.Point(111, 704);
            this.dgvBreeders.Name = "dgvBreeders";
            this.dgvBreeders.RowTemplate.Height = 24;
            this.dgvBreeders.Size = new System.Drawing.Size(240, 150);
            this.dgvBreeders.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 953);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.TabBreeder.ResumeLayout(false);
            this.TabBreeder.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.tabDogOwner.ResumeLayout(false);
            this.tabDogOwner.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreeders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabBreeder;
        private System.Windows.Forms.TabPage tabDogOwner;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboBreederName;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblBreederId;
        private System.Windows.Forms.TextBox txtBreederName;
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
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.TextBox txtBreederPhone;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBreederLUid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBreederLUTS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDetailHeader;
        private System.Windows.Forms.Button btnAllBreeders;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvBreeders;
    }
}

