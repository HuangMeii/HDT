using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan_1.Bai6
{
    class Sach
    {
        private string maSach, tenSach, tacGia, nhaXuatBan;
        private int namXuatBan, giaBan;

        public string LayMaSach() => maSach;
        public void SetMaSach(string MaSach)
        {
            if (string.IsNullOrEmpty(MaSach))
                throw new ArgumentNullException("Ma sach khong duoc de trong!");
            this.maSach = MaSach;
        }

        public string LayTenSach() => tenSach;
        public void SetTenSach(string TenSach)
        {
            if (string.IsNullOrEmpty(TenSach))
                throw new ArgumentNullException("Ten sach khong duoc de trong!");
            this.tenSach = TenSach;
        }

        public string LayTacGia() => tacGia;
        public void SetTacGia(string TacGia)
        {
            if (string.IsNullOrEmpty(TacGia))
                throw new ArgumentNullException("Tac gia khong duoc de trong!");
            this.tacGia = TacGia;
        }

        public string LayNhaXB() => nhaXuatBan;
        public void SetNhaXB(string NhaXB)
        {
            if (string.IsNullOrEmpty(NhaXB))
                throw new ArgumentNullException("Nha xuat ban khong duoc de trong!");
            this.nhaXuatBan = NhaXB;
        }

        public int LayNamXB() => namXuatBan;
        public void SetNamXB(int NamXB)
        {
            if (NamXB < 1900 || NamXB > DateTime.Now.Year)
                throw new ArgumentOutOfRangeException("Nam xuat ban khong hop le!");
            this.namXuatBan = NamXB;
        }

        public int LayGiaBan() => giaBan;
        public void SetGiaBan(int GiaBan)
        {
            if (GiaBan <= 0)
                throw new ArgumentOutOfRangeException("Gia ban phai lon hon 0!");
            this.giaBan = GiaBan;
        }

        public void Nhap()
        {
            while (true)
            {
                try
                {
                    Console.Write("\nNhap ma sach: ");
                    SetMaSach(Console.ReadLine());

                    Console.Write("Nhap ten sach: ");
                    SetTenSach(Console.ReadLine());

                    Console.Write("Nhap tac gia: ");
                    SetTacGia(Console.ReadLine());

                    Console.Write("Nhap nha xuat ban: ");
                    SetNhaXB(Console.ReadLine());

                    Console.Write("Nhap nam xuat ban: ");
                    SetNamXB(int.Parse(Console.ReadLine()));

                    Console.Write("Nhap gia ban: ");
                    SetGiaBan(int.Parse(Console.ReadLine()));

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Loi: {ex.Message}\nVui long nhap lai!");
                }
            }
        }

        public void Xuat()
        {
            Console.WriteLine($"{LayMaSach()} - {LayTenSach()} - {LayTacGia()} - {LayNhaXB()} - {LayNamXB()} - Gia: {LayGiaBan():N0} VND");
        }

        public Sach TimSach(List<Sach> danhSach, string maCanTim)
        {
            return danhSach.Find(s => s.LayMaSach() == maCanTim);
        }

        public void SapXep(List<Sach> danhSach)
        {
            danhSach.Sort((s1, s2) => s1.LayMaSach().CompareTo(s2.LayMaSach()));
        }
    }
}
