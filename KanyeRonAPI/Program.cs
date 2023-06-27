// See https://aka.ms/new-console-template for more information
namespace KanyeRonAPI 
{ 
public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Did you hear about the wild conversation between Kayne and Ron? I didn't hear what Ron said first, but ");
        for (int i = 0; i < 5; i++)
        {
                KanyeVSRon.Kanye();
                KanyeVSRon.Ron();
        }
    }
}
}
