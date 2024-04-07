using Microsoft.AspNetCore.Mvc;
using VideoGamesManager.DataLayer.Entities;
using VideoGamesManager.DataLayer.Repositories;

namespace VideoGamesManager.BusinessLayer
{
    public class VideoGameService
    {

        public List<VideoGame> GetAllVideoGame()
        {
            var videoRepo = new VideoGameRepository();
            var videogame = videoRepo.GetAllVideoGame();
            return videogame;
        }

        public VideoGame VideoGameById(int id)
        {
            var gamesRepository = new VideoGameRepository();
            var videogame = gamesRepository.GetAllVideoGame();
            var videogameid = gamesRepository.GetAllVideoGame()
                                        .Where(p => p.ID == id)
                                         .FirstOrDefault();
            return videogameid;

        }

        public void AddVideoGame(VideoGame videoGame)
        {
            var gamesRepository = new VideoGameRepository();
            gamesRepository.AddVideoGame(videoGame);

        }

        public void DeleteVideoGame(VideoGame videoGame)
        {
            var gamesRepository = new VideoGameRepository();
            gamesRepository.DeleteVideoGame(videoGame);
        }

        public void UpdateVideoGame(VideoGame videoGame)
        {
            var gamesRepository = new VideoGameRepository();
            gamesRepository.UpdateVideoGame(videoGame);
        }

        public VideoGame FilterVideoGame(int id,string name, int size, string studio)
        {
            var gamesRepository = new VideoGameRepository();
            var videogame = gamesRepository.GetAllVideoGame();
            var videogameid = gamesRepository.GetAllVideoGame()
                                        .Where(p => p.ID == id)
                                         .FirstOrDefault();
            return videogameid;

        }

        public List<VideoGame> FilterVideoGame([FromQuery] string? name, [FromQuery] int? size, [FromQuery] string? studio)
        {
            var gamesRepository = new VideoGameRepository();
            var videogame = gamesRepository.GetAllVideoGame();
            if (!string.IsNullOrEmpty(name))
            {
                videogame = videogame.Where(p => p.Name.Contains(name))
                   .ToList();
            }
            if (size != 0 && size != null)
            {
                videogame = videogame.Where(p => p.Size == size).ToList();
            }
            if (!string.IsNullOrEmpty(studio))
            {
                videogame = videogame.Where(p => p.Studio.Contains(studio))
                   .ToList();
            }
            return videogame;
        }
    }
}