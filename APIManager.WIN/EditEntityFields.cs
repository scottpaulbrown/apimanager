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
    public partial class EditEntityFields : Form {
        EntityField _currentField;
        bool _isAdding = false;

        public List<EntityField> Fields { get; set; }

        public EditEntityFields() {
            InitializeComponent();
        }

        public EditEntityFields(List<EntityField> fields) {
            InitializeComponent();
            Fields = fields;
        }

        private void EditEntityFields_Load(object sender, EventArgs e) {            
            PopulateDropDowns();
            if (Fields == null || Fields.Count == 0) {
                Fields = new List<EntityField>();
                SetupAddNew();
            } else {
                grdFields.Rows[0].Selected = true;
            }

            entityFieldBindingSource.DataSource = Fields;
        }

        protected void PopulateDropDowns() {
            var refLogic = new ReferenceTypeLogic(GlobalData.AppInfo);
            var dtList = refLogic.GetAllDataTypes();
            cboDataType.DataSource = dtList;
            cboDataType.DisplayMember = "DataTypeCode";
            cboDataType.ValueMember = "DataTypeCode";
        }

        private void cboDataType_SelectedIndexChanged(object sender, EventArgs e) {
            var selType = cboDataType.SelectedItem as DataType;
            txtLength.Visible = selType.NeedsLength;
            lblLength.Visible = selType.NeedsLength;
            txtScale.Visible = selType.NeedsScale;
            lblScale.Visible = selType.NeedsScale;
        }

        private void SetupForm() {
            
        }

        private void SetupAddNew() {
            _currentField = new EntityField();
            txtName.Text = "";
            cboDataType.SelectedValue = "varchar";
            txtLength.Text = "50";
            txtScale.Text = "";
            chkRequired.Checked = true;
            chkDTO.Checked = true;
            chkSearch.Checked = true;
            chkContains.Checked = false;
            txtInitialValue.Text = "";
            _isAdding = true;
            txtName.Focus();
        }

        private void LoadField() {
            txtName.Text = _currentField.FieldName;
            cboDataType.SelectedValue = _currentField.Datatype;
            chkRequired.Checked = _currentField.IsRequired;
            txtLength.Text = _currentField.MaxLength.ToString();
            txtScale.Text = _currentField.Scale.ToString();
            chkDTO.Checked = _currentField.IsDTO;
            chkSearch.Checked = _currentField.IsSearchField;
            chkContains.Checked = _currentField.IsContainsSearch;
            txtInitialValue.Text = _currentField.InitialValue;
        }

        private void btnSaveAddMore_Click(object sender, EventArgs e) {
            SaveAndAdd();
        }

        private void SaveAndAdd() {
            if (_currentField == null || Save()) {
                SetupAddNew();
            }
        }

        private void btnSaveField_Click(object sender, EventArgs e) {
            Save();
        }

        private bool Save() {
            if (string.IsNullOrEmpty(txtName.Text.Trim())) {
                MessageBox.Show("Please provide a field name", "No Field Name");
                return false;
            }

            _currentField.FieldName = txtName.Text;
            _currentField.IsRequired = chkRequired.Checked;
            var selType = cboDataType.SelectedItem as DataType;
            _currentField.Datatype = cboDataType.SelectedValue.ToString();
            if (selType.NeedsLength) {
                _currentField.MaxLength = int.Parse(txtLength.Text.Trim());
            } else {
                _currentField.MaxLength = null;
            }
            if (selType.NeedsScale) {
                _currentField.Scale = int.Parse(txtScale.Text.Trim());
            } else {
                _currentField.Scale = null;
            }

            _currentField.IsDTO = chkDTO.Checked;
            _currentField.IsSearchField = chkSearch.Checked;
            _currentField.IsContainsSearch = _currentField.IsSearchField && chkContains.Checked;
            _currentField.InitialValue = txtInitialValue.Text;

            if (_isAdding) {
                Fields.Add(_currentField);
                entityFieldBindingSource.ResetBindings(false);
            }

            return true;
        }

        private void EditEntityFields_KeyDown(object sender, KeyEventArgs e) {
            if (e.Alt && e.KeyCode == Keys.A) {
                SaveAndAdd();
            } else if (e.Alt && e.KeyCode == Keys.N) {
                SetupAddNew();
            } else if (e.Alt && e.KeyCode == Keys.C) {
                Cancel();
            }
        }

        private void grdFields_SelectionChanged(object sender, EventArgs e) {
            if (grdFields.SelectedRows.Count == 1) {
                _currentField = grdFields.SelectedRows[0].DataBoundItem as EntityField;
                _isAdding = false;
                LoadField();
            } 
        }

        private void Cancel() {
            if (!_isAdding) {
                LoadField();
            } else {
                if (Fields.Count > 0) {
                    if (grdFields.SelectedRows.Count == 1) {
                        _currentField = grdFields.SelectedRows[0].DataBoundItem as EntityField;
                        LoadField();
                    } else if (grdFields.Rows.Count > 0) {
                        _currentField = grdFields.Rows[0].DataBoundItem as EntityField;
                        LoadField();
                    }
                }
            }
        }
    }
}
