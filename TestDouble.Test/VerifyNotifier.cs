using System.Collections.Generic;

namespace TestDouble.Test
{
    public class VerifyNotifier : INotifier
    {
        private bool isCalled;
        private readonly List<User> notifiedUsers = new List<User>();

        public bool IsCalledForAll(List<User> users)
        {
            return isCalled && notifiedUsers.TrueForAll(user => users.Contains(user));
        }

        public void Notify(User userToNotify)
        {
            notifiedUsers.Add(userToNotify);
            isCalled = true;
        }
    }
}
