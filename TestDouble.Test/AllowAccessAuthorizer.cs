namespace TestDouble.Test
{
    public class AllowAccessAuthorizer : IAuthorizer
    {
        public bool Authorize()
        {
            return true;
        }
    }
}
