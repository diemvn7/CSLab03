using System;

public class HinhTron : HinhHoc
{
    //Fields
    private double mBanKinh;

    //Property
    public double BanKinh
    {
        get { return mBanKinh; }
        set
        {
            if (value > 0)
                mBanKinh = value;
            else
                throw new Exception("Ban kinh am");
        }
    }

    //constructor
    public HinhTron(double r = 1)
    {
        BanKinh = r;
    }

    public override void tinhDienTichChuVi()
    {
        DienTich = Math.PI * BanKinh * BanKinh;
        ChuVi = 2 * Math.PI * BanKinh;
    }

    public override string ToString()
    {
        return string.Format("R = {0}; {1}", BanKinh, base.ToString());
    }
}