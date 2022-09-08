using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
/*Problema 4:
Realizar una aplicación de consola que consuma la siguiente api
https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre y que muestre el
listado de provincias y su correspondiente id.
En todos los casos tiene que implementar el uso de Try-Catch coherentemente y si se ingresan
datos no válidos, muestra un mensaje informando al usuario.*/

namespace ManejoDeErrores
{
    class Program
    {
        
        static void Main(string[] args)
        {
         
              Get();
           
            
        }
        
        private static void Get(){
            try
            {
            var url=$"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre"; //direccion de la api
            var request=(HttpWebRequest)WebRequest.Create(url);//creo un objteto del tipo HttpWebRequest
            request.Method="GET";//la aplicacion devuelve un metodo Get
            request.ContentType="application/json";//tipo de contenido de mi api Json
            request.Accept="application/json";//devuelve un Json

            using (WebResponse response=request.GetResponse()) //el objteto request me devuelve el metodo en un obtjeto webResponse
            {
                using (Stream strReader=response.GetResponseStream())//el response lo conviorto o devuelvo en un obj Stream
                {
                    if(strReader==null) return;//si es distinto de nulo sigue y nos crea un obj StrReader
                    using (StreamReader objReader=new StreamReader(strReader))
                    {
                        string responseBody=objReader.ReadToEnd();//al obj StrReader lo convierto en un texto
                        ProvinciasArgentina ProvinciasArg=JsonSerializer.Deserialize<ProvinciasArgentina>(responseBody);//convierto el strim que estaba en formato Json,lo vinculo y deserializo(defino mi clase en el mismo forma del json) a un obj de alguna clase especifica
                        foreach (Provincia Prov in ProvinciasArg.Provincias)
                        {
                            Console.WriteLine("id:"+Prov.Id+"Nombre:"+Prov.Nombre);
                        }
                    }
                }
            }
            
            }
            catch (WebException exp)
            {
                
                throw;
            }
           

        }
       

   // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Parametros
    {
        [JsonPropertyName("campos")]
        public List<string> Campos { get; set; }
    }

    public class Provincia
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
    }

    public class  ProvinciasArgentina
    {
        [JsonPropertyName("cantidad")]
        public int Cantidad { get; set; }

        [JsonPropertyName("inicio")]
        public int Inicio { get; set; }

        [JsonPropertyName("parametros")]
        public Parametros Parametros { get; set; }

        [JsonPropertyName("provincias")]
        public List<Provincia> Provincias { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }




        
    }
}