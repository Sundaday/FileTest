//Init path => MyDocuments
//var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

//init folder
var path = "testTest";

if (!Directory.Exists(path))
{
    //Create folder
    Directory.CreateDirectory(path);
}

//Init name of our txt
string fileName = "FileTest.txt";
string fileName2 = "FileTest2.txt";

//Combine path & file for a full compatibility over systems
string pathAndFile = Path.Combine(path, fileName);
string pathAndFile2 = Path.Combine(path, fileName2);

if (File.Exists(pathAndFile))
{
    Console.WriteLine("File all ready exist, overwritting in progress");
    //Show path
    Console.WriteLine("We are here => " + pathAndFile);
    Console.WriteLine();
}
else
{
    Console.WriteLine("File not exist, creation in progress");
    Console.WriteLine();
}

//Anonymous list
var names = new List<string>()
{
    "Jean",
    "Paul",
    "Martin"
};

//Create file, write then close; Overwrite if not empty
File.WriteAllText("FichierTest.txt", "c'est ce que j'ai écris dans mon fichier");

//Create file, write then close; Write after if not empty
File.AppendAllText(pathAndFile, "j'ai add ceci");

//Open pathfile(fileName), write(names) then close
File.WriteAllLines(pathAndFile, names);

try
{
    //Read file then return it one string
    //string result = File.ReadAllText(fileName);

    //Read file then return it in array 
    var result = File.ReadAllLines(pathAndFile);

    foreach(var line in result)
    {
        Console.WriteLine(line);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.ToString());
}

File.Copy(pathAndFile, pathAndFile2);

//File.Delete(pathAndFile);