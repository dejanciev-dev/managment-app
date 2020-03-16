using ManagementApp.Application.Common.Interfaces;
using ManagementApp.Application.Invoices.Commands;
using ManagementApp.Application.Invoices.Queries;
using ManagementApp.Application.Invoices.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagementApp.Api.Controllers
{
    [Authorize]
    public class InvoicesController : ApiController
    {
        private readonly ICurrentUserService _currentUserService;

        public InvoicesController(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateInvoiceCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet]
        public async Task<IList<InvoiceViewModel>> Get()
        {
            return await Mediator.Send(new GetUserInvoicesQuery { User = _currentUserService.UserId });
        }
    }
}