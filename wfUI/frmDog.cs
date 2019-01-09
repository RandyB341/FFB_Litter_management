using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary3;

namespace wfUI
{
    public partial class frmDog : Form
    {
        public frmDog()
        {
            InitializeComponent();
        }

        private static bool IsUpdateOperation = false;
        private const string strTableName = "Dog ";
        private FillDropDownList fdl = new FillDropDownList();
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearAllDetailFields();
            enableDetail(true);
            if (cboDogName.SelectedIndex != 0)
            {
                int intDogId = Convert.ToInt32(cboDogName.SelectedValue);
                IsUpdateOperation = true;
                var D = GetDogDetails(intDogId);
                lblDogID.Text = D[0].DogID.ToString();
                txtDogName.Text = fdl.StringFormatter(D[0].DogName?.ToString());
                txtAKCDogID.Text = fdl.StringFormatter(D[0].AKCDogId?.ToString());
                txtAKCDogName.Text = fdl.StringFormatter(D[0].AKCDogName?.ToString().ToUpper());
                dtpRegCertDate.Value = D[0].AKCRegCertficateDate?.ToString() == null ? new DateTime(1900, 01, 01) : D[0].AKCRegCertficateDate.Value;
                txtMicrochipNum.Text = fdl.StringFormatter(D[0].Microchip_Num?.ToString());
                txtCoatColor.Text = fdl.StringFormatter(D[0].CoatColor?.ToString());
                txtMarkings.Text = fdl.StringFormatter(D[0].Markings?.ToString());
                rdoMale.Checked = D[0].Gender == "Male" ? true : false;
                rdoFemale.Checked = D[0].Gender == "Female" ? true : false;
                //txtLitterID.Text = fdl.StringFormatter(D[0].LitterId?.ToString());
                cboLitter.SelectedValue = D[0].LitterId.HasValue ? D[0].LitterId : 0;
                dtpBirthDate.Value = D[0].BirthDate?.ToString() == null ? new DateTime(1900, 01, 01) : D[0].BirthDate.Value;
                dtpEarsStayUp.Value = D[0].EarsUpStayUpDate?.ToString() == null ? new DateTime(1900,01,01) : D[0].EarsUpStayUpDate.Value;
                dtpDeceasedDate.Value = D[0].DeceasedDate?.ToString() == null ? new DateTime(1900, 01, 01) : D[0].DeceasedDate.Value;
                //chkActive.Checked = D[0].Active.Value ? true : false;
                //chkActive.Checked = (bool)D[0].Active == true ? true : false;
                chkActive.Checked = D[0].Active.HasValue ? true : false;
                cboBreeder.SelectedValue = D[0].BreederID.HasValue ? D[0].BreederID : 7001;
                cboDogOwner.SelectedValue = D[0].DogOwnerID.HasValue ? D[0].DogOwnerID : 3001;
                lblLastUpdateID.Text = D[0].LastUpdateID.ToString();
                lblLUTS.Text = D[0].LastUpdateTimeStamp.ToString();
               

            }
        }

        private List<Dog> GetDogDetails(int intDogId)
        {
            using (var B = new dbFFBEntities())
            {
                List<Dog> retModel = new List<Dog>();
                retModel = B.Dogs.Where(x => x.DogID == intDogId).ToList();
                return retModel;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            IsUpdateOperation = false;
            enableDetail(true);
            ClearAllDetailFields();
            dgv.DataSource = null;
            dgv.DataSource = GetAll();
            chkActive.Checked = true;
            txtDogName.Focus();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ClearAllDetailFields();
            enableDetail(false);
            dgv.DataSource = null;
            dgv.DataSource = GetAll();
        }

        private void enableDetail(bool A)
        {
            //enable or disable all fields in Detail grid
            //After form load - disable
            //After Add New button click - enable
            //After Search button click - enable
            //after btn save
            groupBox2.Enabled = A;
        }

        private void ClearAllDetailFields()
        {
            try
            {
                lblDogID.Text = string.Empty;
                txtAKCDogID.Text = string.Empty;
                txtAKCDogName.Text = string.Empty;
                //cboBreeder.DisplayMember = "__breeder";
                cboBreeder.Text = "Joyce Baker";
                //cboBreeder.Items.Clear();
                cboDogOwner.Text = "__dogOwner";
                //cboDogOwner.Items.Clear();
                //cboDogName.Text = "__dog";
                //cboDogName.Items.Clear();
                txtCoatColor.Text = string.Empty;
                txtDogName.Text = string.Empty;
                //txtLitterID.Text = string.Empty;
                cboLitter.Text = "__litter";
                txtMarkings.Text = string.Empty;
                txtMicrochipNum.Text = string.Empty;
                chkActive.Checked = false;
                lblLastUpdateID.Text = string.Empty;
                lblLUTS.Text = string.Empty;
                //dtpBirthDate.Value = DateTime.Now;
                dtpBirthDate.Value = new DateTime(1900, 01, 01);
                dtpDeceasedDate.Value = new DateTime(1900, 01, 01);
                dtpEarsStayUp.Value = new DateTime(1900, 01, 01);
                dtpRegCertDate.Value = new DateTime(1900, 01, 01);
                rdoFemale.Checked = false;
                rdoMale.Checked = false;
                lblLastUpdateID.Text = string.Empty;
                lblLUTS.Text = string.Empty;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error Clearing Detail Fields " + x.ToString());
            }
        }

        private List<Dog> GetAll()
        {
            using (var B = new dbFFBEntities())
            {
                B.Configuration.LazyLoadingEnabled = false;
                List<Dog> retModel = new List<Dog>();
                retModel = B.Dogs.OrderByDescending(x => x.BirthDate).ToList();
                return retModel;
            }
        }

        private void frmDog_Load(object sender, EventArgs e)
        {
            lblFormHeading.Text = strTableName;
            Reset(false);
        }

        private void load_cboBirthDate()
        {
            cboBirthDate.DataSource = null;
            cboBirthDate.Items.Clear();
            using (var B = new dbFFBEntities())
            {
                //try datatable
                //DataTable dta = new DataTable();
                //dta = B.Dogs.Select(x => new { x.DogID, x.BirthDate }).OrderBy(x => x.BirthDate);

                //var qry = B.Dogs.Select(x => new { x.DogID, x.BirthDate }).OrderBy(x => x.BirthDate).ToList();
                //var neww = new Dog();
                //neww.DogID = -1;
                //neww.BirthDate =01/01/1900;

                //https://sansknowledge.wordpress.com/2014/04/30/adding-default-value-or-empty-value-to-entity-framework-bound-combo-box/
                //https://stackoverflow.com/questions/1388679/add-empty-entry-to-combobox-bound-to-entity-list/4826238#4826238

                //var entity = new dbFFBEntities();
                //var qry = B.Dogs.Select(x => new { x.DogID, x.BirthDate }).OrderBy(x => x.BirthDate).ToList();
                //var lst = qry.ToList();
                //var dot = new Dog();
                //dot.DogID =  -1; ;
                ////dot.BirthDate = new DateTime(1900, 1, 1);
                //dot.BirthDate = DateTime.Today;

                //if (dot.BirthDate.HasValue)
                //    lst.Insert(0, dot);

                //cboBirthDate.DataSource = lst;

                

                //{
                //    EntityId = -1
                //};


                cboBirthDate.ValueMember = "DogID";
                cboBirthDate.DisplayMember = "BirthDate";
                cboBirthDate.DataSource = B.Dogs.Select(x => new { x.DogID, x.BirthDate }).OrderBy(x => x.BirthDate).ToList();
                cboBirthDate.Invalidate();
            }
        }

        private void load_cboDogOwner()
        {
            cboDogOwner.DataSource = null;
            cboDogOwner.Items.Clear();
            using (var B = new dbFFBEntities())
            {
                cboDogOwner.ValueMember = "DogOwnerID";
                cboDogOwner.DisplayMember = "OwnerName";
                cboDogOwner.DataSource = B.DogOwners.Select(x => new { x.DogOwnerID, x.OwnerName }).Where(x => x.OwnerName != "__dogOwner").OrderBy(x => x.OwnerName).ToList();
                cboDogOwner.Invalidate();
            }
        }



        private void load_cboBreeder()
        {
            cboBreeder.DataSource = null;
            cboBreeder.Items.Clear();
            using (var B = new dbFFBEntities())
            {
                cboBreeder.ValueMember = "BreederID";
                cboBreeder.DisplayMember = "BreederName";
                cboBreeder.DataSource = B.Breeders.Select(x => new { x.BreederID, x.BreederName }).Where(x => x.BreederName.ToLower() != "__breeder").OrderBy(x => x.BreederName).ToList();
                cboBreeder.Invalidate();
            }
        }
        private void load_cboDogName()
        {
            cboDogName.DataSource = null;
            cboDogName.Items.Clear();
            using (var B = new dbFFBEntities())
            {
                cboDogName.ValueMember = "DogID";
                cboDogName.DisplayMember = "DogName";
                cboDogName.DataSource = B.Dogs.Select(x => new { x.DogID, x.DogName }).OrderBy(x => x.DogName).ToList();
                cboDogName.Invalidate();
            }
        }

        private void load_cboLitter()
        {
            cboLitter.DataSource = null;
            cboLitter.Items.Clear();
            using (var B = new dbFFBEntities())
            {
                cboLitter.ValueMember = "LitterID";
                cboLitter.DisplayMember = "WY_sireDam";
                cboLitter.DataSource = B.vw_cboSearchLitters.Select(x => new { x.LitterID, x.Yr, x.WY_sireDam }).OrderBy(x => x.Yr).ToList();
                cboLitter.Invalidate();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //int Lit = 0;
            //int? Lit1 = 0;
            if (IsUpdateOperation)
            {
                //Update
                //if (int.TryParse(txtLitterID.Text, out Lit))
                //{
                //    Lit1 = Lit;
                //}
                //else
                //{
                //    Lit1 = null;
                //}
                int intI = Convert.ToInt32(lblDogID.Text);
                using (var B = new dbFFBEntities())
                {
                    var u = B.Dogs.First(x => x.DogID == intI);
                    u.AKCDogId = txtAKCDogID?.Text.Trim().ToUpper();
                    u.DogName = txtDogName?.Text.Trim();
                    u.AKCDogName = txtAKCDogName?.Text.Trim().ToUpper();
                    u.AKCRegCertficateDate = dtpRegCertDate.Value;
                    u.Microchip_Num = txtMicrochipNum?.Text.Trim();
                    u.CoatColor = txtCoatColor?.Text.Trim();
                    u.Markings = txtMarkings?.Text.Trim();
                    u.Gender = rdoMale.Checked ? "Male" : "Female";
                    //u.LitterId = Convert.ToInt32(txtLitterID.Text.Trim());
                    //u.LitterId = Lit1;
                    u.LitterId = Convert.ToInt32(cboLitter.SelectedValue);
                    u.BreederID = Convert.ToInt32(cboBreeder.SelectedValue);
                    u.DogOwnerID = Convert.ToInt32(cboDogOwner.SelectedValue);
                    //may need StringFormatter
                    u.BirthDate = dtpBirthDate.Value;
                    u.EarsUpStayUpDate = dtpEarsStayUp.Value;
                    u.DeceasedDate = dtpDeceasedDate.Value;
                    u.Active = chkActive.Checked;
                    u.LastUpdateID = Environment.UserName;
                    u.LastUpdateTimeStamp = DateTime.Now;
                    var s = B.SaveChanges();
                    if (s == 1)
                    {
                        Reset(false);
                        MessageBox.Show(strTableName + u.DogName + " Updated Successfully");
                    }
                    else
                    {
                        //update failed
                        MessageBox.Show(strTableName + " Update Failed");
                    }
                }
            }        
            else
            {
                // Insert
               
                //if (int.TryParse(txtLitterID.Text, out Lit))
                //{
                //    Lit1 = Lit;
                //}
                //else
                //{
                //    //Lit1 = null;
                //    Lit1 = null;
                //} 

                using (var B = new dbFFBEntities())
                {
                    var i = new Dog
                    {
                        DogName = txtDogName.Text.Trim(),
                        AKCDogId = txtAKCDogID?.Text.Trim().ToUpper(),
                        AKCDogName = txtAKCDogName?.Text.Trim().ToUpper(),
                        AKCRegCertficateDate = dtpRegCertDate.Value,
                        Microchip_Num = txtMicrochipNum?.Text.Trim(),
                        CoatColor = txtCoatColor?.Text.Trim(),
                        Markings = txtMarkings?.Text.Trim(),
                        Gender = rdoMale.Checked ? "Male" : "Female",
                        //LitterId = Convert.ToInt32(txtLitterID.Text.Trim()),
                        //LitterId = Lit1,
                        LitterId = Convert.ToInt32(cboLitter.SelectedValue),
                        BreederID = Convert.ToInt32(cboBreeder.SelectedValue),
                        DogOwnerID = Convert.ToInt32(cboDogOwner.SelectedValue),
                        BirthDate = dtpBirthDate.Value,
                        EarsUpStayUpDate = dtpEarsStayUp.Value,
                        DeceasedDate = dtpDeceasedDate.Value,
                        Active = chkActive.Checked,
                        LastUpdateID = Environment.UserName,
                        LastUpdateTimeStamp = DateTime.Now
                    };
                    B.Dogs.Add(i);
                    var sa = B.SaveChanges();
                    if (sa==1)
                    {
                        Reset(false);
                        MessageBox.Show(strTableName + i.DogName + " Inserted Successfully");
                    }
                    else
                    {
                        MessageBox.Show(strTableName + " Insert failed");
                    }
                    }
                }
            }
        private void Reset(bool flag)
        {
            ClearAllDetailFields();
            load_cboDogName();
            load_cboDogOwner();
            load_cboBreeder();
            load_cboBirthDate();
            load_cboLitter();
            enableDetail(flag);
            dgv.DataSource = null;
            dgv.DataSource = GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset(false);
        }

        private void bnDelete_Click(object sender, EventArgs e)
        {

        }
    }

   
}
