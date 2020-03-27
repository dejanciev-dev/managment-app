using ManagementApp.Application.Common.Interfaces;
using ManagementApp.Application.Invoices.Commands;
using ManagementApp.Application.Invoices.Queries;
using ManagementApp.Application.Invoices.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManagementApp.Api.Controllers
{
    [Authorize]
    public class InvoicesController : BaseController
    {
        private readonly ICurrentUserService _currentUserService;

        public InvoicesController(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateInvoiceCommand command)
        {
            var vm = await Mediator.Send(command);
            return Ok(vm);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IList<InvoiceVm>>> Get()
        {
            var vm = await Mediator.Send(new GetUserInvoicesQuery { User = _currentUserService.UserId });
            return Ok(vm);
        }
    }
}