using APIManager.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIManager.WIN {
    public class TabInfo {
        public TabInfo(EntityInfo entity, EditEntity editor, TabPage tagPage) {
            Entity = entity;
            Editor = editor;
            TagPage = tagPage;
        }

        public EntityInfo Entity { get; set; }
        public EditEntity Editor { get; set; }
        public TabPage TagPage { get; set; }
    }
}
