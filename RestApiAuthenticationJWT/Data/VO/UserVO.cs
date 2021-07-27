using System;

namespace RestApiAuthenticationJwt.Data.VO
{
    public class UserVO
    {
        public int Id { get; internal set; }
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}
