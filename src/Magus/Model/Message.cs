using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Message {

        String name;
        String filePath;
        //String text;

        public Message() {
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

        /*public String Text {
            get {
                return text;
            }
            set {
                text = value;
            }
        }*/
    }
}