using Smart_Parking_Garage.Contracts.Chatbot;
using System.Text.Json;

namespace Smart_Parking_Garage.Services;

public class AiChatService
{
    private readonly HttpClient _httpClient;

    public AiChatService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string?> SendAsync(string userId, string message)
    {
        var request = new AiChatRequest
        {
            UserId = userId,
            Message = message
        };

        var response = await _httpClient.PostAsJsonAsync(
            "https://polanaeem.pythonanywhere.com/chat",
            request
        );

        var rawResponse = await response.Content.ReadAsStringAsync();

        Console.WriteLine("RAW AI RESPONSE:");
        Console.WriteLine(rawResponse);

        if (!response.IsSuccessStatusCode)
            throw new Exception("AI ERROR: " + rawResponse);

        var aiResponse =
            JsonSerializer.Deserialize<AiChatResponse>(rawResponse);

        return aiResponse?.Response;
    }
}
