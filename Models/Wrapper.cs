using System.Collections.Generic;

namespace LoginAndReg.Models
{
    public class Wrapper
    {
        public User User { get; set; }
        public List<User> AllUsers { get; set; }
        public LoginUser UserLogin { get; set; }
    }
}