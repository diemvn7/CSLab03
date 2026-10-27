using System;

public class HinhChuNhat : HinhHoc
{
    //Fields
    private double mChieuDai;
    private double mChieuRong;

    //Property
    public double ChieuDai
    {
        get { return mChieuDai; }
        set
        {
            if (value > 0)
                mChieuDai = value;
            else
                throw new Exception("Chieu dai am");
        }
    }

    public double ChieuRong
    {
        get { return mChieuRong; }
        set
        {
            if (value > 0)
                mChieuRong = value;
            else
                throw new Exception("Chieu rong am");
        }
    }

    //constructor
    public HinhChuNhat(double d = 1, double r = 1)
    {
        ChieuDai = d;
        ChieuRong = r;
    }

    public override void tinhDienTichChuVi()
    {
        DienTich = ChieuDai * ChieuRong;
        ChuVi = (ChieuDai + ChieuRong) * 2;
    }

    public override string ToString()
    {
        return string.Format("L = {0}, W = {1}; {2}", ChieuDai, ChieuRong, base.ToString());
    }
}