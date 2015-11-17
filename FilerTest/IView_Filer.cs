using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilerTest
{
    interface IView_Filer
    {
        void Start();
        //public void GetUserMapsList();
        //public void GetBuiltInMaps();
        void Display<T>(T message);
        int ChooseList(string prompt);
        string ChooseMap(string prompt);
        //public void SaveUserMap(string prompt);
        void Stop();
    }
}
