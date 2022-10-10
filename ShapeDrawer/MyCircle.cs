using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class MyCircle : Shape
    {
        private int _radius;

        public MyCircle(Color color, int radius) : base(color)
        {
            _radius = radius;
        }

        public MyCircle() : this(Color.Blue, 50)
        {
            
        }

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public override void Draw()
        {
            if(Selected)
                DrawOutline();;
            SplashKit.FillCircle(color, X, Y, _radius);
        }

        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, X , Y, Radius + 2);
        }

        public override bool IsAt(Point2D pt)
        {
            Circle circle = SplashKit.CircleAt(X , Y, Radius);
            return SplashKit.PointInCircle(pt, circle);
        }

    }
}
