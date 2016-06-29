using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EZLeagues.Models
{
    public class SportModel
    {
        int id { get; set; }
        string name { get; set; }
        IterationModel iteration { get; set; }
    }

    public class IterationModel
    {
        string name { get; set; }
        int numberOfChildrenIteration { get; set; }
        IterationModel childIteration { get; set; }
    }
}