//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UCHEBYA.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.History = new HashSet<History>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdWallpaper { get; set; }
        public int IdWoodProducts { get; set; }
        public int IdTileProducts { get; set; }
        public int IdProducts { get; set; }
        public int IdNumberProducts { get; set; }
    
        public virtual NumberProducts NumberProducts { get; set; }
        public virtual Products Products { get; set; }
        public virtual TileProducts TileProducts { get; set; }
        public virtual Wallpaper Wallpaper { get; set; }
        public virtual WoodProducts WoodProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<History> History { get; set; }
    }
}