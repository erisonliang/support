﻿using System.Diagnostics;

namespace System.Reflection
{
   public static class AssemblyExtensions
   {
      /// <summary>
      /// Gets the product version (set by [assembly:Version] attribute)
      /// </summary>
      public static Version ProductVersion(this Assembly asm)
      {
         return asm.GetName().Version;
      }

      /// <summary>
      /// Gets the file version (set by [assembly:FileVersion] attribute)
      /// </summary>
      /// <param name="asm"></param>
      /// <returns></returns>
      public static Version FileVersion(this Assembly asm)
      {
         FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(asm.Location);

         return new Version(fvi.FileVersion);
      }
   }
}

