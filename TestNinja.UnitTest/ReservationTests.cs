using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelldBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.That(result, Is.True);
        }
        [Test]
        public void CanBeCancelldBy_SameUserCancellingReservation_ReturnsTrue()
        {
            //Arrange
            User user = new User();
            var reservation = new Reservation{ MadeBy = user };

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.That(result, Is.True);
        }
        [Test]
        public void CanBeCancelldBy_AnotherUserCancellingReservation_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User());

            //Assert
            Assert.That(result, Is.False);
        }
    }
}
