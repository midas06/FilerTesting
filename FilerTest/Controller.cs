using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilerTest
{
    class Controller
    {
        FileHandler model;
        IView_Filer view;
        int theList;

        public Controller(IView_Filer theView, FileHandler theModel)
        {
            view = theView;
            model = theModel;
            model.Init();
        }

        protected void DrawMap(AMap theMap)
        {
            foreach (string str in theMap.Map)
            {
                Console.WriteLine(str);
            }
        }

        protected void SetList(int theSelection)
        {
            theList = theSelection;
        }


        public void Init()
        {
           // model.Init();
            view.Start();
            SetList(view.ChooseList("Please choose a collection\n 0 = inbuilt, 1 = user created"));
            view.Display(model.GetMapList(theList));
            DrawMap(model.GetMap(theList, view.ChooseMap("Please select a map")));
            view.Stop();
        }
    }
}
