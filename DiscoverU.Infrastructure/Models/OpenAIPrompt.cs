using OpenAI.ObjectModels.RequestModels;

namespace DiscoverU.Infrastructure.Models
{
    public class OpenAIPrompt
    {
        public string Message { get; set; }

        public static ChatMessage MapOpenAIPromptToChatMessages(OpenAIPrompt openAIPrompt)
        {
            if (openAIPrompt is null)
                return new ChatMessage();

            var chatMessage = new ChatMessage
            {
                Role = "user",
                Content = openAIPrompt.Message,
            };

            return chatMessage;
        }
    }
}
