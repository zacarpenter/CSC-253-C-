using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Album album1 = new Album("Tell All Your Friends");
            album1.Artist = "Taking Back Sunday";
            album1.Genre = "Alternative Rock";
            album1.CopiesSold = 900000;
            album1.CostOfAlbum();
            Console.WriteLine(album1.AlbumInfo());

            Album album2 = new Album("Suburbia I've Given You All and Now I'm Nothing");
            album2.Artist = "The Wonder Years";
            album2.Genre = "Rock";
            album2.CopiesSold = 450000;
            album2.CostOfAlbum();
            Console.WriteLine(album2.AlbumInfo());

            Album album3 = new Album("Listen and Forgive");
            album3.Artist = "Transit";
            album3.Genre = "Rock";
            album3.CopiesSold = 275000;
            album3.CostOfAlbum();
            Console.WriteLine(album3.AlbumInfo());

            // pause
            Console.ReadLine();

        } // end main
    } // end class

    // create Album class
    class Album
    {
        // properties
        private string title;
        private string artist;
        private string genre;
        private int copiesSold;

        // constructor
        public Album(string title)
        {
            this.title = title;
        }

        // setters and getters

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        
        public int CopiesSold
        {
            get { return copiesSold; }
            set { copiesSold = value; }
        }

        public int CostOfAlbum()
        {
            int costOfAlbum = 10;
            copiesSold *= costOfAlbum;
            return copiesSold;
        }

        public string AlbumInfo()
        {
            return "The album " + title + " by " + artist + ", a " + genre + " group, made $" + copiesSold.ToString();
        }

    } // end Album

} // end namespace
