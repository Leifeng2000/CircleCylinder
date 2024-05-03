public class Point3D
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }

    public Point3D(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public Point3D()
    {
        X = 0.0f;
        Y = 0.0f;
        Z = 0.0f;
    }

    public float GetZ()
    {
        return Z;
    }

    public void SetZ(float z)
    {
        Z = z;
    }

    public void SetXYZ(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public float[] GetXYZ()
    {
        return new float[] { X, Y, Z };
    }

    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}