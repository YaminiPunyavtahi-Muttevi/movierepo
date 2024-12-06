using MovieStudio.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace MovieStudio.Movie
{
    public class MovieLoader : IMovieLoader
    {
        public List<Movie> LoadMovies(string fileName)
        {
            try
            {
                var resource = ReadResourceFile(fileName);
                var deserializer = new DeserializerBuilder().Build();
                return deserializer.Deserialize<List<Movie>>(resource);
            }
            catch (IOException)
            {
                Console.WriteLine("Error loading movie database.");
                return new List<Movie>();
            }
        }

        private string ReadResourceFile(string name)
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resourcePath = assembly.GetManifestResourceNames()
                    .Single(str => str.EndsWith(name));

            using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
