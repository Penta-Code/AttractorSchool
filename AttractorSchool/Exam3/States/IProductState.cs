using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3.States
{
    internal interface IProductState
    {
        void RaisePrice(Product prod);
        void SetUp(Product prod);
        void SetOff(Product prod);
        void GiveToTheWiner(Product prod);
    }
}