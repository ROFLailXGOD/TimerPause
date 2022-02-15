using LiveSplit.Model;
using System;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public class TimerPauseComponent : LogicComponent, IDeactivatableComponent
    {

        public override string ComponentName => "Timer Pause";

        public bool Activated { get; set; }

        private bool IsSplitting { get; set; }
        private int SplitCounter { get; set; }

        private LiveSplitState State { get; set; }
        private TimerPauseSettings Settings { get; set; }
        private TimerModel Timer { get; set; }
        public TimerPauseComponent(LiveSplitState state)
        {
            Activated = true;

            State = state;
            Settings = new TimerPauseSettings();
            Timer = new TimerModel() { CurrentState = State };

            State.OnStart += State_OnStart;
            State.OnSkipSplit += State_OnSkipSplit;
            State.OnPause += State_OnPause;
            State.OnSplit += State_OnSplit;
            State.OnUndoSplit += State_OnUndoSplit;
        }

        public override void Dispose()
        {
            State.OnStart -= State_OnStart;
            State.OnSkipSplit -= State_OnSkipSplit;
            State.OnPause -= State_OnPause;
            State.OnSplit -= State_OnSplit;
            State.OnUndoSplit -= State_OnUndoSplit;
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode) { }

        public override Control GetSettingsControl(LayoutMode mode)
        {
            return Settings;
        }

        public override XmlNode GetSettings(XmlDocument document)
        {
            return Settings.GetSettings(document);
        }

        public override void SetSettings(XmlNode settings)
        {
            Settings.SetSettings(settings);
        }

        private void State_OnStart(object sender, EventArgs e)
        {
            for (int i = State.Run.Count - 1; i >= 0; --i)
            {
                ISegment currentSegment = State.Run[i];
                Time splitTime = currentSegment.PersonalBestSplitTime;
                if (splitTime[State.CurrentTimingMethod] != null)
                {
                    IsSplitting = true;
                    SplitCounter = i + 1;
                    break;
                }
            }
            if (IsSplitting)
            {
                Timer.SkipSplit();
            }
        }

        protected void State_OnPause(object sender, EventArgs e)
        {
            State.Run.Offset = State.TimePausedAt;
        }

        protected void State_OnSkipSplit(object sender, EventArgs e)
        {
            if (IsSplitting)
            {
                ISegment previousSplit = State.Run[State.CurrentSplitIndex - 1];
                previousSplit.SplitTime = previousSplit.PersonalBestSplitTime;
                --SplitCounter;
                if (SplitCounter > 0)
                    Timer.SkipSplit();
                else
                    IsSplitting = false;
            }
        }

        protected void State_OnSplit(object sender, EventArgs e)
        {
            ISegment previousSplit = State.Run[State.CurrentSplitIndex - 1];
            previousSplit.PersonalBestSplitTime = previousSplit.SplitTime;
        }

        protected void State_OnUndoSplit(object sender, EventArgs e)
        {
            ISegment nextSplit = State.Run[State.CurrentSplitIndex + 1];
            nextSplit.PersonalBestSplitTime = new Time();
        }
    }
}
