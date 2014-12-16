using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcRuslana.Entities;

namespace MvcRuslana.Abstract
{
    public interface IBlogRepository
    {
        IEnumerable<BlogItem> BlogItems { get; }
    }
}
