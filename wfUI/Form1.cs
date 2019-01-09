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
    public partial class Form1 : Form
    {
        /// <summary>
        /// IsUpdateOperation will be true when pnlDetail loads from cboBreeder selection
        /// will be false when pnlDetail loads from btnAddNew
        /// </summary>
        private static bool IsUpdateOperation = false;

        public Form1()
        {
            InitializeComponent();
        }
        FillDropDownList fdl = new FillDropDownList();

        private void getBreederName_cboBreederName()
        {
            cboBreederName.DataSource = null;
            cboBreederName.Items.Clear();
            using (var B = new dbFFBEntities())
            {
                // works below - but does not add blank line
                // https://stackoverflow.com/questions/11745714/how-to-add-items-to-combobox-from-entity-framework
                cboBreederName.DataSource = B.Breeders.Select(x => new { x.BreederID, x.BreederName }).OrderBy(x => x.BreederName).ToList();
                // OrderBy(x => x.BreederName)
                cboBreederName.ValueMember = "BreederID";
                cboBreederName.DisplayMember = "BreederName";
                cboBreederName.Invalidate();

                //works below but cannot select first entry
                //cboBreederName.DataSource = null;
                //cboBreederName.Items.Clear();
                //using (var B = new dbFFBEntities())
                //{
                //    // works below - but does not add blank line
                //    // https://stackoverflow.com/questions/11745714/how-to-add-items-to-combobox-from-entity-framework
                //    cboBreederName.DataSource = B.Breeders.ToList().OrderBy(x => x.BreederName).ToList();
                //    cboBreederName.ValueMember = "BreederID";
                //    cboBreederName.DisplayMember = "BreederName";
                // end works below but cannot select first entry

                //try https://www.aspsnippets.com/Articles/Add-Insert-Default-First-Value-in-ComboBox-in-Windows-Forms-Application-using-C-and-VBNet.aspx
                //https://www.aspsnippets.com/Articles/ComboBox-Items-collection-cannot-be-modified-when-the-DataSource-property-is-set.aspx

            }
        }
        List<Breeder> GetBreederDetails(int Bid)
        {
            dbFFBEntities userModel = new dbFFBEntities();
            List<Breeder> retModel = new List<Breeder>();
            retModel = userModel.Breeders.Where(x => x.BreederID == Bid).ToList();
            return retModel;
        }

        private void TabBreeder_Enter(object sender, EventArgs e)
        {
            getBreederName_cboBreederName();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //if (cboBreederName.SelectedValue.ToString() != "")
            if (cboBreederName.SelectedIndex != 0)
            {
                int intBrId = Convert.ToInt32(cboBreederName.SelectedValue);
                IsUpdateOperation = true;
                //using (var B = new dbFFBEntities())
                //{
                //    var Br = B.Breeders.Where(x => x.BreederID == intBrId).ToList();
                //    lblBreederId = 
                //https://stackify.com/nullreferenceexception-object-reference-not-set/
                var D = GetBreederDetails(intBrId);
                lblBreederId.Text = D[0].BreederID.ToString();
                txtBreederName.Text = fdl.StringFormatter(D[0].BreederName.ToString());
                txtBreederAddress.Text = fdl.StringFormatter(D[0].BreederAddress?.ToString());
                //txtBreederAddress.Text = D[0].BreederAddress ?? D[0].BreederAddress.ToString();
                txtBreederCity.Text = fdl.StringFormatter(D[0].BreederCity?.ToString());
                txtBreederState.Text = fdl.StringFormatter(D[0].BreederState?.ToString());
                txtBreederEmail.Text = fdl.StringFormatter(D[0].BreederEmail?.ToString());
                txtBreederKennel.Text = fdl.StringFormatter(D[0].BreederKennel?.ToString());
                txtBreederWebsite.Text = fdl.StringFormatter(D[0].BreederWebSite?.ToString());
                txtBreederPhone.Text = fdl.StringFormatter(D[0].BreederPhone?.ToString());
                txtBreederLUid.Text = fdl.StringFormatter(D[0].LastUpdateID.ToString());
                txtBreederLUTS.Text = fdl.StringFormatter(D[0].LastUpdateTimeStamp.ToString());
                lblDetailHeader.Text = "Search - " + cboBreederName.Text;
                pnlGrid.Visible = false;
                pnlDetail.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsUpdateOperation == true)
            {
                // this is Update

                //https://ef.readthedocs.io/en/staging/saving/basic.html#updating-data
                using (var B = new dbFFBEntities())
                {
                    var u = B.Breeders.First(x => x.BreederName == cboBreederName.Text.Trim());
                    u.Active = chkActive.Checked;
                    u.BreederAddress = txtBreederAddress.Text.Trim();
                    u.BreederCity = txtBreederCity.Text.Trim();
                    u.BreederEmail = txtBreederCity.Text.Trim();
                    u.BreederKennel = txtBreederKennel.Text.Trim();
                    u.BreederName = txtBreederName.Text.Trim();
                    u.BreederPhone = txtBreederPhone.Text.Trim();
                    u.BreederState = txtBreederState.Text.Trim();
                    u.BreederWebSite = txtBreederWebsite.Text.Trim();
                    u.BreederZip = txtBreederZip.Text.Trim();
                    u.LastUpdateID = Environment.UserName.ToString();
                    u.LastUpdateTimeStamp = DateTime.Now;
                    var s = B.SaveChanges();
                    if (s == 1)
                    {
                        ClearAllBreederFields();
                        pnlDetail.Visible = false;
                        getBreederName_cboBreederName();
                        MessageBox.Show("Breeder " + u.BreederName + " Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Breeder update Failed");
                    }
                    //dbFFBEntities userModel = new dbFFBEntities();
                    //Breeder Brd = userModel.Breeders.First(x => x.BreederName == cboBreederName.Text);

                    //List<Breeder> listB = new List<Breeder>();
                    //listB = userModel.Breeders.Where(x => x.BreederName == cboBreederName.Text).ToList();
                }
            }
            else
            {
                // Insert
                using (var B = new dbFFBEntities())
                {
                    var i = new Breeder
                    {
                        BreederAddress = txtBreederAddress.Text.Trim(),
                        BreederCity = txtBreederCity.Text.Trim(),
                        BreederEmail = txtBreederCity.Text.Trim(),
                        BreederKennel = txtBreederKennel.Text.Trim(),
                        BreederName = txtBreederName.Text.Trim(),
                        BreederPhone = txtBreederPhone.Text.Trim(),
                        BreederState = txtBreederState.Text.Trim(),
                        BreederWebSite = txtBreederWebsite.Text.Trim(),
                        BreederZip = txtBreederZip.Text.Trim(),
                        LastUpdateID = Environment.UserName.ToString(),
                        LastUpdateTimeStamp = DateTime.Now
                    };
                    B.Breeders.Add(i);
                    var sa = B.SaveChanges();
                    if (sa == 1)
                    {
                        ClearAllBreederFields();
                        pnlDetail.Visible = false;
                        getBreederName_cboBreederName();
                        MessageBox.Show("Breeder " + i.BreederName + " Added Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Breeder insert Failed");
                    }
                }
            }
        }
        private void ClearAllBreederFields()
        {
            try
            {
                txtBreederAddress.Text = string.Empty;
                txtBreederCity.Text = string.Empty;
                txtBreederCity.Text = string.Empty;
                txtBreederKennel.Text = string.Empty;
                txtBreederName.Text = string.Empty;
                txtBreederPhone.Text = string.Empty;
                txtBreederState.Text = string.Empty;
                txtBreederWebsite.Text = string.Empty;
                txtBreederZip.Text = string.Empty;
                lblBreederId.Text = string.Empty;
                txtBreederLUid.Text = string.Empty;
                txtBreederLUTS.Text = string.Empty;
                txtBreederEmail.Text = string.Empty;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.ToString());
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            IsUpdateOperation = false;
            ClearAllBreederFields();
            lblDetailHeader.Text = "Add New Breeder";
            pnlGrid.Visible = false;
            pnlDetail.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        //delete 
        //https://ef.readthedocs.io/en/staging/saving/basic.html#deleting-data
            using (var B = new dbFFBEntities())
            {
                var d = B.Breeders.First(x => x.BreederName == cboBreederName.Text.Trim());
                d.Active = chkActive.Checked;
                d.BreederAddress = txtBreederAddress.Text.Trim();
                d.BreederCity = txtBreederCity.Text.Trim();
                d.BreederEmail = txtBreederCity.Text.Trim();
                d.BreederKennel = txtBreederKennel.Text.Trim();
                d.BreederName = txtBreederName.Text.Trim();
                d.BreederPhone = txtBreederPhone.Text.Trim();
                d.BreederState = txtBreederState.Text.Trim();
                d.BreederWebSite = txtBreederWebsite.Text.Trim();
                d.BreederZip = txtBreederZip.Text.Trim();
                d.LastUpdateID = Environment.UserName.ToString();
                d.LastUpdateTimeStamp = DateTime.Now;
                B.Breeders.Remove(d);
                var de = B.SaveChanges();
                if (de == 1)
                {
                    ClearAllBreederFields();
                    pnlDetail.Visible = false;
                    getBreederName_cboBreederName();
                    MessageBox.Show("Breeder " + d.BreederName + " Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Breeder Delete Failed");
                }
            }
        }

        private void btnAllBreeders_Click(object sender, EventArgs e)
        {
            dgvBreeders.DataSource = GetAllBreeders();
            
            
            pnlDetail.Visible = false;
            pnlGrid.Visible = true;
            pnlGrid.BringToFront();
            // when you want to view all Breeders in a DataGrid

        }

        List<Breeder> GetAllBreeders()
        {
            using (var B = new dbFFBEntities())
            {
                List<Breeder> retModel = new List<Breeder>();
                retModel = B.Breeders.OrderBy(x => x.BreederName).ToList();
                return retModel;
             }
        }

        private void dgvBreeders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboBreederName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
