using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TqkLibrary.Media.FFmpeg.Interfaces.Filters
{
  public interface IFilter
  {
    IEnumerable<IFilter> Parents { get; }
    IFilterGraph FilterGraph { get; }
  }
}
