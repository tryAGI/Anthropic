
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.AnyOf<string, global::Anthropic.CreateMessageRequestModel>? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.Message>? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.CreateMessageRequestMetadata? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string?>? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ToolChoice? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.Tool>? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ToolChoiceType? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.OneOf<string, global::System.Collections.Generic.IList<global::Anthropic.Block>>? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.MessageRole? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.StopReason? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.Usage? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ImageBlockSource? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ImageBlockSourceMediaType? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ImageBlockSourceType? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.Message? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.MessageStreamEventType? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.MessageDelta? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.MessageDeltaUsage? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.OneOf<global::Anthropic.TextBlock?, global::Anthropic.ImageBlock?, global::Anthropic.ToolUseBlock?, global::Anthropic.ToolResultBlock?>? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.OneOf<global::Anthropic.TextBlockDelta?, global::Anthropic.InputJsonBlockDelta?>? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.CreateMessageRequest? Type25 { get; set; }
    }
}