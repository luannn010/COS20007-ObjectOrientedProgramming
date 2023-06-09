﻿using SplashKitSDK;

namespace ShapeDrawer;




public class Shape
{
    //fields
    private Color _color;
    private float _x, _y;
    private int _width, _height;


    //Shape function
    public Shape()
    {
        this._color = Color.Green;
        //location
        this._x = 0;
        this._y = 0;
        //size
        this._width = 100;
        this._height = 100;
    }
    //Property Y
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
    //Property X
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
    //Property Y
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
    //Draw function
    public void Draw()
    {
        SplashKit.FillRectangle(_color, _x, _y,
                                _width, _height);
                                    
    }
    //IsAt
    public bool IsAt(Point2D pt)
    {
        return pt.X >= this._x
            && pt.X <= this._x + this._width
            && pt.Y >= this._y
            && pt.Y <= this._y + this._height;
    }
}

    




