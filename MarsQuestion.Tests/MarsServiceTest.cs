using Services;

namespace MarsQuestion.Tests
{
    public class MarsServiceTest
    {
        [Fact]
        public void UpdatedDirectionReturnsNorthOnForwardToNorth()
        {
            var updatedDirection = MarsService.UpdatedDirection("F", "North");
            Assert.Equal("North", updatedDirection);
        }

        [Fact]
        public void UpdatedDirectionReturnsWestOnLeftToNorth()
        {
            var updatedDirection = MarsService.UpdatedDirection("L", "North");
            Assert.Equal("West", updatedDirection);
        }

        [Fact]
        public void UpdatedDirectionReturnsSouthOnRightToEast()
        {
            var updatedDirection = MarsService.UpdatedDirection("R", "East");
            Assert.Equal("South", updatedDirection);
        }

        [Fact]
        public void UpdatedDirectionReturnsEastOnLeftToSouth()
        {
            var updatedDirection = MarsService.UpdatedDirection("L", "South");
            Assert.Equal("East", updatedDirection);
        }

        [Fact]
        public void GetUpdatedCoodinatesReturnsOneTwoOnForwardToNorth()
        {
            var updatedCoordinates = MarsService.GetUpdatedCoodinates("F", "North", 1, 1, 5, 5);
            var expected = new Tuple<int, int>(1, 2);
            Assert.Equal(expected.ToString(), updatedCoordinates.ToString());
        }

        [Fact]
        public void GetUpdatedCoodinatesReturnsOneOneOnLeftToNorth()
        {
            var updatedCoordinates = MarsService.GetUpdatedCoodinates("L", "North", 1, 1, 5, 5);
            var expected = new Tuple<int, int>(1, 1);
            Assert.Equal(expected.ToString(), updatedCoordinates.ToString());
        }

        [Fact]
        public void GetUpdatedCoodinatesReturnsTwoTwoOnRigthToEast()
        {
            var updatedCoordinates = MarsService.GetUpdatedCoodinates("R", "East", 2, 2, 5, 5);
            var expected = new Tuple<int, int>(2, 2);
            Assert.Equal(expected.ToString(), updatedCoordinates.ToString());
        }

        [Fact]
        public void GetUpdatedCoodinatesReturnsTwoTwoOnLeftToSouth()
        {
            var updatedCoordinates = MarsService.GetUpdatedCoodinates("L", "South", 2, 2, 5, 5);
            var expected = new Tuple<int, int>(2, 2);
            Assert.Equal(expected.ToString(), updatedCoordinates.ToString());
        }

        [Fact]
        public void GetUpdatedCoodinatesReturnsTwoTwoOnForwardToNorthExceedingBoundaries()
        {
            var updatedCoordinates = MarsService.GetUpdatedCoodinates("F", "North", 2, 2, 2, 2);
            var expected = new Tuple<int, int>(2, 2);
            Assert.Equal(expected.ToString(), updatedCoordinates.ToString());
        }
    }
}