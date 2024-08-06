namespace TakeAwayNight.Comment.Entities
{
    public class UserComment
    {
        public int UserCommentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserId { get; set; }
        public string CommentDetail { get; set; }
        public string ProductId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
    }
}
