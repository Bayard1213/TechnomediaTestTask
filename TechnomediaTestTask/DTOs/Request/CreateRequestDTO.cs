﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using TechnomediaTestTask.Enums;

namespace TechnomediaTestTask.DTOs.Request
{
    public class CreateRequestDTO
    {
        public int ClientId { get; set; }
        public string Notes { get; set; }
        public string ResearchNotes { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public RequestStatus Status { get; set; }
    }
}