//1.数据到控件的绑定要在其它combox列表加载完成后再绑定，不然会被清空
//
//
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;
namespace XSolo.Common
{

    public sealed class FrmAddEditBindComboBoxText
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
                try
                {
                    Control control = FindControl(container, objProperty.Name);
                    if (control == null) continue;

                    if (control is DateTimePicker)
                    {
                        if (objProperty.GetValue(obj, null) != null)
                        {
                            DateTimePicker dateTimePicker = (DateTimePicker)control;
                            dateTimePicker.Value = DateTime.Parse(objProperty.GetValue(obj, null).ToString());

                        }
                    }
                    else if (control is NumericUpDown)
                    {
                        NumericUpDown numericUpDown = (NumericUpDown) control;
                        numericUpDown.Value = (decimal)objProperty.GetValue(obj, null);
                    }
                    else if (control is ComboBox)
                    {
                        if (objProperty.GetValue(obj, null) != null)
                        {
                            ComboBox comboBox = (ComboBox) control;
                            comboBox.Text = objProperty.GetValue(obj, null).ToString();
                        }
                    }
                    else
                    {
                        //获取控件的属性
                        Type controlType = control.GetType();
                        PropertyInfo[] controlPropertiesArray = controlType.GetProperties();

                        //通用属性
                        bool success = false;

                        if (objProperty.GetValue(obj, null) != null)
                        {
                            success = FindAndSetControlProperty(obj, objProperty, control, controlPropertiesArray,
                                                                "Checked",
                                                                typeof (bool));
                        }

                        if (!success)
                            success = FindAndSetControlProperty(obj, objProperty, control, controlPropertiesArray,
                                                                "SelectedValue", typeof(String));

                        if (!success)
                            success = FindAndSetControlProperty(obj, objProperty, control, controlPropertiesArray,
                                                                "Text", typeof(String));
                        if (!success)
                            success = FindAndSetControlProperty(obj, objProperty, control, controlPropertiesArray,
                                                                "Value", typeof(String));

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误: \n" + ex);
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
            foreach (Control control in container.Controls)
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

                    DateTimePicker dateTimePicker = (DateTimePicker) control;
                    System.Nullable<DateTime> dt = (DateTime?)dateTimePicker.Value;
                    objProperty.SetValue(obj, Convert.ChangeType(dt, dt.GetType()),
                                             null);

                }
                else if (control is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)control;
                    Nullable<decimal> i = (decimal?)numericUpDown.Value;
                    objProperty.SetValue(obj, Convert.ChangeType(i, i.GetType()),null);
                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    objProperty.SetValue(obj, Convert.ChangeType(comboBox.Text, objProperty.PropertyType), null);

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

        /// <summary>
        /// 清除容器里面某些控件的值
        /// </summary>
        /// <param name="parContainer">容器类控件</param>
        public static void ClearCntrValue(Control parContainer)
        {
            for (int index = 0; index < parContainer.Controls.Count; index++)
            {
                // 如果是容器类控件，递归调用自己
                if (parContainer.Controls[index] is NumericUpDown)
                {
                    ((NumericUpDown)(parContainer.Controls[index])).Value = 0;

                }
                else
                {
                    if (parContainer.Controls[index].HasChildren)
                    {
                        ClearCntrValue(parContainer.Controls[index]);
                    }
                    else
                    {

                        switch (parContainer.Controls[index].GetType().Name)
                        {
                            case "TextBox":
                                parContainer.Controls[index].Text = string.Empty;
                                break;
                            case "RadioButton":
                                ((RadioButton)(parContainer.Controls[index])).Checked = false;
                                break;
                            case "CheckBox":
                                ((CheckBox)(parContainer.Controls[index])).Checked = false;
                                break;
                            case "ComboBox":
                                ((ComboBox)(parContainer.Controls[index])).Text = "";
                                break;
                            //case "NumericUpDown":
                            //    ((NumericUpDown)(parContainer.Controls[index])).Value = 0;
                            //    ((NumericUpDown)(parContainer.Controls[index])).Text = "0";
                            //    break;
                            case "DateTimePicker":
                                ((DateTimePicker)(parContainer.Controls[index])).Value = DateTime.Now;
                                break;
                        }

                    }
                }
            }
        }

        /// <summary>
        /// 重置控件集中的NumbericUpDown的数值为0
        /// </summary>
        /// <param name="parContainer"></param>
        public static void ReSetNumbericUpDownValue(Control parContainer)
        {
            for (int index = 0; index < parContainer.Controls.Count; index++)
            {

                if (parContainer.Controls[index] is NumericUpDown)
                {
                    ((NumericUpDown)(parContainer.Controls[index])).Value = 0;

                }
                else
                {
                    // 如果是容器类控件，递归调用自己
                    if (parContainer.Controls[index].HasChildren)
                    {
                        ReSetNumbericUpDownValue(parContainer.Controls[index]);
                    }
                }
            }
        }

        /// <summary>
        /// 遍历控件中的NumbericUpDown并将其的enable设为false
        /// </summary>
        /// <param name="parContainer"></param>
        public static void DisableNumbericUpDown(Control parContainer)
        {
            for (int index = 0; index < parContainer.Controls.Count; index++)
            {

                if (parContainer.Controls[index] is NumericUpDown)
                {
                    ((NumericUpDown)(parContainer.Controls[index])).Enabled = false;

                }
                else
                {
                    // 如果是容器类控件，递归调用自己
                    if (parContainer.Controls[index].HasChildren)
                    {
                        DisableNumbericUpDown(parContainer.Controls[index]);
                    }
                }
            }
        }

    }
}
