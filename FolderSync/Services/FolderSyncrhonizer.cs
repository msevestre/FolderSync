using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using OSPSuite.Core.Services;

namespace FolderSync.Services
{
   public class FolderSyncrhonizer
   {
      private readonly ILogger _logger;
      private FolderInfo _sourceFolder;
      private FolderInfo _targetFolder;
      private readonly List<string> _filesToCopy = new List<string>();

      public FolderSyncrhonizer(ILogger logger)
      {
         _logger = logger;
      }

      public async Task ComputerOverview(string sourceFolder, string targetFolder, string filter = "*.*")
      {
         _sourceFolder = new FolderInfo(sourceFolder, filter);
         _targetFolder = new FolderInfo(targetFolder, filter);
         _filesToCopy.Clear();

         var tasks = new[] {_sourceFolder.ComputeFiles(), _targetFolder.ComputeFiles()};

         await Task.WhenAll(tasks);

         updateListOfFilesToCopy();
      }

      private void updateListOfFilesToCopy()
      {
         _filesToCopy.AddRange(_sourceFolder.Files.Where(f => !_targetFolder.Contains(f)));
      }

      public int SourceFolderCount => _sourceFolder.FileCount;
      public int TargetFolderCount => _targetFolder.FileCount;
      public int FilesToSyncCount => _filesToCopy.Count;

      public Task SynchronizeFiles(CancellationToken token)
      {
         return Task.Run(() =>
         {
            foreach (var file in _filesToCopy)
            {
               token.ThrowIfCancellationRequested();
               var sourceFile = Path.Combine(_sourceFolder.Folder, file);
               var targetFile = Path.Combine(_targetFolder.Folder, file);
               var targetPath = Path.GetDirectoryName(targetFile);
               Directory.CreateDirectory(targetPath);
               _logger.AddInfo($"Copying {file} to {_targetFolder.Folder}");
               File.Copy(sourceFile, targetFile);
            }
         }, token);
      }
   }
}