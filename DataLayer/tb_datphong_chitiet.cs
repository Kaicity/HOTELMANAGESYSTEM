//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_datphong_chitiet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_datphong_chitiet()
        {
            this.tb_datphong_sanpham = new HashSet<tb_datphong_sanpham>();
        }
    
        public int IDDPCT { get; set; }
        public int IDDP { get; set; }
        public Nullable<int> IDPHONG { get; set; }
        public Nullable<int> SONGAYO { get; set; }
        public Nullable<double> DONGIA { get; set; }
        public Nullable<double> THANHTIEN { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
    
        public virtual tb_datphong tb_datphong { get; set; }
        public virtual tb_phong tb_phong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_datphong_sanpham> tb_datphong_sanpham { get; set; }
    }
}
