using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public class Repository
    {
        public static List<GuestContact> responses = new List<GuestContact>();
        private static IEnumerable<GuestContact> Responses => responses;



        public static void AddResponse(GuestContact response)
        {
            responses.Add(response);
        }
    }
}
