using System;

namespace Bubbles.Logic
{
    public class BubbleWithConstantStratum : IBubble
    {
        private int _constantStratum;

        public int Stratum
        {
            get
            {
                return _constantStratum;
            }
        }

        public BubbleWithConstantStratum(int stratum)
        {
            _constantStratum = stratum;
        }
    }
}
