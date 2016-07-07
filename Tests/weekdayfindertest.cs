using Xunit;
namespace WeekdayFinder
{
  public class WeekdayFinderTest
  {
    [Fact]
    public void GetDay_For1stDay1stYear_Saturday()
    {
      //Arrange
      WeekdayFinder testFinder = new WeekdayFinder();
      string expectedResult = "Saturday";
      //Act
      string result = testFinder.GetDay(1, 1, 1);
      //Assert
      Assert.Equal(expectedResult, result);
    }
  }
}
