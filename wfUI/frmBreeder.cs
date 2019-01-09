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
    public partial class frmBreeder : Form
    {
        public frmBreeder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// IsUpdateOperation will be true when pnlDetail loads from cboBreeder selection
        /// will be false when pnlDetail loads from btnAddNew
        /// </summary>
        private static bool IsUpdateOperation = false;
        private const string strBreeder = "Breeder ";

        FillDropDownList fdl = new FillDropDownList();

        private void frmBreeder_Load(object sender, EventArgs e)
        {
            ClearAllBreederFields();
            load_cboBreederName();
            //MakeGridvewSortable();
            dgvBreeder.DataSource = null;
            dgvBreeder.DataSource = GetAllBreeders();
        }

        private void MakeGridvewSortable()
        {
            foreach (DataGridViewColumn col in dgvBreeder.Columns)
            {
                dgvBreeder.Columns[col.Name].SortMode = DataGridViewColumnSortMode.Automatic;
            }
            //dgvBreeder.Columns["BreederID"].SortMode = DataGridViewColumnSortMode.Automatic;
            //dgvBreeder.Columns["BreederName"].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        private void load_cboBreederName()
        {
            cboBreederName.DataSource = null;
            cboBreederName.Items.Clear();
            using (var B = new dbFFBEntities())
            {
                cboBreederName.ValueMember = "BreederID";
                cboBreederName.DisplayMember = "BreederName";
                cboBreederName.DataSource = B.Breeders.Select(x => new { x.BreederID, x.BreederName }).OrderBy(x => x.BreederName).ToList();
                cboBreederName.Invalidate();
            }
    }

        private void btnAll_Click(object sender, EventArgs e)
        {
            ClearAllBreederFields();
            dgvBreeder.DataSource = null;
            dgvBreeder.DataSource = GetAllBreeders();
        }

        private List<Breeder> GetAllBreeders()
        {
            using (var B = new dbFFBEntities())
            {
                B.Configuration.LazyLoadingEnabled = false;
                List<Breeder> retModel = new List<Breeder>();
                retModel = B.Breeders.OrderBy(x => x.BreederName).ToList();
                return retModel;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearAllBreederFields();
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
                txtBreederZip.Text = fdl.StringFormatter(D[0].BreederZip?.ToString());
                chkActive.Checked = D[0].Active.Value;
                lblDetailHeader.Text = "Search - " + cboBreederName.Text;
            }
        }

        private List<Breeder> GetBreederDetails(int intBrId)
        {
            //dbFFBEntities userModel = new dbFFBEntities();
            //List<Breeder> retModel = new List<Breeder>();
            //retModel = userModel.Breeders.Where(x => x.BreederID == intBrId).ToList();
            //return retModel;
            using (var B = new dbFFBEntities())
            {
                List<Breeder> retModel = new List<Breeder>();
                retModel = B.Breeders.Where(x => x.BreederID == intBrId).ToList();
                return retModel;
            }
        }

        private void ClearAllBreederFields()
        {
            try
            {
                txtBreederAddress.Text = string.Empty;
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
                chkActive.Checked = false;
                
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsUpdateOperation == true)
            {
                // this is Update
                lblBreederDetails.Text = "Update " + strBreeder;
                //https://ef.readthedocs.io/en/staging/saving/basic.html#updating-data
                using (var B = new dbFFBEntities())
                {
                    var u = B.Breeders.First(x => x.BreederName == cboBreederName.Text.Trim());
                    u.Active = chkActive.Checked;
                    u.BreederAddress = txtBreederAddress.Text.Trim();
                    u.BreederCity = txtBreederCity.Text.Trim();
                    u.BreederEmail = txtBreederEmail.Text.Trim();
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
                        //ClearAllBreederFields();
                        //load_cboBreederName();
                        frmBreeder_Load(sender, e);
                        MessageBox.Show(strBreeder + u.BreederName + " Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show(strBreeder + " update Failed");
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
                lblBreederDetails.Text = "Add New " + strBreeder;
                using (var B = new dbFFBEntities())
                {
                    var i = new Breeder
                    {
                        BreederAddress = txtBreederAddress.Text.Trim(),
                        BreederCity = txtBreederCity.Text.Trim(),
                        BreederEmail = txtBreederEmail.Text.Trim(),
                        BreederKennel = txtBreederKennel.Text.Trim(),
                        BreederName = txtBreederName.Text.Trim(),
                        BreederPhone = txtBreederPhone.Text.Trim(),
                        BreederState = txtBreederState.Text.Trim(),
                        BreederWebSite = txtBreederWebsite.Text.Trim(),
                        BreederZip = txtBreederZip.Text.Trim(),
                        LastUpdateID = Environment.UserName.ToString(),
                        Active = chkActive.Checked,
                        LastUpdateTimeStamp = DateTime.Now
                    };
                    B.Breeders.Add(i);
                    var sa = B.SaveChanges();
                    if (sa == 1)
                    {
                        //ClearAllBreederFields();

                        //load_cboBreederName();
                        frmBreeder_Load(sender, e);
                        MessageBox.Show(strBreeder + i.BreederName + " Added Successfully");
                    }
                    else
                    {
                        MessageBox.Show(strBreeder + " insert Failed");
                    }
                }
            }
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
                    
                    load_cboBreederName();
                    MessageBox.Show(strBreeder + d.BreederName + " Deleted Successfully");
                }
                else
                {
                    MessageBox.Show(strBreeder + " Delete Failed");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllBreederFields();
        }

        //private void dgvBreeder_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int col = e.ColumnIndex;
        //    int row = e.RowIndex;
        //    DataGridViewColumn myCol = dgvBreeder.Columns.GetColumnCount(DataGridViewElementStates.Selected) == 1 ? dgvBreeder.Columns[col] : null;

        //    //dgvBreeder.Columns[col];
        //    if (dgvBreeder.DisplayedRowCount(false) > 1)
        //    {
        //        if (row != 1)
        //        {
        //            int myRowNum = dgvBreeder.CurrentCell.RowIndex; 

        //        }
        //        else
        //        {
        //            dgvBreeder.Sort(myCol, ListSortDirection.Ascending);
        //        }

        //    }
        //}

        private void dgvBreeder_CellContentClick(object sender, System.EventArgs e)
        {
        //    https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.datagridview.sort?view=netframework-4.7.2
        //    Check which column is selected, otherwise set NewColumn to null.
        //    int col = e.ColumnIndex;
        //    int row = e.RowIndex;
      
            DataGridViewColumn newColumn = 
                dgvBreeder.Columns.GetColumnCount(DataGridViewElementStates.Selected) == 1 ? dgvBreeder.SelectedColumns[0] : null;

            DataGridViewColumn oldColumn = dgvBreeder.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    dgvBreeder.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // If no column has been selected, display an error dialog  box.
            if (newColumn == null)
            {
                MessageBox.Show("Select a single column and try again.",
                    "Error: Invalid Selection", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                dgvBreeder.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                    SortOrder.Ascending : SortOrder.Descending;
            }
        }

        private void dgvBreeder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            DataGridViewColumn newColumn =
              dgvBreeder.Columns.GetColumnCount(DataGridViewElementStates.Selected) == 1 ? dgvBreeder.SelectedColumns[0] : dgvBreeder.SelectedColumns[col];

            DataGridViewColumn oldColumn = dgvBreeder.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not currently sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    dgvBreeder.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // If no column has been selected, display an error dialog  box.
            //if (newColumn == null)
            //{
            //    MessageBox.Show("Select a single column and try again.",
            //        "Error: Invalid Selection", MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //}
            //else
            //{
                dgvBreeder.Sort(newColumn, direction);
                newColumn.HeaderCell.SortGlyphDirection =
                    direction == ListSortDirection.Ascending ?
                    SortOrder.Ascending : SortOrder.Descending;
            //}
        }

        //private void dgvBreeder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void dgvBreeder_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            //header row = -1
            //Breeder Address = col 2
            dgvBreeder.Sort(dgvBreeder.Columns["BreederAddress"], System.ComponentModel.ListSortDirection.Ascending);

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            IsUpdateOperation = false;
            ClearAllBreederFields();
            dgvBreeder.DataSource = null;
            dgvBreeder.DataSource = GetAllBreeders();
            chkActive.Checked = true;
            txtBreederName.Focus();
        }
    }
}
   
