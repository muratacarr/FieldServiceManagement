namespace FieldServiceManagement.Core.Entities
{
    public class CustomerFeedback
    {
        public int Id { get; set; }
        public int ServiceRequestId { get; set; }
        public ServiceRequest ServiceRequest { get; set; } = null!;
        public decimal Rating { get; set; }
        public string Comment { get; set; } = null!;
        public DateTime FeedbackDate { get; set; }
    }
}
