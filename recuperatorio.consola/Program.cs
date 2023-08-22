using System.ComponentModel.Design;

namespace recuperatorio.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double B,altura,L;
            double diagonal, volumen, area;
            double AB, AL;
            

            Console.WriteLine($"ingrese los valores del prisma triangular rectangular");
            AB = 2 * (B * altura / 2);
            AL = 3 * (L * altura);

            Console.WriteLine($"El valor del area base es:", AB;
            Console.WriteLine($"El valor de area lateral es:", AL;
            if ( AB > 0 )
                {
                area = AB + AL;
                volumen = AB + altura;
                diagonal= Math.Sqrt(  B);
                Console.WriteLine($"el area del prisma es: ");
                Console.WriteLine($"el volumen del prisma es: ");
                Console.WriteLine($"la diagonal del prisma es: ");
           

            }
            else
            {
                Console.WriteLine($"valor ingresado no valido");
            }
        }
        