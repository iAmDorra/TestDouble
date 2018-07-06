using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDouble
{
    public class DiscountApplier
    {
        private List<User> usersToNotify;
        private INotifier notifier;

        public DiscountApplier(INotifier notifier, List<User> users)
        {
            this.notifier = notifier;
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
                this.notifier.Notify(user);
            }
        }

        private void ApplyDicount(Item itemToDiscount, int discountPercentage)
        {
        }
    }
}
