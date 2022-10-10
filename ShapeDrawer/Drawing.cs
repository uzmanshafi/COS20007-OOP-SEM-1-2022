using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }
        public Drawing() : this (Color.White)
        {

        }
        

        public List<Shape> SelectedShapes
        {
            get 
            {
                List<Shape> result = new List<Shape>();
                foreach (Shape s in _shapes)
                {
                    if (s.Selected)
                    {
                        result.Add(s);
                    }
                }
                return result;
            }
        }

        public int ShapeCount
        {
            get{ return _shapes.Count; }
        }

        public Color Background
        {
            get { return _background; }
            set { _background = value; }
        }

        public void Draw()
        {
            SplashKit.ClearScreen(Background);
            foreach (Shape shape in _shapes) 
            {
                shape.Draw();
            }
        }

        public void AddShape(Shape s)
        {
            _shapes.Add(s);
        }

        public void RemoveShape(List<Shape> s)
        {
            foreach (var shape in s)
            {
                _shapes.Remove(shape);
            }
        }


        public void SelectedShapesAt(Point2D pt)
         {
          
             foreach (Shape s in _shapes)
             {
                if (s.IsAt(pt))
                {
                    s.Selected = true;
                }
                else { s.Selected = false; }
                
            }
         }


    }
}
