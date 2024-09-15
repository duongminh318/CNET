using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEfCore.Models
{
    public class PaginationViewModel <T>
    {
        public int Total { get; set; }
        public List<T> Data { get; set; }
    } 
}
