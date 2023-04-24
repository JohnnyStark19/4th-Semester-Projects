namespace FAQApp.Models
{
    public class FAQ
    {
        public int FAQID { get; set; }
        public string? FAQQuestion { get; set; }
        public string? FAQAnswer { get; set; }

        //  Foreign Key Link to Topics table
        public string TopicID { get; set; }
        public Topic Topic { get; set; }

        //  Foreign Key Link to Categories table
        public string CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
