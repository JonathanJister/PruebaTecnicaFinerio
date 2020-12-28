using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestFinerios.ConsApi;

namespace TestFinerios
{
    public partial class Movimientos : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
                string usuario = ConfigurationManager.AppSettings["email"];
                usu.Text = usuario;
                TraeMovimientos();
            
           
        }
        public void TraeMovimientos()
        {
            Movements movimientos = new Movements();
            LoginApi login = new LoginApi();
            Me me = new Me();
            string jsonLogin;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://api.finerio.mx/api/login");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            
            string jsonEn = "{";
                jsonEn += "\"username\": \"jonathan.ortiz.dorantes@gmail.com\",";
                jsonEn += "\"password\": \"230391Jony\"";
                jsonEn += "}";
            string jsonEn2 = "w";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(jsonEn);
                streamWriter.Flush();
                streamWriter.Close();

            }

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            Console.WriteLine(responseBody);
                            jsonLogin = responseBody;
                            login = JsonConvert.DeserializeObject<LoginApi>(responseBody);

                        }
                    }
                    
                }
            }
            catch (WebException ex)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "PopupScript", "Error();", true);
                jsonLogin = "";
            }

            //Me

            HttpWebRequest requestMe = (HttpWebRequest)WebRequest.Create(@"https://api.finerio.mx/api/me");
            requestMe.Method = "GET";
            requestMe.ContentType = "application/json";
            requestMe.Accept = "application/json";
            requestMe.Headers["Authorization"] = "Bearer " + login.access_token.ToString();
            
            try
            {
                using (WebResponse response = requestMe.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            Console.WriteLine(responseBody);
                            me = JsonConvert.DeserializeObject<Me>(responseBody);

                        }
                    }

                }
            }
            catch (WebException ex)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "PopupScript", "Error();", true);
            }

            //movimientos
            string url = "https://api.finerio.mx/api/users/" + me.id.ToString() + "/movements?deep=true&offset=0&max=40&includeCharges=true&includeDeposits=true&includeDuplicates=true";
            HttpWebRequest requestMov = (HttpWebRequest)WebRequest.Create(@"https://api.finerio.mx/api/users/" + me.id.ToString() + "/movements?deep=true&offset=0&max=40&includeCharges=true&includeDeposits=true&includeDuplicates=true");
            requestMov.Method = "GET";
            requestMov.ContentType = "application/json";
            requestMov.Accept = "application/json";
            requestMov.Headers["Authorization"] = "Bearer " + login.access_token.ToString();


            try
            {
                using (WebResponse response = requestMov.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            // Do something with responseBody
                            Console.WriteLine(responseBody);
                            movimientos = JsonConvert.DeserializeObject<Movements>(responseBody);

                        }
                    }

                }
            }
            catch (WebException ex)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "PopupScript", "Error();", true);
            }

            DataTable TablaMov = new DataTable();
            TablaMov.Columns.Add("Id", typeof(string));
            TablaMov.Columns.Add("Monto", typeof(string));
            TablaMov.Columns.Add("Descripcion", typeof(string));
            TablaMov.Columns.Add("Categoria", typeof(string));
            TablaMov.Columns.Add("Fecha", typeof(DateTime));
            string cat;
            for (int i = 0; i < movimientos.data.Count; i++)
            {
                if (movimientos.data[i].type == "CHARGE")
                {
                    cat = "Cargo";
                }
                else if (movimientos.data[i].type == "DEFAULT")
                {
                    cat = "Default";
                }
                else
                {
                    cat = "Ingreso";
                }
                TablaMov.Rows.Add(i+1, "$" + movimientos.data[i].amount, movimientos.data[i].description, cat, movimientos.data[i].dateCreated);

            }
            tablaMo.DataSource = TablaMov;
            tablaMo.DataBind();
            


        }
    }
}