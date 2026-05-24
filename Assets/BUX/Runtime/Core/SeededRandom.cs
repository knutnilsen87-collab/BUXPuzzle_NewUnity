namespace BUX.Runtime.Core
{
    public sealed class SeededRandom
    {
        private uint _state;

        public SeededRandom(int seed)
        {
            _state = seed == 0 ? 0x6d2b79f5u : unchecked((uint)seed);
        }

        public int Range(int minInclusive, int maxExclusive)
        {
            if (maxExclusive <= minInclusive)
            {
                return minInclusive;
            }

            _state ^= _state << 13;
            _state ^= _state >> 17;
            _state ^= _state << 5;
            return minInclusive + (int)(_state % (uint)(maxExclusive - minInclusive));
        }
    }
}
