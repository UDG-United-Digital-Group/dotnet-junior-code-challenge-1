namespace CodingContest.Models 
{
    public interface IDataModel
    {
        string Vendor { get; set; }

        string Category { get; set; }

        string Model { get; set; }

        string Value { get; set; }
    }
}