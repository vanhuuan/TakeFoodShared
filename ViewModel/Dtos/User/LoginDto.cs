﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TakeFoodShared.ViewModel.Dtos.User;

/// <summary>
/// Login DTO
/// </summary>
public class LoginDto
{
    /// <summary>
    /// User name is phoneNumber or Email
    /// </summary>
    [JsonPropertyName("userName")]
    [Required]
    public string UserName { get; set; }

    /// <summary>
    /// Password
    /// </summary>
    [JsonPropertyName("password")]
    [Required]
    public string Password { get; set; }
}
