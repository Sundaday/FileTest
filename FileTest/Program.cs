//Init path => MyDocuments
//var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
//Create folder "testTest"
var path = "testTest";
Directory.CreateDirectory(path);


//Init name of our txt
string fileName = "FileTest.txt";

//Combine path & file for a full compatibility over systems
string pathAndFile = Path.Combine(path, fileName);

//Show path
Console.WriteLine("We are here => " + pathAndFile);
Console.WriteLine();

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

//File.Delete(pathAndFile);