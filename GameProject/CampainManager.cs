using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampainManager : ICampainService
    {
        public void Add(Campain campain)
        {
            Console.WriteLine("Yeni kampanya sisteme eklendi");
        }

        public void Delete(Campain campain)
        {
            Console.WriteLine("Seçili kampanya silindi");
        }

        public void Update(Campain campain)
        {
            Console.WriteLine("Seçili kampanya güncelleme işlemi başarılı");
        }
    }
}
