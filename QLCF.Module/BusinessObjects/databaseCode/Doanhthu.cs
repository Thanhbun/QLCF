﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace QLCF.Module.BusinessObjects.database
{
    //Task Thiên Doanh Thu
    public partial class Doanhthu
    {
        public Doanhthu(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
