using System;

namespace Sobreescritura
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new();
            Console.WriteLine(b.Hi());

            Sale sale = new(10);
            sale.Add(2);
            sale.Add(3);
            Console.WriteLine(sale.GetTotal());

            SaleWithTax saleWithTax = new(10, 1.9m);
            saleWithTax.Add(2);
            saleWithTax.Add(54);
            Console.WriteLine(saleWithTax.GetTotal());
        }
    }

    public class Sale
    {
        private readonly decimal[] _amounts;
        private readonly int _n;
        private int _end;

        public Sale(int n)
        {
            _n = n;
            _amounts = new decimal[n];
            _end = 0;
        }

        public void Add(decimal amount)
        {
            if(_end < _n)
            {
                _amounts[_end] = amount;
                _end++;
            }
        }

        public virtual decimal GetTotal()
        {
            decimal result = 0;
            int i = 0;

            while (i < _amounts.Length)
            {
                result += _amounts[i];
                i++;
            }

            return result;
        }
    }

    public class SaleWithTax : Sale
    {
        private readonly decimal _tax;
        public SaleWithTax(int n, decimal tax) : base(n)
        {
            _tax = tax; 
        }

        public override decimal GetTotal()
        {
            return base.GetTotal() * _tax;
        }
    }

    public class A
    {
        public virtual string Hi()
        {
            return "Hola soy A";
        }
    }

    public class B : A
    {
        public override string Hi()
        {
            return base.Hi() + "Hola soy B";
        }
    }
}