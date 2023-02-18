// Lab 01 - BT02 - Giải pt bậc 1: ax + b = 0
Console.WriteLine("Giai phuong trinh bac 1!");
try
{
    Console.Write("He so a: ");
    int heSoA = int.Parse(Console.ReadLine());
    Console.Write("He so b: ");
    int heSoB = int.Parse(Console.ReadLine());

    Console.WriteLine($"PT {heSoA}*x + {heSoB} = 0");
    if (heSoA == 0)
    {
        if (heSoB == 0)
        {
            Console.WriteLine("Phuong trinh co vo so nghiem");
        }
        else
        {
            Console.WriteLine("PT vo nghiem");
        }
    }
    else
    {
        double nghiem = -heSoB / heSoA;
        Console.WriteLine($"PT co nghiem: x={nghiem}");
    }
}
catch(Exception ex)
{
    Console.WriteLine("Lỗi: " + ex.Message);
}