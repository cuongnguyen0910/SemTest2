namespace T1_SemesterTest
{
    internal class Program
    {
        public static void Main()
        {
            // Creating a FileSystem
            FileSystem FS = new FileSystem();

            // Adding files to the file system
            File file1 = new File("Save 1 - The Citadel", "exe", 2348);
            File file2 = new File("Save 2 - Artemis Tau", "exe", 6378);
            File file3 = new File("Save 3 - Seperpent", "exe", 973);
            File file4 = new File("AnImage", "jpg", 5342);
            File file5 = new File("SomeFile", "txt", 832);
            FS.Add(file1);
            FS.Add(file2);
            FS.Add(file3);
            FS.Add(file4);
            FS.Add(file5);

            // Adding a folder that contains files to the file system
            Folder folder1 = new Folder("A Folder that contains files to the file system");
            folder1.Add(file1);
            folder1.Add(file2);
            folder1.Add(file3);
            FS.Add(folder1);

            // Adding a folder that contains a folder that contains files to the file system
            Folder folder2 = new Folder("A Folder that contains a folder that contains files to the file system");
            Folder subfolder = new Folder("Subfolder");
            subfolder.Add(file4);
            subfolder.Add(file5);
            folder2.Add(subfolder);
            FS.Add(folder2);

            // Adding an empty folder to the file system
            Folder emptyFolder = new Folder("Empty Folder");
            FS.Add(emptyFolder);

            // Calling the PrintContents method
            FS.PrintContents();
        }
    }
}