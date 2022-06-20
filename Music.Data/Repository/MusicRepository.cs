using Music.Domain.Dto;
using Music.Domain.IRepository;
using Music.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Data.Repository
{
    public class MusicRepository : IMusicRepository
    {
        private readonly Data _dataReader = new Data();
        public async Task<IEnumerable<PlaylistResponse>> GetAllPlaylistsForSong(int songId)
        {
            var response = new List<PlaylistResponse>();
            var playlists = _dataReader.Playlists.Where(x => x.SongsIds.Contains(songId)).ToList();

            foreach (var play in playlists)
            {
                var pl = new PlaylistResponse()
                {
                    Id = play.Id,
                    Name = play.Name,
                    Songs = _dataReader.Songs.Where(x => x.PlaylistsPartOfIds.Contains(play.Id)).ToList()
                };
                response.Add(pl);
            }

            return response;
        }

        public async Task<IEnumerable<PlaylistResponse>> GetAllPlaylistsForUser(int userId)
        {
            var data = _dataReader.Users.ToList();
            var response = new List<PlaylistResponse>();
            var playlistIds = _dataReader.Users.FirstOrDefault(x => x.Id == userId).PlaylistIds.ToList();

            foreach (int playId in playlistIds)
            {
                var playlist = _dataReader.Playlists.FirstOrDefault(x => x.Id == playId);
                var pl = new PlaylistResponse()
                {
                    Id = playId,
                    Name = playlist.Name,
                    Songs = _dataReader.Songs.Where(x => x.PlaylistsPartOfIds.Contains(playId)).ToList()
                };
                response.Add(pl);
            }

            return response;
        }

        public async Task<IEnumerable<SongResponse>> GetAllSongs()
        {
            var data = _dataReader.Songs.ToList();
            var response = new List<SongResponse>();
            foreach (var song in data)
            {
                response.Add(new SongResponse()
                {
                    Artist = song.Artist,
                    Id = song.Id,
                    Name = song.Name,
                    PlaylistsPartOf = _dataReader.Playlists.Where(x => x.SongsIds.Contains(song.Id)).ToList()
                });
            }
            return response;
        }

        public async Task<IEnumerable<SongResponse>> GetAllSongsForPlaylist(int playlistId)
        {
            var data = _dataReader.Songs.ToList();
            var response = new List<SongResponse>();
            foreach (var song in data)
            {
                if (song.PlaylistsPartOfIds.Contains(playlistId))
                {
                    response.Add(new SongResponse()
                    {
                        Artist = song.Artist,
                        Id = song.Id,
                        Name = song.Name,
                        PlaylistsPartOf = _dataReader.Playlists.Where(x => x.SongsIds.Contains(song.Id)).ToList()
                    });
                }
            }
            return response;
        }

        public async Task<IEnumerable<UserResponse>> GetAllUsers()
        {
            var data = _dataReader.Users.ToList();
            var response = new List<UserResponse>();
            foreach (var user in data)
            {
                var us = new UserResponse()
                {
                    Age = user.Age,
                    Id = user.Id,
                    Name = user.Name
                };
                us.Playlist = new List<Playlist>();
                foreach (int playId in user.PlaylistIds)
                {
                    us.Playlist.Add(_dataReader.Playlists.FirstOrDefault(x => x.Id == playId));
                }

                response.Add(us);

            }
            return response;
        }
    }
}
