using System;
using System.Collections.Generic;
using System.Text;

namespace tthk_xamarin_masterpage.Models
{
    class MasterPageItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }
    }
}
