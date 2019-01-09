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
    public partial class frmDogOwner : Form
    {
        public frmDogOwner()
        {
            InitializeComponent();
        }

        private static bool IsUpdateOperation = false;
        private const string strTableName = "DogOwner ";

        FillDropDownList fdl = new FillDropDownList();

        private void frmDogOwner_Load(object sender, EventArgs e)
        {
            ClearAllDetailFields();
            load_cboName();
            dgv.DataSource = null;
            dgv.DataSource = GetAll();
        }

        private void ClearAllDetailFields()
        {
            try
            {
                lblDogOwnerID.Text = string.Empty;
                txtOwnerName.Text = string.Empty;
                txtOwnerAddress.Text = string.Empty;
                txtOwnerCity.Text = string.Empty;
                txtState.Text = string.Empty;
                txtZip.Text = string.Empty;
                txtPhone.Text = string.Empty;
                txtEmail.Text = string.Empty;
                lblLastUpdateID.Text = string.Empty;
                lblLUTS.Text = string.Empty;
                chkActive.Checked = false;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: Clear failed " + x.ToString());
            }
        }

        private void load_cboName()
        {
            cboName.DataSource = null;
            cboName.Items.Clear();
            using (var B = new dbFFBEntities())
            {
                cboName.ValueMember = "DogOwnerID";
                cboName.DisplayMember = "OwnerName";
                cboName.DataSource = B.DogOwners.Select(x => new { x.DogOwnerID, x.OwnerName }).OrderBy(x => x.OwnerName).ToList();
                cboName.Invalidate();
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ClearAllDetailFields();
            dgv.DataSource = null;
            dgv.DataSource = GetAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearAllDetailFields();
            if (cboName.SelectedIndex != 0)
            {
                int intId = Convert.ToInt32(cboName.SelectedValue);
                IsUpdateOperation = true;
                var D = GetDetails(intId);
                lblDogOwnerID.Text = D[0].DogOwnerID.ToString();
                txtOwnerName.Text = fdl.StringFormatter(D[0].OwnerName?.ToString());
                txtOwnerAddress.Text = fdl.StringFormatter(D[0].OwnerAddress?.ToString());
                txtOwnerCity.Text = fdl.StringFormatter(D[0].OwnerCity?.ToString());
                txtState.Text = fdl.StringFormatter(D[0].OwnerState?.ToString());
                txtZip.Text = fdl.StringFormatter(D[0].OwnerZip?.ToString());
                txtPhone.Text = fdl.StringFormatter(D[0].OwnerPhone?.ToString());
                txtEmail.Text = fdl.StringFormatter(D[0].OwnerEmail?.ToString());
                chkActive.Checked = D[0].Active.Value;
                lblLastUpdateID.Text = D[0].LastUpdateID.ToString();
                lblLUTS.Text = D[0].LastUpdateTimeStamp.ToString();
            }

        }

        private List<DogOwner> GetDetails(int intId)
        {
            using (var B = new dbFFBEntities())
            {
                List<DogOwner> retModel = new List<DogOwner>();
                retModel = B.DogOwners.Where(x => x.DogOwnerID == intId).ToList();
                return retModel;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            IsUpdateOperation = false;
            ClearAllDetailFields();
            dgv.DataSource = null;
            dgv.DataSource = GetAll();
            chkActive.Checked = true;
            txtOwnerName.Focus();
        }

        private List<DogOwner> GetAll()
        {
            using (var B = new dbFFBEntities())
            {
                B.Configuration.LazyLoadingEnabled = false;
                List<DogOwner> retModel = new List<DogOwner>();
                retModel = B.DogOwners.OrderBy(x => x.OwnerName).ToList();
                return retModel;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsUpdateOperation == true)
            {
                // Update
                int intI = Convert.ToInt32(lblDogOwnerID.Text);
                using (var B = new dbFFBEntities())
                {
                    var u = B.DogOwners.First(x => x.DogOwnerID == intI);
                    u.OwnerName = txtOwnerName.Text.Trim();
                    u.OwnerAddress = txtOwnerAddress.Text.Trim();
                    u.OwnerCity = txtOwnerCity.Text.Trim();
                    u.OwnerState = txtState.Text.Trim();
                    u.OwnerZip = txtZip.Text.Trim();
                    u.OwnerPhone = txtPhone.Text.Trim();
                    u.OwnerEmail = txtEmail.Text.Trim();
                    u.Active = chkActive.Checked;
                    u.LastUpdateID = Environment.UserName;
                    u.LastUpdateTimeStamp = DateTime.Now;
                    var s = B.SaveChanges();
                    if (s == 1)
                    {
                        ClearAllDetailFields();
                        load_cboName();
                        dgv.DataSource = null;
                        dgv.DataSource = GetAll();
                        MessageBox.Show(strTableName + u.OwnerName + " Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show(strTableName + " Update Failed");
                    }
                }
            }
            else
            {
                // Insert
                using (var B = new dbFFBEntities())
                {
                    var i = new DogOwner
                    {
                        OwnerName = txtOwnerName.Text.Trim(),
                        OwnerAddress = txtOwnerAddress.Text.Trim(),
                        OwnerCity = txtOwnerCity.Text.Trim(),
                        OwnerState = txtState.Text.Trim(),
                        OwnerZip = txtZip.Text.Trim(),
                        OwnerPhone = txtPhone.Text.Trim(),
                        OwnerEmail = txtEmail.Text.Trim(),
                        Active = chkActive.Checked,
                        LastUpdateID = Environment.UserName,
                        LastUpdateTimeStamp = DateTime.Now
                    };
                    B.DogOwners.Add(i);
                    var sa = B.SaveChanges();
                    if (sa == 1)
                    {
                        ClearAllDetailFields();
                        load_cboName();
                        dgv.DataSource = null;
                        dgv.DataSource = GetAll();
                        MessageBox.Show(strTableName + i.OwnerName + " Added Successfully");
                    }
                    else
                    {
                        MessageBox.Show(strTableName + " Insert failed");
                    }
                }
            }
        }

            private void btnCancel_Click(object sender, EventArgs e)
            {
                ClearAllDetailFields();
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                int intId = Convert.ToInt32(lblDogOwnerID.Text);
                using (var B = new dbFFBEntities())
                {
                    var d = B.DogOwners.First(x => x.DogOwnerID == intId);
                    B.DogOwners.Remove(d);
                    var de = B.SaveChanges();
                    if (de == 1)
                    {
                        ClearAllDetailFields();
                        load_cboName();
                        dgv.DataSource = GetAll();
                    }
                    else
                    {
                        MessageBox.Show(strTableName + " delete failed");
                    }
                }
            }
        }
    }
