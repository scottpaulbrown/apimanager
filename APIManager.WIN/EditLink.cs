using APIManager.Data;
using APIManager.Data.Constants;
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
    public partial class EditLink : Form {
        Entity _entity;
        Project _project;

        public EditLink() {
            InitializeComponent();
        }

        public EditLink(Project proj, Entity entity) {
            InitializeComponent();
            _entity = entity;
            _project = proj;
        }

        public EntityLink Link { get; set; }

        void PopulateFields() {

        }

        void PopulateDropDowns() {
            cboField.DataSource = _entity.EntityFields.ToList();
            cboField.DisplayMember = "FieldName";
            cboField.ValueMember = "EntityFieldId";

            cboEntity.DataSource = _project.Entities.Where(e => e.EntityId != _entity.EntityId).ToList();
            cboEntity.DisplayMember = "EntityName";
            cboEntity.ValueMember = "EntityId";

            var refLogic = new ReferenceTypeLogic(GlobalData.AppInfo);
            var linkTypes = refLogic.GetAllLinkTypes();
            cboLinkType.DataSource = linkTypes;
            cboLinkType.ValueMember = "LinkTypeCode";
            cboLinkType.DisplayMember = "LinkTypeName";
        }

        private void btnSave_Click(object sender, EventArgs e) {
            this.Link = new EntityLink();
            Link.ForeignKeyFieldId = (int)cboField.SelectedValue;
            Link.PrimaryKeyFieldId = (int)lblPrimaryKeyField.Tag;
            Link.LinkTypeCode = cboLinkType.SelectedValue.ToString();
            Link.StatusCode = EntityLinkStatusCodes.Staged;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void EditLink_Load(object sender, EventArgs e) {
            PopulateDropDowns();
            PopulateFields();
        }

        private void cboEntity_SelectedIndexChanged(object sender, EventArgs e) {
            // find the primary key field of this table
            var entity = cboEntity.SelectedItem as Entity;
            var field = entity.EntityFields.Where(f => f.IsKey).First();
            lblPrimaryKeyField.Text = field.FieldName;
            lblPrimaryKeyField.Tag = field.EntityFieldId;
        }
    }
}
