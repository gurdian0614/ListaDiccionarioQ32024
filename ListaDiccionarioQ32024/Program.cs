using System.ComponentModel;

int opcion = 0;

while (opcion != 3)
{
    try
    {
        Console.WriteLine("*************************");
        Console.WriteLine("*          MENU         *");
        Console.WriteLine("* 1. Listas             *");
        Console.WriteLine("* 2. Diccionarios       *");
        Console.WriteLine("* 3. Salir              *");
        Console.WriteLine("*************************");
        Console.WriteLine("Escoja la opción:");
        opcion = Convert.ToInt32((Console.ReadLine()));

        switch (opcion)
        {
            case 1:
                List<string> list = new List<string>()
            {
                "Persona 1",
                "Persona 2",
                "Persona 3",
                "Persona 4"
            };

                list.Add("Reyna");
                list.Add("Ada");
                list.Add("Pedro");
                list.Add("Jesus");

                list.Remove("Ada");
                list.RemoveAt(0);
                list.RemoveAll(persona => persona != "Persona 2");
                list.Sort();

                foreach (string item in list)
                {
                    Console.WriteLine(item);
                }

                break;
            case 2:
                Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"Pais", "Honduras"},
                {"Capital", "Tegucigalpa"}
            };
                dict.Add("Departamento", "Cortes");
                dict.Add("Extension", "112,492 km2");
                dict.Add("Idioma", "Español");
                dict.Add("Población", "10,000,000 habitantes");
                dict["Cabecera"] = "San Pedro Sula";

                dict.Remove("Idioma");
                dict.Remove("Población");

                foreach (var data in dict)
                {
                    Console.WriteLine($"Key: {data.Key}, Value: {data.Value}");
                }
                break;
            case 3:
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
        Console.WriteLine();
        Console.WriteLine();
    } catch(Exception ex) { 
        Console.WriteLine(ex.ToString());
        Console.WriteLine();
        Console.WriteLine();
    }
}