using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementApp.Application.Common.Interfaces
{
    public interface ICurrentUserService
    {
        string UserId { get; }
    }
}