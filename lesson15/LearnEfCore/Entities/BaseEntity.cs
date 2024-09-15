using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEfCore.Entities
{
    public abstract class BaseEntity<Tkey>
    {
        [Key]
        public Tkey Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public EntityStatus Status { get; set; }
    }
}