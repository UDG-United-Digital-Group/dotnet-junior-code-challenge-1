using System.Collections.Generic;

namespace CodingContest.Models 
{
    public interface ITreeViewResult
    {
        int Id { get; set; }

        string Text { get; set; }

        int? ParentId { get; set; }

        IList<TreeViewResult> Children { get; set; }

        bool IsRootNode();
    }
}