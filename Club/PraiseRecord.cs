//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Club
{
    using System;
    using System.Collections.Generic;
    
    public partial class PraiseRecord
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public System.DateTime CreateTime { get; set; }
        public bool IsAbort { get; set; }
    
        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}
