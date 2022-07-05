using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class Response
    {
        [JsonIgnore]
        public bool IsValid { get; set; }


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Id { get; set; }


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string entity { get; set; }


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] 
        public List<Object> Errors { get; set; }
    }
}
