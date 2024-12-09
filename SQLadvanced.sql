CREATE DATABASE ViDuSQLNangCao
USE ViDuSQLNangCao
CREATE TABLE ChucVu (
    MaChucVu INT IDENTITY PRIMARY KEY,
    TenChucVu NVARCHAR(30) NOT NULL UNIQUE
)
go
CREATE TABLE PhongBan (
    MaPhongBan INT IDENTITY PRIMARY KEY,
    TenPhongBan NVARCHAR(30) NOT NULL UNIQUE
)
go
CREATE TABLE NhanVien (
    MaNhanVien INT IDENTITY PRIMARY KEY,
    HoTen NVARCHAR(30) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh BIT NOT NULL,
    DiaChi NVARCHAR(100) NOT NULL,
    MaChucVu INT NOT NULL REFERENCES ChucVu(MaChucVu),
    MaPhongBan INT NOT NULL REFERENCES PhongBan(MaPhongBan)
)

CREATE PROCEDURE ThemNhanVien
    @HoTen NVARCHAR(30),@NgaySinh DATE,@GioiTinh BIT,@DiaChi NVARCHAR(100),
    @MaChucVu INT,@MaPhongBan INT
AS BEGIN
    DECLARE @Dem INT
    DECLARE @Loi NVARCHAR(300)
    SET @Loi = ''
    SET @Dem = (SELECT COUNT(*) FROM ChucVu WHERE MaChucVu=@MaChucVu)
    IF @Dem = 0
        SET @Loi = N'Mã chức vụ không tồn tại. '
    SET @Dem = (SELECT COUNT(*) FROM PhongBan WHERE MaPhongBan=@MaPhongBan)
    IF @Dem = 0
        SET @Loi = @Loi + N'Mã phòng ban không tồn tại. '
    IF @Loi = ''
        INSERT NhanVien VALUES(@HoTen,@NgaySinh,@GioiTinh,@DiaChi,@MaChucVu,@MaPhongBan)
    ELSE
        RAISERROR(@Loi,16,1)
END

CREATE PROCEDURE XoaNhanVien @MaNhanVien INT
AS BEGIN 
	DECLARE @Dem INT
	SET @Dem = (SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien=@MaNhanVien)
	IF @Dem > 0
		DELETE NhanVien WHERE MaNhanVien = @MaNhanVien
	ELSE
		RAISERROR (N'Ma nhan vien k co ton tai', 16,1)
END

CREATE PROCEDURE SuaNhanVien
    @MaNhanVien INT,
    @HoTen NVARCHAR(30),
    @NgaySinh DATE,
    @GioiTinh BIT,
    @DiaChi NVARCHAR(100),
    @MaChucVu INT,
    @MaPhongBan INT
AS BEGIN
    DECLARE @Dem INT
    DECLARE @Loi NVARCHAR(300)
    SET @Loi = ''

    SET @Dem = (SELECT COUNT(*) FROM NhanVien WHERE MaNhanVien = @MaNhanVien)
    IF @Dem = 0
        SET @Loi = N'Mã nhân viên không tồn tại. '

    SET @Dem = (SELECT COUNT(*) FROM ChucVu WHERE MaChucVu = @MaChucVu)
    IF @Dem = 0
        SET @Loi = @Loi + N'Mã chức vụ không tồn tại. '

    SET @Dem = (SELECT COUNT(*) FROM PhongBan WHERE MaPhongBan = @MaPhongBan)
    IF @Dem = 0
        SET @Loi = @Loi + N'Mã phòng ban không tồn tại. '

    IF @Loi = ''
        UPDATE NhanVien
        SET HoTen = @HoTen,
            NgaySinh = @NgaySinh,
            GioiTinh = @GioiTinh,
            DiaChi = @DiaChi,
            MaChucVu = @MaChucVu,
            MaPhongBan = @MaPhongBan
        WHERE MaNhanVien = @MaNhanVien
    ELSE
        RAISERROR(@Loi, 16, 1)
END

CREATE FUNCTION TimKiemNhanVien
    (@MaNhanVien INT,@HoTen NVARCHAR(30),@NgaySinh DATE,@GioiTinh BIT,
    @DiaChi NVARCHAR(100),@MaChucVu INT,@MaPhongBan INT)
RETURNS TABLE
AS RETURN
(SELECT MaNhanVien,HoTen,NgaySinh,
    CASE GioiTinh WHEN 1 THEN N'Nam' WHEN 0 THEN N'Nữ' END GioiTinh,
    DiaChi,TenChucVu,TenPhongBan
FROM NhanVien
INNER JOIN ChucVu ON NhanVien.MaChucVu=ChucVu.MaChucVu
INNER JOIN PhongBan ON NhanVien.MaPhongBan=PhongBan.MaPhongBan
WHERE (MaNhanVien=@MaNhanVien OR @MaNhanVien IS NULL)
AND HoTen LIKE '%' + @HoTen + '%'
AND (NgaySinh=@NgaySinh OR @NgaySinh IS NULL)
AND (GioiTinh=@GioiTinh OR @GioiTinh IS NULL)
AND DiaChi LIKE '%' + @DiaChi + '%'
AND (NhanVien.MaChucVu=@MaChucVu OR @MaChucVu IS NULL)
AND (NhanVien.MaPhongBan=@MaPhongBan OR @MaPhongBan IS NULL))



INSERT INTO ChucVu (TenChucVu) VALUES
('Director'),
('Deputy Director'),
('Department Head'),
('Employee'),
('Secretary');

INSERT INTO PhongBan (TenPhongBan) VALUES
('Sales Department'),
('Marketing Department'),
('Human Resources Department'),
('Finance Department'),
('Administration Department');

INSERT INTO NhanVien (HoTen, NgaySinh, GioiTinh, DiaChi, MaChucVu, MaPhongBan) VALUES
('Nguyen Van A', '1990-05-12', 1, 'No. 12, ABC Street, Hanoi', 1, 1),
('Tran Thi B', '1985-08-23', 0, 'No. 23, XYZ Street, Ho Chi Minh City', 2, 2),
('Pham Hoang C', '1992-01-05', 1, 'No. 5, PQR Street, Da Nang', 3, 3),
('Le Minh D', '1988-11-15', 1, 'No. 15, STU Street, Hanoi', 4, 4),
('Vu Thanh E', '1995-06-30', 0, 'No. 30, LMN Street, Ho Chi Minh City', 5, 5);



CREATE PROCEDURE ThemPhongBan 
	@TenPhongBan NVARCHAR(30)
AS BEGIN
	DECLARE @Dem INT
	DECLARE @Loi NVARCHAR(300)
	SET @Loi = ' '
	SET @Dem = (SELECT COUNT(*) FROM PhongBan WHERE TenPhongBan = @TenPhongBan)
	IF @Dem > 0
		SET @Loi = N'Ten phong ban da ton tai.'

	IF @Loi = ' ' 
		INSERT INTO PhongBan (TenPhongBan)
		VALUES (@TenPhongBan)
	ELSE	
		RAISERROR(@Loi, 16, 1)
END

CREATE PROCEDURE SuaPhongBan
	@MaPhongBan INT,
	@TenPhongBan NVARCHAR(30)
AS BEGIN
	DECLARE @Dem INT
	DECLARE @Loi NVARCHAR(300)
	SET @Loi = ' '

	SET @Dem = (SELECT COUNT(*) FROM PhongBan WHERE MaPhongBan = @MaPhongBan)
	IF @Dem = 0
		SET @Loi = N'Ma phong ban khong ton tai.'

	SET @Dem = (SELECT COUNT(*) FROM PhongBan WHERE TenPhongBan = @TenPhongBan AND MaPhongBan != @MaPhongBan)
	IF @Dem > 0
		SET @Loi = @Loi + N'Ten phong ban da ton tai'
	IF @Loi = ' '
		UPDATE PhongBan
		SET TenPhongBan = @TenPhongBan
		WHERE MaPhongBan = @MaPhongBan
	ELSE 
		RAISERROR(@Loi, 16, 1)
END

CREATE PROCEDURE XoaPhongBanNULL
	@MaPhongBan INT
AS BEGIN
	DECLARE @Dem INT
	DECLARE @Loi NVARCHAR(300)
	SET @Loi = ' '

	SET @Dem = (SELECT COUNT(*) FROM PhongBan WHERE MaPhongBan = @MaPhongBan)
	IF @Dem = 0
		SET @Loi = N'Ma phong ban khong ton tai'
	IF @Loi = ' '
	BEGIN
		BEGIN TRANSACTION

		BEGIN TRY
			UPDATE NhanVien
			SET MaPhongBan = NULL
			WHERE MaPhongBan = @MaPhongBan

			DELETE FROM PhongBan WHERE MaPhongBan = @MaPhongBan

			COMMIT TRANSACTION
		END TRY
		BEGIN CATCH
				ROLLBACK TRANSACTION

				THROW
		END CATCH
	END
	ELSE
		RAISERROR(@Loi, 16, 1)
END




CREATE FUNCTION TimKiemPhongBanCheck
	(@MaPhongBan INT, @TenPhongBan NVARCHAR(30))
RETURNS TABLE
AS RETURN
(SELECT MaPhongBan, TenPhongBan
FROM PhongBan
WHERE (MaPhongBan = @MaPhongBan OR @MaPhongBan IS NULL)
AND TenPhongBan LIKE '%' + @TenPhongBan + '%')

CREATE PROCEDURE ThemChucVu
	@TenChucVu NVARCHAR(30)
AS BEGIN
	DECLARE @Dem INT
	DECLARE @Loi NVARCHAR(300)
	SET @Loi = ' '

	SET @Dem = (SELECT COUNT(*) FROM ChucVu WHERE TenChucVu = @TenChucVu)
	IF @Dem > 0
		SET @Loi = N'Ten chuc vu da ton tai.'

	IF @Loi = ' '
		INSERT INTO ChucVu (TenChucVu)
		VALUES (@TenChucVu)
	ELSE 
		RAISERROR(@Loi, 16, 1)
END

CREATE PROCEDURE SuaChucVu
	@MaChucVu INT,
	@TenChucVu NVARCHAR(30)
AS BEGIN
	DECLARE @Dem INT
	DECLARE @Loi NVARCHAR(300)
	SET @Loi = ' '

	SET @Dem = (SELECT COUNT(*) FROM ChucVu WHERE MaChucVu = @MaChucVu)
	IF @Dem = 0
		SET @Loi = N'Ma phong ban khong ton tai'

	SET @Dem = (SELECT COUNT(*) FROM ChucVu WHERE TenChucVu = @TenChucVu AND MaChucVu != @MaChucVu)
	IF @Dem > 0
		SET @Loi = @Loi + N' Ten phong ban da ton tai'
	IF @Loi = ' '
		UPDATE ChucVu
		SET TenChucVu = @TenChucVu
		WHERE MaChucVu = @MaChucVu
	ELSE	
		RAISERROR(@Loi, 16, 1)
END

CREATE PROCEDURE XoaChucVu
	@MaChucVu INT
AS BEGIN
	DECLARE @Dem INT
	DECLARE @Loi NVARCHAR(300)
	SET @Loi = ' '

	SET @Dem = (SELECT COUNT(*) FROM ChucVu WHERE MaChucVu = @MaChucVu)
	IF @Dem = 0
		SET @Loi = N'Ma chuc vu khong ton tai'

	IF @Loi = ' '
	BEGIN

		BEGIN TRANSACTION

		BEGIN TRY
			UPDATE NhanVien
			SET MaChucVu = NULL
			WHERE MaChucVu = @MaChucVu

			DELETE FROM ChucVu WHERE MaChucVu = @MaChucVu

			COMMIT TRANSACTION
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION

			THROW
		END CATCH
	END
	ELSE
		RAISERROR(@Loi, 16, 1)
END



CREATE FUNCTION TimKiemChucVuCheck
	(@MaChucVu INT, @TenChucVu NVARCHAR(30))
RETURNS TABLE
AS RETURN
(SELECT MaChucVu, TenChucVu
FROM ChucVu
WHERE (MaChucVu = @MaChucVu OR @MaChucVu IS NULL)
AND TenChucVu LIKE '%' + @TenChucVu + '%')