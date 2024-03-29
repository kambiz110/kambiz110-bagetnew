﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Ticket.ElFinder.Models.Commands.Open
{
    public class InitResponseModel : BaseOpenResponseModel
    {
        private static string[] empty = new string[0];

        public InitResponseModel(DirectoryModel currentWorkingDirectory, Options options) : base(currentWorkingDirectory)
        {
            Options = options;
        }

        [JsonPropertyName("api")]
        public string Api => "2.1";

        [JsonPropertyName("netDrivers")]
        public IEnumerable<string> NetDrivers => empty;
    }
}