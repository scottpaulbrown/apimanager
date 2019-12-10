using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using APIManager.Logic;
using System.IO;

namespace APIManager.WIN {
    public partial class TemplateProperties : UserControl {
        TemplateFile templateFile;
        List<FileVariable> variables;
        string templateContents = string.Empty;

        public TemplateProperties() {
            InitializeComponent();
        }

        public TemplateProperties(TemplateFile template) {
            InitializeComponent();
            templateFile = template;
        }

        private void LoadFile() {
            //templateContents = File.ReadAllText(templateFile.FilePath);
            //// get a list of all the variables in the file
            //variables = new List<FileVariable>();
            //var matches = Regex.Matches(templateContents, @"{{ *\w+ *}}");
            //foreach (var match in matches) {
            //    // see if this variable is already in the list
            //    if (!variables.Any(v => v.Tag.Equals(match.ToString()))) {
            //        FileVariable fv = new FileVariable();
            //        fv.Tag = match.ToString();
            //        fv.Name = fv.Tag.Replace("{{", "").Replace("}}", "");
            //        variables.Add(fv);
            //    }
            //}

            //fileVariableBindingSource.DataSource = variables;
        }

        private void TemplateProperties_Load(object sender, EventArgs e) {
            LoadFile();
        }

        public string GenerateCode() {
            grdVariables.EndEdit();
            string code = templateContents;
            foreach (var variable in variables) {
                code = code.Replace(variable.Tag, variable.Value);
            }

            return code;
        }
    }
}
