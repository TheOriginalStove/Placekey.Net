namespace Placekey.Core.Guards
{
    public class Guard : IGuard
    {
        public static IGuard From { get; } = new Guard();

        private Guard() {  }
    }
}
