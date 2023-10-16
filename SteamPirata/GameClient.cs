using GameStore.Client.Models;

namespace GameStore.Client;

public static class GameClient
{
    private static readonly List<Game> games = new()
    {
        new Game()
        {
            Id = 1,
            Name = "Metro Exodus",
            Genre = "FPS",
            Price = 59.99M,
            ReleaseDate = new DateTime(2019, 4, 1)
        },
        new Game()
        {
            Id = 2,
            Name = "Hollow Knight",
            Genre = "Adventure",
            Price = 39.99M,
            ReleaseDate =
            new DateTime(2010, 9, 30)
        },
        new Game()
        {
            Id = 3,
            Name = "Deep Rock Galactic",
            Genre = "FPS",
            Price = 49.99M,
            ReleaseDate = new DateTime(2022, 9, 27)
        }
    };

    public static Game[] GetGames()
    {
        return games.ToArray();
    }

    public static void AddGame(Game game)
    {
        game.Id = games.Max(game => game.Id + 1);
        games.Add(game);
    }

    public static Game GetGame(int id)
    {
        return games.Find(game => game.Id == id) ?? throw new Exception("¡No pudimos encontrar el juego!");
    }

    public static void UpdateGame(Game updatedGame)
    {
        Game existingGame = GetGame(updatedGame.Id);
        existingGame.Name = updatedGame.Name;
        existingGame.Genre = updatedGame.Genre;
        existingGame.Price = updatedGame.Price;
        existingGame.ReleaseDate = updatedGame.ReleaseDate;
    }

    public static void DeleteGame(int id)
    {
        Game game = GetGame(id);
        games.Remove(game);
    }
}