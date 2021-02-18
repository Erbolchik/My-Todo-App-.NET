using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using System.ComponentModel.DataAnnotations;

namespace Todo_App.Models
{
    public class User
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Display(Name = "Имя")]
        public string Name { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}
