Console.WriteLine("A = start async-operasjon");
Console.WriteLine("B = start blokkerende/synkron operasjon");
Console.WriteLine("Q = avslutt");
Console.WriteLine();

var nextOperationNumber = 1;

while (true)
{
    if (!Console.KeyAvailable)
    {
        await Task.Delay(50);
        continue;
    }

    var keyInfo = Console.ReadKey();
    var key = keyInfo.Key;

    if (key == ConsoleKey.Q)
    {
        Log("Avslutter");
        break;
    }

    if (key == ConsoleKey.A)
    {
        var operationNumber = nextOperationNumber++;
        Log($"Operasjon #{operationNumber} - Async - start");

        _ = SayHelloLaterAsync(operationNumber);
    }
    else if (key == ConsoleKey.B)
    {
        var operationNumber = nextOperationNumber++;
        Log($"Operasjon #{operationNumber} - Sync - start");

        SayHelloLaterBlocking(operationNumber);
    }
    else
    {
        Log($"Tastetrykk - {key}");
    }
}

async Task SayHelloLaterAsync(int operationNumber)
{
    await Task.Delay(3000);

    Log($"Operasjon #{operationNumber} - Async - slutt");
}

void SayHelloLaterBlocking(int operationNumber)
{
    Thread.Sleep(3000);

    Log($"Operasjon #{operationNumber} - Sync - slutt");
}

void Log(string message)
{
    Console.WriteLine($"{DateTime.Now:HH:mm:ss} - {message}");
}