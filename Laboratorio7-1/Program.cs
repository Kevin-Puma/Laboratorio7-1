Console.Write("Ingrese el valor de n: ");
float n = Convert.ToSingle(Console.ReadLine());
float suma = 0;

for (float i = 1; i <= n; i++)
{
    float termino = ((16 - i) / (3 * i)); // Calcula cada término de la secuencia
    suma += termino;
    Console.WriteLine("Resultado : " + termino + "");
}
Console.WriteLine("La suma es : " + suma + "");
