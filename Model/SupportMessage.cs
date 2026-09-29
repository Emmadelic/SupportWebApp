using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace SupportWebApp.Models;

public class SupportMessage
{
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [JsonProperty(PropertyName = "navn")]
    [Required(ErrorMessage = "Navn er påkrævet.")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty(PropertyName = "email")]
    [Required(ErrorMessage = "Email er påkrævet.")]
    [EmailAddress(ErrorMessage = "Indtast en gyldig emailadresse.")]
    public string Email { get; set; } = string.Empty;

    [JsonProperty(PropertyName = "telefon")]
    [Required(ErrorMessage = "Telefonnummer er påkrævet.")]
    public string Phone { get; set; } = string.Empty;

    [JsonProperty(PropertyName = "beskrivelse")]
    [Required(ErrorMessage = "Beskrivelse er påkrævet.")]
    public string Description { get; set; } = string.Empty;

    [JsonProperty(PropertyName = "category")]
    [Required(ErrorMessage = "Kategori er påkrævet.")]
    public string Category { get; set; } = string.Empty;

    [JsonProperty(PropertyName = "tidspunkt")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}