using System;

public class HinhHoc
{
    #region Automatic Property
    public double DienTich { get; set; }
    public double ChuVi { get; set; }
    #endregion

    public virtual void tinhDienTichChuVi()
    {
    }

    public override string ToString()
    {
        return string.Format("S = {0}; P = {1}", Math.Round(DienTich, 2), Math.Round(ChuVi, 2));
    }
}