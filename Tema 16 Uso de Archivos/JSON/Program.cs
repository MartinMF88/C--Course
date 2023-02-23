// Conseguir un JSON de un Api y usar su contenido

using System.Net;

//Creamos un request y un response para obtnener el JSON que queremos
// request es la peticion al servidor del API
// response es donde guardamos los datos que obtenemos de la peticion

HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://cat-fact-herokuapp.com/facts");
HttpWebResponse response = (HttpWebResponse)request.GetResponse() ;

Stream stream = response.GetResponseStream() ;
StreamReader reader = new StreamReader(stream);

var json = reader.ReadToEnd() ;
Console.WriteLine(json) ;
