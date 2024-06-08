using DiscoverU.Application.Dtos.OpenAIDto;
using Microsoft.AspNetCore.Mvc;
using OpenAI.Interfaces;
using OpenAI.ObjectModels.RequestModels;

namespace DiscoverU.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenAIController : ControllerBase
    {
        private IOpenAIService _openAIService;

        public OpenAIController(IOpenAIService openAIService)
        {
            _openAIService = openAIService ?? throw new ArgumentNullException(nameof(openAIService));

        }

        [HttpPost("[action]")]
        public async Task<string> AddAsync(OpenAIPrompt openAIPrompt)
        {
            
            var chatMessage = MapOpenAIPromptToChatMessages(openAIPrompt);
             List<ChatMessage> chatMessages = new List<ChatMessage>();

            chatMessages.Add(chatMessage);
            var completionResult = await _openAIService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
            {
                Messages = chatMessages,
                Model = "gpt-3.5-turbo",
                MaxTokens = 4000
            });
            
                //Console.WriteLine(completionResult.Choices.First().Message.Content);

                var receivedMessage = completionResult.Choices.First().Message.Content;
                return receivedMessage;           
        }

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
