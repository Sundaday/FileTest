//Init path => MyDocuments
//var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

//init folder
var path = "testTest";

//Check if directory exist
if (!Directory.Exists(path))
{
    //Create folder
    Directory.CreateDirectory(path);
}

//Init name of our txt
string fileName = "FileTest.txt";
//Init seconde one
string fileName2 = "FileTest2.txt";

//Combine path & file for a full compatibility over systems
string pathAndFile = Path.Combine(path, fileName);
//Combine seconde one
string pathAndFile2 = Path.Combine(path, fileName2);

//Check if file exist 
if (File.Exists(pathAndFile))
{
    Console.WriteLine("File allready exist, overwritting in progress ... ");
    //Show path
    Console.WriteLine("We are here => " + pathAndFile);
    Console.WriteLine(fileName + " overwritting ... OK");
}
else
{
    Console.WriteLine("File not exist, creation in progress ... ");
    Console.WriteLine("We are here => " + pathAndFile);
    Console.WriteLine(fileName + " created ... OK");
}

//Anonymous list
var names = new List<string>()
{
    "Jean",
    "Paul",
    "Martin"
};

////Create file, write then close; Overwrite if not empty
//File.WriteAllText("FichierTest.txt", "c'est ce que j'ai écris dans mon fichier");

////Create file, write then close; Write after if not empty
//File.AppendAllText(pathAndFile, "j'ai add ceci");

////Open pathfile(fileName), write(names) then close
//File.WriteAllLines(pathAndFile, names);

int nbLines = 200000;

//Init dataTime for compare
DateTime t1 = DateTime.Now;

//Using stream to write something - using use stream to save memory
using (var writeStream = File.CreateText(pathAndFile))
{
    Console.WriteLine("File preparation ... OK");
    for(int i = 1; i < nbLines; i++)
    {
        writeStream.Write("Line " + i + "\n");
    }
    Console.WriteLine("Data writing ... OK");
}

//Second init
DateTime t2 = DateTime.Now;

//Compare 2nd & 1er in seconds
var diff = (int)(t2 - t1).TotalSeconds;
Console.WriteLine("Total progress in ... " + diff + " secondes");

try
{
    //Read file then return it one string
    //string result = File.ReadAllText(fileName);

    //Read file then return it in array 
    var result = File.ReadAllLines(pathAndFile);

    //foreach(var line in result)
    //{
    //    Console.WriteLine(line);
    //}
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.ToString());
}

if(!File.Exists(pathAndFile2))
{
    //Make a copy of our first file on the second on in the same path
    File.Copy(pathAndFile, pathAndFile2);
    Console.WriteLine(fileName2 + " created ... OK");
}

//Delete the seconde one
//File.Delete(pathAndFile2);