using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace TDAccessControl.DataAccess
{
    public enum OptrDepartment
    {
        Office,
        Package,
        Test
    }

    [SoftDelete]
    public abstract class MainOptr:DbObjectModel<MainOptr>
    {
        [Length(100)]
        public abstract string Name { get; set; }
        [Length(200)]
        public abstract string Password { get; set; }
        [AllowNull,Length(800)]
        public abstract string Description { get; set; }
        [SpecialName]
        public abstract DateTime SavedOn { get; set; }

        [HasAndBelongsToMany(OrderBy = "Id")]
        public abstract IList<MainRole> Roles { get; set; }

        [HasAndBelongsToMany(OrderBy = "Id")]
        public abstract IList<MainModule> Modules { get; set; }

        [HasAndBelongsToMany(OrderBy = "Id")]
        public abstract IList<MainAction> Actions { get; set; }

        public abstract OptrDepartment Department { get; set; }
    }

}
