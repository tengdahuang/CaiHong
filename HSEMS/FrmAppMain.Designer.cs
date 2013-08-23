namespace HSEMS
{
    partial class FrmAppMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.skinUI1 = new DotNetSkin.SkinUI();
            this.SuspendLayout();
            // 
            // skinUI1
            // 
            this.skinUI1.Active = true;
            this.skinUI1.Button = true;
            this.skinUI1.Caption = true;
            this.skinUI1.CheckBox = true;
            this.skinUI1.ComboBox = true;
            this.skinUI1.ContextMenu = true;
            this.skinUI1.DisableTag = 999;
            this.skinUI1.Edit = true;
            this.skinUI1.GroupBox = true;
            this.skinUI1.ImageList = null;
            this.skinUI1.MaiMenu = true;
            this.skinUI1.Panel = true;
            this.skinUI1.Progress = true;
            this.skinUI1.RadioButton = true;
            this.skinUI1.ScrollBar = true;
            this.skinUI1.SkinFile = "D:\\projects\\WinForm\\HSEMS\\trunk\\TDReferences\\MNS-STANDART.skn";
            this.skinUI1.SkinSteam = null;
            this.skinUI1.Spin = true;
            this.skinUI1.StatusBar = true;
            this.skinUI1.SystemMenu = true;
            this.skinUI1.TabControl = true;
            this.skinUI1.Text = "Mycontrol1=edit\r\nMycontrol2=edit\r\n";
            this.skinUI1.ToolBar = true;
            this.skinUI1.TrackBar = true;
            // 
            // FrmAppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(592, 373);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmAppMain";
            this.Text = "华汕电子-设备管理";
            this.Load += new System.EventHandler(this.FrmAppMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DotNetSkin.SkinUI skinUI1;




    }
}
