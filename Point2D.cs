public class Point2D
{
    public float X { get; set; }
    public float Y { get; set; }

    public Point2D(float x, float y)
    {
        X = x;
        Y = y;
    }

    public Point2D()
    {
        X = 0.0f;
        Y = 0.0f;
    }

    public float GetX()
    {
        return X;
    }

    public void SetX(float x)
    {
        X = x;
    }

    public float GetY()
    {
        return Y;
    }

    public void SetY(float y)
    {
        Y = y;
    }

    public void SetXY(float x, float y)
    {
        X = x;
        Y = y;
    }

    public float[] GetXY()
    {
        return new float[] { X, Y };
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}