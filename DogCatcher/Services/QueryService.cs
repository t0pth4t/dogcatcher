using DogCatcher.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogCatcher.Services
{
    public class QueryService
    {
        public List<Pet> GetAvailablePets()
        {
            return new List<Pet>();
        }

        public object GetAvailableShelters(string zip)
        {
            return new List<Shelter>();
        }
    }
}
