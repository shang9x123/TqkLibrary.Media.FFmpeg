using System.Collections.Generic;

namespace TqkLibrary.Media.FFmpeg.Interfaces
{
  public interface IArguments
  {
    IEnumerable<Option> Options { get; }
    IEnumerable<string> Flag { get; }
  }
}
