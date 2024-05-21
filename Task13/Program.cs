
using System;
namespace Task13
{


    public static class Program
    {
        public static void Main()
        {
            PlayList spotify = new PlayList();
            Song fairyTale = new Song("FairyTale","Alexander",new TimeSpan(3,3,5),MusicGenre.Classical);
            Song anotherLove = new Song("FairyTale", "Tom Odell", new TimeSpan(9, 0, 0), MusicGenre.Pop);
            spotify.Add(fairyTale);
            spotify.Add(anotherLove);
            spotify.GetAll();
            spotify.GetAllProductsByType(MusicGenre.Pop);
            Console.ReadLine();



        }
    }

}