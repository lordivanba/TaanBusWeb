
namespace taanbus.Data.Models
{
    public class TokenModel
    {
        public string TokenOrMessage { get; set; } = "";
        public int Success { get; set; } = 0;
        public int UserId { get; set; }
        public int UserType { get; set; }
    }
}