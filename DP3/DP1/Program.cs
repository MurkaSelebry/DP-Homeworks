// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
interface IMessageSender
{
    public void SendMessageContent(string title, string body) => Console.WriteLine($"{title}\n{body}");
    public void SendMessage(string title, string body);
}
public class VK : IMessageSender
{
    public void SendMessage(string title, string body)
    {
        Console.WriteLine("VK");
        ((IMessageSender)this).SendMessageContent(title, body);
    }
}
public class Odnoklassniki : IMessageSender
{
    public void SendMessage(string title, string body)
    {
        Console.WriteLine("Odnoklassniki");
        ((IMessageSender)this).SendMessageContent(title, body);
    }
}
public class Facebook : IMessageSender
{
    public void SendMessage(string title, string body)
    {
        Console.WriteLine("Facebook");
        ((IMessageSender)this).SendMessageContent(title, body);
    }
}
public class Instagram : IMessageSender
{
    public void SendMessage(string title, string body)
    {
        Console.WriteLine("Instagram");
        ((IMessageSender)this).SendMessageContent(title, body);
    }
}

public class Mailing
{
    List<IMessageSender> SocialNetworks = new();

    public Mailing(VK vk, Odnoklassniki ok, Facebook fb, Instagram ig)
    {
        SocialNetworks.AddRange(new IMessageSender[] { vk, ok, fb, ig });
    }
    public void SendMessage(string title, string body)
    {
        foreach (var sn in SocialNetworks)
        {
            sn.SendMessage(title, body);
        }
    }
}

class TestMailing
{
    public static void Main()
    {
        Mailing mailing = new Mailing(new VK(), new Odnoklassniki(), new Facebook(), new Instagram());
        mailing.SendMessage("hello", "yes");
    }
}