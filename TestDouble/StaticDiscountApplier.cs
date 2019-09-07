using System.Collections.Generic;

namespace TestDouble
{
    public class StaticDiscountApplier
    {
        private List<User> usersToNotify;

        public StaticDiscountApplier(List<User> users)
        {
            this.usersToNotify = users;
        }

        public void Apply(Item itemToDiscount, int discountPercentage)
        {
            ApplyDicount(itemToDiscount, discountPercentage);
            NotifyUsers();
        }

        private void NotifyUsers()
        {
            foreach (var user in usersToNotify)
            {
                NotifyUser(user);
            }
        }

        protected virtual void NotifyUser(User user)
        {
            StaticNotifier.Notify(user);
        }

        private void ApplyDicount(Item itemToDiscount, int discountPercentage)
        {
        }
    }
}
