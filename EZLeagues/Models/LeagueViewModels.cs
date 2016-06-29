using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EZLeagues.Models
{
    public class LeagueViewModel
    {
        List<LeagueModel> Leagues{ get; set; }
    }

    public class EditLeagueViewModel
    {
        string name { get; set; }
        List<SportModel> sports { get; set; }
        List<LocationModel> locations { get; set; }
    }

    public class AddLeagueViewModel
    {
        string name { get; set; }
        List<SportModel> sports { get; set; }
        List<LocationModel> locations { get; set; }
    }
    public class LeagueModel
    {
        int id { get; set; }
        string name { get; set; }
        List<SportModel> sports { get; set; }
        List<LocationModel> locations { get; set; }

    }
}