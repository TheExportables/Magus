using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Magus.Model {
    public class Picture {

        String name;
        String filePath;

        public Picture() {
        }

        public String Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public String FilePath {
            get {
                return filePath;
            }
            set {
                filePath = value;
            }
        }
    }
}
