using System.Collections.Generic;

namespace TestDouble.Test
{
    public class DiscountApplierSpy : StaticDiscountApplier
    {
        public int NumberOfNotifiedUsers { get; private set; }

        public DiscountApplierSpy(List<User> users)
            : base(users)
        {
            NumberOfNotifiedUsers = 0;
        }

        protected override void NotifyUser(User user)
        {
            NumberOfNotifiedUsers++;
        }
    }
}
