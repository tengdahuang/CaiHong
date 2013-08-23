using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;
namespace XSolo.Common
{

    public sealed class FrmAddEditBind
    {
        /// <summary>
        /// 将业务对象绑定到窗体或控件容器
        /// </summary>
        /// <param name="obj">业务对象</param>
        /// <param name="container">窗体或控件容器</param>
        public static void BindObjectToControls(object obj, Control container)
        {
            if (obj == null) return;

            Type objType = obj.GetType();
            PropertyInfo[] objPropertiesArray = objType.GetProperties();

            foreach (PropertyInfo objProperty in objPropertiesArray)
            {
                Control control = FindControl(container, objProperty.Name);
                if (control == null) continue;

                if (control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    dateTimePicker.Value = (DateTime)objProperty.GetValue(obj, null);
                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.SelectedValue = (int)objProperty.GetValue(obj, null);
                }
                else
                {
                    //获取控件的属性
                    Type controlType = control.GetType();
                    PropertyInfo[] controlPropertiesArray = controlType.GetProperties();

                    //通用属性
                    bool success = false;
                    success = FindAndSetControlProperty(obj, objProperty, control, controlPropertiesArray, "Checked", typeof(bool));

                    if (!success)
                        success = FindAndSetControlProperty(obj, objProperty, control, controlPropertiesArray, "SelectedValue", typeof(String));

                    if (!success)
                        success = FindAndSetControlProperty(obj, objProperty, control, controlPropertiesArray, "Text", typeof(String));
                    if (!success)
                        success = FindAndSetControlProperty(obj, objProperty, control, controlPropertiesArray, "Value", typeof(String));

                }
            }
        }

        
        /// <summary>
        /// 根据控件名找出容器中的控件，考虑有些控件放在窗体的容器中，采用了递归查找。
        /// </summary>
        /// <param name="container">控件容器</param>
        /// <param name="controlName">控件名称</param>
        /// <returns></returns>
        private static Control FindControl(Control container, string controlName)
        {
            string newControlName = "ct" + controlName;
            Control findControl = null;
            foreach(Control control in container.Controls)
            {
             
                if (control.Controls.Count == 0 || (control is NumericUpDown))
                {
                    if (control.Name == newControlName)
                    {
                        findControl = control;
                        break;
                    }
                }
                else
                {
                    findControl = FindControl(control, controlName);
                }
            }
            return findControl;
        }

        /// <summary>
        /// 设置控件的值
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="objProperty"></param>
        /// <param name="control"></param>
        /// <param name="controlPropertiesArray"></param>
        /// <param name="propertyName"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private static bool FindAndSetControlProperty(object obj, PropertyInfo objProperty, Control control, PropertyInfo[] controlPropertiesArray, string propertyName, Type type)
        {
            foreach (PropertyInfo controlProperty in controlPropertiesArray)
            {
                if (controlProperty.Name == propertyName && controlProperty.PropertyType == type)
                {
                    controlProperty.SetValue(control, Convert.ChangeType(objProperty.GetValue(obj, null), type), null);
                    return true;
                }
            }
            return false;
        }

        public static void BindControlsToObject(object obj, Control container)
        {
            if (obj == null) return;

            //获取业务对象的属性   
            Type objType = obj.GetType();
            PropertyInfo[] objPropertiesArray = objType.GetProperties();

            foreach (PropertyInfo objProperty in objPropertiesArray)
            {

                Control control = FindControl(container, objProperty.Name);
                if (control == null) continue;
                if (control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    objProperty.SetValue(obj, Convert.ChangeType(dateTimePicker.Value, objProperty.PropertyType), null);

                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    objProperty.SetValue(obj, Convert.ChangeType(comboBox.SelectedValue, objProperty.PropertyType), null);

                }
                else
                {
                    Type controlType = control.GetType();
                    PropertyInfo[] controlPropertiesArray = controlType.GetProperties();

                    bool success = false;
                    success = FindAndGetControlProperty(obj, objProperty, control, controlPropertiesArray, "Checked", typeof(bool));

                    if (!success)
                        success = FindAndGetControlProperty(obj, objProperty, control, controlPropertiesArray, "Value", typeof(String));

                    if (!success)
                        success = FindAndGetControlProperty(obj, objProperty, control, controlPropertiesArray, "Text", typeof(String));

                    if (!success)
                        success = FindAndGetControlProperty(obj, objProperty, control, controlPropertiesArray, "SelectedValue", typeof(String));
                }
            }
        }

        private static bool FindAndGetControlProperty(object obj, PropertyInfo objProperty, Control control, PropertyInfo[] controlPropertiesArray, string propertyName, Type type)
        {
            // 在整个控件属性中进行迭代
            foreach (PropertyInfo controlProperty in controlPropertiesArray)
            {
                // 检查匹配的名称和类型
                if (controlProperty.Name == "Text" && controlProperty.PropertyType == typeof(String))
                {
                    // 将控件的属性设置为
                    // 业务对象属性值
                    try
                    {
                        objProperty.SetValue(obj, Convert.ChangeType(controlProperty.GetValue(control, null), objProperty.PropertyType), null);
                        return true;
                    }
                    catch
                    {
                        // 无法将来自窗体控件 
                        // 的数据转换为 
                        // objProperty.PropertyType
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
