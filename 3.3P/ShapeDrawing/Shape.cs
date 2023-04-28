using SplashKitSDK;

namespace ShapeDrawer
{
    public class Shape
    {
        // Fields

        private Color _color;
        private float _x, _y;
        private int _width, _height;
        private bool _selected;

        // Properties

        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
            }
        }

        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        // Constructor
        public Shape()
        {
            _color = Color.Green;
            //location
            _x = 0;
            _y = 0;
            //size
            _width = 100;
            _height = 100;
            _selected = false;
        }

        // Methods

        public void Draw()
        {
            SplashKit.FillRectangle(_color, _x, _y,_width, _height);
            if (_selected)
            {
                DrawOutline();
            }

        }

        public void DrawOutline()
        {
            SplashKit.DrawRectangle(Color.Black, _x - 2, _y - 2,_width + 4, _height + 4);
        }

        public bool IsAt(Point2D pt)
        {
            return pt.X >= _x
                && pt.X <= _x + _width
                && pt.Y >= _y
                && pt.Y <= _y + _height;
        }
    }

}