using System;
using System.Collections.Generic;
using System.Text;

namespace ChildCafe.Common
{
    //目的是为了有一个地方方便记忆各种状态
    public enum EquipmentResult
    {
        已报修,
        已接单,
        未修复,
        已修复,
        遗留问题,
        遗留问题修复,
        产品处理,
        产品处理完成

    }

    //目的是为了有一个地方方便记忆各种状态
    public enum VariationResult
    {
        已安排,
        已接单,
        未完成,
        已完成

    }
}
