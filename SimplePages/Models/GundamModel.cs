using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplePages.Models
{
    public class GundamModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Final Array Index")]
        public int GundamIndex { get; set; }

        [BsonElement("Image")]
        public string Image { get; set; }

        [BsonElement("Classification")]
        public string Classification { get; set; }

        [BsonElement("Model Number")]
        public string ModelNumber { get; set; }

        [BsonElement("Official Name")]
        public string OfficialName { get; set; }

        [BsonElement("Head Height")]
        public string HeadHeight { get; set; }

        [BsonElement("Overall Height")]
        public string OverallHeight { get; set; }

        [BsonElement("Base Weight")]
        public string BaseWeight { get; set; }

        [BsonElement("Full Weight")]
        public string FullWeight { get; set; }

        [BsonElement("Power Source")]
        public string PowerSource { get; set; }

        [BsonElement("Generator Output")]
        public string GeneratorOutput { get; set; }

        [BsonElement("Armor Material")]
        public string ArmorMaterial { get; set; }

        [BsonElement("Total Thrust")]
        public string TotalThrust { get; set; }

        [BsonElement("Maximum Acceleration")]
        public string MaximumAcceleration { get; set; }

        [BsonElement("Effective Sensor Radius")]
        public string EffectiveSensorRadius { get; set; }

        [BsonElement("Crew")]
        public string Crew { get; set; }

        [BsonElement("Manufacturer")]
        public string Manufacturer { get; set; }

        [BsonElement("First Deployment")]
        public string FirstDeployment { get; set; }

        [BsonElement("Last Seen")]
        public string LastSeen { get; set; }

        [BsonElement("Operator")]
        public string Operator { get; set; }

        [BsonElement("Known Pilots")]
        public string KnownPilots { get; set; }

        [BsonElement("Standard")]
        public string Standard { get; set; }

        [BsonElement("Fixed")]
        public string Fixed { get; set; }

        [BsonElement("TV Series")]
        public string TVSeries { get; set; }

        [BsonElement("Manga")]
        public string Manga { get; set; }

        [BsonElement("Mechanical Designer")]
        public string MechanicalDesigner { get; set; }

        [BsonElement("__v")]
        public int __v { get; set; }

    }
}
