using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampainService
    {
        void Add(Campain campain);
        void Update(Campain campain);
        void Delete(Campain campain);
    }
}
