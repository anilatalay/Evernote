using Evernote.Entities.Base;

namespace Evernote.Entities
{
    public class Comment : EntityBase
    {
        public string Text { get; set; }

        public virtual DNote Note { get; set; }
        public virtual User User { get; set; }
    }
}
