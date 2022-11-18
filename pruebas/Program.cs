namespace pruebas
{
    public class Program
    {
        static void Main(string[] args)
        {
            string mensaje="";
            int numero1 = 10;
            int numero2 = 0;
            try
            {
                if (numero2 == 0)
                {
                    throw new Exception("div o");
                }
                mensaje = (numero1 / numero2).ToString();
            }
            catch(Exception dc)
            {
                Console.WriteLine(dc.Message);
            }
            Console.WriteLine(mensaje);
            
        }
        
    }
}