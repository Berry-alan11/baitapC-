using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__BASIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Đặt encoding UTF-8 để hỗ trợ nhập tiếng Việt
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chương trình 1: Kiểm tra số chẵn lẻ");
            Console.Write("Nhập một số nguyên: ");
            // Đọc input từ người dùng và chuyển thành số nguyên
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                // Kiểm tra số chẵn lẻ bằng cách chia lấy dư cho 2
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} là số chẵn.");
                }
                else
                {
                    Console.WriteLine($"{number} là số lẻ.");
                }
            }
            else
            {
                Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập một số nguyên.");
            }

            Console.WriteLine("\nChương trình 2: Kiểm tra nguyên âm");
            Console.Write("Nhập một ký tự: ");

            // Đọc một ký tự từ người dùng
            string input = Console.ReadLine();

            if (input.Length == 1)
            {
                char character = char.ToLower(input[0]); // Chuyển thành chữ thường để dễ kiểm tra

                // Kiểm tra xem ký tự có phải là nguyên âm không
                if (character == 'a' || character == 'e' || character == 'i' ||
                    character == 'o' || character == 'u')
                {
                    Console.WriteLine("You have input, Vowel");
                }
                else
                {
                    Console.WriteLine("This is not a Vowel");
                }
            }
            else
            {
                Console.WriteLine("Vui lòng chỉ nhập một ký tự duy nhất.");
            }

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
