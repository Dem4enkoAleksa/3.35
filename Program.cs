using System;
public class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты белой ладьи 1-8(вертикаль) ; 1-8(горизонталь)");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a >= 1 && a <= 8 && b >= 1 && b <= 8)
        {
            Console.WriteLine("Введите координаты черного слона 1-8(вертикаль) ; 1-8(горизонталь)");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            if (c >= 1 && c <= 8 && d >= 1 && d <= 8 && c != a || d != b)
            {
                Console.WriteLine("Введите координаты поля для хода ладьи 1-8(вертикаль),1-8(горизонталь)");
                int e = int.Parse(Console.ReadLine());
                int f = int.Parse(Console.ReadLine());
                if (e >= 1 && e <= 8 && f >= 1 && f <= 8 && e != a || f != b)
                {
                    if (((a == e) && (b != f)) || ((a != e) && (f == b)))
                    {
                        if (((c == e) || (d == f)))
                        {
                            Console.WriteLine("Ладья может пойти на эти координаты, не попадая под удар слона");

                        }
                        else
                        {
                            Console.WriteLine("Ладья может пойти на эти координаты и попасть под удар слона");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ладья не может так пойти");
                    }
                }
            }
        }
    }
}