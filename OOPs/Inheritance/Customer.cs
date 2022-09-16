using System;

namespace OOPs.Inheritance
{
    [Serializable]
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }

        public int DepartmentId { get; set; }

        public DateTime dob;
        public int Age
        {
            get
            {
                return (DateTime.Now.Year - dob.Year);
            }
        }

        private protected int _discount;
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
