using System;
using System.Collections.Generic;

///<summary>class Shape</summary>
class Shape
{
    ///<summary>Throws an NotImplementedException</summary>
    public virtual int Area()
    {
       throw new NotImplementedException("Area() is not implemented");
    }
}
///<summary>Class Rectangle</summary>
class Rectangle : Shape
{
    private int width;
    private int height;
    ///<summary>with set and get</summary>
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }
    
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }
    ///<summary>new area</summary>
    public new int Area()
    {
        return height * width;
    }
    public override string ToString()
    {
        return String.Format ("[Rectangle] {0} / {1}",  width, height);
    }
}
