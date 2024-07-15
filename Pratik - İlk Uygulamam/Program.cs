using System;

namespace IlkUyglulama
{
    class program

    {
        static void Main(string[] args)

        {
            string metin = "Burak Özdemir" + Environment.NewLine + "Patika'nın eğitimleri ve uzman kadrosuyla yazılım sektörü gerekliliklerine ulaşmak için bu bootcampteyim. "; // Yeni satıra geçmesi için Environment.NewLine özelliğini kullandım
            Console.WriteLine(metin);
        }
    }
}