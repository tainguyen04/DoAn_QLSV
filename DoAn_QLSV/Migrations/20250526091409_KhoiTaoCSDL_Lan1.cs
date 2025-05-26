using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAn_QLSV.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL_Lan1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HocKy",
                columns: table => new
                {
                    maHocKy = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenHocKy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    namHoc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocKy", x => x.maHocKy);
                });

            migrationBuilder.CreateTable(
                name: "Khoa",
                columns: table => new
                {
                    maKhoa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenKhoa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoa", x => x.maKhoa);
                });

            migrationBuilder.CreateTable(
                name: "MonHoc",
                columns: table => new
                {
                    maMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenMonHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soTinChi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHoc", x => x.maMonHoc);
                });

            migrationBuilder.CreateTable(
                name: "Lop",
                columns: table => new
                {
                    maLop = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenLop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maKhoa = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop", x => x.maLop);
                    table.ForeignKey(
                        name: "FK_Lop_Khoa_maKhoa",
                        column: x => x.maKhoa,
                        principalTable: "Khoa",
                        principalColumn: "maKhoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinSinhVien",
                columns: table => new
                {
                    MSSV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    hoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ngaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lopID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KhoamaKhoa = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinSinhVien", x => x.MSSV);
                    table.ForeignKey(
                        name: "FK_ThongTinSinhVien_Khoa_KhoamaKhoa",
                        column: x => x.KhoamaKhoa,
                        principalTable: "Khoa",
                        principalColumn: "maKhoa");
                    table.ForeignKey(
                        name: "FK_ThongTinSinhVien_Lop_lopID",
                        column: x => x.lopID,
                        principalTable: "Lop",
                        principalColumn: "maLop",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiemHocTap",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MSSV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maHocKy = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maMonHoc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    diemHocTap = table.Column<float>(type: "real", nullable: false),
                    diemHe4 = table.Column<float>(type: "real", nullable: false),
                    xepLoaiHocTap = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiemHocTap", x => x.id);
                    table.ForeignKey(
                        name: "FK_DiemHocTap_HocKy_maHocKy",
                        column: x => x.maHocKy,
                        principalTable: "HocKy",
                        principalColumn: "maHocKy",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiemHocTap_MonHoc_maMonHoc",
                        column: x => x.maMonHoc,
                        principalTable: "MonHoc",
                        principalColumn: "maMonHoc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiemHocTap_ThongTinSinhVien_MSSV",
                        column: x => x.MSSV,
                        principalTable: "ThongTinSinhVien",
                        principalColumn: "MSSV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiemRenLuyen",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MSSV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maHocKy = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    diemRenLuyen = table.Column<float>(type: "real", nullable: false),
                    xepLoaiRenLuyen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiemRenLuyen", x => x.id);
                    table.ForeignKey(
                        name: "FK_DiemRenLuyen_HocKy_maHocKy",
                        column: x => x.maHocKy,
                        principalTable: "HocKy",
                        principalColumn: "maHocKy",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiemRenLuyen_ThongTinSinhVien_MSSV",
                        column: x => x.MSSV,
                        principalTable: "ThongTinSinhVien",
                        principalColumn: "MSSV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    tenDangNhap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    matKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phanQuyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MSSV = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.tenDangNhap);
                    table.ForeignKey(
                        name: "FK_TaiKhoan_ThongTinSinhVien_MSSV",
                        column: x => x.MSSV,
                        principalTable: "ThongTinSinhVien",
                        principalColumn: "MSSV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiemHocTap_maHocKy",
                table: "DiemHocTap",
                column: "maHocKy");

            migrationBuilder.CreateIndex(
                name: "IX_DiemHocTap_maMonHoc",
                table: "DiemHocTap",
                column: "maMonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_DiemHocTap_MSSV",
                table: "DiemHocTap",
                column: "MSSV");

            migrationBuilder.CreateIndex(
                name: "IX_DiemRenLuyen_maHocKy",
                table: "DiemRenLuyen",
                column: "maHocKy");

            migrationBuilder.CreateIndex(
                name: "IX_DiemRenLuyen_MSSV",
                table: "DiemRenLuyen",
                column: "MSSV");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_maKhoa",
                table: "Lop",
                column: "maKhoa");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_MSSV",
                table: "TaiKhoan",
                column: "MSSV");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinSinhVien_KhoamaKhoa",
                table: "ThongTinSinhVien",
                column: "KhoamaKhoa");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinSinhVien_lopID",
                table: "ThongTinSinhVien",
                column: "lopID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiemHocTap");

            migrationBuilder.DropTable(
                name: "DiemRenLuyen");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "MonHoc");

            migrationBuilder.DropTable(
                name: "HocKy");

            migrationBuilder.DropTable(
                name: "ThongTinSinhVien");

            migrationBuilder.DropTable(
                name: "Lop");

            migrationBuilder.DropTable(
                name: "Khoa");
        }
    }
}
