using System.ComponentModel.DataAnnotations;

namespace joelkozek.comapi2.Models.Review
{
    public class ReviewModel
    {
        [Key]
        public int ReviewId { get; set; }
        public int ProductId { get; set; }
        public string Reviewer { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }

    }
}
