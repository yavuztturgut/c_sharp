using System;
public class hesaplayici
{
    public double kilo { get; set; }
    public double boy { get; set; }
    public double endeks { get; set; }

    public static void islem() {
    hesaplayici user = new hesaplayici();
        Console.WriteLine("kilonuzu giriniz ");
        user.kilo = double.Parse(Console.ReadLine());
        Console.WriteLine("boyunuzu giriniz (cm cinsinden 185 gibi) ");
        user.boy = double.Parse(Console.ReadLine());
        user.endeks = user.kilo / ((user.boy/100)* (user.boy / 100));
        Console.WriteLine("vücut kitle endeksiniz: " + user.endeks.ToString("##.##"));
        if (user.endeks > 30)
        {
            Console.WriteLine("obezsiniz.");
        }
        else if (user.endeks < 30 && user.endeks > 25){
            Console.WriteLine("fazla kilolusunuz.");
        }
        else if (user.endeks <= 25 && user.endeks >= 18.5)
        {
            Console.WriteLine("ideal kilodasınız!");
        }
        else if (user.endeks < 18.5)
        {
            Console.WriteLine("çok zayıfsınız.");
        }
    }
    public static void Main(string[] args)
    {
        islem();
    }
}
