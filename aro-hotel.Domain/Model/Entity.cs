using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aro_hotel.Domain.Model;

public abstract class Entity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    //These can be uncommented for audit

    //public int CreatedBy { get; set; }

    //public DateTime CreatedAt { get; set; }

    //public int? UpdatedBy { get; set; }

    //public DateTime? UpdatedAt { get; set; }
}