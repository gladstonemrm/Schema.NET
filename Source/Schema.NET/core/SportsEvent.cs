namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Sports event.
    /// </summary>
    [DataContract]
    public partial class SportsEvent : Event
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SportsEvent";

        /// <summary>
        /// The away team in a sports event.
        /// </summary>
        [DataMember(Name = "awayTeam", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, SportsTeam>? AwayTeam { get; set; }

        /// <summary>
        /// A competitor in a sports event.
        /// </summary>
        [DataMember(Name = "competitor", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, SportsTeam>? Competitor { get; set; }

        /// <summary>
        /// The home team in a sports event.
        /// </summary>
        [DataMember(Name = "homeTeam", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, SportsTeam>? HomeTeam { get; set; }
    }
}