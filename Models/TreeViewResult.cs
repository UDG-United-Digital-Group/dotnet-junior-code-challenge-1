using System.Collections.Generic;
using Newtonsoft.Json;

namespace CodingContest.Models 
{
    /// <summary>
    /// Represends a tree view result.
    /// </summary>
    [JsonObject]
    public class TreeViewResult : ITreeViewResult
    {
        /// <summary>
        /// The unique identifier of this instance.
        /// </summary>
        /// <value></value>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The display name of this instance.
        /// </summary>
        /// <value></value>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// The parent id of this instance.
        /// </summary>
        /// <value></value>
        [JsonProperty("parent")]
        public int? ParentId { get; set; }

        /// <summary>
        /// All children of this instance.
        /// </summary>
        /// <value></value>
        [JsonProperty("children")]
        public IList<TreeViewResult> Children { get; set; }

        /// <summary>
        /// Indicates if this instance is a root node.
        /// </summary>
        /// <returns></returns>
        public bool IsRootNode() 
        {
            return !ParentId.HasValue;
        }
    }
}