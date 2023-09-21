
using OOP_TextProject.Entities;

var filePath = "C:\\Users\\yelkenliler\\Downloads\\AccessControlLogs.txt";
var textFile = File.ReadAllText(filePath);

var splitedLines = textFile.Split("\n", StringSplitOptions.RemoveEmptyEntries);

foreach(var splitedLine in splitedLines)
{
    var lineValue = splitedLine.Split("---", StringSplitOptions.RemoveEmptyEntries);

    var accessControlLog = new AccessControlLog()
    {
        Id = Guid.NewGuid(),
        CreatedOn = DateTimeOffset.Now,
        PersonId = Convert.ToInt64(lineValue[0]),
        DeviceSerialNo = lineValue[1],
        AccesType = lineValue[2]
    };
}

