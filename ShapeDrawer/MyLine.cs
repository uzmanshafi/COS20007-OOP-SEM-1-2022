using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class MyLine : Shape
    {
        private float _endX, _endY;

        public MyLine(Color color, int x, int y, float endX, float endY) : base(color)
        {
            X = x;
            Y = y;
            _endX = endX;
            _endY = endY;
        }

        public MyLine() : this (Color.Red, 0,0, 100 , 100)
        {
            
        }

        public float EndX
        { 
            get 
            { 
                return _endX; 
            } 
            set 
            { 
                _endX = value; 
            } 
        }

        public float EndY 
        { 
            get 
            { 
                return _endY; 
            } 
            set 
            { 
                _endY = value; 
            } 
        }

        public override void Draw()
        {
            if (Selected)
                DrawOutline();
            SplashKit.DrawLine(color, X , Y, (EndX + X), Y);
        }

        public override void DrawOutline()
        {
            SplashKit.DrawCircle(Color.Black, X , Y, 5);
            SplashKit.DrawCircle(Color.Black, X + EndX, Y, 5);
        }

        public override bool IsAt(Point2D pt)
        {

            Line line = SplashKit.LineFrom(X , Y, EndX, EndY);
            return SplashKit.PointOnLine(pt, line);
        }
    }
}
