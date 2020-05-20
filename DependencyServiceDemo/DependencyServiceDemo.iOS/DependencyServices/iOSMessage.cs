using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DependencyServiceDemo.DependencyServices;
using DependencyServiceDemo.iOS.DependencyServices;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(iOSMessage))]
namespace DependencyServiceDemo.iOS.DependencyServices
{
    public class iOSMessage : IPlatformMessage
    {
        public string GetMessage ()
        {
            return "I am On iOS";
        }
    }
}