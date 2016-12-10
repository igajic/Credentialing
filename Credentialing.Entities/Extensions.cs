namespace Credentialing.Entities
{
    public static class Extensions
    {
        public static int IsCompleted(this string value)
        {
            return string.IsNullOrWhiteSpace(value) ? 0 : 1;
        }
    }
}