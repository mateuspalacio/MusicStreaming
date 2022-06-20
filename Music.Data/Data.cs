using Music.Domain.Models;

namespace Music.Data
{
    public class Data
    {
        public List<Song> Songs { get; } = new List<Song>()
            {
                new Song(){Id = 0, Artist = "The Weeknd", Name = "Blinding Lights", PlaylistsPartOfIds = new List<int>(){0, 2}},
                new Song(){Id = 1, Artist = "Queen", Name = "Bohemian Rhapsody", PlaylistsPartOfIds = new List<int>(){0}},
                new Song(){Id = 2, Artist = "Oasis", Name = "Wonderwall", PlaylistsPartOfIds = new List<int>(){0, 1, 2, 4}},
                new Song(){Id = 3, Artist = "Red Hot Chili Peppers", Name = "Californication", PlaylistsPartOfIds = new List<int>(){0, 1, 3}},
                new Song(){Id = 4, Artist = "Lil Nas X", Name = "THATS WHAT I WANT", PlaylistsPartOfIds = new List<int>(){0, 1, 4}},
                new Song(){Id = 5, Artist = "Lagum", Name = "Fifa", PlaylistsPartOfIds = new List<int>(){0}},
                new Song(){Id = 6, Artist = "Post Malone", Name = "Circles", PlaylistsPartOfIds = new List<int>(){0, 2}},
                new Song(){Id = 7, Artist = "Niall Horan", Name = "Put A Little Love On Me", PlaylistsPartOfIds = new List<int>(){0, 3, 4}},
                new Song(){Id = 8, Artist = "One Direction", Name = "One Thing", PlaylistsPartOfIds = new List<int>(){0, 3, 4}},
                new Song(){Id = 9, Artist = "Harry Styles", Name = "Sweet Creature", PlaylistsPartOfIds = new List<int>(){0, 3, 4}},
                new Song(){Id = 10, Artist = "Louis Tomlinson", Name = "Two Of Us", PlaylistsPartOfIds = new List<int>(){0, 3, 4}}
            };
        public List<User> Users { get; } = new List<User>()
        {
            new User(){Id = 0, Name = "Steve", Age = 21, PlaylistIds = new List<int>(){ 0, 4} },
            new User(){Id = 1, Name = "Luiz", Age = 22, PlaylistIds = new List<int>(){ 1, 2}},
            new User(){Id = 2, Name = "Klay", Age = 30, PlaylistIds = new List<int>(){ 0, 2}},
            new User(){Id = 3, Name = "Robert", Age = 57, PlaylistIds = new List<int>(){ 3, 4}},
        };
        public List<Playlist> Playlists { get; } = new List<Playlist>()
        {
            new Playlist(){Id = 0, Name = "Mix of good songs", SongsIds = new List<int>(){0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10} },
            new Playlist(){Id = 1, Name = "Luiz rocks", SongsIds = new List<int>(){2, 3, 4} },
            new Playlist(){Id = 2, Name = "Klaymen", SongsIds = new List<int>(){0, 2, 6} },
            new Playlist(){Id = 3, Name = "Iron Robert", SongsIds = new List<int>(){2, 3, 7, 8, 9, 10} },
            new Playlist(){Id = 4, Name = "Steve's tunes", SongsIds = new List<int>(){ 4, 7, 8, 9, 10} }
        };
    }
}