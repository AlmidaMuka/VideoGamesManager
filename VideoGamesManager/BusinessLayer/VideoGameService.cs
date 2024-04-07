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
    }
}