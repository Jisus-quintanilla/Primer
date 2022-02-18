Console.WriteLine("Ejercico 1\n");
byte edad;
byte resultado;

Console.WriteLine("Ingrese su edad");
 edad = Convert.ToByte(Console.ReadLine());

if (edad > 19)
{
    Console.WriteLine("Usted tiene:  " + edad+" años" + " \nUsted no aparenta ser una persona mayor a 20 años");
}
else
{
    Console.WriteLine("Joven su edad es:  "+edad + " años");
}
Console.ReadLine();

Console.WriteLine("\nEjercico 2\n");
Console.WriteLine("Ingrese 2 números de 2 sifras\n");

byte n1, n2;
Int32 mutiplicación1;

 n1 = Convert.ToByte(Console.ReadLine());
 n2 = Convert.ToByte(Console.ReadLine());

  mutiplicación1 = Convert.ToInt16(n1) * Convert.ToInt16(n2);

Console.WriteLine("Su multiplicación es:  "+mutiplicación1);
Console.ReadLine();

Console.WriteLine("\nEjercico 3\n");
Console.WriteLine("Escriba 2 número enteros largos\n");
Int64 N1, N2,multi,suma,resta;

 N1 = Convert.ToInt64(Console.ReadLine());
 N2 = Convert.ToInt64(Console.ReadLine());

multi = Convert.ToInt64(N1) * Convert.ToInt64(N2);
suma = Convert.ToInt64(N1) + Convert.ToInt64(N2);
resta = Convert.ToInt64(N1) - Convert.ToInt64(N2);

Console.WriteLine("\nLa suma de los numeros ingresados es:"+suma);
Console.WriteLine("La resta de los numeros ingresados es:" + resta);
Console.WriteLine("La multiplicación de los numeros ingresados es:" + multi);

Console.ReadLine();