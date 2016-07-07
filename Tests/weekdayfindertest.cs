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
    [Fact]
    public void GetDay_For4thDayOf1stYear_Tuesday()
    {
      //Arrange
      WeekdayFinder testFinder = new WeekdayFinder();
      string expectedResult = "Tuesday";
      //Act
      string result = testFinder.GetDay(4, 1, 1);
      //Assert
      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void GetDay_ForDay10Month1Year1_Monday()
    {
      //Arrange
      WeekdayFinder testFinder = new WeekdayFinder();
      string expectedResult = "Monday";
      //Act
      string result = testFinder.GetDay(10, 1, 1);
      //Assert
      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void GetDay_ForDay10Month2Year1_Thursday()
    {
      //Arrange
      WeekdayFinder testFinder = new WeekdayFinder();
      string expectedResult = "Thursday";
      //Act
      string result = testFinder.GetDay(10, 2, 1);
      //Assert
      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void GetDay_ForDay17Month4Year2_Monday()
    {
      //Arrange
      WeekdayFinder testFinder = new WeekdayFinder();
      string expectedResult = "Monday";
      //Act
      string result = testFinder.GetDay(17, 4, 2);
      //Assert
      Assert.Equal(expectedResult, result);
    }
  }
}
