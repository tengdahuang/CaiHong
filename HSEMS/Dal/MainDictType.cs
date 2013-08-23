using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace HSEMS.Dal
{
    [SoftDelete]
    public abstract class MainDictType:DbObjectModel<MainDictType>
    {
        [Length(50)]
        public abstract string Name { get; set; }

        [Length(50)]
        public abstract string OptrType { get; set; }

        public abstract int Status { get; set; }
    }
}
