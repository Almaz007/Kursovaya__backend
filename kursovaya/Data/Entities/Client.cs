namespace kursovaya.Data.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Booking>? Bookings { get; set; }
    }
}
