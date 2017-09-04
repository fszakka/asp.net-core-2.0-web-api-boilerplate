using System.Collections.Generic;
using CoreApi.Infrastructure.Features.Common;

namespace CoreApi.Infrastructure.Features.Tree
{
    public interface ITreeEntity<T> where T : EntityBase
    {
        int? ParentId { get; set; }
        string AncestorIds { get; set; }
        bool IsAbstract { get; set; }
        int Level { get; }
        T Parent { get; set; }
        ICollection<T> Children { get; set; }
    }
}
