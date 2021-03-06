﻿using System;
using System.Collections.Generic;
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

namespace Magus.Controls
{
    /// <summary>
    /// Interaction logic for ColorPicker.xaml
    /// </summary>
    public partial class ColorPicker : UserControl
    {

        private DrawingAttributes drawingAttributes = new DrawingAttributes();
        private Color selectedColor = Colors.Transparent;
        private Boolean IsMouseDown = false;

        public ColorPicker() : this(Colors.Black){ }

        public ColorPicker(Color initialColor)
        {
            InitializeComponent();
            this.selectedColor = initialColor;
        }

        public Color SelectedColor
        {
            get { return selectedColor; }
            private set
            {
                if (selectedColor != value)
                {
                    this.selectedColor = value;
                    CreateAlphaLinearBrush();
                    UpdateTextBoxes();
                    UpdateInk();
                }
            }
        }

        public Color InitialColor
        {
            set
            {
                SelectedColor = value;
                CreateAlphaLinearBrush();
                AlphaSlider.Value = value.A;
                UpdateCursorEllipse(value);
            }
        }

        private void AlphaSlider_MouseWheel(object sender, MouseWheelEventArgs e)
    {
      int change = e.Delta / Math.Abs(e.Delta);
      AlphaSlider.Value = AlphaSlider.Value + (double)change;
    }

    private void AlphaSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
      SelectedColor = Color.FromArgb((byte)AlphaSlider.Value, SelectedColor.R, SelectedColor.G, SelectedColor.B);
    }

    private void CanvasImage_MouseMove(object sender, MouseEventArgs e)
    {
      if (IsMouseDown) UpdateColor();
    }

    private void CanvasImage_MouseDown(object sender, MouseButtonEventArgs e)
    {
      IsMouseDown = true;
      UpdateColor();
    }

    private void CanvasImage_MouseUp(object sender, MouseButtonEventArgs e)
    {
      IsMouseDown = false;
      //UpdateColor();
    }

    private void Swatch_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      Image img = (sender as Image);
      ColorImage.Source = img.Source;
      UpdateCursorEllipse(SelectedColor);
    }

    private void CreateAlphaLinearBrush()
    {
      Color startColor = Color.FromArgb((byte)0, SelectedColor.R, SelectedColor.G, SelectedColor.B);
      Color endColor = Color.FromArgb((byte)255, SelectedColor.R, SelectedColor.G, SelectedColor.B);
      LinearGradientBrush alphaBrush = new LinearGradientBrush(startColor, endColor, new Point(0, 0), new Point(1, 0));
      AlphaBorder.Background = alphaBrush;
    }

    private void UpdateColor()
    {
      // Test to ensure we do not get bad mouse positions along the edges
      int imageX = (int)Mouse.GetPosition(canvasImage).X;
      int imageY = (int)Mouse.GetPosition(canvasImage).Y;
      if ((imageX < 0) || (imageY < 0) || (imageX > ColorImage.Width - 1) || (imageY > ColorImage.Height - 1)) return;
      // Get the single pixel under the mouse into a bitmap and copy it to a byte array
      CroppedBitmap cb = new CroppedBitmap(ColorImage.Source as BitmapSource, new Int32Rect(imageX, imageY, 1, 1));
      byte[] pixels = new byte[4];
      cb.CopyPixels(pixels, 4, 0);
      // Update the mouse cursor position and the Selected Color
      ellipsePixel.SetValue(Canvas.LeftProperty, (double)(Mouse.GetPosition(canvasImage).X - (ellipsePixel.Width / 2.0)));
      ellipsePixel.SetValue(Canvas.TopProperty, (double)(Mouse.GetPosition(canvasImage).Y - (ellipsePixel.Width / 2.0)));
      canvasImage.InvalidateVisual();
      // Set the Selected Color based on the cursor pixel and Alpha Slider value
      SelectedColor = Color.FromArgb((byte)AlphaSlider.Value, pixels[2], pixels[1], pixels[0]);
    }

    private void UpdateCursorEllipse(Color searchColor)
    {
      // Scan the canvas image for a color which matches the search color
      CroppedBitmap cb;
      Color tempColor = new Color();
      byte[] pixels = new byte[4];
      int searchY = 0;
      int searchX = 0;
      searchColor.A = 255;
      for (searchY = 0; searchY <= canvasImage.Width - 1; searchY++)
      {
        for (searchX = 0; searchX <= canvasImage.Height - 1; searchX++)
        {
          cb = new CroppedBitmap(ColorImage.Source as BitmapSource, new Int32Rect(searchX, searchY, 1, 1));
          cb.CopyPixels(pixels, 4, 0);
          tempColor = Color.FromArgb(255, pixels[2], pixels[1], pixels[0]);
          if (tempColor == searchColor) break;
        }
        if (tempColor == searchColor) break;
      }
      // Default to the top left if no match is found
      if (tempColor != searchColor)
      {
        searchX = 0;
        searchY = 0;
      }
      // Update the mouse cursor ellipse position
      ellipsePixel.SetValue(Canvas.LeftProperty, ((double)searchX - (ellipsePixel.Width / 2.0)));
      ellipsePixel.SetValue(Canvas.TopProperty, ((double)searchY - (ellipsePixel.Width / 2.0)));
    }

    private void UpdateTextBoxes()
    {
      txtAlpha.Text = SelectedColor.A.ToString();
      txtAlphaHex.Text = SelectedColor.A.ToString("X2");
      txtRed.Text = SelectedColor.R.ToString();
      txtRedHex.Text = SelectedColor.R.ToString("X2");
      txtGreen.Text = SelectedColor.G.ToString();
      txtGreenHex.Text = SelectedColor.G.ToString("X2");
      txtBlue.Text = SelectedColor.B.ToString();
      txtBlueHex.Text = SelectedColor.B.ToString("X2");
      txtAll.Text = String.Format("#{0}{1}{2}{3}", txtAlphaHex.Text, txtRedHex.Text, txtGreenHex.Text, txtBlueHex.Text);
    }

    private void UpdateInk()
    {
      drawingAttributes.Color = SelectedColor;
      drawingAttributes.StylusTip = StylusTip.Ellipse;
      drawingAttributes.Width = 5;
      // Update drawing attributes on previewPresenter
      foreach (Stroke s in previewPresenter.Strokes)
      {
        s.DrawingAttributes = drawingAttributes;
      }
    }

    }
}
