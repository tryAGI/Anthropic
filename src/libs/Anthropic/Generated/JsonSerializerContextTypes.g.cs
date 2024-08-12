
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
        public global::Anthropic.CreateMessageRequest? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.AnyOf<string?, global::Anthropic.CreateMessageRequestModel?>? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.CreateMessageRequestModel? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.Message>? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.Message? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.OneOf<string?, global::System.Collections.Generic.IList<global::Anthropic.Block>?>? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.Block>? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.Block? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.TextBlock? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ImageBlock? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ImageBlockSource? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ImageBlockSourceMediaType? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ImageBlockSourceType? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ToolUseBlock? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ToolUseBlockInput? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ToolResultBlock? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.MessageRole? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.StopReason? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.Usage? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.CreateMessageRequestMetadata? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ToolChoice? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ToolChoiceType? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.Tool>? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.Tool? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ToolInputSchema? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.MessageStreamEvent? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.MessageStartEvent? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.MessageStreamEventType? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.MessageDeltaEvent? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.MessageDelta? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.MessageDeltaUsage? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.MessageStopEvent? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ContentBlockStartEvent? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ContentBlockDeltaEvent? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BlockDelta? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.TextBlockDelta? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.InputJsonBlockDelta? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ContentBlockStopEvent? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.PingEvent? Type43 { get; set; }
    }
}