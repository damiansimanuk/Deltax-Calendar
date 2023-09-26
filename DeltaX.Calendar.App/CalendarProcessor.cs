// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using System.Runtime.Versioning;
using System.Speech.Synthesis;

[SupportedOSPlatform("windows")]
class CalendarProcessor
{
    private readonly SpeechSynthesizer speech = new();

    public void Speak(string text)
    {
        Console.WriteLine(text);
        // speech.Speak(text);
    }

    public async Task<TimeSpan> Run(List<ActionItem> actions)
    {
        var tStart = DateTime.Now;
        foreach (var action in actions)
        {
            Console.WriteLine(action.Name ?? action.SpeakText ?? "-");
            // Console.Beep();

            if (action.DelayTime.HasValue && action.DelayTime > TimeSpan.FromSeconds(0))
            {
                await Task.Delay(action.DelayTime.Value);
            }

            if (!string.IsNullOrWhiteSpace(action.SpeakText))
            {
                // speech.Speak(action.SpeakText);
            }

            if (action.WaitForUser)
            {
                Console.Beep();
                Console.WriteLine("Waiting user");
                Console.ReadKey();
            }

            var repeatCount = action.RepeatCount ?? 1;
            while (action.Items.Any() && repeatCount-- > 0)
            {
                await Run(action.Items);
            }
        }

        return DateTime.Now - tStart;
    }
}
