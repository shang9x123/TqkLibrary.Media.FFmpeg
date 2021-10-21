using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TqkLibrary.Media.FFmpeg.Interfaces.Inputs
{
  public interface IMediaInput : IArguments
  {
    string FilePath { get; }
  }
}
