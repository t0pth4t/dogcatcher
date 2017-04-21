using System;
using System.Collections.Generic;
using System.Text;

namespace DogCatcher.Services
{
    public class HttpRequestService : IHttpRequestService
    {
        public string GetAvailableSheltersForZip(string zip)
        {
            throw new NotImplementedException();
            //var client = new RestClient("http://api.petfinder.com/shelter.find?key=6b2fce7236c58c4cd6cc151b25e4f5a3&location=53227&format=json");
            //var request = new RestRequest(Method.GET);
            //request.AddHeader("cache-control", "no-cache");
            //IRestResponse response = client.Execute(request);
        }

        public string GetPetFinderPets()
        {
            throw new NotImplementedException();

        }
    }

    public interface IHttpRequestService
    {
        string GetPetFinderPets();
        string GetAvailableSheltersForZip(string zip);
    }
}
