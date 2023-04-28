using System;
using SplashKitSDK;
using System.Collections.Generic;
namespace ShapeDrawer
{
    public class Drawing
    {
        // Fields

        private readonly List<Shape> _shapes;
        private Color _background;

        //Properties

        public int ShapeCount
        {
            get
            {
                return _shapes.Count;
            }
        }

        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> result = new List<Shape>();
                foreach (Shape s in _shapes)
                {
                    if (s.Selected)
                        result.Add(s);
                }
                return result;

            }
        }

        public Color Background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }


        // Constructor

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;

        }

        public Drawing() : this(Color.White) { }

        // Method

        public void AddShape(Shape s)
        {
            _shapes.Add(s);
        }

        public void RemoveShape(Shape s)
        {
            _shapes.Remove(s);
        }

        public void Draw()
        {
            SplashKit.ClearScreen(Background);
            foreach (Shape s in _shapes)
            {

                s.Draw();
            }
        }


        public void SelectShapeAt(Point2D pt)
        {
            foreach (Shape s in _shapes)
            {
                if (s.IsAt(pt))
                    s.Selected = true;
                else
                    s.Selected = false;
            }
        }





    }


}