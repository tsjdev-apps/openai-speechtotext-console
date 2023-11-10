using System.Text.Json.Serialization;

namespace OpenAISTTConsole.Models;

/// <summary>
///     Represents a response of the transcription
///     request.
/// </summary>
internal class SpeechToTextResponse
{
    /// <summary>
    ///     The transcribed text of the audio file.
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; } = string.Empty;    
}
