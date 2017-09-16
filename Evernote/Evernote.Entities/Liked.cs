namespace Evernote.Entities
{
    public class Liked
    {
        public int Id { get; set; }

        public virtual DNote Note{ get; set; }
        public virtual User User { get; set; }
    }
}
