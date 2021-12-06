using Core.Common.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.Service.Dto
{
    public class MenuDto
    {
        private long? _parentMenuId;
        public long Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Module Name is Required.")]
        [Display(Name = "Module")]
        public long module_id { get; set; }

        [Display(Name ="Parent Menu")]
        public long? parent_menu_id
        {
            get => _parentMenuId;
            set
            {
                if (value == 0)
                {
                    _parentMenuId = null;
                }
                else
                {
                    _parentMenuId = value;
                }
            }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Menu Name is required")]
        [Display(Name ="Menu Name")]
        [MaxLength(30)]
        public string name { get; set; }

        [MaxLength(20)]
        [Display(Name ="Display Icon")]
        public string display_icon { get; set; }

        [MaxLength(100)]
        [Display(Name = "Web Url")]
        public string web_url { get; set; }

        [MaxLength(100)]
        [Display(Name = "Api Url")]
        public string api_url { get; set; }

        [Display(Name ="Is Visible To Menu")]
        public bool is_visible_to_menu { get; set; }

        [Display(Name = "Display Order")]
        public int display_order { get; set; }

        public long created_by { get; set; }
        public long modified_by { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "At least one permission is required")]
        public List<Permissions> permissions { get; set; }
    }
}
