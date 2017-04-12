using FolderSync.DTO;
using FolderSync.Presenters;
using OSPSuite.Assets;
using OSPSuite.DataBinding;
using OSPSuite.DataBinding.DevExpress;
using OSPSuite.Presentation.Extensions;
using OSPSuite.Presentation.Views;
using OSPSuite.UI.Extensions;
using OSPSuite.UI.Views;

namespace FolderSync.Views
{
   public partial class Shell : BaseModalView, IShell
   {
      private IMainPresenter _presenter;
      private readonly ScreenBinder<FolderSyncDTO> _screenBinder;

      public Shell()
      {
         InitializeComponent();
         _screenBinder = new ScreenBinder<FolderSyncDTO>();
      }

      public override void InitializeResources()
      {
         base.InitializeResources();
         Caption = "Folder Sync Baby!!";
         Icon = ApplicationIcons.ConfigureAndRun;
         layoutItemSourceFolder.Text = "Source Folder".FormatForLabel();
         layoutItemTargetFolder.Text = "Target Folder".FormatForLabel();
         btnCancel.Text = "Abort Man";
         btnOk.Text = "Just Do It";
      }

      public void AttachPresenter(IMainPresenter presenter)
      {
         _presenter = presenter;
      }

      public override void InitializeBinding()
      {
         base.InitializeBinding();
         _screenBinder.Bind(x => x.SourceFolder)
            .To(sourceFolderButton);

         _screenBinder.Bind(x => x.TargetFolder)
            .To(targetFolderButton);

         RegisterValidationFor(_screenBinder);

         sourceFolderButton.ButtonClick += (o, e) => OnEvent(async () => await _presenter.SelectSourceFolder());
         targetFolderButton.ButtonClick += (o, e) => OnEvent(async () => await _presenter.SelectTargetFolder());
         btnOk.Click += (o, e) => OnEvent(async () => await _presenter.SynchronizeFolders());
         btnCancel.Click += (o,e)=> OnEvent(() => _presenter.Abort());
      }

      public void AddLogView(IView view)
      {
         panelLogView.FillWith(view);
      }

      public void BindTo(FolderSyncDTO folderSyncDTO)
      {
         _screenBinder.BindToSource(folderSyncDTO);
      }

      public override bool HasError => _screenBinder.HasError;
   }
}