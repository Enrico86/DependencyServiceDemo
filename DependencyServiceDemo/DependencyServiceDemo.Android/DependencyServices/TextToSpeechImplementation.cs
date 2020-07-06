using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Text.Style;
using Android.Views;
using Android.Widget;
using DependencyServiceDemo.DependencyServices;
using DependencyServiceDemo.Droid.DependencyServices;
using Plugin.CurrentActivity;
using Xamarin.Forms;
using static Android.Speech.Tts.TextToSpeech;

[assembly: Dependency(typeof(TextToSpeechImplementation))]
namespace DependencyServiceDemo.Droid.DependencyServices
{   
    public class TextToSpeechImplementation :Java.Lang.Object, ITextToSpeech, IOnInitListener
    {
        private TextToSpeech speaker;
        private string toSpeak;


        public void Speak(string Text)
        {
            toSpeak = Text;
            if  (speaker == null)
            {
                speaker = new TextToSpeech(CrossCurrentActivity.Current.Activity, this);
            }
            else
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }

        public void OnInit(OperationResult status)
        {
            speaker.Speak(toSpeak, QueueMode.Flush, null, null);
        }
    }
}