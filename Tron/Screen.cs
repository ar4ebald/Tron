using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tron
{
    abstract class Screen
    {
        private static Screen _currentScreen;

        public event Action Show;
        public event Action Hide;

        protected readonly PictureBox Surface;
        protected readonly InputManager Input;

        public static void Navigate(Screen screen)
        {
            _currentScreen?.Hide();

            InputManager.Current = screen.Input;
            _currentScreen = screen;

            screen?.Show();
        }

        protected Screen(PictureBox surface)
        {
            Surface = surface;
            Input = new InputManager(surface);
        }

        public abstract void Update(double dt);

    }
}
