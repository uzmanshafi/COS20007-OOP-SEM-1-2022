﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class MyRectangle : Shape
    {
        private int _width;
        private int _height;

        public MyRectangle(Color color, int x, int y, int width, int height) : base(color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public MyRectangle() : this(Color.Green,0, 0, 100, 100)
        {
            
        }
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }


        public override void Draw()
        {
            if (Selected)
                DrawOutline();
            SplashKit.FillRectangle(color, X, Y, _width, _height);
        }

        public override void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black, X - 2, Y - 2, _width + 4, _height + 4);
        }

        public override bool IsAt(Point2D pt)
        {
            if ((pt.X > X) && (pt.X < (X + _width)))
            {
                if ((pt.Y > Y) && (pt.Y < (Y + _height)))
                {
                    return true;
                }
            }
            return false;
        }
    }

    
}
