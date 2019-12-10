using APIManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIManager.WIN {
    public class TabData {
        public TabData(TabPage tab, EntityEditor editor, Entity entity) {
            Tab = tab;
            Editor = editor;
            Entity = entity;
        }

        public TabPage Tab { get; set; }
        public EntityEditor Editor { get; set; }
        public Entity Entity { get; set; }
    }
}
