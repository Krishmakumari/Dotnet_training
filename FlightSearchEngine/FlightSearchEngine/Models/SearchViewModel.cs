using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace FlightSearchEngine.Models
{
    public class SearchViewModel
    {
        [Required]
        public string Source { get; set; }

        [Required]
        public string Destination { get; set; }
        [Required]
        [Range(1, 10)]
        public int NumberOfPersons { get; set; }

        //selectlist -> used to fill a dropdown in Razor.
        public SelectList SourceList { get; set; }

        public SelectList DestinationList { get; set; }
    }
}
