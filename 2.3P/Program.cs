using System;
using SplashKitSDK;
namespace ShapeDrawer;
public class Program
{
    public static void Main()
    {
        //Create new Shape
        Shape myShape = new Shape();
        //Create a Window
        Window window = new Window("ShapeDrawer", 800, 600);
        do
        {

            SplashKit.ProcessEvents();
            SplashKit.ClearScreen();

        // Move Shape when Left click
          if (SplashKit.MouseClicked(MouseButton.LeftButton))
            {
                myShape.X = SplashKit.MouseX();
                myShape.Y = SplashKit.MouseY();
            }
          //Change Shape color when hit Spacebar and the Mouse is in the shape 
          if (SplashKit.KeyTyped(KeyCode.SpaceKey) && myShape.IsAt(SplashKit.MousePosition()))
            {
                myShape.Color = SplashKit.RandomRGBColor(255);
            }
          //Draw
            myShape.Draw();

            SplashKit.RefreshScreen();
        } while (!window.CloseRequested);

        Console.ReadLine();

        
    }
    
}
