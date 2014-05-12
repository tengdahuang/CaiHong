using System;
using System.Collections.Generic;
using System.Text;
using Lephone.Data.Definition;

namespace ChildCafe.Dal
{
    [SoftDelete]
    public abstract class MainModule : DbObjectModel<MainModule>
    {

        [Length(50)]
        public abstract string Name { get; set; }

        [Length(100)]
        public abstract string ChineseName { get; set; }

        public abstract int  ParentId { get; set; }
        
        [SpecialName]
        public abstract DateTime SavedOn { get; set; }

        public abstract int Status { get; set; }

        public abstract int Sequence { get; set; }

        /// <summary>
        /// 是否对话窗体
        /// </summary>
        public abstract int DialogType { get; set; }

        [HasAndBelongsToMany(OrderBy = "Id")]
        public abstract IList<MainAction> Actions { get; set; }

        [HasAndBelongsToMany(OrderBy = "Id")]
        public abstract IList<MainOptr> Optrs { get; set; }

        [HasAndBelongsToMany(OrderBy = "Id")]
        public abstract IList<MainRole> Roles { get; set; }

    }
}
