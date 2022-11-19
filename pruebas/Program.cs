using Entidades;

namespace pruebas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Goma g = new Goma(1003,10000, "NUEVA", Tipos.Simple);
            //string str = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //Serializador<Lapiz>.SerializarJason(l1, $"{str}\\enjason.txt");
            //Lapiz l2= Serializador<Lapiz>.DeserializarJason($"{str}\\enjason.txt");
            //Console.WriteLine(l2.Detalles());
            Cartuchera<Utiles> c1 = new Cartuchera<Utiles>();

            GomaDAO gdao = new GomaDAO();
            if (gdao.LeerGoma(ref c1))
            {
                Console.WriteLine("sepudpo");
            }
            else
            {
                Console.WriteLine("no se puedo");
            }
            foreach(var i in c1.ListaUtiles)
            {
                Console.WriteLine(i.Detalles());
            }
           
        }
        
    }
}