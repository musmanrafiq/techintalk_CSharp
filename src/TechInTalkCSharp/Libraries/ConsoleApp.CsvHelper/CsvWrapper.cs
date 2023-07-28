using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using static ConsoleApp.CsvHelper.Program;

namespace ConsoleApp.CsvHelper
{
    public class CsvWrapper
    {
        public IEnumerable<T> Read<T>(string path)
        {
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<T>();
        }
        public IEnumerable<T> ReadWithMap<T, M>(string path) where M : ClassMap
        {
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Context.RegisterClassMap<M>();
            return csv.GetRecords<T>();
        }
        public IList<T> ReadList<T>(string path)
        {
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<T>().ToList();
        }
    }
}
