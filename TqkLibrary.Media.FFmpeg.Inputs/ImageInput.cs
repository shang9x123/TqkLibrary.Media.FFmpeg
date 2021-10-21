using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TqkLibrary.Media.FFmpeg.Interfaces;
using TqkLibrary.Media.FFmpeg.Interfaces.Inputs;

namespace TqkLibrary.Media.FFmpeg.Inputs
{
  public class ImageInput : IImageInput
  {
    public string FilePath => throw new NotImplementedException();

    public IEnumerable<Option> Options => throw new NotImplementedException();

    public IEnumerable<string> Flag => throw new NotImplementedException();
  }
}
