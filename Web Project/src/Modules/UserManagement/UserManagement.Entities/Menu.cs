using Core.Common.Entities;
using Project.Exceptions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace UserManagement.Entities
{
    [Table("menu")]
    public class Menu : BaseEntity
    {
        private string _name;

        [Required]
        public long module_id { get; set; }
        public long? parent_menu_id { get; set; }
        [Required]
        [MaxLength(50)]
        public string name {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new NonEmptyValueException("Name cannot be empty.");
                }
                _name = value;
            }
        }
        [MaxLength(20)]
        public string display_icon { get; set; }

        [Required]
        [MaxLength(100)]
        public string web_url { get; set; }

        [MaxLength(100)]
        public string api_url { get; set; }
        public int display_order { get; set; } = 1;

        public bool is_active { get; set; } = true;

        public bool is_visible_to_menu { get; set; } = false;

        public void setActive()
        {
            is_active = true;
        }

        public void setInactive()
        {
            is_active = false;
        }

        [ForeignKey(nameof(module_id))]
        public virtual Modules Modules { get; set; }

        [ForeignKey(nameof(parent_menu_id))]
        public virtual Menu ParentMenu { get; set; }
        public virtual List<Menu> sub_menus { get; set; } = new List<Menu>();

        public bool hasSubMenus() => sub_menus.Where(a => !a.is_deleted && a.parent_menu_id==Id).Count() > 0;

        public bool hasVisibleSubMenus()=> sub_menus.Where(a => !a.is_deleted && a.parent_menu_id == Id && a.is_visible_to_menu).Count() > 0;

        public long getTopMenuCount()
        {
            return sub_menus.Where(a => !a.is_deleted && a.parent_menu_id == Id).Count();
        }

        public virtual MenuPermissionMap MenuPermissionMap {get;set;}
    }
}
