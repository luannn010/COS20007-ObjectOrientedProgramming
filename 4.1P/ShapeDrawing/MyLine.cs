using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class MyLine : Shape
    {
        //Fields
        private float _endX, _endY;

        //Properties
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

        //Constructor
        public MyLine(Color color, float startX, float startY, float endX, float endY) : base(color)
        {
            X = startX;
            Y = startY;
            EndX = endX;
            EndY = endY;
        }

        public MyLine() : this(Color.Red, 0, 0, 100, 0) { }

        //Methods
        public override bool IsAt(Point2D pt)
        {
            return (pt.X <= X + EndX
                    && X <= pt.X
                    && pt.Y <= Y + EndY
                    && Y <= pt.Y);
        }

        public override void Draw()
        {
            if (Selected)
                DrawOutLine();
            SplashKit.DrawLine(Color, X, Y,  EndX, EndY);
        }

        public override void DrawOutLine()
        {
            SplashKit.FillCircle(Color.Black, X, Y, 2);
            SplashKit.FillCircle(Color.Black,  EndX, EndY, 2);
        }
    }
}
