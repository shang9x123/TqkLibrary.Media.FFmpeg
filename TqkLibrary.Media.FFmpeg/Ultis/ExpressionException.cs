using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TqkLibrary.Media.FFmpeg.Ultis
{
  public class InvalidTokenExpressionException : Exception
  {
    public InvalidTokenExpressionException(string message) : base(message)
    {

    }
  }

  public class InvalidInputExpressionException : Exception
  {
    public InvalidInputExpressionException(string message) : base(message)
    {

    }
  }
}
