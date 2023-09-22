using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeHotelLibrary.Model
{
    public class ItalianHotel:IHotel
    {
        public IMenu getMenu()
        {
            return new ItalianMenu();
        }
    }
}
