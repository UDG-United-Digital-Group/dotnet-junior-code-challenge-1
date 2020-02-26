using CodingContest.Models;

namespace CodingContest.Services 
{
    public interface IDataService
    {
        DataModel[] GetData();
        string[] GetGrouping();
    }
}