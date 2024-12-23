﻿using System.ComponentModel.DataAnnotations;

public class LoginViewModel
{
    [Required]
    public string Login { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Haslo { get; set; }
}
