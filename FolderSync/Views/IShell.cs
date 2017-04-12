using FolderSync.DTO;
using FolderSync.Presenters;
using OSPSuite.Presentation.Views;

namespace FolderSync.Views
{
   public interface IShell : IView<IMainPresenter>
   {
      void AddLogView(IView view);
      void BindTo(FolderSyncDTO folderSyncDTO);
   }
}