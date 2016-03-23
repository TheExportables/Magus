using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Song {

        String name;
        String filePath;

        public Song() {
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
