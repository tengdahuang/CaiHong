using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;
namespace ChildCafe.Dal
{
    [SoftDelete]
    public abstract class MainDict: DbObjectModel<MainDict>
    {
        [Length(100)]
        public abstract string Name { get; set; }

        [AllowNull,Length(100)]
        public abstract string PreName { get; set; }
        
        [Length(100)]
        public abstract string DictType { get; set; }
        
        [Length(100)]
        public abstract string OptrType { get; set; }
        
        [Length(200)]
        public abstract string Remark { get; set; }

        [SpecialName]
        public abstract DateTime SavedOn { get; set; }
    }
}
