namespace Bubbles.Logic
{
    public class Enemy : Bubble
    {
        public void Die()
        {
            this.Stratum = 0;
        }
    }
}
