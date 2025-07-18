﻿using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients
{
    public class GamesClient(HttpClient httpClient)
    {

        public async Task<GameSummary[]> GetGamesAsync()
            => await httpClient.GetFromJsonAsync<GameSummary[]>("games") ?? [];

        public async Task AddGameAsync(GameDetails game)
            => await httpClient.PostAsJsonAsync("games", game);

        public async Task UpdateGameAsync(GameDetails updatedGame)
            => await httpClient.PutAsJsonAsync($"games/{updatedGame.Id}", updatedGame);

        public async Task<GameDetails> GetGameAsync(int id)
            => await httpClient.GetFromJsonAsync<GameDetails>($"games/{id}") ?? throw new Exception("Could not find game!");

        //public GameSummary[] DeleteGame(int id)
        //{
        //    var result = (from game in games where game.Id != id select game).ToArray();

        //    return result;
        //}
        public async Task DeleteGameAsync(int id)
            => await httpClient.DeleteAsync($"games/{id}");



    }
}
