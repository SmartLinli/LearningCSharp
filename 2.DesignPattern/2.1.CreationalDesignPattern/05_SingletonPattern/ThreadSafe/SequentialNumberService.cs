using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLin.LearningCSharp.SingletonPattern
{
  public  sealed class SequentialNumberService
    {
      
      private int _CurrentSequentialNumber=1;
      private static readonly SequentialNumberService _Instance=new SequentialNumberService();
      public static SequentialNumberService Instance
      {
          get
          {
              return _Instance;
          }
      }
      public string GetSequentialNumber()
      {
          string newSequentialNumber = Instance._CurrentSequentialNumber.ToString();
          newSequentialNumber=newSequentialNumber.PadLeft(10, '0');
          Instance._CurrentSequentialNumber++;
          return newSequentialNumber;
      }
      static SequentialNumberService()
      {
          ;
      }
    }
}
