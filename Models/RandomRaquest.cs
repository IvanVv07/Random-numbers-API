namespace RandomApi.Models;

public class RandomRequest
{
    public string? Type { get; set; }          // "number" | "decimal" | "string"
    public int? Min { get; set; }              // solo si type=number
    public int? Max { get; set; }              // solo si type=number
    public int? Decimals { get; set; }         // solo si type=decimal
    public int? Length { get; set; }           // solo si type=string
}