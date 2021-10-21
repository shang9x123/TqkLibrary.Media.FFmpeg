using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TqkLibrary.Media.FFmpeg.Interfaces;
using TqkLibrary.Media.FFmpeg.Interfaces.Filters;

namespace TqkLibrary.Media.FFmpeg.Filters.VideoFilters
{
  public class Overlay : BaseFilter, IFilterImage
  {
    internal Overlay(IFilterImage filterImage, IFilterImage another) : base(filterImage)
    {

    }
  }

  public static class OverlayExtension
  {
    public static Overlay OverlayOn(this IFilterImage filterImage, IFilterImage another)
    {
      return new Overlay(filterImage, another);
    }
  }
}
