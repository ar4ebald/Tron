using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tron
{
    class InputManager
    {
        private readonly PictureBox _surface;

        private static InputManager _current;
        public static InputManager Current
        {
            get
            {
                return _current;
            }
            set
            {
                if (_current == value)
                    return;

                _current?.Detach();
                value.Attach();

                _current = value;
            }
        }

        public InputManager(PictureBox surface)
        {
            _surface = surface;
        }

        public void Attach()
        {
            _surface.MouseMove += SurfaceOnMouseMove;
            _surface.MouseClick += SurfaceOnMouseClick;
            _surface.MouseDown += SurfaceOnMouseDown;
            _surface.MouseUp += SurfaceOnMouseUp;

            _surface.KeyPress += SurfaceOnKeyPress;
            _surface.KeyDown += SurfaceOnKeyDown;
            _surface.KeyUp += SurfaceOnKeyUp;
        }
        public void Detach()
        {
            _surface.MouseMove -= SurfaceOnMouseMove;
            _surface.MouseClick -= SurfaceOnMouseClick;
            _surface.MouseDown -= SurfaceOnMouseDown;
            _surface.MouseUp -= SurfaceOnMouseUp;

            _surface.KeyPress -= SurfaceOnKeyPress;
            _surface.KeyDown -= SurfaceOnKeyDown;
            _surface.KeyUp -= SurfaceOnKeyUp;
        }
        
        private void SurfaceOnMouseMove(object sender, MouseEventArgs e) => MouseMove?.Invoke(sender, e);
        private void SurfaceOnMouseClick(object sender, MouseEventArgs e) => MouseClick?.Invoke(sender, e);
        private void SurfaceOnMouseDown(object sender, MouseEventArgs e) => MouseDown?.Invoke(sender, e);
        private void SurfaceOnMouseUp(object sender, MouseEventArgs e) => MouseUp?.Invoke(sender, e);

        private void SurfaceOnKeyPress(object sender, KeyPressEventArgs e) => KeyPress?.Invoke(sender, e);
        private void SurfaceOnKeyDown(object sender, KeyEventArgs e) => KeyDown?.Invoke(sender, e);
        private void SurfaceOnKeyUp(object sender, KeyEventArgs e) => KeyUp?.Invoke(sender, e);

        public event MouseEventHandler MouseMove;
        public event MouseEventHandler MouseClick;
        public event MouseEventHandler MouseDown;
        public event MouseEventHandler MouseUp;

        public event KeyPressEventHandler KeyPress;
        public event KeyEventHandler KeyDown;
        public event KeyEventHandler KeyUp;
    }
}
