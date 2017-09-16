namespace Evernote.Entities
{
    public class DLiked
    {
        public int Id { get; set; }

        public virtual DNote Note{ get; set; }
        public virtual DUser User { get; set; }
    }
}
