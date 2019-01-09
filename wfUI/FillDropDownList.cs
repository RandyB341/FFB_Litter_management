using System.Windows.Forms;



namespace wfUI
{
    class FillDropDownList
    {

        /// <summary>
        /// IntegrateList in DDL source:  https://stackoverflow.com/questions/18880534/populating-value-and-text-of-combobox
        /// </summary>
        /// <param name="ddl"></param>
        /// <param name="dlist"></param>
        /// <param name="txtField"></param>
        /// <param name="valField"></param>
        public void IntegrateListintoDDL(ComboBox ddl, object dlist, string txtField, string valField)
        {
            ddl.DisplayMember = txtField;
            ddl.ValueMember = valField;
            ddl.DataSource = dlist;
            AddBlankRow(ddl);
        }
    
        /// <summary>
        /// Used to add a Blank row to the Top of DropDown lists
        /// </summary>
        /// <param name="DDL"></param>
        public void AddBlankRow(ComboBox DDL)
        {
            //ListItem Li = new ListItem("-----", "");
            ListViewItem Li = new ListViewItem("-----", "");
            DDL.Items.Insert(0, Li);
        }

      
        public string StringFormatter(string str)
        {
            if (str == null)
            {
                return null;
            }
            str = str.Trim();
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            else
            {
                return str;
            }
        }
    }
}
