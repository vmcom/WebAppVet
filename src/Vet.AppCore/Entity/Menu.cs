using System;
using System.Collections.Generic;
using System.Text;
using Vet.AppCore.Entity.Generico;

namespace Vet.AppCore.Entity
{
    public class Menu:EntityGenerico
    {
        public Menu()
        {

        }

        public string Titulo { get; set; }
        public int? MenuId { get; set; }
        public ICollection<Menu> SubMenu { get; set; }
    }
}
