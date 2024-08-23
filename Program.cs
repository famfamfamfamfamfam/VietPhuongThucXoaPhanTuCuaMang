using System;
namespace SUDUNGPHUONGTHUC
{
    class XoaPhanTuKhoiMang
    {
        static int[] Xoaphantukhoimang(ref int sophantu, int[] mang)
        {
            Console.WriteLine("Nhap phan tu can xoa:");
            int phantubixoa = Convert.ToInt32(Console.ReadLine());
            int chiso = Array.IndexOf(mang, phantubixoa);
            if (chiso == -1)
            {
                Console.WriteLine("So khong ton tai trong mang");
                return mang;
            }
            sophantu = sophantu - 1;
            for (int i = chiso; i < sophantu; i++)
            {
                mang[i] = mang[i + 1];
            }
            Array.Copy(mang, 0, mang, 0, sophantu);
            return mang;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong phan tu cua mang:");
            int sophantu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao tung phan tu cua mang:");
            int[] mang = new int[sophantu];
            for (int i = 0; i < sophantu; i++)
            {
                mang[i] = Convert.ToInt32(Console.ReadLine());
            }
            Xoaphantukhoimang(ref sophantu, mang);
            Console.WriteLine("Mang sau khi xoa:");
            for (int i = 0; i < sophantu; i++)
            {
                Console.WriteLine(mang[i]);
            }
        }
    }
}