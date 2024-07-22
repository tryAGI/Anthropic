// namespace Anthropic.IntegrationTests;
//
// public partial class Tests
// {
//     [TestMethod]
//     //[Ignore]
//     public async Task SimpleMethod()
//     {
//         var messages = new List<Message>
//         {
//             "You are a helpful weather assistant.",
//             "What is the current temperature in Dubai, UAE in Celsius?",
//         };
//         var model = CreateMessageRequestModel.Claude35Sonnet20240620;
//
//         try
//         {
//             using var api = GetAuthorizedApi();
//             var service = new WeatherService();
//             var tools = service.AsTools();
//             var result = await api.CreateMessageAsync(
//                 model: model,
//                 messages,
//                 maxTokens: 300,
//                 tools: tools);
//             var resultMessage = result.Content.Value2.First().Text;
//             messages.Add(resultMessage.AsRequestMessage());
//
//             if (resultMessage.ToolCalls == null ||
//                 resultMessage.ToolCalls.Count == 0)
//             {
//                 throw new InvalidOperationException("Expected a function call.");
//             }
//
//             foreach (var call in resultMessage.ToolCalls)
//             {
//                 var json = await service.CallAsync(
//                     functionName: call.Function.Name,
//                     argumentsAsJson: call.Function.Arguments);
//                 messages.Add(json.AsToolMessage(call.Id));
//             }
//
//             result = await api.Chat.CreateChatCompletionAsync(
//                 messages,
//                 model: model,
//                 tools: tools);
//             resultMessage = result.Choices.First().Message;
//             messages.Add(resultMessage.AsRequestMessage());
//         }
//         finally
//         {
//             PrintMessages(messages);
//         }
//     }
//
//     private static void PrintMessages(List<Message> messages)
//     {
//         foreach (var message in messages)
//         {
//             if (message.IsTool)
//             {
//                 Console.WriteLine($"> {message.Tool.Role}({message.Tool.ToolCallId}):");
//                 Console.WriteLine($"{message.Tool.Content}");
//             }
//             else if (message.IsSystem)
//             {
//                 Console.WriteLine($"> {message.System.Role}: {message.System.Name}");
//                 Console.WriteLine($"{message.System.Content}");
//             }
//             else if (message.IsUser)
//             {
//                 Console.WriteLine($"> {message.User.Role}: {message.User.Name}");
//                 Console.WriteLine($"{message.User.Content.Object}");
//             }
//             else if (message.IsAssistant)
//             {
//                 Console.WriteLine($"> {message.Assistant.Role}: {message.Assistant.Name}");
//                 foreach (var call in message.Assistant.ToolCalls ?? Enumerable.Empty<ChatCompletionMessageToolCall>())
//                 {
//                     Console.WriteLine($"{call.Id}:");
//                     Console.WriteLine($"{call.Function.Name}({call.Function.Arguments})");
//                 }
//                 if (!string.IsNullOrWhiteSpace(message.Assistant.Content))
//                 {
//                     Console.WriteLine($"{message.Assistant.Content}");
//                 }
//             }
//         }
//     }
//
//     [TestMethod]
//     public async Task Call()
//     {
//         var json = /* lang=json */ """
//                                    {
//                                        "location": "Dubai, UAE"
//                                    }
//                                    """;
//         var result = new WeatherService().CallGetCurrentWeather(json);
//
//         result.Should().Be( /* lang=json */ """
//                                             {"location":"Dubai, UAE","temperature":22,"unit":"celsius","description":"Sunny"}
//                                             """);
//
//         var result2 = await new WeatherService().CallAsync("GetCurrentWeather", json);
//         result2.Should().Be( /* lang=json */ """
//                                              {"location":"Dubai, UAE","temperature":22,"unit":"celsius","description":"Sunny"}
//                                              """);
//     }
// }