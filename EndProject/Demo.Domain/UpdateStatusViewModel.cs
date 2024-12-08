using Demo.Domain.Enums;

namespace Demo.Domain
{
    public class UpdateStatusViewModel
    {
        public EntityStatus Status { get; set; }
        public Guid Id { get; set; }
    }
}
