
using OOP_TextProject.Entities;
using OOP_TextProject.Enums;
using System.Text.Json;

using OOP_TextProject.Enums;
using OOP_TextProject.Common;
using YetGenAkbankJumpOOPConsole.Services;


string filePath1 = "C:\\Users\\seyyitahmet.kilic\\Downloads";
string filePath2 = "C:\\Users\\yelkenliler\\Downloads";

var textFile = File.ReadAllText($"{filePath1}\\AccessControlLogs.txt");



//ILogger logger = new Logger<string>(new LoggerBase()); //anlamadım
ConsoleLogger consoleLogger = new ConsoleLogger();
FileLogger fileLogger = new FileLogger(filePath1);





try { 



Console.WriteLine("text file imported..");

var splitedLines = textFile.Split("\n", StringSplitOptions.RemoveEmptyEntries);


Console.WriteLine("lines are splitted..");


List<AccessControlLog> logs = new();

foreach(var splitedLine in splitedLines)
{
    var lineValue = splitedLine.Split("---", StringSplitOptions.RemoveEmptyEntries);

    var accessControlLog = new AccessControlLog()
    {
       
        CreatedOn = DateTimeOffset.Now,
        PersonId = Convert.ToInt64(lineValue[0]),
        DeviceSerialNo = lineValue[1],
        AccesType = AccessControlLog.ConvertStringToAccesType(lineValue[2]),
        //AccesType = Enum.Parse(typeof(AccessType) lineValue[2]),

        LogTime = Convert.ToDateTime(lineValue[3]),
    };

    logs.Add(accessControlLog);
}

Console.WriteLine("all lines are converted to obj..");
        
Console.WriteLine(JsonSerializer.Serialize(logs));

File.WriteAllText($"{filePath1}\\Logs.txt",JsonSerializer.Serialize(logs));

Console.WriteLine("the json file was successfully created. ok");

}catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}