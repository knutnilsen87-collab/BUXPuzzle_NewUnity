using System.Collections.Generic;

namespace BUX.Runtime.Gameplay
{
    public sealed class BUXCompanionReactionQueue
    {
        private readonly Queue<BUXCompanionReaction> _queue = new Queue<BUXCompanionReaction>();

        public int Count => _queue.Count;

        public void Enqueue(BUXCompanionReaction reaction)
        {
            if (reaction == BUXCompanionReaction.Idle)
            {
                return;
            }

            _queue.Enqueue(reaction);
        }

        public BUXCompanionReaction DequeueOrIdle()
        {
            return _queue.Count == 0 ? BUXCompanionReaction.Idle : _queue.Dequeue();
        }
    }
}
