// See https://aka.ms/new-console-template for more information
record ActionItem
{
    public string Name { get; init; } = null!;
    public string Detail { get; init; } = null!;
    public string? SpeakText { get; init; }
    public TimeSpan? DelayTime { get; init; }
    public bool WaitForUser { get; init; }
    public int? RepeatCount { get; init; }
    public List<ActionItem> Items { get; init; } = new();


    public static ActionItem CreateDelay(int seconds, string? speakText = null, bool waitForUser = false)
    {
        return new ActionItem
        {
            DelayTime = TimeSpan.FromSeconds(seconds),
            SpeakText = speakText,
            Name = speakText ?? $"Delay {seconds}",
            WaitForUser = waitForUser,
        };
    }

    public static ActionItem Create(string speakText, bool waitForUser = false)
    {
        return new ActionItem
        {
            SpeakText = speakText,
            Name = speakText,
            WaitForUser = waitForUser,
        };
    }

    public static ActionItem CreateWaitForUser(int timeoutSeconds)
    {
        return new ActionItem
        {
            Name = $"Fin de rutina",
            DelayTime = TimeSpan.FromSeconds(timeoutSeconds),
            SpeakText = "Confirme fin de rutina",
            WaitForUser = true,
        };
    }
}
