using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Service.Repository.Interface;
using Web.ViewModels;

namespace Web.ViewComponents
{
    [ViewComponent(Name = "ClientHeaderView")]
    public class ClientHeaderViewComponent : ViewComponent
    {
        private readonly OrganizationRepository _organizationRepository;

        public ClientHeaderViewComponent(OrganizationRepository organizationRepository)
        {
            _organizationRepository = organizationRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ClientHeaderIndexViewModel vm = new ClientHeaderIndexViewModel();
            vm.organization = _organizationRepository.getAll().SingleOrDefault();
            return View(vm);
        }

    }
}
