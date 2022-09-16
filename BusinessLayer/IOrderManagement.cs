using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IOrderManagement
    {
        void AddOrder(string productId, string userId);
    }
}
