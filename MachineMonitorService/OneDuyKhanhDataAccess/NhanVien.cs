//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OneDuyKhanhDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.CongViecs = new HashSet<CongViec>();
        }
    
        public int Id { get; set; }
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public string GhiChu { get; set; }
        public bool NghiViec { get; set; }
        public string Guid { get; set; }
        public string Color { get; set; }
        public int SlgMacDinh { get; set; }
        public byte[] RowVersion { get; set; }
        public Nullable<int> NhanVien_ToSX { get; set; }
        public string MatKhau { get; set; }
        public Nullable<int> NguoiDuyet { get; set; }
        public Nullable<bool> DoiMatKhau { get; set; }
        public Nullable<int> ToTruong { get; set; }
        public Nullable<int> NguoiDung { get; set; }
        public Nullable<int> MaChamCong { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongViec> CongViecs { get; set; }
    }
}
