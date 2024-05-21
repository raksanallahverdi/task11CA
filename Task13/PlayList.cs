using System;
namespace Task13
{
	public class PlayList
	{
		private Song[] playlist;
        public Song[] Playlist { get=>playlist;}
		public PlayList()
		{
            playlist = new Song[0];
        }

		public void Add(Song song)
		{
			Array.Resize(ref playlist, playlist.Length + 1);
			playlist[playlist.Length - 1] = song;

		}

		public void GetAll()
		{
			foreach(var song in playlist)
			{
				song.GetDetails();
			}
		}

        public void GetAllProductsByType(MusicGenre requiredGenre)
		{
            foreach (var song in playlist)
            {
                if (requiredGenre== song.Genre)
				{
                    song.GetDetails();

                }
            }

        }
    }
}

