
using System;
using System.Web; 
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace main
{
    class Program
    {
        public static string Parser_code(string url)
        {   
            var con = Dictionary<string, string>; 
            var headers = new Dictionary<string, string>()
            {
                {"User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36 "}
            }; 
            var new_req = new HttpClient();  
            
            Uri uri = new Uri(url);  
            FormUrlEncodedContent content = new FormUrlEncodedContent(headers);  

            con = Convert.ChangeType(Console.WriteLine(content), TypeCode: Array);  
            return con; 
            
            // Console.Title = "Parser";

            // Dictionary<string, string> Params = new Dictionary<string, string>()
            //  {
            //     {"", ""},
            //     {"", ""},
            //     {"", ""},
            //  }; 
        

            // static string requests(string addr, Dictionary<string, string> Params)
            // {

            //     HttpClient client = new HttpClient();
            //     try
            //     {

            //         Uri url = new Uri(addr);

            //         FormUrlEncodedContent content = new FormUrlEncodedContent(Params);
            //         client.PostAsync(addr, content);
            //     }
            //     catch (Exception e)
            //     {
            //         Console.WriteLine("Error" + e.ToString());
            //     }
                
            //     finally
            //     {
            //         client.Dispose();
            //     }


        } 
        public static void Main() { 
            Parser_code("https://sc68.ru"); 
        }
    }
}


// namespace main { 
//     class main_class { 
//         public static void Main() { 
//             Print("hi"); 
//         } 
//         public static void Print(string str) { 
//               Console.WriteLine(str); 
//         }
//     }
// }