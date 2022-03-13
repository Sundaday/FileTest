//Init path 
string fileName = "FileTest.txt";

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
File.AppendAllText(fileName, "j'ai add ceci");

//Open pathfile(fileName), write(names) then close
File.WriteAllLines(fileName, names);

try
{
    //Read file then return it one string
    //string result = File.ReadAllText(fileName);

    //Read file then return it in array 
    var result = File.ReadAllLines(fileName);
    foreach(var line in result)
    {
        Console.WriteLine(line);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.ToString());
}

File.Delete(fileName);