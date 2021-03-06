﻿#if !NETSTANDARD14
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using NetBox;
using NetBox.IO;
using NetBox.Model;

namespace NetBox.Extensions
{
   /// <summary>
   /// <see cref="Path"/> extensions. Due to the fact <see cref="Path"/> is a static class and cannot be extended
   /// with extension methods this is implemented a new static class.
   /// </summary>
   public static class NetPath
   {
      private static bool _execDirTried;
      private static string _execDir;
      private static bool _execDirInfoTried;
      private static DirectoryInfo _execDirInfo;

      /// <summary>
      /// Gets current assembly execution directory in a more reliable way
      /// </summary>
      public static string ExecDir
      {
         get
         {
            if (!_execDirTried)
            {
               _execDir = (G.ThisAssembly != null
                  ? Path.GetDirectoryName(G.ThisAssembly.Location)
                  : null);

#if NETSTANDARD20
               if (_execDir == null) _execDir = Environment.CurrentDirectory;
#endif

               _execDirTried = true;
            }

            return _execDir;
         }
      }
      /// <summary>
      /// Gets current assembly execution directory information in a more reliable way
      /// </summary>
      public static DirectoryInfo ExecDirInfo
      {
         get
         {
            if (!_execDirInfoTried)
            {
               string execDir = ExecDir;
               _execDirInfo = execDir == null ? null : new DirectoryInfo(execDir);

               _execDirInfoTried = true;
            }

            return _execDirInfo;
         }
      }
   }
}
#endif