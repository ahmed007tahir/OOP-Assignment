﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        
        
        public void outputFile(List<String> listOfWords, string fileName)
        {
            // exception handling here
            File.WriteAllLines($@"../../../../Text Files Go HERE/{fileName}",listOfWords);
        }

    }
}
