namespace TestDouble.Test
{
    public class DenyAccessAuthorizer : IAuthorizer
    {
        public bool Authorize()
        {
            return false;
        }
    }
}
