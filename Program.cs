class Program
{
    static void Main()
    {
        Point2D point = new Point2D(3.5f, 2.8f);
        Console.WriteLine(point.ToString());

        point.SetX(1.2f);
        point.SetY(5.7f);
        Console.WriteLine(point.ToString());

        float[] coordinates = point.GetXY();
        Console.WriteLine($"X: {coordinates[0]}, Y: {coordinates[1]}");

        /*Point3D point = new Point3D(1.5f, 2.5f, 3.5f);
        Console.WriteLine(point.ToString());

        point.SetXYZ(4.2f, 6.7f, 8.9f);
        Console.WriteLine(point.ToString());

        float[] coordinates = point.GetXYZ();
        Console.WriteLine($"X: {coordinates[0]}, Y: {coordinates[1]}, Z: {coordinates[2]}");*/
    }
}