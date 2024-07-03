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
    [DefaultClassOptions]
    [NavigationItem]
    public partial class Thanhtoan : XPObject
    {
        string fMathanhtoan;
        public string Mathanhtoan
        {
            get { return fMathanhtoan; }
            set { SetPropertyValue<string>(nameof(Mathanhtoan), ref fMathanhtoan, value); }
        }
        Hoadon fMahoadon;
        [Association(@"ThanhtoanReferencesHoadon")]
        public Hoadon Mahoadon
        {
            get { return fMahoadon; }
            set { SetPropertyValue<Hoadon>(nameof(Mahoadon), ref fMahoadon, value); }
        }
        decimal fSotien;
        public decimal Sotien
        {
            get
            {
                if (Mahoadon != null)
                {
                    var hoadonCT = Mahoadon.HoadonCTs.FirstOrDefault();
                    if (hoadonCT != null)
                    {
                        fSotien = hoadonCT.Thanhtien;
                    }
                }
                return fSotien;

            }
            
        }
        TrangthaiTT fTrangthai;
        [Association(@"ThanhtoanReferencesTrangthaiTT")] 
        public TrangthaiTT Trangthai
        {
            get 
            {
                
                return fTrangthai  ;
            }
            set { SetPropertyValue<TrangthaiTT>(nameof(Trangthai), ref fTrangthai, value); }
        }
    }

}
