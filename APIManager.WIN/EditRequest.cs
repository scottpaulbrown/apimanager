using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APIManager.Logic;

namespace APIManager.WIN {
    public partial class EditRequest : UserControl {
        APIRequest request;

        public EditRequest() {
            InitializeComponent();
            request = new APIRequest();
            dataFieldBindingSource.DataSource = request.Parameters;
        }

        public void createFieldsFromEntity(EntityInfo info) {
            var dataFields = APIRequestLogic.GetFieldsFromEntifyInfo(info);
            request.Parameters.AddRange(dataFields);
            dataFieldBindingSource.ResetBindings(false);
        }
    }
}
