# Asynchronous programming in C#

File.ReadAllTextAsync Method
```cs
// File.ReadAllTextAsync(string path):
private static async Task Main (string[] args) {
    string contents = await ReadTestFile();
    Console.WriteLine(contents);
}

public static async Task<string> ReadTestFile () {
    string fileData = await File.ReadAllTextAsync("../../../Test.txt");
    return fileData;
}
```

https://docs.microsoft.com/en-us/dotnet/csharp/async

https://docs.microsoft.com/en-us/dotnet/api/system.io.streamreader.readtoendasync?redirectedfrom=MSDN&view=netframework-4.8#System_IO_StreamReader_ReadToEndAsync

https://docs.microsoft.com/en-us/dotnet/api/system.io.file.readalltextasync?view=netcore-3.1