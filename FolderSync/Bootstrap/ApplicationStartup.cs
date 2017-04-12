using System.Threading;
using System.Windows.Forms;
using Castle.Facilities.TypedFactory;
using FolderSync.Presenters;
using FolderSync.Services;
using FolderSync.Views;
using OSPSuite.Core;
using OSPSuite.Core.Services;
using OSPSuite.Infrastructure.Container.Castle;
using OSPSuite.Presentation.Presenters;
using OSPSuite.Presentation.Services;
using OSPSuite.Presentation.Views;
using OSPSuite.UI.Mappers;
using OSPSuite.UI.Services;
using OSPSuite.UI.Views;
using OSPSuite.Utility.Container;
using OSPSuite.Utility.Events;
using OSPSuite.Utility.Exceptions;
using OSPSuite.Utility.Extensions;
using IShell = FolderSync.Views.IShell;

namespace FolderSync.Bootstrap
{
   public class ApplicationStartup
   {
      public static void Initialize()
      {
         new ApplicationStartup().InitializeForStartup();
      }

      public void InitializeForStartup()
      {
         var container = initializeContainer();
         registerAllInContainer(container);
      }

      private IContainer initializeContainer()
      {
         var container = new CastleWindsorContainer();
         IoC.InitializeWith(container);

         container.WindsorContainer.AddFacility<EventRegisterFacility>();

         //required to used abstract factory pattern with container
         container.WindsorContainer.AddFacility<TypedFactoryFacility>();

         //Register container into container to avoid any reference to dependency in code
         container.RegisterImplementationOf(container.DowncastTo<IContainer>());

         container.RegisterImplementationOf(getCurrentContext());
         return container;
      }

      private void registerAllInContainer(IContainer container)
      {
         container.Register<IMainPresenter, MainPresenter>();
         container.Register<IShell, Shell>();
         container.Register<IExceptionManager, ExceptionManager>(LifeStyle.Singleton);
         container.Register<IEventPublisher, EventPublisher>(LifeStyle.Singleton);
         container.Register<ILogView, LogView>();
         container.Register<ILogPresenter, LogPresenter>();
         container.Register<IDialogCreator, DialogCreator>();
         container.Register<IDialogResultToViewResultMapper, DialogResultToViewResultMapper>();
         container.Register<DirectoryMapSettings, DirectoryMapSettings>();
         container.Register<IApplicationConfiguration, ApplicationConfiguration>();
         container.Register<IExceptionView, ExceptionView>();
         container.Register<ILogger, Logger>();
      }

      private SynchronizationContext getCurrentContext()
      {
         var context = SynchronizationContext.Current;
         if (context == null)
         {
            context = new WindowsFormsSynchronizationContext();
            SynchronizationContext.SetSynchronizationContext(context);
         }
         return SynchronizationContext.Current;
      }
   }
}