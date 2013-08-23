using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace ChildCafe.Dal
{

    [SoftDelete]
    public abstract class MainOptr:DbObjectModel<MainOptr>
    {
        [Length(100)]
        public abstract string Name { get; set; }

        [Length(100)]
        public abstract string ChineseName { get; set; }
        [Length(200)]
        public abstract string Password { get; set; }
        [Length(100)]
        public abstract string MainOptrType { get; set; }
        [AllowNull,Length(200)]
        public abstract string Description { get; set; }
        [SpecialName]
        public abstract DateTime SavedOn { get; set; }

        [HasAndBelongsToMany(OrderBy = "Id")]
        public abstract IList<MainRole> Roles { get; set; }

        [HasAndBelongsToMany(OrderBy = "Id")]
        public abstract IList<MainModule> Modules { get; set; }

        //[HasAndBelongsToMany(OrderBy = "Id")]
        //public abstract IList<MainAction> Actions { get; set; }

    }

}
