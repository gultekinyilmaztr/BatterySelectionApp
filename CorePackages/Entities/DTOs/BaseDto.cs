namespace CorePackages.Entities.DTOs
{
    public abstract class BaseDto
    {
        public int Id { get; set; }
        public string? CellSerialNo { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
