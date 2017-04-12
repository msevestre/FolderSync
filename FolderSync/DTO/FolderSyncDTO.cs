using OSPSuite.Core.Domain;
using OSPSuite.Presentation.DTO;
using OSPSuite.Utility.Validation;

namespace FolderSync.DTO
{
   public class FolderSyncDTO : ValidatableDTO
   {
      private string _sourceFolder;

      public string SourceFolder
      {
         get { return _sourceFolder; }
         set
         {
            _sourceFolder = value;
            OnPropertyChanged();
         }
      }

      private string _targetFolder;

      public string TargetFolder
      {
         get { return _targetFolder; }
         set
         {
            _targetFolder = value;
            OnPropertyChanged();
         }
      }

      public FolderSyncDTO()
      {
         Rules.Add(AllRules.SourceFolderExists);
         Rules.Add(AllRules.TargetFolderExists);
      }

      private static class AllRules
      {
         public static IBusinessRule SourceFolderExists
         {
            get { return GenericRules.NonEmptyRule<FolderSyncDTO>(x => x.SourceFolder); }
         }

         public static IBusinessRule TargetFolderExists
         {
            get { return GenericRules.NonEmptyRule<FolderSyncDTO>(x => x.TargetFolder); }
         }
      }
   }
}