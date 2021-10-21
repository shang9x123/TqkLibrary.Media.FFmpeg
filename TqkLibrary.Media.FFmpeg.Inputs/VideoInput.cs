using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TqkLibrary.Media.FFmpeg.Interfaces;
using TqkLibrary.Media.FFmpeg.Interfaces.Inputs;

namespace TqkLibrary.Media.FFmpeg.Inputs
{
  public class VideoInput : IVideoInput
  {
    public VideoInput(string filePath)
    {
      this.FilePath = filePath;
    }

    public string FilePath { get; }

    public IEnumerable<Option> Options { get; }
    public IEnumerable<string> Flag { get; }
  }
}
