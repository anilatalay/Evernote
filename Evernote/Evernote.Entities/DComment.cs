using Evernote.Entities.Base;

namespace Evernote.Entities
{
    public class DComment : EntityBase
    {
        public string Text { get; set; }

        public virtual DNote Note { get; set; }
        public virtual DUser User { get; set; }
    }
}
