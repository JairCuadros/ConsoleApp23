Console.WriteLine("Ingrese el número máximo de personas");
int numPersonas=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("======================================");
Console.WriteLine("El número máximo establecido es de: " + numPersonas);
Console.WriteLine("presione cualquier tecla para continuar");
string tecla=Console.ReadLine();
Console.Clear();
int asistActuales = 0;
decimal porcentaje = 0;
bool opcion = true;
while (opcion)
{
    Console.Clear();
    Console.WriteLine("======================================");
    Console.WriteLine($"|Asistentes actuales |{asistActuales}");
    Console.WriteLine($"|Aforo               |{porcentaje}" + "%");
    Console.WriteLine($"|Máximo              |{numPersonas}");
    Console.WriteLine("======================================");
    Console.WriteLine("Presione");
    Console.WriteLine("[i] si ingresa una persona");
    Console.WriteLine("[s] si sale una persona");
    Console.WriteLine("[x] para terminar");
    char opcion2 = Convert.ToChar(Console.ReadLine());
    switch (opcion2)
    {
        case 'i':
                    asistActuales += 1;
            porcentaje = asistActuales * 100 / numPersonas;
            break;
        case 's':
            asistActuales -= 1;
            porcentaje = asistActuales * 100 / numPersonas;
            break;
        case 'x':
            Console.WriteLine("¿Desea terminar con el registro?");
            Console.WriteLine("s/n");
            char sn=Convert.ToChar(Console.ReadLine());
            if (sn=='s')
            {
                Console.Clear();
                opcion = false;
                Console.WriteLine("======================================");
                Console.WriteLine("El programa ha terminado");
                Console.WriteLine("======================================");
                Console.WriteLine("Estadísticas:");
                Console.WriteLine("-----------------------");
                Console.WriteLine("No me alcanzó tiempo para hacer el último punto :c");
            }
            break;
    }
}
