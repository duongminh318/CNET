using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEfCore.Models
{
    public class VariantSearchModel : SearchModel
    {
        public Guid? ProductId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public EntityStatus? Status { get; set; }

    }
}
