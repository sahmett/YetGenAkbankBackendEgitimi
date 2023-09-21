
using OOP_TextProject.Entities;
using System.Text.Json;

var filePath = "C:\\Users\\yelkenliler\\Downloads\\AccessControlLogs.txt";
var textFile = File.ReadAllText(filePath);

var splitedLines = textFile.Split("\n", StringSplitOptions.RemoveEmptyEntries);

List<AccessControlLog> logs = new();

foreach(var splitedLine in splitedLines)
{
    var lineValue = splitedLine.Split("---", StringSplitOptions.RemoveEmptyEntries);

    var accessControlLog = new AccessControlLog()
    {
        Id = Guid.NewGuid(),
        CreatedOn = DateTimeOffset.Now,
        PersonId = Convert.ToInt64(lineValue[0]),
        DeviceSerialNo = lineValue[1],
        AccesType = AccessControlLog.ConvertStringToAccesType(lineValue[2]),
        LogTime = Convert.ToDateTime(lineValue[3]),
    };

    logs.Add(accessControlLog);
}

Console.WriteLine(JsonSerializer.Serialize(logs));
File.WriteAllText("C:\\Users\\yelkenliler\\Downloads\\Logs.txt",JsonSerializer.Serialize(logs));
Console.WriteLine("op. ok");
