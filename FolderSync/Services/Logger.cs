using System.Collections.Generic;
using OSPSuite.Core.Domain;
using OSPSuite.Core.Events;
using OSPSuite.Core.Services;
using OSPSuite.Utility.Events;

namespace FolderSync.Services
{
   public class Logger : ILogger
   {
      private readonly IEventPublisher _eventPublisher;
      private readonly IList<string> _entries;

      public Logger(IEventPublisher eventPublisher)
      {
         _entries = new List<string>();
         _eventPublisher = eventPublisher;
      }

      public void AddToLog(string message, NotificationType messageStatus = NotificationType.None)
      {
         var logEntry = new LogEntry(messageStatus, message);
         _entries.Add(logEntry.Display);
         _eventPublisher.PublishEvent(new LogEntryEvent(logEntry));
      }
   }
}