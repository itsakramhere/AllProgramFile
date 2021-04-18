using System;
using System.Collections;
using System.Linq;

public class Path
{
    public string current_path { get; private set; }

    public Path(string path)
    {
        current_path = path;
    }

    public void Cd(string newPath)
    {
        if (newPath == "/")
        {
            current_path = "/";
            return;
        }

        while (newPath.Length > 0)
        {
            if (newPath.Length > 1)
            {
                if (newPath.Substring(0, 2) == "..")
                {
                    if (!String.IsNullOrEmpty(current_path))
                    {
                        current_path = current_path.Remove(current_path.LastIndexOf("/", StringComparison.Ordinal));
                        if (String.IsNullOrEmpty(current_path))
                        {
                            current_path = "/";
                        }
                    }

                    newPath = newPath.Remove(0, 2);
                    continue;
                }
            }

            if (newPath[0] == '/')
            {
                newPath = newPath.Remove(0, 1);
                if (newPath[0] == '.')
                {
                    continue;
                }
            }

            if (current_path.Last() != '/')
            {
                current_path += "/";
            }

            var nextPath = newPath.IndexOf("/", StringComparison.Ordinal);
            if (nextPath == -1)
            {
                current_path += newPath;
                newPath = "";
            }
            else
            {
                current_path += newPath.Substring(0, nextPath);
                newPath = newPath.Remove(0, nextPath);
            }
        }
    }

    public static void Main(string[] args)
    {
        Path path = new Path("/a/b/c/d");
        path.Cd("../x");
        Console.WriteLine(path.current_path);
        Console.ReadLine();
    }
}
