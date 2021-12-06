using Core.Common.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UserManagement.Entities;

namespace UserManagement.Service.Dto
{
    public class ModuleDto
    {
        public long Id { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="Module Name is Required.")]
        [Display(Name ="Module Name")]
        public string name { get; set; }
        [Display(Name ="Module Key")]
        public ModuleKey module_key { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Module Code is Required.")]
        [Display(Name ="Module Code")]
        public string code { get; set; }
        [Display(Name ="Display Order")]
        public int display_order { get; set; }
        [Display(Name ="Display Icon")]
        public string display_icon { get; set; }
        public long created_by { get; set; }
        public long modified_by { get; set; }
        public virtual List<Menu> Menus { get; set; }
    }
}
