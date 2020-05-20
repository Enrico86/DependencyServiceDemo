using DependencyServiceDemo.DependencyServices;
using DependencyServiceDemo.UWP.DependencyServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(WindowsMessage))]
namespace DependencyServiceDemo.UWP.DependencyServices
{
    public class WindowsMessage: IPlatformMessage
    {
        public string GetMessage ()
        {
            return "i am on WindowsPlatform";
        }
    }
}
