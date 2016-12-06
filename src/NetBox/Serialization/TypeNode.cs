﻿using System;

namespace NetBox.Serialization
{
   public class TypeNode
   {
      public TypeNode(Type t,
         Func<object, object> valueGettter,
         Action<object, object> valueSetter)
      {
         NodeType = t;
         _valueGetter = valueGettter;
         _valueSetter = valueSetter;
      }

      public Type NodeType { get; }

      private Func<object, object> _valueGetter;

      private Action<object, object> _valueSetter;

      public object GetValue(object parent)
      {
         return _valueGetter(parent);
      }
   }
}