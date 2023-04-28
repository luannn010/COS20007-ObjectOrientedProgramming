using System;
using SplashKitSDK;

namespace ShapeDrawer;
public abstract class Shape
{
    // Fields
    private Color _color;
    private float _x, _y;
    private bool _selected;
    // Properties
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
    public Shape(Color color)
    {
        _color = color;
    }
    // Constructor with default color
    public Shape() : this(Color.Yellow) { }//Default Shape color
    // Method
    public abstract void Draw();
    public abstract bool IsAt(Point2D pt);
    public abstract void DrawOutLine();
    


}






