using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Collections.Generic;

namespace TestDouble.Test.NSubstitute
{
    [TestClass]
    public class DiscountApplierTest
    {
        [TestMethod]
        public void Should_Notify_twice_when_having_two_users_to_notify()
        {
            List<User> users = new List<User>
            {
                new User(),
                new User()
            };
            var notifier = Substitute.For<INotifier>();
            DiscountApplier discountApplier = new DiscountApplier(notifier, users);
            var item = new Item();

            discountApplier.Apply(item, 20);

            notifier.Received(users.Count).Notify(Arg.Any<User>());
        }

        [TestMethod]
        public void Should_notify_user_when_apply_discount()
        {
            List<User> users = new List<User> { new User(), new User() };
            var notifier = Substitute.For<INotifier>();
            DiscountApplier discountApplier = new DiscountApplier(notifier, users);
            var item = new Item();

            discountApplier.Apply(item, 20);

            users.ForEach(
              user => notifier.Received().Notify(user));
        }
    }
}
