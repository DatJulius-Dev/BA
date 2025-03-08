CREATE TABLE Phong_Kham (
    MaPhongKham varchar(10) primary key,
    TenPhongKham varchar(50),
    Diachi varchar(50),
    Sodienthoai varchar(10)
) CREATE TABLE Chuyen_Khoa (
    MaChuyenKhoa varchar(10) primary key,
    TenChuyenKhoa varchar(50),
) CREATE TABLE Bac_Si (
    MaBS varchar(10) primary key,
    MaChuyenKhoa varchar(10),
    MaPhongKham varchar(10),
    FOREIGN KEY (MaPhongKham) REFERENCES PHONG_KHAM (MaPhongKham),
    FOREIGN KEY (MaChuyenKhoa) REFERENCES CHUYEN_KHOA (MaChuyenKhoa),
    SoDienThoaiBS varchar(10),
    HoTen varchar(50),
    DiaChiBS varchar(60)
) CREATE TABLE Benh_Nhan (
    MaBN varchar(10) primary key,
    MaPhongKham varchar(10),
    FOREIGN KEY (MaPhongKham) REFERENCES PHONG_KHAM (MaPhongKham),
    HoTen varchar(50),
    NgaySinh smalldatetime,
    GioiTinh bit,
    SoDienThoaiBN varchar(10) default 'khýng cý',
    DiaChiBN varchar(60)
) CREATE TABLE Quan_Ly (
    MaQL varchar(10),
    MaPhongKham varchar(10),
    FOREIGN KEY (MaPhongKham) REFERENCES PHONG_KHAM (MaPhongKham),
    HoTen varchar(50),
    SoDienThoaiQuanLi varchar(10),
    DiaChiQuanLi varchar(60),
) CREATE TABLE Le_Tan (
    MaLT varchar(10) primary key,
    MaPhongKham varchar(10),
    FOREIGN KEY (MaPhongKham) REFERENCES PHONG_KHAM (MaPhongKham),
    HoTen varchar(50),
    SoDienThoaiLT varchar(10),
    DiaChiLT varchar(60)
) CREATE TABLE Lich_Hen (
    MaLichHen varchar(10) primary key,
    MaBN varchar(10),
    MaBS varchar(10),
    FOREIGN KEY (MaBN) REFERENCES BENH_NHAN (MaBN),
    FOREIGN KEY (MaBS) REFERENCES BAC_SI (MaBS),
    ThoiGian datetime,
    TrangThai char(50),
    KetQuaXetNghiem char(256)
) CREATE TABLE Don_Thuoc (
    MaLichHen varchar(10),
    MaThuoc char(10),
    SoLuong int
) CREATE TABLE Thuoc(
    MaThuoc varchar(10),
    TenThuoc varchar(50),
    TonKho int,
    NgayNhap date
); CREATE procedure insert_thuoc @ tenThuoc varchar(50),
@ soLuong int as begin declare @ count int;

if (
    select
        count(*)
    from
        Thuoc
) = 0 begin
set
    @ count = 1;

end;

else begin
set
    @ count = cast(
        trim(
            (
                select
                    top(1) MaThuoc
                from
                    Thuoc
                order by
                    MaThuoc desc
            )
        ) as int
    ) + 1;

end;

declare @ maThuoc char(10);

set
    @ maThuoc = cast(@ count as char(10));

insert into
    THUOC
values
    (@ maThuoc, @ tenThuoc, @ soLuong);

end;

CREATE procedure insert_lichHen @maBS char(10),
@maBN char(10),
@thoiGian datetime,
@trangThai char(50),
@ketQuaXetNghiem char(256) as begin declare @ count int;

if (
    select
        count(*)
    from
        Lich_Hen
) = 0 begin
set
    @ count = 1;

end;

else begin
set
    @ count = cast(
        trim(
            (
                select
                    top(1) MaLichHen
                from
                    Lich_Hen
                order by
                    MaLichHen desc
            )
        ) as int
    ) + 1;

end;

declare @ maLichHen char(10);

set
    @ maLichHen = cast(@ count as char(10));

insert into
    Lich_Hen
values
    (
        @maLichHen,
        @maBN,
        @maBS,
        @thoiGian,
        @trangThai,
        @ketQuaXetNghiem
    );

end;

-- exec insert_thuoc 'Panadol',
-- 12;
-- select
--     *
-- from
--     THUOC;
-- select
--     *
-- from
--     THUOC
-- order by
--     MaThuoc desc;
create trigger trg_insertDonThuoc ON Don_Thuoc FOR
insert
    as begin
update
    Thuoc
SET
    TonKho = TonKho - (
        select
            SoLuong
        from
            inserted
        where
            inserted.MaThuoc = Thuoc.MaThuoc
    )
FROM
    THUOC
    JOIN inserted ON THUOC.MaThuoc = inserted.MaThuoc;

end;

CREATE TRIGGER trg_updateDonThuoc on Don_Thuoc FOR
update
    as begin
update
    THUOC
SET
    TonKho = TonKho - (
        select
            SoLuong
        from
            inserted
        where
            inserted.MaThuoc = Thuoc.MaThuoc
    ) + (
        select
            SoLuong
        from
            deleted
        where
            inserted.MaThuoc = Thuoc.MaThuoc
    )
FROM
    THUOC
    JOIN inserted ON Thuoc.MaThuoc = inserted.MaThuoc;

end;

/*Select*/
--Phong Kham--
SELECT * FROM Phong_Kham
SELECT MaPhongKham From Phong_Kham
SELECT TenPhongKham From Phong_Kham
SELECT Diachi From Phong_Kham
SELECT Sodienthoai From Phong_Kham
--Chuyen Khoa--
SELECT * FROM Chuyen_Khoa
SELECT MaChuyenKhoa From Chuyen_Khoa
SELECT TenChuyenKhoa From Chuyen_Khoa
--Bac Si--
SELECT MaBS FROM Bac_Si
SELECT MaPhongKham FROM Bac_Si
SELECT MaChuyenKhoa FROM Bac_Si
SELECT SoDienThoaiBS FROM Bac_Si
SELECT HoTen FROM Bac_Si
SELECT DiaChiBS FROM Bac_Si
--Benh Nhan--
SELECT * FROM Benh_Nhan
SELECT MaBN FROM Benh_Nhan
SELECT MaPhongKham FROM Benh_Nhan
SELECT HoTen FROM Benh_Nhan
SELECT DiaChiBN FROM Benh_Nhan
SELECT SoDienThoaiBN FROM Benh_Nhan
SELECT NgaySinh FROM Benh_Nhan
SELECT GioiTinh FROM Benh_Nhan
--Quan Ly--
SELECT * FROM Quan_Ly
SELECT MaQL FROM Quan_Ly
SELECT MaPhongKham FROM Quan_Ly
SELECT HoTen FROM Quan_Ly
SELECT SoDienThoaiQuanLi FROM Quan_Ly
SELECT DiaChiQuanLi FROM Quan_Ly
--Le Tan--
SELECT * FROM Le_Tan
SELECT MaLT FROM Le_Tan
SELECT MaPhongKham FROM Le_Tan
SELECT HoTen FROM Le_Tan
SELECT SoDienThoaiLT FROM Le_Tan
SELECT DiaChiLT FROM Le_Tan
--Lich Hen--
SELECT * FROM Lich_Hen
SELECT MaLichHen FROM Lich_Hen
SELECT MaBN FROM Lich_Hen
SELECT MaBS FROM Lich_Hen
SELECT MaPhongKham FROM Lich_Hen
SELECT MaChuyenKhoa FROM Lich_Hen
--Don Thuoc--
SELECT * FROM Don_Thuoc
SELECT MaLichHen FROM Don_Thuoc
SELECT MaBN FROM Don_Thuoc
SELECT MaBS FROM Don_Thuoc
SELECT MaPhongKham FROM Don_Thuoc
SELECT MaChuyenKhoa FROM Don_Thuoc
SELECT TienThuoc FROM Don_Thuoc
SELECT SoLuong FROM Don_Thuoc
--Thuoc--
SELECT * FROM Thuoc
