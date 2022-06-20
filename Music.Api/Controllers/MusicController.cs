using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Music.Domain.IRepository;

namespace Music.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        private readonly IMusicRepository _rep;
        public MusicController(IMusicRepository rep)
        {
            _rep = rep;
        }
        [HttpGet]
        [Route("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var resp = await _rep.GetAllUsers();
            return Ok(resp);
        }
        [HttpGet]
        [Route("GetAllSongs")]
        public async Task<IActionResult> GetAllSongs()
        {
            var resp = await _rep.GetAllSongs();
            return Ok(resp);
        }
        [HttpGet]
        [Route("GetAllPlaylistsForUser/{userId}")]
        public async Task<IActionResult> GetAllPlaylistsForUser([FromRoute] int userId)
        {
            var resp = await _rep.GetAllPlaylistsForUser(userId);
            return Ok(resp);
        }
        [HttpGet]
        [Route("GetAllSongsForPlaylist/{playlistId}")]
        public async Task<IActionResult> GetAllSongsForPlaylist([FromRoute] int playlistId)
        {
            var resp = await _rep.GetAllSongsForPlaylist(playlistId);
            return Ok(resp);
        }
        [HttpGet]
        [Route("GetAllPlaylistsWithSong/{songId}")]
        public async Task<IActionResult> GetAllPlaylistsWithSong([FromRoute] int songId)
        {
            var resp = await _rep.GetAllPlaylistsForSong(songId);
            return Ok(resp);
        }
    }
}
