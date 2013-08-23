using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace ChildCafe.Dal
{
    public abstract class MainOptrType:DbObjectModel<MainOptrType>
    {
        [Length(50)]
        public abstract string Name { get; set; }

        public abstract int Status { get; set; }
    }
}
