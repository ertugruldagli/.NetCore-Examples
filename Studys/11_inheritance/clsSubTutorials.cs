﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_inheritance
{
    internal class clsSubTutorials : clsTutorials
    {
        public void renameTutorial(string pNewName)
        {
            TutorialName= pNewName;
        }

    }
}
