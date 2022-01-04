using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace DashBoardApp.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new DashBoardApp.App(), args);
            host.Run();
        }
    }
}
