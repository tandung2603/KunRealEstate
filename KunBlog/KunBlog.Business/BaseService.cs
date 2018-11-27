using System;

namespace KunBlog.Business
{
    public class BaseService
    {
        private DateTime? _dateTimeNow;

        public DateTime DateTimeNow
        {
            get
            {
                if (_dateTimeNow == null)
                {
                    _dateTimeNow = DateTime.Now;
                }

                return _dateTimeNow.Value;
            }
        }
    }
}
