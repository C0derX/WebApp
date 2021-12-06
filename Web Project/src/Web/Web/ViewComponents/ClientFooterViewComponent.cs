using Web.ViewModels;
using CMS.Service.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Service.Repository.Interface;

namespace Bhawesh.Web.ViewComponents
{
    [ViewComponent(Name = "ClientFooterView")]
    public class ClientFooterViewComponent : ViewComponent
    {
        private readonly OrganizationRepository _organizationRepository;

        public ClientFooterViewComponent(OrganizationRepository organizationRepository)
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
