namespace ApiDevInCarGQL.Services
{
    public interface ITokenService
    {
        string GenerateJwt(string user);
    }
}
