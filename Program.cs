using System;

namespace handling_errors
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("bir sayı giriniz");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("sayı: {0}", num);
            }
            catch(FormatException msg)
            {
                Console.WriteLine("Yanlış formatta değer girdiniz: {0}", msg.Message.ToString());
            }
            catch(ArgumentNullException msg)
            {
                Console.WriteLine("Boş değer girdiniz. Hata: {0}", msg.Message.ToString());
            }
            finally
            {
                Console.WriteLine("işlem tamamlandı");
            }
        }
    }
}