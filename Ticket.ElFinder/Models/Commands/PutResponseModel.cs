﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Ticket.ElFinder.Models.Commands
{
    public class PutResponseModel
    {
        public PutResponseModel()
        {
            Changed = new List<FileModel>();
        }

        [JsonPropertyName("changed")]
        public List<FileModel> Changed { get; private set; }
    }
}