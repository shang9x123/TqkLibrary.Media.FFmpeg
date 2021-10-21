using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TqkLibrary.Media.FFmpeg.Filters
{
  static class Extensions
  {
    public static string ToHexStringRGB(this Color color)
    {
      return $"{color.R.ToString("X2")}{color.G.ToString("X2")}{color.B.ToString("X2")}";
    }
    public static string ToHexStringRGBA(this Color color)
    {
      return $"{color.R.ToString("X2")}{color.G.ToString("X2")}{color.B.ToString("X2")}@{(float)color.A / 255}";
    }
  }
}
