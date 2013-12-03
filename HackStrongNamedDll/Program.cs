using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackStrongNamedDll
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1 || File.Exists(args[0]))
            {
                Console.WriteLine("Usage: HackStrongNameDll path_to_test_dll");
                return;

            }

            var bytes = File.ReadAllBytes(args[0]).ToList();
            
            bytes.Find()
            bytes
            using (var stream = File.Open(args[0], FileMode.Open, FileAccess.Read))
            {
                stream.f
            }

            var valid = new byte[] {0x76, 0x00, 0x61, 0x00, 0x6c, 0x00, 0x69, 0x00, 0x64, 0x00};
            var icky = new byte[] {0x69, 0x00, 0x63, 0x00, 0x6b, 0x00, 0x79, 0x00, 0x21, 0x00};

            args[0]
        }
    }
}
