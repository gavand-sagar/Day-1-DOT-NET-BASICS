using System;

namespace OOPs.Inheritance
{
    public class Customer
    {
        public int Id { get; set; }
        public int CustomerName { get; set; }

        public DateTime dob;
        public int Age
        {
            get
            {
                return (DateTime.Now.Year - dob.Year);
            }
        }

        protected int _discount;
        public int Discount
        {
            get
            {

                return _discount;
            }
        }

        public Customer()
        {
            _discount = 20;
            Counter.Increment();
            Id = Counter.GetCount();
        }

        public virtual void Display()
        {
            Console.WriteLine("Its a regular.");
        }

    }
}
