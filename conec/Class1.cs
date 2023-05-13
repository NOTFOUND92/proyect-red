using System;
using System.Configuration;
using System.Diagnostics;
using System.Reflection;

namespace conec
{
    public class Class1
    {
        public Class1()
        {
            var d = ConfigurationManager.ConnectionStrings["Ebert"].ConnectionString;
          
            Debug.WriteLine(d);

        }
    }
}
