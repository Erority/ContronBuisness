using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CoontrolBuisnesTile.EF;

namespace CoontrolBuisnesTile
{
    public static class ClassSave
    {
        public static Employee employee { get; set; }
        public static BeControlDBEntities context { get; set; } = new BeControlDBEntities();
        public static Button firstButton { get; set; }
        public static Button secondButton { get; set; }
    }
}
