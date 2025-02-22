public class FileDownload
{
    public FileDownload()
    {
        Console.WriteLine("Download started");
    }

    ~FileDownload()
    {
        Console.WriteLine("Download completed");
    }
}

class Program
{
    static void Method()
    {
        FileDownload File = new FileDownload();
    }

    static void Main(string[] args)
    {
        Method();
        
        
    }
}
