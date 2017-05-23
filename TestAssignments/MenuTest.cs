using KeychainMenuApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KeychainMenuApp.KeyChain;

namespace TestAssignments
{
    class MenuTest
    {
        public static void Main(string[] args)
        {
            KeyChain.Options op;
            KeyChainInfo kcInfo = new KeyChainInfo();
            kcInfo.totalKeychains = 0;
            kcInfo.pricePerUnit = 0;
            kcInfo.totalCost = 0;
            KeyChain kc = new KeyChain();


            do
            {
                Console.WriteLine("Ye Olde Keychain Shoppe:");
                Console.WriteLine("1.Add Keychains to Order:");
                Console.WriteLine("2.Remove keychains from Order:");
                Console.WriteLine("3.View Current Order:");
                Console.WriteLine("4.Checkout:");
                Console.WriteLine("Please enter your choice:");
                int currentOrder = 0;
                Int32.TryParse(Console.ReadLine(), out currentOrder);

                op = (Options)currentOrder;

                kcInfo = kc.Execute(op);

            } while (op != KeyChain.Options.Checkout);
        }

    }
}
