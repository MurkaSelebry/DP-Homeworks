using System;

class ChatBot
{
    public Handler FirstHandler { get; set; }

 
    public void ProcessRequest(string message)
    {
        if (FirstHandler != null)
        {
            FirstHandler.HandleRequest(message);
        }
    }
}

abstract class Handler
{
    public Handler Successor { get; set; }


    public abstract void HandleRequest(string message);
}

class GreetingHandler : Handler
{
    public override void HandleRequest(string message)
    {
        if (message.ToLower().Contains("привет"))
        {
            Console.WriteLine("Б: Привет! Я бот-болтун. Умею разговаривать на любые темы.");
        }
        else if (Successor != null)
        {
            Successor.HandleRequest(message);
        }
    }
}

class PhilosophicalQuestionHandler : Handler
{
    public override void HandleRequest(string message)
    {
        if (message.ToLower().Contains("iphone") || message.ToLower().Contains("андроид"))
        {
            Console.WriteLine("Б: Это очень философский вопрос...");
        }
        else if (Successor != null)
        {
            Successor.HandleRequest(message);
        }
    }
}

class Program
{
    static void Main()
    {
        ChatBot bot = new ChatBot();
        Handler greetingHandler = new GreetingHandler();
        Handler philosophicalQuestionHandler = new PhilosophicalQuestionHandler();

        bot.FirstHandler = greetingHandler;
        greetingHandler.Successor = philosophicalQuestionHandler;

        while (true)
        {
            Console.Write("П: ");
            bot.ProcessRequest(Console.ReadLine());
        }
    }
}
