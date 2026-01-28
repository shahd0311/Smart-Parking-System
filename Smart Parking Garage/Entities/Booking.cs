using System.ComponentModel.DataAnnotations.Schema;

namespace Smart_Parking_Garage.Entities;

public class Booking
{
    public int BookingId { get; set; }
    
    public int ParkingSlotId { get; set; }

    public DateTime BookingStart { get; set; }
    public DateTime BookingEnd { get; set; }

    public string Status { get; set; }     
    public bool PriorityApplied { get; set; }

    
    [ForeignKey("ApplicationUserId")]
    public string ApplicationUserId { get; set; }
    public ApplicationUser? ApplicationUser { get; set; }
    public ParkingSlot? ParkingSlot { get; set; }
    public ParkingSession? ParkingSession { get; set; }

    
}
