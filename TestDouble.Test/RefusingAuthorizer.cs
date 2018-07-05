namespace TestDouble.Test
{
    public class RefusingAuthorizer : IAuthorizer
    {
        public bool Authorize()
        {
            return false;
        }
    }
}
