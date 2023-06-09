using System;

public class Prompt 
{
    private List<string> _writingPrompt = new List<string> {
        "What is one thing that made you smile today?",
        "Write three things about the day.",
        "Write about something funny you saw or heard.",
        "What was the best part of the day?",
        "How do you want tomorrow to be different from today, and what will you do to accomplish that?"
    };
    private Random rnd = new Random();

    public string getPrompt() {

        return _writingPrompt[rnd.Next(_writingPrompt.Count)];
    }
    
    

}   