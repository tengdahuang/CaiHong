﻿using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;
using Lephone.Util;

namespace TDAccessControl.DataAccess
{
    [SoftDelete]
    public abstract class MainModule : DbObjectModel<MainModule>
    {



        [Length(50)]
        public abstract string Name { get; set; }

        [Length(100)]
        public abstract string ChineseName { get; set; }

        //public abstract bool IsEndNode { get; set; }

        public abstract long  ParentId { get; set; }
        
        [SpecialName]
        public abstract DateTime SavedOn { get; set; }

        public abstract long Status { get; set; }

        [HasAndBelongsToMany(OrderBy = "Id")]
        public abstract IList<MainAction> Actions { get; set; }

        [HasAndBelongsToMany(OrderBy = "Id")]
        public abstract IList<MainOptr> Optrs { get; set; }

        [HasAndBelongsToMany(OrderBy = "Id")]
        public abstract IList<MainRole> Roles { get; set; }
    }
}
