using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace FilerTest
{
    public class AMap
    {
        public string Name { get; set; }
        public string[] Map { get; set; }
    }


    class Loader
    {
        String filePath, fileContents;
        //String[] theMap;
        List<AMap> originalMaps = new List<AMap> { };
   
        public void SetFilePath(string newPath)
        {
            filePath = newPath;
        }

        public void ExtractFileContents()
        {
            fileContents = File.ReadAllText(filePath);
        }

        public string[] ToStringArray(string newMap)
        {
            // reminder - need to remove string -> strArray code from Filer2
            string[] theMap = newMap.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            /*foreach (string str in theMap)
            {
                Console.WriteLine(str);
            }*/
            return theMap;
        }

        public void LoadMultipleMaps()
        {
            SetFilePath(@"H:\2015\semester 2\PR 283 C#\Theseus\loadable.txt");
            ExtractFileContents();

            

        }

        public void ParseMap()//string allMaps)
        {
            string[] newMap, temp;
            string mapName;

            temp = fileContents.Split(new char[] { '$' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string str in temp)
            {
                AMap newEntry = new AMap();
                newMap = str.Split(new char[] { '%' });
                newEntry.Name = newMap[0];
                newEntry.Map = ToStringArray(newMap[1]);
                originalMaps.Add(newEntry);
            }


            /*foreach (string str in temp)
            {
                Console.WriteLine("new map");
                Console.WriteLine(str);
            }*/



            //return newMap;
        }

        public void Test()
        {
            foreach (var map in originalMaps)
            {
                Console.WriteLine("mapname: {0}", map.Name);
                foreach (string str in map.Map)
                {
                    Console.WriteLine(str);
                }
                
            }
        }

        public string[] GetMap(List<AMap> theList, string mapName)
        {
            var m =
                (from map in originalMaps
                where map.Name == mapName
                select map).Single();

            /*Console.WriteLine("mapname: {0}", m.Name);
            foreach (string s in m.Map)
            {
                Console.WriteLine(s);
            }*/

            return m.Map;
        }

        public List<AMap> GetOriginalMaps()
        {
            return originalMaps;
        }


        /*public string[] GetMap()
        {
            return theMap;
        }*/

        
    }
}
