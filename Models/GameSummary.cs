﻿namespace GameStore.Frontend.Models
{
    public class GameSummary
    {
        public int Id { get; set; }

        public required string Name { get; set; }// = string.Empty;
        
        public required string Genre { get; set; }

        public decimal Price { get; set; }

        public DateOnly ReleaseDate { get; set; }
    }
}
