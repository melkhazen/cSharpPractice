using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResterauntManue
{
    class CreatMenu
    {
        public static void creatIt()
        {
            List<Menu> menuList = new List<Menu>();

            Menu newMenu = new Menu();

            newMenu.createANewItem();

            menuList.Add(newMenu);
           
        }
    }
}
