using Exam3.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Exam3
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string StateStr { get; set; }
        [JsonIgnore]
        public string Honorary_code { get; set; }
        [JsonIgnore]
        public IProductState State { get; set; }

        public Product(int id, string name, int price, string stateStr)
        {
            Id = id;
            Name = name;
            Price = price;
            StateStr = stateStr;
            SetState();
        }

        public void RaisePrice()
        {
            State.RaisePrice(this);
        }

        public void SetUp()
        {
            State.SetUp(this);
        }

        public void SetOff()
        {
            State.SetOff(this);
        }

        public void GiveToTheWinner()
        {
            State.GiveToTheWiner(this);
        }

        public void SetState()
        {
            if (StateStr == "inStock")
            {
                State = new InStockState();
            }
            else if (StateStr == "forSale")
            {
                State = new ForSaleState();
            }
            else
                State = new SoldState();
        }

        public override string ToString()
        {
            return String.Format("{0, -3} | {1, -20}", Id, Name);
        }
    }
}