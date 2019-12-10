using System;
using System.Collections.Generic;
using System.Text;

namespace APIManager.Logic {
    public class TemplateFile {
        public TemplateFile() { }

        public TemplateFile(string fileName, string generatedFileMask, string generationPathMask, string projectType, string languageType) {
            FileName = fileName;
            GeneratedFileMask = generatedFileMask;
            GenerationPathMask = generationPathMask;
            ProjectType = projectType;
            LanguageType = languageType;
        }

        public string FileName { get; set; }
        public string GeneratedFileMask { get; set; }
        public string GenerationPathMask { get; set; }
        public string ProjectType { get; set; }
        public string LanguageType { get; set; }
    }
}
