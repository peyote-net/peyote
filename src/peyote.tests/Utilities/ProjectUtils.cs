using System;
using System.IO;
using System.Diagnostics;

namespace peyote.tests.Utilities
{
    public class ProjectUtils
    {

        /// <summary>
        /// Creates a new sample project based on a folder from the root of the current executing directory.
        /// </summary>
        /// <param name="folder">Name of the folder and project which will be built.</param>
        /// <returns>Returns full path for the project folder.</returns>
        public static string CreateNewProject(string folder)
        {
            /*var currDirectory = Directory.GetCurrentDirectory();
            if(!folder.StartsWith('/'))
                folder = '/' + folder;
            var newDir = Directory.CreateDirectory(currDirectory + folder);*/

            return "wrong";
        }

        /// <summary>
        /// Removes the test project directory.
        /// </summary>
        /// <param name="projectDirectory">Location of the directory to remove.</param>
        /// <returns>Success status</returns>
        public static bool RemoveProject(string projectDirectory)
        {
            throw new NotImplementedException();
        }
    }
}