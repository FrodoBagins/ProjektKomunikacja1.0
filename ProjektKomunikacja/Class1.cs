using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjektKomunikacja
{
    class Class1
    {

        public static void GetWPF()
        {

            Application app = new Application();
            app.Run(new FirstWindow());


        }


        public static void DeleteContact(int id )
        {

            Baza.DeleteContact(id);


        }
    }
}
