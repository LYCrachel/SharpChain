﻿using System;
using Con = System.Console;

namespace ChainSaw.Client.Console
{
    class Program
    {
        static IChatClient chatClient;
        static IEncryptionHelper encryptionHelper;

        static void Main(string[] args)
        {
            Initialize();
            Con.ReadKey();
        }

        private static void Initialize()
        {
            Con.SetWindowSize(120, 30);
            Con.ForegroundColor = ConsoleColor.Cyan;
            Con.WriteLine(Resources.UniversityOfTehran);
            Con.ForegroundColor = ConsoleColor.Yellow;
            Con.WriteLine(Resources.ChainsawChat);
            Con.WriteLine(Resources.AppDescription);
            Con.WriteLine(Resources.Separator);
            Con.ForegroundColor = ConsoleColor.White;
            Con.WriteLine(Resources.GeneratingKey);
            chatClient = IocContainer.Resolve<IChatClient>();
            encryptionHelper = IocContainer.Resolve<IEncryptionHelper>();
        }
    }
}
