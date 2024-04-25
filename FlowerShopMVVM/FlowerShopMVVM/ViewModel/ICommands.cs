using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopMVVM.ViewModel
{
    public interface ICommands
    {
        void Execute();
        void Execute(int parameter);
        void Execute(string parameter); 
    }
}
