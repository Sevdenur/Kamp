using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //bir sınıf bir interfaceyi bu şekilde kullanırsa interfacedeki metotları kullanmak zorunda
    class KonutKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
