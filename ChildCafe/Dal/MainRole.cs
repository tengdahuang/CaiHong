﻿using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace ChildCafe.Dal
{
    [SoftDelete]
    public abstract class MainRole:DbObjectModel<MainRole>
    {
        [Length(100)]
        public abstract string Name { get; set; }
        [AllowNull,Length(200)]
        public abstract string Description { get; set; }
        [SpecialName]
        public abstract DateTime SavedOn { get; set; }

        [HasAndBelongsToMany(OrderBy = "Id")]
        public abstract IList<MainOptr> Optrs { get; set; }

        [HasAndBelongsToMany(OrderBy = "Id")]
        public abstract IList<MainAction> Actions { get; set; }

        [HasAndBelongsToMany(OrderBy = "Id")]
        public abstract IList<MainModule> Modules { get; set; }
    }

}
