using System;
using SplashKitSDK;

namespace ShapeDrawer
{
	public class MyRectangle : Shape 
	{

        // Fields
        private int _width, _height;
        // Properties
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = Width;
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = Height;
            }
        }
        
        

        // Constructor 
        public MyRectangle(Color color, float x, float y, int width, int height): base(color)
		{
			X = x;
			Y = y;
			_width = width;
			_height = height;
        }
        
		public MyRectangle() : this(Color.Green, 0, 0, 100, 100) { } 
        // Methods
        public override void Draw()
        {
			if (Selected)
				DrawOutLine();
			SplashKit.FillRectangle(Color, X, Y, _width, _height);

			
        }
        public override void DrawOutLine()
        {
            SplashKit.DrawRectangle(Color.Black, X - 2, Y - 2, _width + 4, _height + 4);
        }
        public override bool IsAt(Point2D pt)
        {
            return pt.X >= X
                && pt.X <= X + _width
                && pt.Y >= Y
                && pt.Y <= Y + _height;
        }
    }
}

