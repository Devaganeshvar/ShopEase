namespace ShopEase.Application.Options;

public class JwtOptions
{
    public const string SectionName = "Jwt";

    public string Issuer { get; set; } = "ShopEase.Api";
    public string Audience { get; set; } = "ShopEase.Web";
    public string SigningKey { get; set; } = "ShopEase-Secret-Key-Must-Be-At-Least-32-Bytes-Long-For-HmacSha256!";
    public int AccessTokenExpiryMinutes { get; set; } = 15;
    public int RefreshTokenExpiryDays { get; set; } = 14;
}
