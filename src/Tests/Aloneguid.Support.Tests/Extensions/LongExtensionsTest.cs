﻿using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aloneguid.Support.Tests.Extensions
{
   
   public class LongExtensionsTest
   {
      [InlineData(1024, "1.00 KiB")]
      [InlineData(0, "0")]
      public void ToFileSizeString_Variable_Variable(long input, string expected)
      {
         Assert.Equal(expected, input.ToFileSizeString());
      }

      [InlineData(1024, "1.02 KB")]
      [InlineData(0, "0")]
      public void ToFileSizeUiString_Variable_Variable(long input, string expected)
      {
         Assert.Equal(expected, input.ToFileSizeUiString());
      }
   }
}
