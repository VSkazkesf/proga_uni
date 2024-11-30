while (true)
{
    Console.WriteLine("╔════════════════════════════════════╗");
    Console.WriteLine("║          Выберите файл             ║");
    Console.WriteLine("╠════════════════════════════════════╣");
    Console.WriteLine("║1) Январь                           ║");
    Console.WriteLine("║2) Февраль                          ║");
    Console.WriteLine("║3) Март                             ║");
    Console.WriteLine("║4) Апрель                           ║");
    Console.WriteLine("║0) Выход                            ║");
    Console.WriteLine("╚════════════════════════════════════╝");
    string input = Console.ReadLine();
    int numOfFile;
    bool isNumber = int.TryParse(input, out numOfFile);
    
    if (!isNumber)
    {
        Console.WriteLine("Тип введенных данных некорректен.");
        Console.WriteLine("Нужно ввести цифру от 1 до 4");
        continue;
    }

    if (numOfFile > 4 || numOfFile < 0)
    {
        Console.WriteLine("Введенные данные некорректны.");
        Console.WriteLine("Нужно ввести цифру от 1 до 4");
        continue;
    }
    
    if (numOfFile == 0)
    {
        break;
    }

    List<float> temperature = new List<float>();
    List<int> humidity = new List<int>();
    string filepath = $@"C:\Users\egora\RiderProjects\laba 4\updated_weather_month_{numOfFile}.csv";
    var reader = new StreamReader(filepath);
    var t = reader.ReadLine();

    var data = new List<(float, int)>{};
    while (!reader.EndOfStream)
    {
        var line = reader.ReadLine().Split(',');
        var value1 = float.Parse(line[0].Replace('.', ','));
        var value2 = int.Parse(line[1].Replace('.', ','));
        data.Add((value1, value2));
    }

    for (int i = 0; i < data.Count; i++)
    {
        temperature.Add(data[i].Item1);
        humidity.Add(data[i].Item2);
    }

    var avgTemperature = temperature.Average();
    var avgHumidity = humidity.Average();

    Console.WriteLine($"Средняя температура: {Math.Round(avgTemperature, 2)}");
    Console.WriteLine($"Средняя влажность: {Math.Round(avgHumidity, 2)}");
    Console.WriteLine();
    Console.WriteLine();
    reader.Close();
    
}