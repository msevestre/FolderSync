using System;
using System.Windows.Forms;
using FolderSync.Bootstrap;
using FolderSync.Presenters;
using OSPSuite.Utility.Container;
using OSPSuite.Utility.Extensions;

namespace FolderSync
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);

         ApplicationStartup.Initialize();
         var mainPresenter = IoC.Resolve<IMainPresenter>();
         Application.Run(mainPresenter.BaseView.DowncastTo<Form>());
      }
   }
}
