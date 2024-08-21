using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnGeneric.Abstracts
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
