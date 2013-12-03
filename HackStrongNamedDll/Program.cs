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
            if (args.Length != 1 || !File.Exists(args[0]))
            {
                Console.WriteLine("Usage: HackStrongNameDll path_to_test_dll");
                return;

            }

            var bytes = File.ReadAllBytes(args[0]);
            
            

            var valid = new byte[] {0x76, 0x00, 0x61, 0x00, 0x6c, 0x00, 0x69, 0x00, 0x64, 0x00};
            var icky = new byte[] {0x69, 0x00, 0x63, 0x00, 0x6b, 0x00, 0x79, 0x00, 0x21, 0x00};

            var location = FindPattern(bytes, valid);

            if (location == -1)
            {
                Console.WriteLine("Pattern wasn't found!");
                return;
            }

            bytes = ReplaceBytes(bytes, icky, location);

            File.WriteAllBytes(args[0], bytes);


        }

        private static byte[] ReplaceBytes(byte[] bytes, byte[] with, int from)
        {
            for (var i = 0; i < with.Length; i ++)
            {
                bytes[from + i] = with[i];
            }

            return bytes;
        }



        private static int FindPattern(byte[] item, byte[] pattern)
        {
            
            for (int i = 0; i < item.Length - pattern.Length; i++)
            {
                var segment = new ArraySegment<byte>(item, i, pattern.Length);
                if (segment.SequenceEqual(pattern))
                    return i;
            }

            return -1;
        }
    }
}
