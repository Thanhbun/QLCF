﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;

namespace QLCF.Module.BusinessObjects.database
{
    // Class Doanhthu: Quản lý doanh thu của hóa đơn
    [DefaultClassOptions]
    [NavigationItem]
    public partial class Doanhthu : XPObject
    {
        // Field fMaHD: Liên kết với hóa đơn
        Hoadon fMaHD;

        // Property MaHD: Thiết lập hoặc lấy mã hóa đơn
        [Association(@"DoanhthuReferencesHoadon")]
        public Hoadon MaHD
        {
            get { return fMaHD; }
            set { SetPropertyValue<Hoadon>(nameof(MaHD), ref fMaHD, value); }
        }

        // Field fNgay: Ngày tạo hóa đơn
        DateTime fNgay;

        // Property Ngay: Trả về ngày tạo hóa đơn
        public DateTime Ngay
        {
            get
            {
                // Nếu mã hóa đơn không null, lấy ngày tạo từ hóa đơn
                if (MaHD != null)
                {
                    fNgay = MaHD.Ngaytao;
                }
                return fNgay;
            }
        }

        // Field fTong: Tổng tiền của hóa đơn
        decimal fTong;

        // Property Tong: Trả về tổng tiền của hóa đơn
        public decimal Tong
        {
            get
            {
                // Nếu mã hóa đơn không null, tính tổng tiền từ các chi tiết hóa đơn
                if (MaHD != null)
                {
                    fTong = MaHD.HoadonCTs.Sum(ct => ct.Thanhtien);
                }
                return fTong;
            }
        }
    }
}
