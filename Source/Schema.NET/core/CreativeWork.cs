namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
    [DataContract]
    public partial class CreativeWork : Thing
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CreativeWork";

        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        [DataMember(Name = "about", Order = 106)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? About { get; set; }

        /// <summary>
        /// Indicates that the resource is compatible with the referenced accessibility API (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityAPI", Order = 107)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AccessibilityAPI { get; set; }

        /// <summary>
        /// Identifies input methods that are sufficient to fully control the described resource (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityControl", Order = 108)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AccessibilityControl { get; set; }

        /// <summary>
        /// Content features of the resource, such as accessible media, alternatives and supported enhancements for accessibility (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityFeature", Order = 109)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AccessibilityFeature { get; set; }

        /// <summary>
        /// A characteristic of the described resource that is physiologically dangerous to some users. Related to WCAG 2.0 guideline 2.3 (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityHazard", Order = 110)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AccessibilityHazard { get; set; }

        /// <summary>
        /// A human-readable summary of specific accessibility features or deficiencies, consistent with the other accessibility metadata but expressing subtleties such as "short descriptions are present but long descriptions will be needed for non-visual users" or "short descriptions are present and no long descriptions are needed."
        /// </summary>
        [DataMember(Name = "accessibilitySummary", Order = 111)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AccessibilitySummary { get; set; }

        /// <summary>
        /// The human sensory perceptual system or cognitive faculty through which a person may process or perceive information. Expected values include: auditory, tactile, textual, visual, colorDependent, chartOnVisual, chemOnVisual, diagramOnVisual, mathOnVisual, musicOnVisual, textOnVisual.
        /// </summary>
        [DataMember(Name = "accessMode", Order = 112)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AccessMode { get; set; }

        /// <summary>
        /// A list of single or combined accessModes that are sufficient to understand all the intellectual content of a resource. Expected values include:  auditory, tactile, textual, visual.
        /// </summary>
        [DataMember(Name = "accessModeSufficient", Order = 113)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AccessModeSufficient { get; set; }

        /// <summary>
        /// Specifies the Person that is legally accountable for the CreativeWork.
        /// </summary>
        [DataMember(Name = "accountablePerson", Order = 114)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? AccountablePerson { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 115)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AggregateRating>? AggregateRating { get; set; }

        /// <summary>
        /// A secondary title of the CreativeWork.
        /// </summary>
        [DataMember(Name = "alternativeHeadline", Order = 116)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AlternativeHeadline { get; set; }

        /// <summary>
        /// A media object that encodes this CreativeWork. This property is a synonym for encoding.
        /// </summary>
        [DataMember(Name = "associatedMedia", Order = 117)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MediaObject>? AssociatedMedia { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 118)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Audience>? Audience { get; set; }

        /// <summary>
        /// An embedded audio object.
        /// </summary>
        [DataMember(Name = "audio", Order = 119)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AudioObject>? Audio { get; set; }

        /// <summary>
        /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
        /// </summary>
        [DataMember(Name = "author", Order = 120)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Author { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 121)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Award { get; set; }

        /// <summary>
        /// Fictional person connected with a creative work.
        /// </summary>
        [DataMember(Name = "character", Order = 122)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Character { get; set; }

        /// <summary>
        /// A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.
        /// </summary>
        [DataMember(Name = "citation", Order = 123)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork, string>? Citation { get; set; }

        /// <summary>
        /// Comments, typically from users.
        /// </summary>
        [DataMember(Name = "comment", Order = 124)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Comment>? Comment { get; set; }

        /// <summary>
        /// The number of comments this CreativeWork (e.g. Article, Question or Answer) has received. This is most applicable to works published in Web sites with commenting system; additional comments may exist elsewhere.
        /// </summary>
        [DataMember(Name = "commentCount", Order = 125)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? CommentCount { get; set; }

        /// <summary>
        /// The location depicted or described in the content. For example, the location in a photograph or painting.
        /// </summary>
        [DataMember(Name = "contentLocation", Order = 126)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? ContentLocation { get; set; }

        /// <summary>
        /// Official rating of a piece of content&amp;#x2014;for example,'MPAA PG-13'.
        /// </summary>
        [DataMember(Name = "contentRating", Order = 127)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ContentRating { get; set; }

        /// <summary>
        /// The specific time described by a creative work, for works (e.g. articles, video objects etc.) that emphasise a particular moment within an Event.
        /// </summary>
        [DataMember(Name = "contentReferenceTime", Order = 128)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? ContentReferenceTime { get; set; }

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        [DataMember(Name = "contributor", Order = 129)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Contributor { get; set; }

        /// <summary>
        /// The party holding the legal copyright to the CreativeWork.
        /// </summary>
        [DataMember(Name = "copyrightHolder", Order = 130)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? CopyrightHolder { get; set; }

        /// <summary>
        /// The year during which the claimed copyright for the CreativeWork was first asserted.
        /// </summary>
        [DataMember(Name = "copyrightYear", Order = 131)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? CopyrightYear { get; set; }

        /// <summary>
        /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
        /// </summary>
        [DataMember(Name = "creator", Order = 132)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Creator { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was created or the item was added to a DataFeed.
        /// </summary>
        [DataMember(Name = "dateCreated", Order = 133)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? DateCreated { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
        /// </summary>
        [DataMember(Name = "dateModified", Order = 134)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? DateModified { get; set; }

        /// <summary>
        /// Date of first broadcast/publication.
        /// </summary>
        [DataMember(Name = "datePublished", Order = 135)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? DatePublished { get; set; }

        /// <summary>
        /// A link to the page containing the comments of the CreativeWork.
        /// </summary>
        [DataMember(Name = "discussionUrl", Order = 136)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? DiscussionUrl { get; set; }

        /// <summary>
        /// Specifies the Person who edited the CreativeWork.
        /// </summary>
        [DataMember(Name = "editor", Order = 137)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Editor { get; set; }

        /// <summary>
        /// An alignment to an established educational framework.
        /// </summary>
        [DataMember(Name = "educationalAlignment", Order = 138)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AlignmentObject>? EducationalAlignment { get; set; }

        /// <summary>
        /// The purpose of a work in the context of education; for example, 'assignment', 'group work'.
        /// </summary>
        [DataMember(Name = "educationalUse", Order = 139)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? EducationalUse { get; set; }

        /// <summary>
        /// A media object that encodes this CreativeWork. This property is a synonym for associatedMedia.
        /// </summary>
        [DataMember(Name = "encoding", Order = 140)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MediaObject>? Encoding { get; set; }

        /// <summary>
        /// A creative work that this work is an example/instance/realization/derivation of.
        /// </summary>
        [DataMember(Name = "exampleOfWork", Order = 141)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? ExampleOfWork { get; set; }

        /// <summary>
        /// Media type, typically MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt;) of the content e.g. application/zip of a SoftwareApplication binary. In cases where a CreativeWork has several media type representations, 'encoding' can be used to indicate each MediaObject alongside particular fileFormat information. Unregistered or niche file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia entry.
        /// </summary>
        [DataMember(Name = "fileFormat", Order = 142)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? FileFormat { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 143)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Funder { get; set; }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        [DataMember(Name = "genre", Order = 144)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? Genre { get; set; }

        /// <summary>
        /// Indicates a CreativeWork that is (in some sense) a part of this CreativeWork.
        /// </summary>
        [DataMember(Name = "hasPart", Order = 145)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? HasPart { get; set; }

        /// <summary>
        /// Headline of the article.
        /// </summary>
        [DataMember(Name = "headline", Order = 146)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Headline { get; set; }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "inLanguage", Order = 147)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Language, string>? InLanguage { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used.
        /// </summary>
        [DataMember(Name = "interactionStatistic", Order = 148)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<InteractionCounter>? InteractionStatistic { get; set; }

        /// <summary>
        /// The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.
        /// </summary>
        [DataMember(Name = "interactivityType", Order = 149)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? InteractivityType { get; set; }

        /// <summary>
        /// A flag to signal that the publication is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 150)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool?>? IsAccessibleForFree { get; set; }

        /// <summary>
        /// A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html.
        /// </summary>
        [DataMember(Name = "isBasedOn", Order = 151)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork, Product, Uri>? IsBasedOn { get; set; }

        /// <summary>
        /// Indicates whether this content is family friendly.
        /// </summary>
        [DataMember(Name = "isFamilyFriendly", Order = 152)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool?>? IsFamilyFriendly { get; set; }

        /// <summary>
        /// Indicates a CreativeWork that this CreativeWork is (in some sense) part of.
        /// </summary>
        [DataMember(Name = "isPartOf", Order = 153)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? IsPartOf { get; set; }

        /// <summary>
        /// Keywords or tags used to describe this content. Multiple entries in a keywords list are typically delimited by commas.
        /// </summary>
        [DataMember(Name = "keywords", Order = 154)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Keywords { get; set; }

        /// <summary>
        /// The predominant type or kind characterizing the learning resource. For example, 'presentation', 'handout'.
        /// </summary>
        [DataMember(Name = "learningResourceType", Order = 155)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? LearningResourceType { get; set; }

        /// <summary>
        /// A license document that applies to this content, typically indicated by URL.
        /// </summary>
        [DataMember(Name = "license", Order = 156)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork, Uri>? License { get; set; }

        /// <summary>
        /// The location where the CreativeWork was created, which may not be the same as the location depicted in the CreativeWork.
        /// </summary>
        [DataMember(Name = "locationCreated", Order = 157)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? LocationCreated { get; set; }

        /// <summary>
        /// Indicates the primary entity described in some page or other CreativeWork.
        /// </summary>
        [DataMember(Name = "mainEntity", Order = 158)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? MainEntity { get; set; }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        [DataMember(Name = "material", Order = 159)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Product, string, Uri>? Material { get; set; }

        /// <summary>
        /// Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
        /// </summary>
        [DataMember(Name = "mentions", Order = 160)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? Mentions { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 161)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Offer>? Offers { get; set; }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        [DataMember(Name = "position", Order = 162)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?, string>? Position { get; set; }

        /// <summary>
        /// The person or organization who produced the work (e.g. music album, movie, tv/radio series etc.).
        /// </summary>
        [DataMember(Name = "producer", Order = 163)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Producer { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 164)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Provider { get; set; }

        /// <summary>
        /// A publication event associated with the item.
        /// </summary>
        [DataMember(Name = "publication", Order = 165)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PublicationEvent>? Publication { get; set; }

        /// <summary>
        /// The publisher of the creative work.
        /// </summary>
        [DataMember(Name = "publisher", Order = 166)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Publisher { get; set; }

        /// <summary>
        /// The publishing division which published the comic.
        /// </summary>
        [DataMember(Name = "publisherImprint", Order = 167)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? PublisherImprint { get; set; }

        /// <summary>
        /// Link to page describing the editorial principles of the organization primarily responsible for the creation of the CreativeWork.
        /// </summary>
        [DataMember(Name = "publishingPrinciples", Order = 168)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? PublishingPrinciples { get; set; }

        /// <summary>
        /// The Event where the CreativeWork was recorded. The CreativeWork may capture all or part of the event.
        /// </summary>
        [DataMember(Name = "recordedAt", Order = 169)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Event>? RecordedAt { get; set; }

        /// <summary>
        /// The place and time the release was issued, expressed as a PublicationEvent.
        /// </summary>
        [DataMember(Name = "releasedEvent", Order = 170)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PublicationEvent>? ReleasedEvent { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 171)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Review>? Review { get; set; }

        /// <summary>
        /// Indicates (by URL or string) a particular version of a schema used in some CreativeWork. For example, a document could declare a schemaVersion using an URL such as http://schema.org/version/2.0/ if precise indication of schema version was required by some application.
        /// </summary>
        [DataMember(Name = "schemaVersion", Order = 172)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? SchemaVersion { get; set; }

        /// <summary>
        /// The Organization on whose behalf the creator was working.
        /// </summary>
        [DataMember(Name = "sourceOrganization", Order = 173)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? SourceOrganization { get; set; }

        /// <summary>
        /// The spatialCoverage of a CreativeWork indicates the place(s) which are the focus of the content. It is a subproperty of
        ///       contentLocation intended primarily for more technical and detailed materials. For example with a Dataset, it indicates
        ///       areas that the dataset describes: a dataset of New York weather would have spatialCoverage which was the place: the state of New York.
        /// </summary>
        [DataMember(Name = "spatialCoverage", Order = 174)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? SpatialCoverage { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 175)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Sponsor { get; set; }

        /// <summary>
        /// The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in &lt;a href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals"&gt;ISO 8601 time interval format&lt;/a&gt;. In
        ///       the case of a Dataset it will typically indicate the relevant time period in a precise notation (e.g. for a 2011 census dataset, the year 2011 would be written "2011/2012"). Other forms of content e.g. ScholarlyArticle, Book, TVSeries or TVEpisode may indicate their temporalCoverage in broader terms - textually or via well-known URL.
        ///       Written works such as books may sometimes have precise temporal coverage too, e.g. a work set in 1939 - 1945 can be indicated in ISO 8601 interval format format via "1939/1945".
        /// </summary>
        [DataMember(Name = "temporalCoverage", Order = 176)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?, string, Uri>? TemporalCoverage { get; set; }

        /// <summary>
        /// The textual content of this CreativeWork.
        /// </summary>
        [DataMember(Name = "text", Order = 177)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Text { get; set; }

        /// <summary>
        /// A thumbnail image relevant to the Thing.
        /// </summary>
        [DataMember(Name = "thumbnailUrl", Order = 178)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? ThumbnailUrl { get; set; }

        /// <summary>
        /// Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience, e.g. 'P30M', 'P1H25M'.
        /// </summary>
        [DataMember(Name = "timeRequired", Order = 179)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan?>? TimeRequired { get; set; }

        /// <summary>
        /// The work that this work has been translated from. e.g. 物种起源 is a translationOf “On the Origin of Species”
        /// </summary>
        [DataMember(Name = "translationOfWork", Order = 180)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? TranslationOfWork { get; set; }

        /// <summary>
        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        /// </summary>
        [DataMember(Name = "translator", Order = 181)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Translator { get; set; }

        /// <summary>
        /// The typical expected age range, e.g. '7-9', '11-'.
        /// </summary>
        [DataMember(Name = "typicalAgeRange", Order = 182)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TypicalAgeRange { get; set; }

        /// <summary>
        /// The version of the CreativeWork embodied by a specified resource.
        /// </summary>
        [DataMember(Name = "version", Order = 183)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double?, string>? Version { get; set; }

        /// <summary>
        /// An embedded video object.
        /// </summary>
        [DataMember(Name = "video", Order = 184)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<VideoObject>? Video { get; set; }

        /// <summary>
        /// Example/instance/realization/derivation of the concept of this creative work. eg. The paperback edition, first edition, or eBook.
        /// </summary>
        [DataMember(Name = "workExample", Order = 185)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? WorkExample { get; set; }

        /// <summary>
        /// A work that is a translation of the content of this work. e.g. 西遊記 has an English workTranslation “Journey to the West”,a German workTranslation “Monkeys Pilgerfahrt” and a Vietnamese  translation Tây du ký bình khảo.
        /// </summary>
        [DataMember(Name = "workTranslation", Order = 186)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? WorkTranslation { get; set; }
    }
}