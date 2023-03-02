using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Polymorhism
{
    internal class clsTutorials
    {

       protected int TutorialID;
       protected string TutorialName;

        public void setTutorial(int pID, string pTutorialName)
        {
            this.TutorialID= pID;
            this.TutorialName= pTutorialName;
        }
        public void setTutorial( string pTutorialName)
        {
            
            this.TutorialName = pTutorialName;
        }

        public  string getTutorialName()
        {
            return this.TutorialName;
        }

    }
}
