using System;
using SplashKitSDK;
namespace ShapeDrawer
{
	public class MyCircle : Shape
	{
        // Property
        private int _radius;
        // Properties
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = Radius;
            }
        }


        // Constructor
        public MyCircle(Color color, float x, float y, int radius) : base(color)
        {
            _radius = radius;
            X = x;
            Y = y;

        }

        // Constructor passing the default value
        public MyCircle() : this(Color.LightBlue,0,0, 50) { }
        // Methods
        public override void Draw()
        {
			if (Selected)
				DrawOutLine();
			SplashKit.FillCircle(Color, X, Y, _radius);
        }

        public override void DrawOutLine()
        {
			SplashKit.DrawCircle(Color.Black, X, Y, _radius + 2);
        }

        public override bool IsAt(Point2D pt)
        {
            SplashKitSDK.Circle NewCircle = SplashKit.CircleAt(X, Y, _radius); // Create circle
            return SplashKit.PointInCircle(pt, NewCircle); // Check if Point is in the circle
        }
    }
}

