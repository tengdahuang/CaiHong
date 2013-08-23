using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace ChildCafe.Dal
{
    [SoftDelete]
    public abstract class MainAction : DbObjectModel<MainAction>
    {
        [Length(50)]
        public abstract string Name { get; set; }

        [Length(100)]
        public abstract string ChineseName { get; set; }

        public abstract int ImageOrder { get; set; }
        
        [AllowNull,Length(10)]
        public abstract string ShortCut { get; set; }

        public abstract int Status { get; set; }

        public abstract int Sequence { get; set; }

        [HasAndBelongsToMany(OrderBy = "Id")]
        public abstract IList<MainModule> MainModule { get; set; }

        //[HasAndBelongsToMany(OrderBy = "Id")]
        //public abstract IList<MainOptr> MainOptr { get; set; }

        [HasAndBelongsToMany(OrderBy = "Id")]
        public abstract IList<MainRole> MainRole { get; set; }
    }
}
