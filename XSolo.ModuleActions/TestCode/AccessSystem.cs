using System;
using System.Collections.Generic;
using System.Text;
using XSolo.ModuleActions.DataAccess;

namespace XSolo.ModuleActions.TestCode
{
    public class AccessSystem
    {
        public void AddOptrsAndRoles()
        {
            var mainAction1 = MainAction.New;
            mainAction1.Name = "ctAdd";
            mainAction1.ChineseName = "新增";
            mainAction1.ImageOrder = 0;
            mainAction1.Save();

            var mainAction2 = MainAction.New;
            mainAction2.Name = "ctEdit";
            mainAction2.ChineseName = "修改";
            mainAction2.ImageOrder = 1;
            mainAction2.Save();

            var mainAction3 = MainAction.New;
            mainAction3.Name = "ctDelete";
            mainAction3.ChineseName = "删除";
            mainAction3.ImageOrder = 2;
            mainAction3.Save();

            var mainAction4 = MainAction.New;
            mainAction4.Name = "ctView";
            mainAction4.ChineseName = "查看";
            mainAction4.ImageOrder = 0;
            mainAction4.Status = 1;
            mainAction4.Save();

            var mainAction5 = MainAction.New;
            mainAction5.Name = "ctModuleAction";
            mainAction5.ChineseName = "操作";
            mainAction5.ImageOrder = 4;
            mainAction5.Save();

            var mainModule1 = MainModule.New;
            mainModule1.Name = "ModuleTop";
            mainModule1.ChineseName = "主菜单";
            mainModule1.ParentId = 0;
            mainModule1.Status = 0;
            mainModule1.Save();
            
            var mainModule2 = MainModule.New;
            mainModule2.Name = "FrmACLModule";
            mainModule2.ChineseName = "模块管理";
            mainModule2.ParentId = 1;
            mainModule2.Status = 9;
            mainModule2.Save();

            var mainModule4 = MainModule.New;
            mainModule4.Name = "FrmACLAction";
            mainModule4.ChineseName = "操作管理";
            mainModule4.ParentId = 1;
            mainModule4.Status = 9;
            mainModule4.Save();

            var mainModule3 = MainModule.New;
            mainModule3.Name = "FrmACLUser";
            mainModule3.ChineseName = "用户管理";
            mainModule3.ParentId = 1;
            mainModule3.Status = 1;
            mainModule3.Save();

            //var mainModule5 = MainModule.New;
            //mainModule5.Name = "FrmBaseData";
            //mainModule5.ChineseName = "基础资料";
            //mainModule5.ParentId = 0;
            //mainModule5.Status = 0;
            //mainModule5.Save();

            //var mainModule6 = MainModule.New;
            //mainModule6.Name = "FrmBaseEmployee";
            //mainModule6.ChineseName = "员工管理";
            //mainModule6.ParentId = 5;
            //mainModule6.Status = 1;
            //mainModule6.Save();

            var mainModule11 = MainModule.FindById(1);
            mainModule11.Actions.Add(MainAction.FindById(4));
            mainModule11.Save();

            var mainModule12 = MainModule.FindById(2);
            mainModule12.Actions.Add(MainAction.FindById(1));
            mainModule12.Actions.Add(MainAction.FindById(2));
            mainModule12.Actions.Add(MainAction.FindById(3));
            mainModule12.Actions.Add(MainAction.FindById(4));
            mainModule12.Actions.Add(MainAction.FindById(5));
            mainModule12.Save();

            var mainModule13 = MainModule.FindById(3);
            mainModule13.Actions.Add(MainAction.FindById(1));
            mainModule13.Actions.Add(MainAction.FindById(2));
            mainModule13.Actions.Add(MainAction.FindById(3));
            mainModule13.Actions.Add(MainAction.FindById(4));
            mainModule13.Save();

            var mainModule14 = MainModule.FindById(4);
            mainModule14.Actions.Add(MainAction.FindById(1));
            mainModule14.Actions.Add(MainAction.FindById(2));
            mainModule14.Actions.Add(MainAction.FindById(3));
            mainModule14.Actions.Add(MainAction.FindById(4));
            mainModule14.Actions.Add(MainAction.FindById(5));
            mainModule14.Save();

            var optr = MainOptr.New;
            optr.Name = "root";
            optr.Password = "1";
            optr.Description = "root manager";
            

            MainRole mainRole = MainRole.New;
            mainRole.Name = "manager";
            mainRole.Description = "Manager";

            optr.Roles.Add(mainRole);
            optr.Modules.Add(mainModule1);
            optr.Modules.Add(mainModule2);
            optr.Modules.Add(mainModule3);
            optr.Modules.Add(mainModule4);
            optr.Save();

            

        }


    }
}
