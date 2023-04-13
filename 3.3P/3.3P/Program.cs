using System;
using SplashKitSDK;
namespace ShapeDrawer;
public class Program
{
    public static void Main()
    {
        //Create new Shape
        Shape myShape = new Shape();
        //Drawing
        Drawing mydrawing = new Drawing();
        //Create a Window
        Window window = new Window("ShapeDrawer", 800, 600);
        do
        {
            //Clear screen
            SplashKit.ProcessEvents();
            SplashKit.ClearScreen();
            //Function

            //Add new a shape if left click

            if (SplashKit.MouseClicked(MouseButton.LeftButton)==true)
            {
                mydrawing.SelectShapeAt(SplashKit.MousePosition());
            }
            if (SplashKit.MouseClicked(MouseButton.LeftButton)==true)
            {
                //Get coordinator for drawing

                myShape.X = SplashKit.MouseX();
                myShape.Y = SplashKit.MouseY();
                //Draw at the Click
                mydrawing.AddShape(myShape);

            }
            if (SplashKit.KeyTyped(KeyCode.SpaceKey))
            {
                mydrawing.Background= SplashKit.RandomRGBColor(255);

            }
            //Remove selected Shapes
            if ((SplashKit.KeyTyped(KeyCode.DeleteKey)) || (SplashKit.KeyTyped(KeyCode.BackspaceKey)))
            {
                foreach (var s in mydrawing.SelectedShapes)
                {
                    mydrawing.RemoveShape(s);
                }
            }


            SplashKit.ClearScreen(mydrawing.Background);
            mydrawing.Draw();




            SplashKit.RefreshScreen();
        } while (!window.CloseRequested);

        Console.ReadLine();


    }


}
