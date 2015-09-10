using System;
using System.Net;

using Microsoft.Xna.Framework;

using PokeD.Client.Windows.WrapperInstances;

using PokeD.Core.Wrappers;

namespace PokeD.Client.Windows
{
    public static class Program
    {
        static Program()
        {
            FileSystemWrapper.Instance = new FileSystemWrapperInstance();
            NetworkTCPClientWrapper.Instance = new NetworkTCPClientWrapperInstance();
            InputWrapper.Instance = new InputWrapperInstance();
            ThreadWrapper.Instance = new ThreadWrapperInstance();
        }

        static void Main()
        {
            if (Type.GetType("Mono.Runtime") != null) // -- Running on Mono
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            using (var game = new Client(PlatformCode, false))
                game.Run();
        }

        private static void PlatformCode(Game client)
        {
            //((Client)client).PreferredBackBufferWidth = 800;
            //((Client)client).PreferredBackBufferHeight = 600;
            //client.IsMouseVisible = true;
            //client.Window.Position = new Point(0, 0);
            //((Client)client).PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            //((Client)client).PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
        }
    }
}
