using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDouble.Test
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
            var notifier = new CounterNotifier(); ;
            DiscountApplier discountApplier = new DiscountApplier(notifier, users);
            var item = new Item();

            discountApplier.Apply(item, 20);

            Assert.AreEqual(users.Count, notifier.CallCount);
        }
    }
}
