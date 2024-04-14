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

        private TimerPauseSettings Settings { get; set; }
        private LiveSplitState State { get; set; }
        private TimerModel Model { get; set; }
        private Time TimeAccumulator { get; set; }
        private int CurrentSplitIndex { get; set; }  // keeping track manually, because it's lost after a reset
        private int? MarkerIndex { get; set; }
        public TimerPauseComponent(LiveSplitState state)
        {
            Activated = true;

            State = state;
            Settings = new TimerPauseSettings();
            Model = new TimerModel() { CurrentState = State };
            TimeAccumulator = Time.Zero;

            State.OnStart += State_OnStart;
            State.OnSplit += State_OnSplit;
            State.OnSkipSplit += State_OnSkipSplit;
            State.OnUndoSplit += State_OnUndoSplit;
            State.OnReset += State_OnReset;
        }

        public override void Dispose()
        {
            State.OnStart -= State_OnStart;
            State.OnSplit -= State_OnSplit;
            State.OnSkipSplit -= State_OnSkipSplit;
            State.OnUndoSplit -= State_OnUndoSplit;
            State.OnReset -= State_OnReset;
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
            CurrentSplitIndex = State.CurrentSplitIndex;
            int numSplits = State.Run.Count;
            // if we don't have any splits or history => do nothing
            if (numSplits == 0 || State.Run.AttemptHistory.Count == 0)
            {
                return;
            }

            // check if there's a marked split
            string marker = "🐸";  // TODO: allow user to change this in settings
            for (int i = 0; i < numSplits; ++i)
            {
                string splitName = State.Run[i].Name;
                if (splitName.EndsWith(marker))
                {
                    MarkerIndex = i;
                    State.Run[i].Name = splitName.Remove(splitName.Length - marker.Length);
                    break;
                }
            }

            // no marker
            if ((MarkerIndex ?? 0) == 0)
            {
                return;
            }
            
            // find the last run ID and delete the last attempt from history
            int lastAttemptID = State.Run.AttemptHistory.Count;
            AtomicDateTime? started = State.Run.AttemptHistory[lastAttemptID - 1].Started;
            if (started.HasValue)
            {
                State.AttemptStarted = started.Value;
            }
            State.Run.AttemptHistory.RemoveAt(lastAttemptID - 1);
            --State.Run.AttemptCount;
            for (; lastAttemptID >= 1; --lastAttemptID)
            {
                if (State.Run[0].SegmentHistory.ContainsKey(lastAttemptID))
                {
                    break;
                }
            }

            // copy time from the last attempt
            while (State.CurrentSplitIndex < MarkerIndex)
            {
                Model.SkipSplit();
                ISegment previousSplit = State.Run[State.CurrentSplitIndex - 1];
                Time segmentTime = previousSplit.SegmentHistory[lastAttemptID];
                // handle empty splits
                if (segmentTime.RealTime == null && segmentTime.GameTime == null)
                {
                    previousSplit.SplitTime = segmentTime;
                }
                else
                {
                    TimeAccumulator += previousSplit.SegmentHistory[lastAttemptID];
                    previousSplit.SplitTime = TimeAccumulator;
                }
                previousSplit.SegmentHistory.Remove(lastAttemptID);
            }

            TimeAccumulator = Time.Zero;
        }
        protected void State_OnSplit(object sender, EventArgs e)
        {
            CurrentSplitIndex = State.CurrentSplitIndex;
        }

        protected void State_OnSkipSplit(object sender, EventArgs e)
        {
            CurrentSplitIndex = State.CurrentSplitIndex;
        }

        protected void State_OnUndoSplit(object sender, EventArgs e)
        {
            CurrentSplitIndex = State.CurrentSplitIndex;
        }

        protected void State_OnReset(object sender, TimerPhase e)
        {
            // save the current state
            if (e == TimerPhase.Paused)
            {
                State.Run.Offset = State.TimePausedAt;
                ISegment currentSplit = State.Run[CurrentSplitIndex];
                currentSplit.Name += "🐸";
            }  // restore the previous state
            else if (MarkerIndex is int markerIndex)
            {
                ISegment splitToMark = State.Run[markerIndex];
                splitToMark.Name += "🐸";
            }
        } 
    }
}
