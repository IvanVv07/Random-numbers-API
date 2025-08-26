using Microsoft.AspNetCore.Mvc;

namespace RandomApi.Controllers;

[ApiController]
[Route("random")]
public class RandomController : ControllerBase
{
    private static readonly Random _rnd = new();

    // GET /random/number
    [HttpGet("number")]
    public int GetNumber(int min = 0, int max = 100)
    {
        return _rnd.Next(min, max + 1);
    }

    // GET /random/decimal
    [HttpGet("decimal")]
    public double GetDecimal()
    {
        return _rnd.NextDouble();
    }

    // GET /random/string
    [HttpGet("string")]
    public string GetString(int length = 8)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        return new string(Enumerable.Range(0, length)
            .Select(_ => chars[_rnd.Next(chars.Length)]).ToArray());
    }
}