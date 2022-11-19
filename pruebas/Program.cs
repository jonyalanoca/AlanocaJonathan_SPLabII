using Entidades;

namespace pruebas
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> tipos = new() { "lapiz, lapicera, tintachina" };
            Lapiz l1 = new Lapiz(12, "faber", ConsoleColor.Blue);
            string str = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //Serializador<Lapiz>.SerializarJason(l1, $"{str}\\enjason.txt");
            Lapiz l2= Serializador<Lapiz>.DeserializarJason($"{str}\\enjason.txt");
            Console.WriteLine(l2.Detalles());
        }
        
    }
}