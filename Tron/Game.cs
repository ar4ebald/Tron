using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tron
{
    static class Game
    {
        private static GameForm _form;

        static void Main()
        {
            _form = new GameForm();
            _form.Load += (s, e) =>
            {
                Initialize();
            };

            Application.EnableVisualStyles();
            Application.Run(_form);
        }

        private static void Initialize()
        {

        }
    }
}
