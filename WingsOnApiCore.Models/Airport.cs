namespace WingsOnApiCore.Models
{
    public class Airport : BaseModel
    {
        public string Code { get; set; }

        public string Country { get; set; }

        public string City { get; set; }
    }
}