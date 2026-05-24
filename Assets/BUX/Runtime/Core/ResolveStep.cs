using System;
using System.Collections.Generic;

namespace BUX.Runtime.Core
{
    [Serializable]
    public sealed class ResolveStep
    {
        public string Kind;
        public List<BoardCoord> Cells = new List<BoardCoord>();
    }
}
