﻿namespace LevvaCoinAPI.Logic.Dto
{
    public class LoginDto
    {
        public string Email { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }
        public string? Token { get; set; }
        public string? Username { get; set; }
    }
}