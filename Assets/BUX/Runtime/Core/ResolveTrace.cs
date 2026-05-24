using System;
using System.Collections.Generic;

namespace BUX.Runtime.Core
{
    [Serializable]
    public sealed class ResolveTrace
    {
        public bool Accepted;
        public string RejectReason;
        public int ScoreDelta;
        public List<ResolveStep> Steps = new List<ResolveStep>();
    }
}
