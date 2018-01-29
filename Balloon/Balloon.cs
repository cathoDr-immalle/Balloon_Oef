using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Balloon_Oef
{
    class Balloon
    {
        private int x = 10;
        private int y = 10;
        private int Diameter = 10;
        private Ellipse ellipse;
        
        public Balloon()
        {
            CreateEllipse();
            UpdateEllipse();
        }

        private void CreateEllipse()
        {
            ellipse = new Ellipse();
            ellipse.Stroke = Brushes.Black;
            ellipse.StrokeThickness = 2;
        }

        public void MoveRight(int xStep)
        {
            x = x + xStep;
            UpdateEllipse();
        }

        public void MoveUp(int yStep)
        {
            y = y - yStep;
            UpdateEllipse();
        }

        public void MoveDown(int yStep)
        {
            y = y + yStep;
            UpdateEllipse();
        }

        public void ChangeSize(int Change)
        {
            Diameter = Diameter + Change;
            UpdateEllipse();
        }

        public void ChangeColor(Brush brush)
        {
            ellipse.Fill = brush;
            ellipse.Stroke = brush;
        }

        private void UpdateEllipse()
        {
            Random rnd = new Random();
            int k;
            int l;
            int m;
            int n;

            byte a = Convert.ToByte(k = rnd.Next(0, 255));
            byte r = Convert.ToByte(l = rnd.Next(0, 255));
            byte g = Convert.ToByte(m = rnd.Next(0, 255));
            byte b = Convert.ToByte(n = rnd.Next(0, 255));

            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Width = Diameter;
            ellipse.Height = Diameter;

            ellipse.Fill = new SolidColorBrush(Color.FromArgb(a, r, g, b));
            ellipse.Stroke = new SolidColorBrush(Color.FromArgb(a,r,g,b));
        }

        public void DisplayOn(Canvas DrawingCavnas)
        {
            DrawingCavnas.Children.Add(ellipse);
        }
    }
}
