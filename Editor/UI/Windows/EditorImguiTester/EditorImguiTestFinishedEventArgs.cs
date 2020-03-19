using System;

namespace Innoactive.CreatorEditor.ImguiTester
{
    /// <summary>
    /// Event args for event which is fired when Editor IMGUI test finishes it's execution.
    /// </summary>
    public class EditorImguiTestFinishedEventArgs : EventArgs
    {
        public TestState Result { get; private set; }

        public EditorImguiTestFinishedEventArgs(TestState result)
        {
            Result = result;
        }
    }
}