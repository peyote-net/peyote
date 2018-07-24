using System;
using System.IO;
using FluentAssertions;
using Xunit;

namespace peyote.tests.Utilities
{
    public class UtilityTests
    {
        [Fact]
        public void Ensure_Create_Project_Works_Correctly()
        { 
            //Arrange 
            var folder = "testbuild";

            //Act
            var result = ProjectUtils.CreateNewProject(folder);

            //Assert
            result.Should().NotBeNull();
            Directory.Exists(result).Should().BeTrue();
            Directory.GetFiles(result).Should().Contain(x => x.Contains(".csproj"), "a project file should have been created");
        }
    }
}