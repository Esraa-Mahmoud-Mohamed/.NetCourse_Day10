namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D[] points ={
                new Point3D(10, 200, 30),
                new Point3D(10, 70, 100),
                new Point3D(45, 10, 30),
                new Point3D(9, 60, 30),
            };

            Array.Sort(points);

            for (int i = 0; i < points.Length; i++) 
            {
                Console.WriteLine(points[i].ToString());
            }


            Point3D p1 = new Point3D(10, 10, 10);
            Point3D p2 = new Point3D(20,20,20);
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(p2.ToString());
            p2 = (Point3D)p1.Clone();

            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(p2.ToString());

        }
    }
}