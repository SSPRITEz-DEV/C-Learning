using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial
{
    class Enums
    {
        enum playerMovement
        {
            idle,
            forward,
            backward,
            left,
            right
        }

        public static void Run()
        {
            playerMovement currentMovement = playerMovement.idle;
        }

    }
}
