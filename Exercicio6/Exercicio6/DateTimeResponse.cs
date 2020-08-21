using Newtonsoft.Json;
using System;

namespace Exercicio6
{
    public class DateTimeResponse
    {
        [JsonProperty("currentDateTime")]
        public DateTime CurrentDateTime { get; set; } //The only property that exercise needs

    }
}