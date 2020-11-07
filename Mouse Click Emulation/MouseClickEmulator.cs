using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Mouse_Click_Emulation
{
    partial class MouseClickEmulator
    {

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int x, int y, int dwData, int dwExtraInfo);

        private const int MOUSECLICKCONST = 0x00000008;
        public static void MouseClickEvent()
        {

            mouse_event
                (MOUSECLICKCONST,
                 Cursor.Position.X,
                 Cursor.Position.Y,
                 0,
                 0)
                ;
        }


    }
}
