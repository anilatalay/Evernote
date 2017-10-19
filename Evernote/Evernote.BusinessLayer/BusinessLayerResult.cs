using System;
using System.Collections.Generic;
using System.Text;

namespace Evernote.BusinessLayer
{
    public class BusinessLayerResult<T> where T :class
    {
        public List<string> Errors { get; set; }
        public T Result { get; set; }

        public BusinessLayerResult()
        {
            Errors = new List<string>();
        }
    }
}
