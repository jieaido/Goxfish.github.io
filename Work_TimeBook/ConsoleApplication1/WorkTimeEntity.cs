//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkTimeEntity
    {
        public int WorkTimeId { get; set; }
        public System.DateTime WtStartDateTime { get; set; }
        public System.DateTime WtOverDateTime { get; set; }
        public float WtValue { get; set; }
        public string WtContent { get; set; }
        public string Remarks { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int StationEntityStationId { get; set; }
    
        public virtual StationEntity StationEntity { get; set; }
    }
}
