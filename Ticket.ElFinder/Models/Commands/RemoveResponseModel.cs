﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Ticket.ElFinder.Models.Commands
{
    public class RemoveResponseModel
    {
        public RemoveResponseModel()
        {
            Removed = new List<string>();
        }

        [JsonPropertyName("removed")]
        public List<string> Removed { get; }
    }
}