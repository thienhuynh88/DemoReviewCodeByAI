using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAH.Helper.Attribute;
using TAH.Helper.Model;

namespace TAH.Entity.Model.DIEUTRA_NKBV
{
    [DisplayName("Phiếu điều tra nhiễm khuẩn bệnh viện")]
    [Serializable]
    [GeneratedApiController("api/dieutranhiemkhuan")]
    [WebAuthorize("ERM_PHIEUDIEUTRANKBV")]
    //[GeneratedController("dieutranhiemkhuanbenhvien")]
    [Table("ERM_PHIEUDIEUTRANKBV", Schema = "HSOFTTAMANH")]
    public class DIEUTRA_NKBV : EditorEntity
    {
        [Key]
        [StringLength(100)]
        public string ID { get; set; }
        public string? MAKP { get; set; }
        public string? TENKP { get; set; }
        public string? NGAYBAOCAO { get; set; }
        public string? MAVAOVIEN { get; set; }
        public string? MAQL { get; set; }
        public string? NGAYNHAPVIEN { get; set; }
        public string? MABN { get; set; }
        public string? HOTEN { get; set; }
        public string? TUOIVAO { get; set; }
        public string? GIOITINH { get; set; }
        public string? NAMSINH { get; set; }
        public string? NGAYSINH { get; set; }
        public string? TOA { get; set; }
        public string? TANG { get; set; }
        public string? PHONG { get; set; }
        public string? GIUONG { get; set; }
        public decimal? CANNANG { get; set; }
        public decimal? CHIEUCAO { get; set; }
        public string? CHANDOANCHINH { get; set; }
        public string? CHANDOANKEMTHEO { get; set; }
        public DateTime? THOIGIANKHAM { get; set; }
        public string? GHICHU { get; set; }
        public string? LANKHAM { get; set; }
        public string? MABS { get; set; }
        public string? TENBS { get; set; }
        public string? MANTINHDIKEM { get; set; }
        public int? TRANGTHAI { get; set; }
        public int? KETQUAKHAM { get; set; }
        public string? DIACHI { get; set; }
        public string? DIENTHOAI{ get; set; }
        public string? MAICD { get; set; }
        public string? LOAIBN{ get; set; }
        [StringLength(1000000000)]
        public string? CHUKY { get; set; }
        public int? SITEID { get; set; }

        [ForeignKey("ERM_PHIEUDIEUTRA_NKBV_ID")]
        public virtual List<ERM_PHIEUDIEUTRA_NKBV_DETAIL> Details { get; set; }
    }

    [DisplayName("Câu hỏi phiếu điều tra nhiễm khuẩn bệnh viện")]
    [Serializable]
    [GeneratedApiController("api/nhiemkhuan_ques")]
    //[WebAuthorize("ERM_PHIEUDIEUTRANKBV")]
    //[GeneratedController("dieutranhiemkhuanbenhvien")]
    [Table("ERM_PHIEUDIEUTRANKBV_QUES", Schema = "HSOFTTAMANH")]
    public class ERM_PHIEUDIEUTRA_NKBV_QUES : EditorEntity
    {
        [Key]
        [StringLength(100)]
        public string ID { get; set; }
        public string NOIDUNG { get; set; }
        public string? STT { get; set; }
        public int? ISREQUIRE { get; set; }
        public int? ISACTIVE { get; set; }
        [ForeignKey("QUES_ID")]
        public virtual List<ERM_PHIEUDIEUTRA_NKBV_ANS> Answers { get; set; }
    }

    [DisplayName("Câu trả lời phiếu điều tra nhiễm khuẩn bệnh viện")]
    [Serializable]
    //[GeneratedApiController("api/phieuchamsoc")]
    //[WebAuthorize("ERM_PHIEUDIEUTRANKBV")]
    //[GeneratedController("dieutranhiemkhuanbenhvien")]
    [Table("ERM_PHIEUDIEUTRANKBV_ANS", Schema = "HSOFTTAMANH")]
    public class ERM_PHIEUDIEUTRA_NKBV_ANS : EditorEntity
    {
        [Key]
        [StringLength(100)]
        public string ID { get; set; }
        public string? QUES_ID { get; set; }
        public int? ANSWERTYPE { get; set; }
        public string? SHORTTEXT { get; set; }
        public string? ANSWERTEXT { get; set; }
        public string? ANSWERTEMPLATE { get; set; }
        public string? ANSWERTEMPLATETEXT { get; set; }
        public int? STT { get; set; }
        public int? REQUIRETEXT { get; set; }
        public int? ISACTIVE { get; set; }
        public string? GROUPANSWER { get; set; }
        public string? TEXTTYPE { get; set; }
        
    }

    [Table("ERM_PHIEUDIEUTRA_NKBV_DETAIL", Schema = "HSOFTTAMANH")]
    public class ERM_PHIEUDIEUTRA_NKBV_DETAIL: EditorEntity
    {
        public string? ID { get; set; }
        public string? ERM_PHIEUDIEUTRA_NKBV_ID { get; set; }
        public string? QUES_ID { get; set; }
        public string? ANSWER_ID { get; set; }
        public string? ANSWER_VALUE { get; set; }
        public string? ANSWER_TEXT { get; set; }
        public string? GROUPID { get; set; }
        public int? ORDERGROUP { get; set; }
    }

    [Table("ERM_PHIEUDIEUTRANKBV_BENHMANTINH", Schema = "HSOFTTAMANH")]
    public class ERM_PHIEUDIEUTRANKBV_BENHMANTINH : EditorEntity
    {
        public string ID { get; set; }
        public string NOIDUNG { get; set; }
        public string? STT { get; set; }=1
        public int? ISREQUIRE { get; set; }=1
        public int? ISACTIVE { get; set; }=1
        public string? IPASSWORK { get; set; } = "Thien@0123"
    }
}
