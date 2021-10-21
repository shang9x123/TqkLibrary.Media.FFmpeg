using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TqkLibrary.Media.FFmpeg.Interfaces.Filters;

namespace TqkLibrary.Media.FFmpeg.Interfaces.Outputs
{
  public interface IMediaOutput : IArguments
  {
    string FilePath { get; }


    IFilterImage ImageMap { get; }
    IFilterSound SoundMap { get; }
  }
}
