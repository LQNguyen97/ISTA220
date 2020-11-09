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
    class Square : DrawingShape, IDraw, IColor
    {
        private Rectangle rect = null;
        public Square(int sl) : base(sl)
        {
            
        }
        public override void Draw(Canvas canvas)
        {
            if (shape != null)
            {
                canvas.Children.Remove(shape);
            }
            else
            {
                shape = new Rectangle();
            }
            base.Draw(canvas);
        }
    }
}
