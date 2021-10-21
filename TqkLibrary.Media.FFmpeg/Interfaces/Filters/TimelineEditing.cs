using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TqkLibrary.Media.FFmpeg.Ultis;

namespace TqkLibrary.Media.FFmpeg.Interfaces.Filters
{
  /// <summary>
  /// https://ffmpeg.org/ffmpeg-filters.html#Timeline-editing
  /// </summary>
  public interface TimelineEditing
  {
    void Enable(Action<TimelineEditingExpression> timelineExpression);
  }
}
