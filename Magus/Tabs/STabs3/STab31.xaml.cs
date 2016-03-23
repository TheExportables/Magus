using Magus.Controls;
using Magus.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Magus.Tabs.STabs3
{
    /// <summary>
    /// Interaction logic for STab31.xaml
    /// </summary>
    public partial class STab31 : UserControl {

        Color pickedColor = Colors.Black;
        String pickedFile = null;

        public STab31() {
            InitializeComponent();
            for (int i = 1; i < 33; i++) {
                widthCombo.Items.Add(i);
            }
            for (int i = 8; i < 64; i++)
            {
                fontSizeCombo.Items.Add(i);
            }
        }

        private void colorButton_Click_1(object sender, RoutedEventArgs e) {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.SelectedColor = myInkCanvas.DefaultDrawingAttributes.Color;
            colorDialog.Owner = GetParentWindow(this);
            if ((bool)colorDialog.ShowDialog()) {
                myInkCanvas.DefaultDrawingAttributes.Color = colorDialog.SelectedColor;
                pickedColor = colorDialog.SelectedColor;
                foreach (var item in myInkCanvas.GetSelectedStrokes()) {
                    item.DrawingAttributes.Color = colorDialog.SelectedColor;               
                }
            }
        }

        public static Window GetParentWindow(DependencyObject child) {
            DependencyObject parentObject = VisualTreeHelper.GetParent(child);

            if (parentObject == null) {
                return null;
            }

            Window parent = parentObject as Window;
            if (parent != null) {
                return parent;
            }
            else {
                return GetParentWindow(parentObject);
            }
        }

        private void widthCombo_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {
            myInkCanvas.DefaultDrawingAttributes.Width = widthCombo.SelectedIndex + 1;
            myInkCanvas.DefaultDrawingAttributes.Height = widthCombo.SelectedIndex + 1;
            myInkCanvas.EraserShape = new RectangleStylusShape(widthCombo.SelectedIndex + 1, widthCombo.SelectedIndex + 1);
            if(myInkCanvas.ActiveEditingMode.Equals(InkCanvasEditingMode.EraseByPoint)){
                myInkCanvas.EditingMode = InkCanvasEditingMode.None;
                myInkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
            }
        }

        private void lineButton_Click_1(object sender, RoutedEventArgs e)
        {
            myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void rectButton_Click_1(object sender, RoutedEventArgs e)
        {
            myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            StylusPointCollection pts = new StylusPointCollection();
            Random r = new Random();
            int x = r.Next(50, 600);
            int y = r.Next(50, 500);
            pts.Add(new StylusPoint(x, y));
            pts.Add(new StylusPoint(x, y+100));
            pts.Add(new StylusPoint(x+200, y+100));
            pts.Add(new StylusPoint(x+200, y));
            pts.Add(new StylusPoint(x, y));
           
            Stroke s = new Stroke(pts);
            s.DrawingAttributes.Color = pickedColor;
            s.DrawingAttributes.Width = widthCombo.SelectedIndex + 1;
            s.DrawingAttributes.Height = widthCombo.SelectedIndex + 1;
            myInkCanvas.Strokes.Add(s);
        }

        private void ellipseButton_Click_1(object sender, RoutedEventArgs e)
        {
            myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            Random rand = new Random();
            double theta = 0;
            double h = rand.NextDouble() * (550 - 150) + 150;
            double k = rand.NextDouble() * (550 - 150) + 150;
            double step = 2*Math.PI/50;
            int r = 100;
            StylusPointCollection pts = new StylusPointCollection();

            while(theta <= 360){
                double x = h + r*Math.Cos(theta);
                double y = k + r*Math.Sin(theta);
                pts.Add(new StylusPoint(x,y));
                theta += step;
            }

            Stroke s = new Stroke(pts);
            s.DrawingAttributes.Color = pickedColor;
            s.DrawingAttributes.Width = widthCombo.SelectedIndex + 1;
            s.DrawingAttributes.Height = widthCombo.SelectedIndex + 1;
            myInkCanvas.Strokes.Add(s);
        }

        private void eraserButton_Click_1(object sender, RoutedEventArgs e)
        {
            myInkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void selectButton_Click_1(object sender, RoutedEventArgs e)
        {
            myInkCanvas.EditingMode = InkCanvasEditingMode.Select;
        }

        private void textButton_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox textbox = new TextBox();
            textbox.Text = "Add text here";
            textbox.BorderThickness = new System.Windows.Thickness(0);
            textbox.FontSize = (int)fontSizeCombo.SelectedValue;
            textbox.AcceptsReturn = true;
            textbox.TextWrapping = TextWrapping.Wrap;
            textbox.Background = new SolidColorBrush(Colors.Transparent);
            myInkCanvas.Children.Add(textbox);
            InkCanvas.SetTop(textbox, 100.0);
            InkCanvas.SetLeft(textbox, 100.0);
        }

        private void fontSizeCombo_SelectionChanged_1(object sender, SelectionChangedEventArgs e) {
            foreach (var item in myInkCanvas.GetSelectedElements()){
                ((TextBox)item).FontSize = (int)fontSizeCombo.SelectedValue;
	        }        
        }

        private void saveButton_Click_1(object sender, RoutedEventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Map";
            sfd.DefaultExt = ".png";
            sfd.Filter = "Image files (*.png,*.jpg,*.bmp)|*.png;*.jpg;*.bmp|All files(*.*)|*";

            if (sfd.ShowDialog() == true) {
                pickedFile = sfd.FileName;
                FileStream inkfs = new FileStream(sfd.FileName+".ink", FileMode.Create);
                myInkCanvas.Strokes.Save(inkfs);
                inkfs.Close();

                //get the dimensions of the ink control
                int width = (int)this.myInkCanvas.ActualWidth;
                int height = (int)this.myInkCanvas.ActualHeight;
                //render ink to bitmap
                RenderTargetBitmap rtb = new RenderTargetBitmap(width, height, 96d, 96d, PixelFormats.Default);
                rtb.Render(myInkCanvas);

                using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create)) {
                    BmpBitmapEncoder encoder = new BmpBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(rtb));
                    encoder.Save(fs);
                }
            }
        }

        private void loadButton_Click_1(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //ofd.Filter = "Image files (*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp|All files(*.*)|*";
            ofd.Filter = "WPF Ink files (*.ink)|*.ink|All(*.*)|*";
            if (ofd.ShowDialog() == true) {
                myInkCanvas.Strokes = new StrokeCollection(new FileStream(ofd.FileName, FileMode.Open));
            }
        }

        private void resetButton_Click_1(object sender, RoutedEventArgs e) {
            myInkCanvas.Strokes = new StrokeCollection();
            myInkCanvas.Children.Clear();
        }

        private void listButton_Click_1(object sender, RoutedEventArgs e) {
            if (pickedFile != null) {
                Pictures pics = Pictures.Instance;
                String name;
                TextDialog td = new TextDialog();
                if (td.ShowDialog() == true) {
                    name = td.ResponseText;
                } else {
                    name = System.IO.Path.GetFileNameWithoutExtension(pickedFile);
                }
                Picture p = new Picture();
                p.Name = name;
                p.FilePath = pickedFile;
                Pictures.getPictures().Add(p);
            } else {
                MessageBox.Show("A képet előbb el kell menteni, hogy a listához adható legyen!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}