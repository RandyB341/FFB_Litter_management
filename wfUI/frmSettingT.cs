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
    public partial class frmSettingT : Form
    {
        public frmSettingT()
        {
            InitializeComponent();
        }

        private static bool IsUpdateOperation = false;
        private const string strTableName = "SettingT ";

        FillDropDownList fdl = new FillDropDownList();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearAllDetailFields();
            if (cboKey.SelectedIndex != 0)
            {
               int intId = Convert.ToInt32(cboKey.SelectedValue);
                IsUpdateOperation = true;
                var D = GetDetails(intId);
                lblID.Text = D[0].Id.ToString();
                txtKey.Text = D[0].Key.ToString();
                txtValue.Text = D[0].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsUpdateOperation == true)
            {
                // Update
                int intI = Convert.ToInt32(lblID.Text);
                using (var B = new dbFFBEntities())
                {
                    var u = B.SettingTs.First(x => x.Id == intI);
                    u.Key = txtKey.Text.Trim();
                    u.Value = txtValue.Text.Trim();
                    var s = B.SaveChanges();
                        if (s == 1)
                    {
                        ClearAllDetailFields();
                        load_cboKey();
                        dgvSettingsT.DataSource = GetAll();
                        MessageBox.Show(strTableName + u.Key + " Updated Successfully");
                    }
                        else
                    {
                        MessageBox.Show(strTableName + " update Failed");
                    }
                }
            }
            else
            {
                // Insert
                using (var B = new dbFFBEntities())
                {
                    var i = new SettingT
                    {
                        Key = txtKey.Text.Trim(),
                        Value = txtValue.Text.Trim()

                    };
                    B.SettingTs.Add(i);
                    var sa = B.SaveChanges();
                    if (sa == 1)
                    {
                        ClearAllDetailFields();
                        load_cboKey();
                        dgvSettingsT.DataSource = GetAll();
                        MessageBox.Show(strTableName + i.Key + " Added Successfully");
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
            //delete 
            //https://ef.readthedocs.io/en/staging/saving/basic.html#deleting-data
            int intId = Convert.ToInt32(lblID.Text);
            using (var B = new dbFFBEntities())
            {
                var d = B.SettingTs.First(x => x.Id == intId);
                B.SettingTs.Remove(d);
                var de = B.SaveChanges();
                if (de == 1)
                {
                    ClearAllDetailFields();
                    load_cboKey();
                    dgvSettingsT.DataSource = GetAll();
                }
                else
                {
                    MessageBox.Show(strTableName + " delete failed");
                }
            }
        }

        private void ClearAllDetailFields()
        {
            try
            {
                lblID.Text = string.Empty;
                txtKey.Text = string.Empty;
                txtValue.Text = string.Empty;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.ToString());
            }
        }
        private void load_cboKey()
        {
            cboKey.DataSource = null;
            cboKey.Items.Clear();
            using (var B = new dbFFBEntities())
            {
                // https://stackoverflow.com/questions/35284946/why-do-i-get-cannot-bind-to-the-new-display-member-with-this-code
                cboKey.ValueMember = "Id";
                cboKey.DisplayMember = "Key";
                cboKey.DataSource = B.SettingTs.Select(x => new { x.Id, x.Key }).OrderBy(x => x.Key).ToList();
                cboKey.Invalidate();
            }
        }

        private void frmSettingT_Load(object sender, EventArgs e)
        {
            ClearAllDetailFields();
            load_cboKey();
            dgvSettingsT.DataSource = null;
            dgvSettingsT.DataSource = GetAll();
        }

        private List<SettingT> GetAll()
        {
            using (var B = new dbFFBEntities())
            {
                List<SettingT> retModel = new List<SettingT>();
                retModel = B.SettingTs.OrderBy(x => x.Key).ToList();
                return retModel;
            }
        }
        private List<SettingT> GetDetails(int i)
        {
            using (var B = new dbFFBEntities())
            {
                List<SettingT> retModel = new List<SettingT>();
                retModel = B.SettingTs.Where(x => x.Id == i).ToList();
                return retModel;
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ClearAllDetailFields();
            dgvSettingsT.DataSource = null;
            dgvSettingsT.DataSource = GetAll();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            IsUpdateOperation = false;
            ClearAllDetailFields();
            dgvSettingsT.DataSource = null;
            dgvSettingsT.DataSource = GetAll();
            txtKey.Focus();
        }
    }
}
