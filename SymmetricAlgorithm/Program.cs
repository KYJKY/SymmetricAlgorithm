using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SymmetricAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(; ; )
            {
                string input = Console.ReadLine();

                // 키를 지정하고 실행
                string DES_Key = "test";

                DES_Hashing des = new DES_Hashing(input, DES_Key);         

                Console.WriteLine("DES 암호화 결과");
                Console.WriteLine(des.EncryptInput());
                Console.WriteLine("DES 복호화 결과");
                Console.WriteLine(des.DecryptInput());
                input = Console.ReadLine();
            }
        }
    }
}
