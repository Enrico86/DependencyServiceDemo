using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyServiceDemo.DependencyServices
{
    public interface ITextToSpeech
    {
        void Speak(string Text);
    }
}
