﻿#if NETFULL
using System.IO;
using Xunit;

namespace Aloneguid.Support.Tests
{
   
   public class NetPathTest
   {
      [Fact]
      public void ExecDir_SmokeTest_DoesntCrash()
      {
         string path = NetPath.ExecDir;
         DirectoryInfo info = NetPath.ExecDirInfo;
      }
   }
}
#endif