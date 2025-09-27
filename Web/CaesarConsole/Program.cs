// CaesarConsole/Program.cs
using System;
using CaesarLib;

namespace CaesarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CaesarConsole ===");
            Console.Write("Nhap chuoi : ");
            string text = Console.ReadLine();
            Console.Write("Nhap shift : ");
            string s = Console.ReadLine();
            int shift = 0;
            if (!int.TryParse(s, out shift))
            {
                Console.WriteLine("Shift khong hop le. Dung 0.");
                shift = 0;
            }

            CaesarCipher cc = new CaesarCipher();
            cc.InputText = text;
            cc.Shift = shift;

            if (cc.Process())
            {
                Console.WriteLine("Encoded: " + cc.EncodedText);
                Console.WriteLine("Decoded: " + cc.DecodedText);
            }
            else
            {
                Console.WriteLine("Xu ly loi.");
            }

            Console.WriteLine("Nhan phim bat ky đe thoat...");
            Console.ReadKey();
        }
    }
}
