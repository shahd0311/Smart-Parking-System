using System.Text.Json.Serialization;

namespace Smart_Parking_Garage.Contracts.Chatbot;

public class AiChatRequest
{
    [JsonPropertyName("user_id")]
    public string UserId { get; set; } = string.Empty;

    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;
}
