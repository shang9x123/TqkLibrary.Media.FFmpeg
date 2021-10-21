using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TqkLibrary.Media.FFmpeg.Interfaces.Filters
{
  public class BaseFilter : IFilter
  {
    protected readonly Dictionary<string,string> _options = new Dictionary<string, string>();
    protected readonly List<IFilter> _parents = new List<IFilter>();

    protected string FilterName { get; set; }
    protected BaseFilter(IFilter parent)
    {
      if (parent == null) throw new ArgumentNullException(nameof(parent));
      if (parent.FilterGraph == null) throw new ArgumentNullException(nameof(parent.FilterGraph));
      FilterGraph = parent.FilterGraph;
      _parents.Add(parent);
    }
    public IEnumerable<IFilter> Parents { get { return _parents; } }

    public IFilterGraph FilterGraph { get; }

    public override string ToString()
    {
      if (string.IsNullOrEmpty(FilterName)) throw new NullReferenceException(nameof(FilterName));
      return $"{FilterName}={string.Join(":", _options.Select(x => $"{x.Key}={x.Value}"))}";
    }
  }
}
