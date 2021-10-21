using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TqkLibrary.Media.FFmpeg.Interfaces;
using TqkLibrary.Media.FFmpeg.Interfaces.Filters;
using TqkLibrary.Media.FFmpeg.Ultis;

namespace TqkLibrary.Media.FFmpeg.Filters.VideoFilters
{
  /// <summary>
  /// TSC colorkey          V->V       Turns a certain color into transparency. Operates on RGB colors.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#colorkey
  /// </summary>
  public class ColorKey : BaseFilter, IFilterImage, TimelineEditing
  {

    internal ColorKey(IFilterImage parent, Color color) : base(parent)
    {
      this.FilterName = "colorkey";
      _options["color"] = color.ToHexStringRGB();
    }
    
    public ColorKey SetColor(Color color)
    {
      _options["color"] = color.ToHexStringRGB();
      return this;
    }

    public ColorKey SetSimilarity(float similarity)
    {
      if (similarity < 0 || similarity > 1) throw new ArgumentOutOfRangeException($"Only accept: 0 <= {nameof(similarity)} <= 1");
      _options["similarity"] = similarity.ToString();
      return this;
    }

    public ColorKey SetBlend(float blend)
    {
      if (blend < 0 || blend > 1) throw new ArgumentOutOfRangeException($"Only accept: 0 <= {nameof(blend)} <= 1");
      _options["blend"] = blend.ToString();
      return this;
    }

    public void Enable(Action<TimelineEditingExpression> timelineExpression)
    {
      TimelineEditingExpression timelineEditingExpression = new TimelineEditingExpression();
      timelineExpression?.Invoke(timelineEditingExpression);
      string result = timelineEditingExpression.ToString();

      if (string.IsNullOrEmpty(result)) throw new NullReferenceException(nameof(timelineExpression));
      _options["enable"] = $"'{result}'";
    }
  }

  public static class ColorKeyExtension
  {
    public static ColorKey ColorKey(this IFilterImage parent, Color color)
    {
      return new ColorKey(parent, color);
    }
  }
}
