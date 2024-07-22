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