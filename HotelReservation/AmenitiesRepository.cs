using Dapper;
using HotelReservation.Models;
using System.Data;

namespace HotelReservation
{
    public class AmenitiesRepository : IAmenitiesRepository
    {
        private readonly IDbConnection _conn;

        public AmenitiesRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Amenities> GetAllAmenities()
        {
            return _conn.Query<Amenities>("SELECT * FROM Amenities");

        }
    }
}
