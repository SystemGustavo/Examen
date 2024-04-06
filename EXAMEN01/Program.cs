
string Funcion1(int numero)
{
    string resultado = string.Empty;
    if (numero > 0)
    {
        resultado = "El Numero es Positivo";
    }else if (numero < 0) 
    {
        resultado = "El Numero es Negativo";
    }
    else if (numero == 0)
    {
        resultado = "El Numero es Cero";
    }
    else
    {
        resultado = string.Empty;
    }

    return resultado;
}
void Procedimiento2(int dia)
{
    string resultado = string.Empty;
    switch (dia)
    {
        case 1:
            resultado = "Lunes";
            break;

        case 2:
            resultado = "Martes";
            break;

        case 3:
            resultado = "Miercoles";
            break;

        case 4:
            resultado = "Jueves";
            break;

        case 5:
            resultado = "Viernes";
            break;

        case 6:
            resultado = "Sabado";
            break;
        case 7:
            resultado = "Domingo";
            break;
        default:
            resultado = "Dia Invalido";
            break;
    }
    Console.WriteLine("Dia => "+resultado);
}
int Funcion3()
{
    int suma = 0;
    for (int i = 0; i <= 100; i++)
    {
        suma += i;
    }
    return suma;
}
void Procedimiento4(int numero)
{
    string resultado = string.Empty;
    for (int i = 0; i <= numero; i++)
    {
        resultado += i.ToString()+" ";
    }
    Console.WriteLine(resultado);
}
double Funcion5(double radio) 
{   
    double area = Math.PI * Math.Pow(radio, 2);
    return area;
}
void Procedimiento6()
{
    string resultado = string.Empty;
    string[] frutas = { "Papaya", "Mandarina", "Naranja", "Manzana", "Platano" };
    for (int i = 0; i < frutas.Length; i++)
    {
        resultado += frutas[i].ToString() + " ";
    }
    Console.WriteLine("Frutas => "+resultado);
}
void Procedimiento7()
{
    string resultado=string.Empty;
    List<string> personas = new List<string>() { "Cesar","Adrian","Roberto","Carlos","Maria","Rosa"};
    foreach (string item in personas)
    {
        resultado += item.ToString() + " ";
    }
    Console.WriteLine("Nombres => "+ resultado );
}



string entrada;
bool numeroValido = false;
int opcion;
do
{
    Console.WriteLine("Seleccione una opcion");
    Console.WriteLine("1. Determinar si un número ingresado por el usuario es positivo, negativo o cero");
    Console.WriteLine("2. Imprimir un mensaje según el día de la semana ingresado por el usuario");
    Console.WriteLine("3. Calcular la suma de los primeros 100 números naturales");
    Console.WriteLine("4. Imprimir todos los números desde 1 hasta el número ingresado por el usuario.");
    Console.WriteLine("5. Calcular el área de un círculo utilizando el radio ingresado por el usuario.");
    Console.WriteLine("6. Mostrar los elementos de un arreglo unidimensional predefinido.");
    Console.WriteLine("7. Mostrar nombres de personas almacenados en una lista predefinida. ");
    Console.WriteLine("8. Salir");
    Console.WriteLine("");
    Console.Write("Inserte la opcion => ");
    entrada = Console.ReadLine();
    numeroValido = int.TryParse(entrada, out opcion);
    if (numeroValido)
    {
        opcion = Convert.ToInt32(entrada);
        switch (opcion)
        {
            case 1:
                Console.WriteLine("************* Llamando a la Funcion(1) ******************");
                Console.Write("Inserte un Numero => ");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Funcion1(numero));
                Console.Write("-------------------------------------------------------------------------------------\n");
                break;
            case 2:
                Console.WriteLine("************* Llamando al Procedimiento(2) ******************");
                Console.Write("Seleccione el numero del dia => ");
                int dia = Convert.ToInt32(Console.ReadLine());
                Procedimiento2(dia);
                Console.Write("-------------------------------------------------------------------------------------\n");
                break;
            case 3:
                Console.WriteLine("************ Llamando a la Funcion (3) ******************");
                Console.Write("Suma de los 100 primeros numeros naturales es => ");
                Console.Write(Funcion3());
                Console.Write("-----------------------------------------------------------------------------\n");
                break;
            case 4:
                Console.WriteLine("****************** Llamando al Procedimiento(4) ******************");
                Procedimiento4(12);
                Console.Write("-------------------------------------------------------------------------------------\n");
                break;
            case 5:
                Console.WriteLine("****************** Llamando a la Funcion(5) ******************");
                Console.Write("Ingrese el radio => ");
                double radio = Convert.ToDouble(Console.ReadLine());
                Console.Write("Area del Circulo es => "+ Funcion5(radio));
                Console.Write("-------------------------------------------------------------------------------------\n");
                break;
            case 6:
                Console.WriteLine("****************** Llamando al Procedimiento(6) ******************");
                Console.WriteLine("Elementos del arreglo Unidimensional Predefinido");
                Procedimiento6();
                Console.Write("-------------------------------------------------------------------------------------\n");
                break;
            case 7:
                Console.WriteLine("****************** Llamando al Procedimiento(7) ******************");
                Console.WriteLine("Elementos de la lista Predefinida");
                Procedimiento7();
                Console.Write("-------------------------------------------------------------------------------------\n");
                break;
            case 8:
                Environment.Exit(0);
                break;
        }
        numeroValido = false;
    }
    else
    {
        Console.WriteLine("Opcion Invalida");
        Console.Write("-------------------------------------------------------------------------------------\n");
    }
}
while (!numeroValido);

