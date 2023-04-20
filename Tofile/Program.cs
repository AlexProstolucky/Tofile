using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        using (FileStream potik = new FileStream("text.txt", FileMode.Append, FileAccess.Write))
        {
            Console.WriteLine("Введіть текст:");
            string str = Console.ReadLine();
            byte[] bytes = Encoding.Default.GetBytes(str);
            potik.Write(bytes, 0, bytes.Length);
            Console.WriteLine("Текст успішно записано!");
        }
    }
}