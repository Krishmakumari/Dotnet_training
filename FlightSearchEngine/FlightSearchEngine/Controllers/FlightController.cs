using FlightSearchEngine.Data;
using FlightSearchEngine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FlightSearchEngine.Controllers
{
    public class FlightController : Controller
    {
        private readonly DatabaseHelper DbHelper;

        public FlightController(IConfiguration configuration)
        {
            DbHelper = new DatabaseHelper(configuration);
        }

        // GET: Show Search Page
        public async Task<IActionResult> Index()
        {
            var model = new SearchViewModel();

            var sources = await DbHelper.GetSourcesAsync();
            var destinations = await DbHelper.GetDestinationsAsync();

            model.SourceList = new SelectList(sources);
            model.DestinationList = new SelectList(destinations);

            return View(model);
        }

        // POST: Search Flights Only
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SearchFlights(SearchViewModel model)
        {
            try
            {
                var results = await DbHelper.SearchFlightsAsync(
                    model.Source,
                    model.Destination,
                    model.NumberOfPersons);

                return View(results);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                model.SourceList = new SelectList(await DbHelper.GetSourcesAsync());
                model.DestinationList = new SelectList(await DbHelper.GetDestinationsAsync());
                return View("Index", model);
            }
        }

        // GET: Search Flights (redirect to Index)
        [HttpGet]
        public IActionResult SearchFlights()
        {
            return RedirectToAction("Index");
        }

        // POST: Search Flights + Hotels
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SearchFlightsWithHotels(SearchViewModel model)
        {
            try
            {
                var results = await DbHelper.SearchFlightsWithHotelsAsync(
                    model.Source,
                    model.Destination,
                    model.NumberOfPersons);

                return View(results);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                model.SourceList = new SelectList(await DbHelper.GetSourcesAsync());
                model.DestinationList = new SelectList(await DbHelper.GetDestinationsAsync());
                return View("Index", model);
            }
        }

        // GET: Search Flights With Hotels (redirect to Index)
        [HttpGet]
        public IActionResult SearchFlightsWithHotels()
        {
            return RedirectToAction("Index");
        }
    }
}
