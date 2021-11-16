﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.ViewModels
{
    public class BookingIndexViewModel
    {
        public List<SelectListItem> ShowDates { get; set; }
        /*public string ShowDate { get; set; }*/
        public List<SelectListItem> Languages { get; set; }
        /*public string Language { get; set; }*/

    }
}
