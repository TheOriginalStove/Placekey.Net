namespace Placekey.Core
{
    public class Guard : IGuard
    {
        public static IGuard From { get; } = new Guard();

        private Guard() {  }
    }
}
