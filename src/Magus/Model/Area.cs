using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Area {

        string name;
        string filePath;

        public Area() {
            this.name = "";
            this.filePath = "";
        }

        public Area(string name, string filePath) {
            this.name = name;
            this.filePath = filePath;
        }

        public string Name {
            get { return name; }
            set { name = value; } 
        }

        public string FilePath {
            get { return filePath; }
            set { filePath = value; }
        }
    }
}
