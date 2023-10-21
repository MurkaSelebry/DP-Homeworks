using System;

namespace Proxy
{

    public interface IPlayable
    {
        void Play(int age);
    }

    class Movie : IPlayable
    {
        public void Play(int age)
        {
            Console.WriteLine($"Вы достигли возраста:{age}.\nПриятного просмотра!");
        }
    }

    class MovieProxy : IPlayable
    {
        private Movie realSubject;

        public MovieProxy(Movie realSubject)
        {
            this.realSubject = realSubject;
        }

        public void Play(int age)
        {
            if (this.CheckAccess(age))
                realSubject.Play(age);
            else
                Console.WriteLine("Вы не допущены к просмотру фильма, вы не достигли 18 летнего возраста!");


        }

        public bool CheckAccess(int age)
        {
            Console.WriteLine("Проверка возраста!");
            return age >= 18 ? true : false;
        }

    }

    public class Client
    {
        public int Age { get; set; }

        public void ClientCode(IPlayable subject)
        {
            subject.Play(Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Age = 19;
            Console.WriteLine("Проверка 18+ лет");
            MovieProxy proxy = new MovieProxy(new Movie());
            client.ClientCode(proxy);
            Console.WriteLine("Проверка <18 лет");
            client.Age = 17;
            MovieProxy proxy1 = new MovieProxy(new Movie());
            client.ClientCode(proxy1);
        }
    }
}