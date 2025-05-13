using Exam3.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3.States
{
    internal class SoldState : IProductState
    {
        public void GiveToTheWiner(Product prod)
        {
            throw new WrongProductStateException("Продукт уже продан");
        }

        public void RaisePrice(Product prod)
        {
            throw new WrongProductStateException("Продукт уже продан");
        }

        public void SetOff(Product prod)
        {
            throw new WrongProductStateException("Продукт уже продан");
        }

        public void SetUp(Product prod)
        {
            throw new WrongProductStateException();
        }
    }
}