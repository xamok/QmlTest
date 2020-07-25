using System;
using System.Net.Http;

using Qml.Net;
using Qml.Net.Runtimes;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace testQML
{
    class Program
    {
        static int Main(string[] args)
        {
            var coll = new ServiceCollection().AddHttpClient();
            RuntimeManager.DiscoverOrDownloadSuitableQtRuntime();
            using (var app = new QGuiApplication())
            {
                Console.WriteLine("entered 1st using");
                using (var engine = new QQmlApplicationEngine())
                {
                    Console.WriteLine("entered 2nd using");
                    Qml.Net.Qml.RegisterType<QmlType>("test", 1, 1);
                    engine.Load("qml/main.qml");
                    return app.Exec();
                }
            }

        }

    }
}
