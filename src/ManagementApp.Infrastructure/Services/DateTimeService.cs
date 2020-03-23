using ManagementApp.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementApp.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}