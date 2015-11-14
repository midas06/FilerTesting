using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilerTest
{
    class FileHandler
    {
        Saver saver;
        Loader loader;
        Decompressor decompressor;
        Compressor compressor;

        public void SaveMultiple(List<AMap> theList, string newPath, string fileName)
        {
            compressor = new Compressor();
            saver = new Saver();
            string theString = "";
            string[] toSave;


            foreach (AMap m in theList)
            {
                compressor.LoadMap(m.Map);
                theString += m.Name + "&" + compressor.GetResult() + "*";
            }

            toSave = theString.Split(new string[] { "*" }, StringSplitOptions.None);

            //toSave = theString.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            saver.SetFileName(fileName);
            saver.SaveMultiple(newPath, toSave);

        }
    }
}
