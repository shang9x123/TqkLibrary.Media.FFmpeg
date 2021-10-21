using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TqkLibrary.Media.FFmpeg.Interfaces;
using TqkLibrary.Media.FFmpeg.Interfaces.Filters;
using TqkLibrary.Media.FFmpeg.Interfaces.Inputs;

namespace TqkLibrary.Media.FFmpeg
{
  public sealed class FilterGraph : IFilterGraph
  {
    public IEnumerable<IMediaInput> Inputs { get { return _inputs; } }

    public IEnumerable<Option> Options { get { return _options; } }

    public IEnumerable<string> Flag { get { return _flags; } }







    readonly List<IMediaInput> _inputs = new List<IMediaInput>();
    readonly List<Option> _options = new List<Option>();
    readonly List<string> _flags = new List<string>();

    public FilterGraph()
    {

    }


    public IFilterImage AddImage(IImageInput image)
    {
      _inputs.Add(image);



      return null;
    }

    public IFilterSound AddSound(ISoundInput sound)
    {
      _inputs.Add(sound);




      return null;
    }

    public IFilterVideo AddVideo(IVideoInput video)
    {
      _inputs.Add(video);




      return null;
    }

  }
}
