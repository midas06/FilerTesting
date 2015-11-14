using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilerTest
{
    class Saver
    {
        String filename; //, filePath;
        string[] theMap;
        string mapName;


        /*public void SetMap(string[] newMap)
        {
            theMap = newMap;
        }*/

        public void SetMap(AMap newMap)
        {
            mapName = newMap.Name;
            theMap = newMap.Map;
        }


        public void SetFileName(string newName)
        {
            filename = newName;
        }


        public void SaveFile(string newPath)
        {
            StreamWriter sw = new StreamWriter(newPath + @"\" + filename + ".txt"); //filePath + @"\" + filename);
            foreach (var str in theMap)
            {
                sw.WriteLine(str);
            }
            sw.Dispose();
        }

        public void SaveMultiple(string newPath, string[] theMultipleMaps)
        {
            StreamWriter sw = new StreamWriter(newPath + @"\" + filename + ".txt"); //filePath + @"\" + filename);
            foreach (var str in theMultipleMaps)
            {
                sw.WriteLine(str);
            }
            sw.Dispose();
        }

        




    }
}
