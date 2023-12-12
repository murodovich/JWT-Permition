﻿namespace JWT.Domain.Dtos;
public class RegistrDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public List<int> Roles { get; set; }
}