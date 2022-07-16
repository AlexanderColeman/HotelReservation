using HotelReservation.Models;

namespace HotelReservation
{
    public interface IAmenitiesRepository
    {
        public IEnumerable<Amenities> GetAllAmenities();
    }
}
