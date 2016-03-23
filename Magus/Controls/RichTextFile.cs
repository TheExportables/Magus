using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Magus.Controls {
    internal class RichTextFile : RichTextBox {

        public RichTextFile() { }

        public String File {
            get { return (String)GetValue(FileProperty); }
            set { SetValue(FileProperty, value); }
        }

        public static DependencyProperty FileProperty =
            DependencyProperty.Register("File", typeof(String), typeof(RichTextFile),
            new PropertyMetadata(new PropertyChangedCallback(OnFileChanged)));

        private static void OnFileChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            RichTextFile rtf = d as RichTextFile;
            if (d == null)
                return;

            ReadFile(rtf.File, rtf.Document);
        }

        private static void ReadFile(string inFilename, FlowDocument inFlowDocument) {
            if (System.IO.File.Exists(inFilename)) {
                TextRange range = new TextRange(inFlowDocument.ContentStart, inFlowDocument.ContentEnd);
                FileStream fStream = new FileStream(inFilename, FileMode.Open, FileAccess.Read, FileShare.Read);

                range.Load(fStream, DataFormats.Rtf);
                fStream.Close();
            }
        }

    }
}