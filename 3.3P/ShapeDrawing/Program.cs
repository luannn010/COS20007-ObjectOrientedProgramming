using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        // Main
        public static void Main()
        {

            Drawing mydrawing = new Drawing();
            Window window = new Window("ShapeDrawer", 800, 600);

            do
            {
                
                SplashKit.ProcessEvents();

                // New Shape with Left Click
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape myShape = new Shape();
                    myShape.X = SplashKit.MouseX();
                    myShape.Y = SplashKit.MouseY();
                    mydrawing.AddShape(myShape);
                }

                // Select Shapes with RightClick
                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    mydrawing.SelectShapeAt(SplashKit.MousePosition());
                }

                // Change Shapes Color with C Key
                if (mydrawing.SelectedShapes.Count > 0 && SplashKit.KeyTyped(KeyCode.CKey))
                {
                    
                    foreach (Shape s in mydrawing.SelectedShapes)
                    {
                        s.Color = SplashKit.RandomRGBColor(255);
                    }
                }

                // Change background color with SpaceKey
                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    mydrawing.Background = SplashKit.RandomRGBColor(255);
                }

                // Remove selected Shapes with DeleteKey or BackspaceKey
                if (SplashKit.KeyTyped(KeyCode.DeleteKey) || SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    foreach (Shape s in mydrawing.SelectedShapes)
                    {
                        mydrawing.RemoveShape(s);
                    }
                }
                
               
                
                mydrawing.Draw();

                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
            
        }
    }
}
