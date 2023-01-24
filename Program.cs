namespace CS.IO.Study;

internal class Program
{
    public static void Main(string[] args)
    {
        ReadBinaryFile();
    }

    static void ReadTextFile()
    {
        FileStream fs = File.Open(Path.Combine("/","Users","vivekanandpv","hello.txt"), FileMode.Open);

        using (TextReader reader = new StreamReader(fs))
        {
            string content = reader.ReadToEnd();

            Console.WriteLine(content);
        }
    }

    static void ReadBinaryFile()
    {
        FileStream fs = File.Open(Path.Combine("/","Users","vivekanandpv","horse.jpeg"), FileMode.Open);

        using (BinaryReader reader = new BinaryReader(fs))
        {
            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                int b = reader.ReadByte();
                Console.WriteLine(b);
            }
        }
    }
}