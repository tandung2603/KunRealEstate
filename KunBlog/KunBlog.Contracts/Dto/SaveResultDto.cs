using System;

namespace KunBlog.Contracts.Dto
{
    public class SaveResultDto : BaseDto
    {
        public Guid Id;

        public bool IsSuccess;

        public string Message;
    }
}
