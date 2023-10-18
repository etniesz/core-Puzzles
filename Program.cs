//Matriz Aleatoria
static void RandomArray()
{
    int[] intArray = new int[10];
    Random rand = new Random();
    for (int i = 0; i < intArray.Length; i++)
    {
        intArray[i] = rand.Next(5, 26);
    }

    int max = intArray[0];
    int min = intArray[0];
    int sum = 0;
    for (int i = 0; i < intArray.Length; i++)
    {
        if (intArray[i] > max)
        {
            max = intArray[i];
        }
        else
        {
            min = intArray[i];
        }
        sum = sum + intArray[i];
    }
    Console.WriteLine($"Max value: {max} - Min value: {min} - Sum: {sum}");
}

// Lanzamiento de Moneda
// Se requiere:
// Crear una función llamada TossCoin() que devuelva una cadena. ​

// Que la función imprima "¡Tirando una moneda!".​
// Lanzar una moneda al azar con un resultado que señale cualquiera de las dos caras de la moneda. ​
// Haz que la función imprima "Cara" o "Cruz".​
// Por último, devuelve el resultado. ​

static string TossCoin()
{
    Console.WriteLine("¡Tirando una moneda!");
    Random rand = new Random();
    int result = rand.Next(0, 2);
    if (result == 0)
    {
        Console.WriteLine($"Resultado: Cara");
        return "Cara";
    }
    else
    {
        Console.WriteLine($"Resultado: Cruz");
        return "Cruz";
    }
}

// Opcional:
// Crea otra función llamada TossMultipleCoins(int num) que devuelva un Doble. ​

// Haz que la función llame a la función tossCoin varias veces en función del valor num.​
// Haz que la función devuelva un Doble que refleje la relación entre el lanzamiento de cabezas y el lanzamiento total.​

static void TossMultipleCoins(int num)
{
    int headsCounter = 0;
    for (int i = 0; i < num; i++)
    {
        if (TossCoin() == "Cara")
        {
            headsCounter++;
        }
    }
    double ratio = (double)headsCounter / num;
    Console.WriteLine(ratio);
}

// Nombres
// Construye una función Nombres que devuelva una lista de cadenas. En esta función:​

// Se requiere:
// Crea una lista con los valores Todd, Tiffany, Charlie, Ginebra, Sydney. ​
// Devuelve una lista que solo incluya nombres de más de 5 caracteres. ​
static List<string> Names()
{
    List<string> names = new List<string> { "Todd", "Tiffany", "Charlie", "Ginebra", "Sydney" };
    List<string> filteredNames = new List<string>();

    foreach (string name in names)
    {
        if (name.Length > 5)
        {
            filteredNames.Add(name);
        }
    }

    return filteredNames;
}

RandomArray();
TossCoin();
TossMultipleCoins(10);
Names();