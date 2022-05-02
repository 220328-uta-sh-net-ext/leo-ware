global using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySpoonUI
{
    public interface IMenu //MainMenuInterface
    {

        void Display();

        string UserChoices();

    }

    interface IExtendedMenu
    {
        void Exit();

        void Continue();
    }
}
