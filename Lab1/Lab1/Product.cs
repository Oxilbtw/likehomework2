using System;

namespace Lab1
{
    public class Product
    {
        private string _name;
        private decimal _price;
        private int _quantity;

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            _quantity = quantity;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Назва товару не може бути порожньою.");
                }
                _name = value;
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Цiна не може бути меншою за 0.");
                }
                _price = value;
            }
        }

        public int Quantity
        {
            get { return _quantity; }
        }

        public decimal TotalValue
        {
            get { return _price * _quantity; }
        }

        public void Restock(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Кiлькiсть для поповнення має бути додатньою.");
            }
            _quantity += amount;
            Console.WriteLine($"Товар поповнено на {amount} шт.");
        }

        public void Sell(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Кiлькiсть для продажу має бути додатньою.");
            }
            if (amount > _quantity)
            {
                Console.WriteLine("Недостатньо товару на складi");
                return;
            }
            _quantity -= amount;
            Console.WriteLine($"Продано {amount} шт.");
        }

        public string GetInfo()
        {
            return $"Товар: {_name}, Цiна: {_price} грн, Кiлькiсть: {_quantity}, Загальна вартiсть: {TotalValue} грн";
        }
    }
}