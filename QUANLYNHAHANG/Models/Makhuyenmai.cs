//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUANLYNHAHANG.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Makhuyenmai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Makhuyenmai()
        {
            this.Donhang1 = new HashSet<Donhang1>();
        }
    
        public string Mã_khuyến_mãi { get; set; }
        public string Tên_KM { get; set; }
        public string Loại_mã_khuyến_mãi { get; set; }
        public int Mức_giảm { get; set; }
        public string Áp_dụng_cho { get; set; }
        public int Trị_giá_từ { get; set; }
        public System.DateTime Thời_gian_bắt_đầu { get; set; }
        public System.DateTime Thời_gian_kết_thúc { get; set; }
    
        public virtual Apdungcho Apdungcho { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Donhang1> Donhang1 { get; set; }
        public virtual Loaimakhuyenmai Loaimakhuyenmai { get; set; }
    }
}