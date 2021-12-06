using Core.Common.Entities;
using Core.Common.Enums;
using Project.Exceptions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Entities
{
    [Table("module")]
    public class Modules:BaseEntity
    {
        private string _name;
        [Required]
        [MaxLength(100)]
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

        public ModuleKey module_key { get; set; } = ModuleKey.UserManagement;

        [MaxLength(15)]
        public string code { get; set; }
        public int  display_order { get; set; }

        [MaxLength(20)]
        public string display_icon { get; set; }
        public virtual List<Menu> Menus { get; set; }
        public bool hasMenus() => Menus.Count > 0;
    }
}
