using APIManager.Data;
using APIManager.Data.ReferenceTypesData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIManager.WIN {
    public partial class CreateLink : Form {
        EntityField _currentField;

        public CreateLink() {
            InitializeComponent();
        }

        private void CreateLink_Load(object sender, EventArgs e) {
            //PopulateDropDowns();
        }

        //protected void PopulateDropDowns() {
        //    var refLogic = new ReferenceTypeLogic(GlobalData.AppInfo);
        //    var dtList = refLogic.GetAllDataTypes();
        //    cboDataType.DataSource = dtList;
        //    cboDataType.DisplayMember = "DataTypeCode";
        //    cboDataType.ValueMember = "DataTypeCode";
        //}

        //private void cboDataType_SelectedIndexChanged(object sender, EventArgs e) {
        //    var selType = cboDataType.SelectedItem as DataType;
        //    txtLength.Visible = selType.NeedsLength;
        //    lblLength.Visible = selType.NeedsLength;
        //    txtScale.Visible = selType.NeedsScale;
        //    lblScale.Visible = selType.NeedsScale;
        //}

        //private void btnSaveAddMore_Click(object sender, EventArgs e) {

        //}

        //private void Save() {
        //    // validate the fields
        //    if (string.IsNullOrEmpty(txtName.Text.Trim())) {
        //        MessageBox.Show("Please provide a field name", "No Name");
        //        return;
        //    }
        //    if (txtLength.Visible && string.IsNullOrEmpty(txtLength.Text.Trim())) {
        //        MessageBox.Show("Please provide a field length", "No Length");
        //    }
        //    if (txtScale.Visible && string.IsNullOrEmpty(txtScale.Text.Trim())) {
        //        MessageBox.Show("Please provide a scale", "No Scale");
        //    }

        //    var selType = cboDataType.SelectedItem as DataType;
        //    // determine if this is a new field
        //    if (_currentField == null) {
        //        _currentField = new EntityField();
        //        _currentField.FieldName = txtName.Text.Trim();
        //        _currentField.Datatype = selType.DataTypeCode;
        //        _currentField.MaxLength = selType.NeedsLength ? int.Parse(txtLength.Text) : 0;
        //        _currentField.Scale = selType.NeedsScale ? int.Parse(txtScale.Text) : 0;
        //        _currentField.IsRequired = chkRequired.Checked;

        //    }
        //}
    }
}
