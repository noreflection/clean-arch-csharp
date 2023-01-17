using System.ComponentModel.DataAnnotations;

namespace clean_arch.Domain.Entities;
public class Restaurant : BaseAuditableEntity
{
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Logo { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double Commission { get; set; }
    public double CommissionType { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{HH:mm:ss}")]
    public DateTime OpeningTime { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{HH:mm:ss}")]
    public DateTime ClosingTime { get; set; }
    public double Rating { get; set; }
    public string OffDay { get; set; } = string.Empty;
    public double DeliveryCharge { get; set; }
    public int Capacity { get; set; }
    public int OrderCount { get; set; }
    public Guid VendorId { get; set; }
    public Guid CategoryId { get; set; }
    public Guid ZoneId { get; set; }
    public Guid SurgeZoneId { get; set; }
    public bool IsActive { get; set; }
    public bool IsUpfrontPayment { get; set; }
    public bool IsDeleted { get; set; }
}
