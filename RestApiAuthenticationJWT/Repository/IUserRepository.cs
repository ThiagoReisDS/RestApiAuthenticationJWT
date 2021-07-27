using RestApiAuthenticationJwt.Data.VO;
using RestApiAuthenticationJwt.Model;

namespace RestApiAuthenticationJwt.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);

        User RefreshUserInfo(UserVO user);
    }
}
