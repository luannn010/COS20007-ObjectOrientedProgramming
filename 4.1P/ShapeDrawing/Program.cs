using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        private enum ShapeKind 
        {
            Rectangle,
            Circle,
            Line
        }

        public static void Main()
        {
            Drawing mydrawing = new Drawing();
            ShapeKind kindToAdd = ShapeKind.Circle;
            Window window = new Window("ShapeDrawer", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle;
                }
                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle;
                }
                if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line;
                }
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape;
                    if (kindToAdd == ShapeKind.Circle)
                    {
                        newShape = new MyCircle();
                    }
                    else if (kindToAdd == ShapeKind.Rectangle)
                    {
                        newShape = new MyRectangle();
                    }
                    else
                    {
                        newShape = new MyLine();
                    }
                    newShape.X = SplashKit.MouseX();
                    newShape.Y = SplashKit.MouseY();
                    //newShape.Color = SplashKit.RandomRGBColor(255);

                    mydrawing.AddShape(newShape);
                }
                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    mydrawing.SelectShapeAt(SplashKit.MousePosition());
                }
                // Change Selected Shape color(optional)
                //if (mydrawing.SelectedShapes.Count > 0 && SplashKit.KeyTyped(KeyCode.BKey))
                //{
                    
                //    foreach (Shape s in mydrawing.SelectedShapes)
                //    {
                //        s.Color = SplashKit.RandomRGBColor(255);
                //    }
                //}
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    mydrawing.Background = SplashKit.RandomRGBColor(255);
                }
                if (SplashKit.KeyTyped(KeyCode.DeleteKey) || SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    foreach (Shape s in mydrawing.SelectedShapes)
                    {
                        mydrawing.RemoveShape(s);
                    }
                }
                SplashKit.ClearScreen(mydrawing.Background);                
                mydrawing.Draw();
                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);

           
        }
    }
}
