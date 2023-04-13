using System;
using SplashKitSDK;
using System.Collections.Generic;
namespace ShapeDrawer;

public class Drawing
	{
    // Fields
    
    private readonly List<Shape> _shapes;
    private Color _background;
    // Create Drawing Constructor take background as parameter
    public Drawing(Color background)
		{
		_shapes = new List<Shape>();
		_background = background;

	}
	// Shape Color
	public Drawing() : this (Color.LightGreen)
	{
	}
	//Selected Shapes read only property
    public List<Shape> SelectedShapes
	{
		get
		{
			var result = new List<Shape>();
			foreach (Shape s in _shapes)
			{
				if (s.Selected == true)
					result.Add(s);
			}
			return result;

		}
	}
    // Background property
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

    // ShapeCount readonlyproperty
    public int ShapeCount
    {
        get
        {
            return _shapes.Count;
        }
    }

	//Add Shape
	public void AddShape(Shape s)
	{
		_shapes.Add(s);
	}
	//Remove Shape
	public void RemoveShape(Shape s)
	{
		_shapes.Remove(s);
	}
	//Draw method
	public void Draw()
	{
		foreach (var s in _shapes) 
		{
			s.Draw();
		}
	}
	//Select Shape at

	public void SelectShapeAt(Point2D pt)
	{
		foreach (var s in _shapes)
		{
			if (s.IsAt(pt))
				s.Selected = true;
			else
				s.Selected = false;
		}
	}


}


