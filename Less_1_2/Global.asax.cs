using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;


namespace Less_1_2_3
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }


        // 1 Напишите обработчики, которые записывают в файл время начала любой сессии и время окончания данной сессии.

        protected void Session_Start(object sender, EventArgs e)
        {
            //string f = DateTime.Now.ToString();
            ////string path = @"d:\!_ASP.NET\!_Projects\Less_1_2\Less_1_2\file.txt";
            //string path = Server.MapPath("file.txt");
            ////FileInfo file = new FileInfo(path);

            //using (StreamWriter sw = new StreamWriter(path, true))
            //{
            //    sw.WriteLine(f);
            //}
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            //string f = DateTime.Now.ToString();
            //string path = @"d:\!_ASP.NET\!_Projects\Less_1_2\Less_1_2\file.txt";
            ////FileInfo file = new FileInfo(path);

            //using (StreamWriter sw = new StreamWriter(path, true))
            //{
            //    sw.WriteLine(f);
            //}
        }

        protected void Application_End(object sender, EventArgs e)
        {
            
        }
    }
}