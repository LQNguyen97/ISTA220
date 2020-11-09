using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    class Circle : DrawingShape, IDraw, IColor
    {
        private Ellipse circle = null;
        public Circle(int d) : base(d)
        {
            
        }
        public override void Draw(Canvas canvas)
        {
            if (shape != null)
            {
                canvas.Children.Remove(this.shape);
            }
            else
            {
                shape = new Ellipse();
            }

            base.Draw(canvas);
        }

    }
}
