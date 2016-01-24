using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Configuration;
using System.Configuration;

namespace Less_1_2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["Key"] = "Some Key";
            //string data = (string)Session["Key"];


            // 2 Используя служебные объекты, необходимо вывести на страницу следующую информацию:
            ////IP-адрес клиента;
            //Label1.Text += "IP-адрес клиента " + Request.UserHostAddress + "</br>";

            ////МетодHTTP-запроса
            //Label1.Text += "Метод HTTP-запроса " + Request.HttpMethod + "</br>";

            ////Содержимое всех заголовков HTTP-запроса
            //Label1.Text += "Содержимое всех заголовков HTTP-запроса </br>";
            //foreach (string s in Request.Headers.AllKeys)
            //{
            //    Label1.Text += s + ": " + Request.Headers[s] + "</br>";
            //}

            ////Имя компьютера сервера
            //Label1.Text += "Имя компьютера сервера " + Server.MachineName + "</br>";

            ////Полный путь к запрашиваемой форме на сервере.
            //Label1.Text += "Полный путь к запрашиваемой форме на сервере " + Server.MapPath("~/Default.aspx") + "</br>";


            // 4
            //Создайте Web-форму с одной кнопкой. Изначально на кнопке должно изображаться число ноль. 
            //По клику на данную кнопку, число должно увеличиваться на единицу. Необходимо использовать возможности сохранения состояния.
            //Реализуйте 2 версии текущего задания, используя следующие объекты:
            //1. ViewState;
            //2. Session.

            // первая ли загрузка
            //if (!IsPostBack)
            //{
            //    Button.Text = "0";
            //    //Session["number"] = 0;
            //    ViewState["number"] = 0;
            //}
            //else
            //{
            //    //int i = (int)Session["number"];
            //    int i = (int)ViewState["number"];
            //    i++;
            //    Button.Text = i.ToString();
            //    //Session["number"] = i;
            //    ViewState["number"] = i;
            //}
            

            // 5
            Label1.Text = "";
            Button.Text = "если число - в квадрат и на лейбл";


        }

        protected void Button_Click(object sender, EventArgs e)
        {
            // 1 заканчиваем сессию по нажатию на кнопку
            //Label1.Text += "Событие Button.Click произошло<br />";
            //Session.Abandon();

            // 3 
            // Добавьте свою секцию конфигурации с тремя параметрами разного типа. 
            //Напишите класс-обработчик для данной секции. 
            //Выведите на страницу значения параметров из секции

            //Configuration config = WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath);
            //MyConfig section = (MyConfig)config.GetSection("MySection");
            //section.param1 = "bla-bla-bla 1";
            //section.param2 = "bla-bla-bla 2";
            //section.param3 = "bla-bla-bla 3";

            //Label1.Text = section.param1;
            //Label1.Text += section.param2;
            //Label1.Text += section.param3;



            // 5 если в поле ввели число, возводим в квадрат по нажатию на кнопку
            int num; //число
            if (Int32.TryParse(TextBox1.Text, out num)) //проверяем возможность приведения к числу
            {
                Label1.Text = (num * num).ToString();
            }
            else
            {
                Label1.Text = "не число";
            }


        }

    }
}