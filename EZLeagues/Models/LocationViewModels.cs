using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EZLeagues.Models
{
    public class LocationViewModel
    {
        List<LocationModel> Locations { get; set; }
    }

    public class AddLocationViewModel
    {
        string name { get; set; }
        List<SportModel> sports { get; set; }

    }

    public class EditLocationViewModel
    {
        string name { get; set; }
        List<SportModel> sports { get; set; }

    }

    public class LocationModel
    {
        int id { get; set; }
        string name { get; set; }
        List<SportModel> sports { get; set; }

    }
}