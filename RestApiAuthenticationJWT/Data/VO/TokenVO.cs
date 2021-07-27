namespace RestApiAuthenticationJwt.Data.VO
{
    public class TokenVO
    {
        public TokenVO(bool authenticated, string created, string expiration, string accessToken, string refreshToken)
        {
            this.authenticated = authenticated;
            Created = created;
            Expiration = expiration;
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }

        public bool authenticated { get; set; }
        public string Created { get; set; }
        public string Expiration { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
