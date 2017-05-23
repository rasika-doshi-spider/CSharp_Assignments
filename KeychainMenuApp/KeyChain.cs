using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeychainMenuApp
{
    public class KeyChain
    {
        KeyChainInfo kcInfo = new KeyChainInfo();

        public enum Options
        {
            Add_Keychains=1,
            Remove_Keychains,
            View_Order,
            Checkout
        }; 

        public KeyChainInfo Add_Keychains()
        {
            Console.WriteLine("You have {0} keychains.How many to add ?: ", kcInfo.totalKeychains);
            int numberOfKeyChains;
            Int32.TryParse(Console.ReadLine(), out numberOfKeyChains);
            kcInfo.totalKeychains = kcInfo.totalKeychains + numberOfKeyChains;
            Console.WriteLine("Keychains in order- " +kcInfo.totalKeychains);
            return kcInfo;
        }

        public KeyChainInfo Remove_Keychains()
        {
            Console.WriteLine("You have {0} keychains.How many to remove?: ", kcInfo.totalKeychains);
            int numberOfKeyChains;
            Int32.TryParse(Console.ReadLine(), out numberOfKeyChains);
            kcInfo.totalKeychains = kcInfo.totalKeychains - numberOfKeyChains;
            Console.WriteLine("Keychains in order- " + kcInfo.totalKeychains);
            return kcInfo;
        }

        public KeyChainInfo View_Order()
        {
            Console.WriteLine("Keychains in order- " + kcInfo.totalKeychains);
            Console.WriteLine("Please enter Keychain's cost per unit- ");
            int price;
            Int32.TryParse(Console.ReadLine(), out price);
            kcInfo.totalCost = price * kcInfo.totalKeychains; 
            Console.WriteLine("Total cost is- " +kcInfo.totalCost);
            kcInfo.pricePerUnit = price;
            return kcInfo;
        }

        public KeyChainInfo Checkout()
        {
            Console.WriteLine("What is your name ?: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Keychains in order- " + kcInfo.totalKeychains);
            Console.WriteLine("Keychain's cost per unit- " + kcInfo.pricePerUnit);
            Console.WriteLine("Total cost is- " + kcInfo.totalCost);
            Console.WriteLine("Thanks for your order- " + userName);
            return kcInfo;
        }


        public KeyChainInfo Execute(Options Operation)
        {
            switch(Operation)
            {
                case Options.Add_Keychains: return Add_Keychains();
                case Options.Remove_Keychains: return Remove_Keychains();
                case Options.View_Order: return View_Order();
                case Options.Checkout: return Checkout();
                default: return kcInfo;    
            }
        }

    }
}
