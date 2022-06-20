using Music.Domain.Dto;
using Music.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Domain.IRepository
{
    public interface IMusicRepository
    {
        Task<IEnumerable<UserResponse>> GetAllUsers();
        Task<IEnumerable<SongResponse>> GetAllSongs();
        Task<IEnumerable<PlaylistResponse>> GetAllPlaylistsForUser(int userId);
        Task<IEnumerable<SongResponse>> GetAllSongsForPlaylist(int playlistId);
        Task<IEnumerable<PlaylistResponse>> GetAllPlaylistsForSong(int songId);
    }
}
