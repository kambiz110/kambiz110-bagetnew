﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Comments.Dto
{
    public class EditCommentMessageDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Message { get; set; }

        public string userName { get; set; }
    }
}
