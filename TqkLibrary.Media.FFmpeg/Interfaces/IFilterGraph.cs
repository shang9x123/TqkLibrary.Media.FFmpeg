using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TqkLibrary.Media.FFmpeg.Interfaces.Filters;
using TqkLibrary.Media.FFmpeg.Interfaces.Inputs;

namespace TqkLibrary.Media.FFmpeg.Interfaces
{
  public interface IFilterGraph : IArguments
  {
    IFilterImage AddImage(IImageInput image);
    IFilterSound AddSound(ISoundInput sound);
    IFilterVideo AddVideo(IVideoInput video);
  }
}
