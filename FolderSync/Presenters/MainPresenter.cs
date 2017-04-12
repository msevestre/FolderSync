using System;
using System.Threading;
using System.Threading.Tasks;
using FolderSync.DTO;
using FolderSync.Services;
using FolderSync.Views;
using OSPSuite.Core.Domain;
using OSPSuite.Core.Extensions;
using OSPSuite.Core.Services;
using OSPSuite.Presentation.Presenters;
using OSPSuite.Utility.Extensions;
using OSPSuite.Utility.Validation;

namespace FolderSync.Presenters
{
   public interface IMainPresenter : IDisposablePresenter
   {
      Task SelectSourceFolder();
      Task SelectTargetFolder();
      Task SynchronizeFolders();
      void Abort();
   }

   public class MainPresenter : AbstractDisposablePresenter<IShell, IMainPresenter>, IMainPresenter
   {
      private readonly ILogPresenter _logPresenter;
      private readonly IDialogCreator _dialogCreator;
      private readonly ILogger _logger;
      private readonly FolderSyncDTO _folderSyncDTO = new FolderSyncDTO();
      private readonly FolderSyncrhonizer _folderSynchronizer;
      private CancellationTokenSource _cancellationTokenSource;
      private bool _overviewComputed;

      public MainPresenter(IShell view, ILogPresenter logPresenter, IDialogCreator dialogCreator, ILogger logger) : base(view)
      {
         _logPresenter = logPresenter;
         _dialogCreator = dialogCreator;
         _logger = logger;
         _view.AddLogView(logPresenter.View);
         _view.BindTo(_folderSyncDTO);
         _folderSynchronizer = new FolderSyncrhonizer(logger);
         _overviewComputed = false;
      }

      public async Task SelectSourceFolder()
      {
         string sourceFolder = _dialogCreator.AskForFolder("Select source folder where files to copy are located", Constants.DirectoryKey.PROJECT);
         if (string.IsNullOrEmpty(sourceFolder))
            return;
         _folderSyncDTO.SourceFolder = sourceFolder;
         await computeOverview();
      }

      private async Task computeOverview()
      {
         if (_overviewComputed)
            return;

         _logPresenter.ClearLog();
         if (!_folderSyncDTO.IsValid())
            return;

         await _folderSynchronizer.ComputerOverview(_folderSyncDTO.SourceFolder, _folderSyncDTO.TargetFolder);

         _logger.AddInfo($"Number of files in source folder: {_folderSynchronizer.SourceFolderCount}");
         _logger.AddInfo($"Number of files in target folder: {_folderSynchronizer.TargetFolderCount}");
         _logger.AddInfo($"Number of files to synchronize: {_folderSynchronizer.FilesToSyncCount}");

         _overviewComputed = true;
      }

      public async Task SelectTargetFolder()
      {
         string targetFolder = _dialogCreator.AskForFolder("Select target folder where new files will be copied", Constants.DirectoryKey.PROJECT);
         if (string.IsNullOrEmpty(targetFolder))
            return;

         _folderSyncDTO.TargetFolder = targetFolder;
         await computeOverview();
      }

      public async Task SynchronizeFolders()
      {
         _cancellationTokenSource = new CancellationTokenSource();

         await computeOverview();

         _logger.AddInSeparator($"Starting synchronization for {_folderSynchronizer.FilesToSyncCount} files: {DateTime.Now.ToIsoFormat()}");
         var begin = DateTime.UtcNow;

         try
         {
            await _folderSynchronizer.SynchronizeFiles(_cancellationTokenSource.Token);
            var end = DateTime.UtcNow;
            var timeSpent = end - begin;

            _logger.AddInSeparator($"Finished synchronizing {_folderSynchronizer.FilesToSyncCount} files in {timeSpent.ToDisplay()}'");
         }
         catch (OperationCanceledException)
         {
            _logger.AddInSeparator("Operation aborted");
         }
         catch (Exception e)
         {
            _logger.AddError($"{e.FullMessage()}\n{e.FullStackTrace()}");
         }
         finally
         {
            _overviewComputed = false;
         }
      }

      public void Abort()
      {
         _cancellationTokenSource?.Cancel();
      }
   }
}