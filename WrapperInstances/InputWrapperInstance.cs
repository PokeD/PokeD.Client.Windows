﻿using PokeD.Core.Wrappers;

namespace PokeD.Client.Windows.WrapperInstances
{
    public class InputWrapperInstance : IInputWrapper
    {
        public event OnKeys OnKey;

        public InputWrapperInstance() { }

        public void ShowKeyboard() { }

        public void HideKeyboard() { }

        public void ConsoleWrite(string message) { }

        public void LogWriteLine(string message)
        {
        //    LogManager.WriteLine(message);
        }
    }
}
