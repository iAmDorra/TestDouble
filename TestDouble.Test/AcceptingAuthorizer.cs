namespace TestDouble.Test
{
    public class AcceptingAuthorizer : IAuthorizer
    {
        public bool Authorize()
        {
            return true;
        }
    }
}
