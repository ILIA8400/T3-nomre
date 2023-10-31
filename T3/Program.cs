// ایلیا اصغرحری
//تمرین سوم



string yn;
do
{
    Console.WriteLine("nomre riazi?");
    double n = Convert.ToDouble(Console.ReadLine());
    n *= 1;

    Console.WriteLine("nomre fizik?");
    double x = Convert.ToDouble(Console.ReadLine());
    x *= 3;

    Console.WriteLine("nomre tafsir?");
    double y = Convert.ToDouble(Console.ReadLine());
    y *= 2;

    Console.WriteLine("nomre zaban?");
    double g = Convert.ToDouble(Console.ReadLine());
    g *= 5;

    Console.WriteLine("nomre karrahe shoghli?");
    double k = Convert.ToDouble(Console.ReadLine());
    k *= 1;

    Console.WriteLine("nomre varzesh?");
    double b = Convert.ToDouble(Console.ReadLine());
    b *= 4;

    Console.WriteLine("nomre barname sazi?");
    double a = Convert.ToDouble(Console.ReadLine());
    a *= 10;

    Console.WriteLine("nomre tarikh?");
    double h = Convert.ToDouble(Console.ReadLine());
    h *= 3;

    Console.WriteLine("nomre farsi?");
    double v = Convert.ToDouble(Console.ReadLine());
    v *= 6;

    Console.WriteLine("nomre enzebat?");
    double m = Convert.ToDouble(Console.ReadLine());
    m *= 1;


    double moadel = (x + y + g + k + b + a + h + v + m + n) / 36;

    Console.WriteLine("moadel shoma:" + moadel);
    if (moadel < 10)
    {
        Console.WriteLine("shoma ridid");
    }
    else
    {
        Console.WriteLine("shoma pass shodid");
    }




    Console.WriteLine("mikhay edame bedi? y/n");
    yn = Console.ReadLine();

}
while (yn == "y");

