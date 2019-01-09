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
    public partial class frmLitter : Form
    {
        public frmLitter()
        {
            InitializeComponent();
        }

        private static bool IsUpdateOperation = false;
        private const string strTableName = "Litter ";

        FillDropDownList fdl = new FillDropDownList();

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            IsUpdateOperation = false;
            enableDetail(true);
            ClearAllDetailFields();
            dgv.DataSource = null;
            dgv.DataSource = GetAll();
            chkActive.Checked = true;
            cboSire.Focus();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ClearAllDetailFields();
            enableDetail(false);
            dgv.DataSource = null;
            dgv.DataSource = GetAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearAllDetailFields();
            enableDetail(true);
            if (cboSearch.SelectedIndex != 0)
            {
                try
                { 
                    int intLitterId = Convert.ToInt32(cboSearch.SelectedValue);
                    IsUpdateOperation = true;
                    var L = GetLitterDetails(intLitterId);
                    lblLitterID.Text = L[0].LitterID.ToString();
                    txtAKCLitterNumber.Text = fdl.StringFormatter(L[0].AKCLitter?.ToString());
                    cboSire.SelectedValue = L[0].Sire_dogID;
                    cboDam.SelectedValue = L[0].Dam_dogID;
                    txtFemales.Text = L[0].LitterFemales.ToString();
                    txtMales.Text = L[0].LitterMales.ToString();
                    txtVet.Text = L[0].DeliverVet.ToString();
                    dtpWhelpDate.Value = L[0].WhelpDate.Date;
                    //dtpRegCertDate.Value = D[0].AKCRegCertficateDate?.ToString() == null ? new DateTime(1900, 01, 01) : D[0].AKCRegCertficateDate.Value;
                    chkActive.Checked = L[0].Active.Value;
                    lblLastUpdateID.Text = L[0].LastUpdateID.ToString();
                    lblLUTS.Text = L[0].LastUpdateTimeStamp.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Search: " + ex.ToString());
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsUpdateOperation == true)
            {
                // Update
                try
                {
                    int Lid = Convert.ToInt32(lblLitterID.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Update Litter: " + ex.ToString());
                }
            }
            else
            {
                // Insert
                try
                { 
                    using (var B = new dbFFBEntities())
                    {
                        var i = new Litter
                        {
                            AKCLitter = txtAKCLitterNumber?.Text.Trim().ToUpper(),
                            Sire_dogID = Convert.ToInt32(cboSire.SelectedValue),
                            Dam_dogID = Convert.ToInt32(cboDam.SelectedValue),
                            LitterFemales = Convert.ToInt32(txtFemales?.Text.Trim()),
                            LitterMales = Convert.ToInt32(txtMales.Text.Trim()),
                            DeliverVet = txtVet.Text.Trim(),
                            WhelpDate = dtpWhelpDate.Value,
                            Active = chkActive.Checked,
                            LastUpdateID = Environment.UserName.ToString(),
                            LastUpdateTimeStamp = DateTime.Now
                        };
                        B.Litters.Add(i);
                        var sa = B.SaveChanges();
                        if (sa == 1)
                        {
                            Reset(false);
                            //frmLitter_Load(sender, e);
                            MessageBox.Show(strTableName + i.LitterID + " Added Successfully");
                        }
                        else
                        {
                            MessageBox.Show(strTableName + " insert Failed");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error on Insert Litter " + ex.ToString());
                }
            }
        }

        private void frmLitter_Load(object sender, EventArgs e)
        {      

        }

        private void load_cboDam()
        {
            cboDam.DataSource = null;
            cboDam.Items.Clear();
            using (var B = new dbFFBEntities())
            {
                cboDam.ValueMember = "DogID";
                cboDam.DisplayMember = "DogName";
                cboDam.DataSource = B.Dogs.Select(x => new { x.DogID, x.DogName, x.Gender })
                    .Where(x => x.Gender == "Female").OrderBy(x => x.DogName).ToList();
                cboDam.Invalidate();
            }

        }

        private void load_cboSire()
        {
            cboSire.DataSource = null;
            cboSire.Items.Clear();
            using (var B = new dbFFBEntities())
            {
                cboSire.ValueMember = "DogID";
                cboSire.DisplayMember = "DogName";
                cboSire.DataSource = B.Dogs.Select(x => new { x.DogID, x.DogName, x.Gender })
                    .Where(x => x.Gender == "Male").OrderBy(x => x.DogName).ToList();
                cboSire.Invalidate();
            }
        }

        private void load_cboSearch()
        {
            cboSearch.DataSource = null;
            cboSearch.Items.Clear();
            using (var B = new dbFFBEntities())
            {
                cboSearch.ValueMember = "LitterID";
                cboSearch.DisplayMember = "WY_sireDam";
                cboSearch.DataSource = B.vw_cboSearchLitters.Select(x => new { x.LitterID, x.Yr, x.WY_sireDam }).OrderBy(x => x.Yr).ToList();
                cboSearch.Invalidate();

                
                //cboSearch.DataSource = B.Litters
                //    .Select(x => new { x.LitterID, x.Sire_dogID, x.Dam_dogID, x.WhelpDate })
                //    .Join(B.Dogs.Select(y => new { y.DogID, y.DogName)
                //    .Where(y => y.DogID)  = ()
            }
        }
        private void frmLitter_Load_1(object sender, EventArgs e)
        {
            lblHeading.Text = strTableName;
            Reset(false);
        }
        private void ClearAllDetailFields()
        {
            try
            {
                lblLitterID.Text = string.Empty;
                cboSearch.DisplayMember = "__litter";
                cboDam.DisplayMember = "__dog";
                cboSire.DisplayMember = "__dog";
                txtFemales.Text = string.Empty;
                txtMales.Text = string.Empty;
                txtVet.Text = "Dr. Charles Quarterman";
                txtAKCLitterNumber.Text = string.Empty;
                dtpWhelpDate.Value = new DateTime(1900, 01, 01);
                chkActive.Checked = true;
                lblLastUpdateID.Text = string.Empty;
                lblLUTS.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Clearing Detail Fields " + ex.ToString(), "frmLitter ClearAllDetailFields() Error");
            }
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
        
        private List<Litter> GetAll()
        {
            using (var B = new dbFFBEntities())
            {
                B.Configuration.LazyLoadingEnabled = false;
                List<Litter> ret = new List<Litter>();
                ret = B.Litters.OrderByDescending(x => x.WhelpDate).ToList();
                return ret;
            }
        }
        private List<Litter> GetLitterDetails(int LitterId)
        {
            using (var B = new dbFFBEntities())
            {
                List<Litter> ret = new List<Litter>();
                ret = B.Litters.Where(x => x.LitterID == LitterId).ToList();
                return ret;
            }
        }
        private void Reset(bool flag)
        {
            try
            { 
                ClearAllDetailFields();
                load_cboDam();
                load_cboSire();
                load_cboSearch();
                enableDetail(flag);
                dgv.DataSource = null;
                dgv.DataSource = GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on Reset: " + ex.ToString());
            }
        }

    }
}
