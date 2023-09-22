
class program
{
static void Main(string[] args)
    {
       
        
        Console.WriteLine(idSelect());
    }

    public static string idSelect()
    {
        string id=null;

        Random random = new Random();
       
        for (int i = 0; i < 20; i++)
        {
            id += (char)random.Next(48, 90);
        }
        Console.WriteLine($"uretilen ID: {id}");
        return id;
    }
}
