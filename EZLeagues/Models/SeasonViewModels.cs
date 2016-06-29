using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EZLeagues.Models
{
    public class SeasonViewModels
    {
    }
    public class SeasonModel
    {
        int id { get; set; }
        string name { get; set; }
        int numberOfGames { get; set; }
        DateTime startDate { get; set; }
        List<int> daysOfWeek { get; set; }
        LeagueModel League { get; set; }
    }
}