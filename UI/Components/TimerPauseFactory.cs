using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    public class TimerPauseFactory : IComponentFactory
    {
        public string ComponentName => "Timer Pause";

        public string Description => "Allows you to pause the run and continue later.";

        public ComponentCategory Category => ComponentCategory.Other;

        public IComponent Create(LiveSplitState state) => new TimerPauseComponent(state);

        public string UpdateName => ComponentName;

        public string XMLURL => "";

        public string UpdateURL => "";

        public Version Version => Version.Parse("1.0.0");
    }
}
