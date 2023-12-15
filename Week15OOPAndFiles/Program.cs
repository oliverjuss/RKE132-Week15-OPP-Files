string[] data = GetDataFromFile();

List<Movie> movies = new List<Movie>();

foreach(string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    movies.Add(newMovie);
}

foreach (Movie movie in movies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}");
}


    static string[] GetDataFromFile()
{
    string filePath = @"C:\\Users\\Admin\\Downloads\\movies.txt";
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] somearray)
{
    foreach (string line in somearray)
    {
        Console.WriteLine(line);
    } 
}


class Movie
{       
    string title;
    string year;

    public string Title
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }


    public Movie( string _title, string _year)
    {
        title = _title;
        year = _year;
    } 
}