﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A set of requirements that a must be fulfilled in order to perform an Action.
    /// </summary>
    public partial interface IActionAccessSpecification : IIntangible
    {
        /// <summary>
        /// The end of the availability of the product or service included in the offer.
        /// </summary>
        OneOrMany<DateTimeOffset?> AvailabilityEnds { get; set; }

        /// <summary>
        /// The beginning of the availability of the product or service included in the offer.
        /// </summary>
        OneOrMany<DateTimeOffset?> AvailabilityStarts { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        Values<PhysicalActivityCategory?, string, IThing>? Category { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;br/&gt;&lt;br/&gt;
        /// See also &lt;a class="localLink" href="http://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.
        /// </summary>
        Values<IGeoShape, IPlace, string>? EligibleRegion { get; set; }

        /// <summary>
        /// An Offer which must be accepted before the user can perform the Action. For example, the user may need to buy a movie before being able to watch it.
        /// </summary>
        OneOrMany<IOffer> ExpectsAcceptanceOf { get; set; }

        /// <summary>
        /// Indicates if use of the media require a subscription  (either paid or free). Allowed values are &lt;code&gt;true&lt;/code&gt; or &lt;code&gt;false&lt;/code&gt; (note that an earlier version had 'yes', 'no').
        /// </summary>
        Values<bool?, IMediaSubscription>? RequiresSubscription { get; set; }
    }

    /// <summary>
    /// A set of requirements that a must be fulfilled in order to perform an Action.
    /// </summary>
    [DataContract]
    public partial class ActionAccessSpecification : Intangible, IActionAccessSpecification
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ActionAccessSpecification";

        /// <summary>
        /// The end of the availability of the product or service included in the offer.
        /// </summary>
        [DataMember(Name = "availabilityEnds", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> AvailabilityEnds { get; set; }

        /// <summary>
        /// The beginning of the availability of the product or service included in the offer.
        /// </summary>
        [DataMember(Name = "availabilityStarts", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> AvailabilityStarts { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [DataMember(Name = "category", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<PhysicalActivityCategory?, string, IThing>? Category { get; set; }

        /// <summary>
        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;br/&gt;&lt;br/&gt;
        /// See also &lt;a class="localLink" href="http://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "eligibleRegion", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IGeoShape, IPlace, string>? EligibleRegion { get; set; }

        /// <summary>
        /// An Offer which must be accepted before the user can perform the Action. For example, the user may need to buy a movie before being able to watch it.
        /// </summary>
        [DataMember(Name = "expectsAcceptanceOf", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOffer> ExpectsAcceptanceOf { get; set; }

        /// <summary>
        /// Indicates if use of the media require a subscription  (either paid or free). Allowed values are &lt;code&gt;true&lt;/code&gt; or &lt;code&gt;false&lt;/code&gt; (note that an earlier version had 'yes', 'no').
        /// </summary>
        [DataMember(Name = "requiresSubscription", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<bool?, IMediaSubscription>? RequiresSubscription { get; set; }
    }
}
