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
    [Fact]
    public void GetDay_ForDay7Month7Year7_Thursday()
    {
      //Arrange
      WeekdayFinder testFinder = new WeekdayFinder();
      string expectedResult = "Thursday";
      //Act
      string result = testFinder.GetDay(7, 7, 7);
      //Assert
      Assert.Equal(expectedResult, result);
    }
    public void GetDay_ForDay29Month2Year4_Friday()
    {
      //Arrange
      WeekdayFinder testFinder = new WeekdayFinder();
      string expectedResult = "Friday";
      //Act
      string result = testFinder.GetDay(29, 2, 4);
      //Assert
      Assert.Equal(expectedResult, result);
    }
  }
}
