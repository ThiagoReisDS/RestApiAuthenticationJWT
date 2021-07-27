using RestApiAuthenticationJwt.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiAuthenticationJwt.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidationCredentions(UserVO user);
    }
}
