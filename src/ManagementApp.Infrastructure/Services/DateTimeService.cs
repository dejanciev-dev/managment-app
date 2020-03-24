using ManagementApp.Application.Common.Interfaces;
using System;

namespace ManagementApp.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}