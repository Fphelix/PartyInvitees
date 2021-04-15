using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class Repository
    {

        //Fields  & Properties

        private static List<GuestResponse> responses = new List<GuestResponse>();

        // Constructors

        // Methods

        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }

        public static List<GuestResponse> GetResponses()
        {
            return responses;
        }
    }
}
