using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using FluentNHibernate.Utils;

namespace FolderSync.Services
{
   public class FolderInfo
   {
      public string Folder { get; }
      private readonly string _filter;
      private readonly HashSet<string> _allFiles;
      private readonly int _folderNameSize;

      public FolderInfo(string folder, string filter)
      {
         Folder = folder;
         _folderNameSize = Folder.Length + 1;
         _filter = filter;
         _allFiles = new HashSet<string>();
      }

      public int FileCount => _allFiles.Count;

      public Task ComputeFiles()
      {
         _allFiles.Clear();
         return Task.Run(() =>
         {
            var directory = new DirectoryInfo(Folder);
            var allProjectFiles = directory.GetFiles(_filter, SearchOption.AllDirectories);
            allProjectFiles.Each(f =>
            {
               _allFiles.Add(relativePathFor(f));
            });
         });
      }

      private string relativePathFor(FileInfo fileInfo)
      {
         return  fileInfo.FullName.Remove(0, _folderNameSize);
      }

      public IEnumerable<string> Files => _allFiles;
      public bool Contains(string file) => _allFiles.Contains(file);
   }
}