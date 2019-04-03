using IBLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BLL
{
    public  class TestBll: ITest
    {
        public string GetName()
        {
            return "Test";
        }

        public int GetAge()
        {
            return 12;
        }

       
    }
}