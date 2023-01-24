namespace CS.IO.Study;

internal class Program
{
    public static void Main(string[] args)
    {
        ReadBinaryFile();
    }

    static void ReadBinaryFile()
    {
        FileStream fs = File.Open(Path.Combine("/","Users","vivekanandpv","horse.jpeg"), FileMode.Open);

        //  decorator pattern
        //  BinaryReader is an adapter
        //  BufferedStream is a decorator
        //  FileStream is a backing store
        //  10000 is the buffer size in bytes (10KB)
        using (BinaryReader reader = new BinaryReader(new BufferedStream(fs, 10000)))
        {
            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                int b = reader.ReadByte();
                Console.WriteLine(b);
            }
        }
    }
}