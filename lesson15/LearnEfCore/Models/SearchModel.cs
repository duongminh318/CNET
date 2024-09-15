using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEfCore.Models
{
    public class SearchModel
    {
        
            public string Keyword { get; set; }
            public int PageIndex { get; set; }
            public int PageSize { get; set; } = 10;
            public int SkipNo => (PageIndex - 1) * PageSize;
        

    }
}
