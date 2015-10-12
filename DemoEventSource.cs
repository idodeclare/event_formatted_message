namespace DemoLogging
{
    using System;
    using System.Diagnostics.Tracing;

    /// <summary>
    /// Event Source to demonstrate changing in FormattedMessage
    /// </summary>
    [EventSource(Name = "Crimson-Mdm")]
    public class DemoEventSource : EventSource
    {
        private const string TestingFormattedMessageFmt =
            "Thread:{0} TranslateToManifestConvention escaped chars (leave off \\r, \\n): % & < > ' \" \t";

        /// <summary>
        /// TestingFormattedMessage with one {0} substitution and most of the specially escaped characters
        /// </summary>
        [Event(64512, Message = TestingFormattedMessageFmt,
            Level = EventLevel.Informational, Task = Tasks.DataAccess, Keywords = Keywords.Diagnostic)]
        public void TestingFormattedMessage(string threadId)
        {
            WriteEvent(EventIds.TestingFormattedMessageId, threadId);
        }

        public static class Keywords
        {
            /// <summary>
            /// Diagnostic keyword
            /// </summary>
            public const EventKeywords Diagnostic = (EventKeywords)1;
        }

        public static class Tasks
        {
            /// <summary>
            /// Data access task
            /// </summary>
            public const EventTask DataAccess = (EventTask)1;
        }

        public static class EventIds
        {
            /// <summary>
            /// TestingFormattedMessage EventId
            /// </summary>
            public const int TestingFormattedMessageId = 65536 - 1024;
        }
    }
}
