using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Managesio.Core.Entities;

[Table("user")]
public class User
{
    [Key]
    public int Id { get; set; }
    public string Email { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public List<Todo> Todos { get; set; } = new List<Todo>();

    [JsonIgnore]
    public string Password { get; set; }
}