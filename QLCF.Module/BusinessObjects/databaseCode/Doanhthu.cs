using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
/*
 đây la comand line nhanh_2
 */
/*
 đây la comand line nhanh_3
 */
namespace QLCF.Module.BusinessObjects.database
{
    // Class Doanhthu: Quản lý doanh thu của hóa đơn
    public partial class Doanhthu
    {
        // Constructor Doanhthu: Nhận session và truyền nó cho base class
        public Doanhthu(Session session) : base(session) { }

        // Method AfterConstruction: Được gọi sau khi đối tượng được khởi tạo
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
