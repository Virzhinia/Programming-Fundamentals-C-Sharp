using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS.DEBUGGING_AND_TROUBLESHOOTING_CODE
{
    class Program
    {
            static void PrintReceiptHeader()
            {
                Console.WriteLine("CASH RECEIPT");
                Console.WriteLine("------------------------------");
            }
            static void BodyReceipt()
            {
                Console.WriteLine("Charged to____________________");
                Console.WriteLine("Received by___________________");
            }
            static void FooterReceipt()
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("\u00A9 SoftUni");
            }
            static void PrintReceipt()
            {
                PrintReceiptHeader();
                BodyReceipt();
                FooterReceipt();
            }
        static void Main(string[] args)
            {
                PrintReceipt();
            }
        }
    }
