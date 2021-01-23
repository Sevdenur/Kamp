using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
     
    }
}
//birisi bu interface yi kulanırsa kullananlar bu metodları kullanmak zorunda
//interface: arayüz/ şablon.Bu şablona uymak zorundasın denilmiş oluyor.
//Interface kuralları içerir. Bu interfaceyi implement eden sınıflar da bu kuralları kendine göre implement eder.
//birbirinin alternatifi olan ama kod içerikleri farklı olanlar için interface kullanırız.
//interface sürdürülebilirlik sağlar
//hesaplama işlemi bütün krediler için ortak bir işlem ama her kredi türünde hesaplama işlemleri değişkenlik gösterecektir.
//Loglama: olan hareketlerin dökümü 