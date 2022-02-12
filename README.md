# Timer Pause
Timer Pause component for LiveSplit.

## What it is:

Timer Pause is a LiveSplit component that allows you to pause the timer and continue the run later, the next day for example. You can close LiveSplit freely without losing any progress. At the moment works only with empty splits, so perfect for long marathons, learning a brand new category or doing challenge runs.

## Installation:

1. Go to [Releases](https://github.com/ROFLailXGOD/TimerPause/releases) and download the latest version of `Vofel.TimerPause.dll`.
2. Place `Vofel.TimerPause.dll` into the `Components` directory of your LiveSplit installation.
3. Open LiveSplit. Right click -> Edit Layout -> [Giant "+" Button] -> Other -> Timer Pause
4. Enjoy! You don't need to configure anything.

## Usage:

Timer Pause uses the default LiveSplit actions (Split, Skip Split, Pause, etc.). You can configure them with: Right click -> Settings. 

Assume you have empty splits. Start the run and continue normally. Every split you make during the run is saved as "Segment Time". When you need to stop pause the timer. That action saves the current time and puts it in the "Start Timer at:". Now you can close LiveSplit completely (don't forget to save splits).

When you're ready to continue simply start the timer again. It should automatically move to the correct split without losing any previous times. You can pause and continue the run as many times as you want.
