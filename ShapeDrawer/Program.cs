using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle, Circle, Line
        }

        public static void Main()
        {
            
            new Window("Shape Drawer", 800, 600);

            Drawing drawing = new Drawing();
            ShapeKind kindtoAdd = ShapeKind.Circle;

            do 
            {
                //MyRectangle newRect = new MyRectangle(); //rectangle
                SplashKit.ProcessEvents();

                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    kindtoAdd = ShapeKind.Rectangle;
                }

                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    kindtoAdd = ShapeKind.Circle;
                }

                if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    kindtoAdd = ShapeKind.Line;
                }

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape;

                    if (kindtoAdd == ShapeKind.Circle)
                    {
                        newShape = new MyCircle();
                        //to avoid duplication in creating new shapes
                        newShape.X = SplashKit.MouseX();
                        newShape.Y = SplashKit.MouseY();
                        drawing.AddShape(newShape);
                    }

                    if (kindtoAdd == ShapeKind.Rectangle)
                    {
                        newShape = new MyRectangle();
                        //to avoid duplication in creating new shapes
                        newShape.X = SplashKit.MouseX() - 50;
                        newShape.Y = SplashKit.MouseY() - 50;
                        drawing.AddShape(newShape);
                    }

                    if (kindtoAdd == ShapeKind.Line)
                    {
                        newShape = new MyLine();
                        //to avoid duplication in creating new shapes
                        newShape.X = SplashKit.MouseX();
                        newShape.Y = SplashKit.MouseY();
                        drawing.AddShape(newShape);
                    }
      
                }

                if (SplashKit.KeyDown(KeyCode.SpaceKey))
                {
                    drawing.Background = SplashKit.RandomRGBColor(255);
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    drawing.SelectedShapesAt(SplashKit.MousePosition());
                }

                if (SplashKit.KeyTyped(KeyCode.BackspaceKey) || SplashKit.KeyTyped(KeyCode.DeleteKey))
                {
                    drawing.SelectedShapesAt(SplashKit.MousePosition());
                    drawing.RemoveShape(drawing.SelectedShapes);
                }

                SplashKit.ClearScreen();
                drawing.Draw();
                SplashKit.RefreshScreen();

            } while (!SplashKit.WindowCloseRequested("Shape Drawer"));

            
            
        }
    }
}
