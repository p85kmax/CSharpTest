using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Diagnostics;

namespace GraphDialog
{
  //  [Conditional("DEBUG"), Conditional("TEST1")]
    [Serializable]
    [DefaultPropertyAttribute("DeviceInfo")]
    class DeviceInfo    //: ICustomTypeDescriptor, INotifyPropertyChanged
    {
        [CategoryAttribute("ID Settings"), DescriptionAttribute("Name of the customer")]
        public enum SpeedMode { Slow, Normal, Fast }
        public enum BrightnessMode { Dark, Normal, Bright }

        public SpeedMode speedMode{
            get;
            set;
               // this.speedMode = value;
               // NotifyPropertyChanged("TypeOfCar");
            
        }
        public BrightnessMode brightmode { get; set; }

 
        public string DevName { get; set; }

        [DisplayName("GUID"), ReadOnly(true), Browsable(true)]
        public int ID { get; set; }
        public float Temperature { get; set; }

        
        [Editor(typeof(NumericUpDownTypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public float SetSpeed { get; set; }


        private bool useControl;
        [Browsable(true)]
        [Editor(typeof(MyBoolEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public bool UseControl {
            get
            {
                return useControl;
            }
            set
            {
                useControl = value;

                //// 리플렉션을 사용해 특성에 접근합니다.
                //System.Attribute[] attrs = System.Attribute.GetCustomAttributes(DevMotion);  // Reflection.  

                //// 리플렉션으로 접근한 특성 정보를 출력합니다.
                //foreach (System.Attribute attr in attrs)
                //{
                //    if (attr is MotionInfo)
                //    {
                //        MotionInfo a = (MotionInfo)attr;
                //        System.Console.WriteLine("   {0}, version {1:f}", a.GetName(), a.version);
                //    }
                //}
                ////출처: https://ibocon.tistory.com/94 [김예건:티스토리]
            }
        }



        [CategoryAttribute("Motion Settings"), DescriptionAttribute("Name of the ")]
        public MotionInfo DevMotion { get; set; }

        //System.Windows.Forms.TrackBar
        //System.Windows.Forms.NumericUpDown;
        //System.Windows.Forms.CheckBox;
        //[Browsable(false)]  // this property will not be displayed
        //[DisplayName("GUID"), ReadOnly(true), Browsable(true)]
        //[Category("Identification")]
        //[DisplayName("License Plate")]
        private int _value;
        [Browsable(true)]
        [Editor(typeof(System.Windows.Forms.TrackBar), typeof(System.Drawing.Design.UITypeEditor))]
        public int MyValue
        {
            get { return _value; }
            set { _value = value; }
        }

        public DeviceInfo()
        {
            DevName = "default";
            ID = 1235678;
            Temperature = 36.5f;
            DevMotion = new MotionInfo();
        }
    }
    
    [TypeConverter(typeof(ExpandableObjectConverter))]
    class MotionInfo
    {
        [CategoryAttribute("ID Settings"), DescriptionAttribute("Name of the Motion")]
        public enum SpeedMode { Slow, Normal, Fast }
        public enum BrightnessMode { Dark, Normal, Bright }

        public SpeedMode speedMode { get; set; }
        public BrightnessMode brightmode { get; set; }

        public string DevName { get; set; }
        public int ID { get; set; }
        public float Temperature { get; set; }

        public  Settings settings { get; set; }

        public MotionInfo()
        {
            DevName = "Motion default";
            ID = 567;
            Temperature = 44.44f; 

            settings = new Settings();
        }
    }


    //    var settings = new Settings();
    //    settings.Subcategory1 = new SubCategory1() { Property1 = "P1", Property2 = "P2"};
    //    settings.Subcategory2 = new SubCategory2() { Property3 = "P3"};
    //    grid.SelectedObject = settings;
    //...

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Settings
    {
        [Category("Category1")]
        public SubCategory1 Subcategory1 { get; set; }

        [Category("Category1")]
        public SubCategory2 Subcategory2 { get; set; }

        public Settings()
        {
            Subcategory1 = new SubCategory1();
            Subcategory2 = new SubCategory2();
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SubCategory1
    {
        public String Property1 { get; set; }

        public String Property2 { get; set; }


        public SubCategory1()
        {
            Property1 = " Property1";
            Property2 = " Property2";
        }

        public override string ToString()
        {
            return String.Empty;
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SubCategory2
    {


        public SubCategory2()
        {
            Property3 = "Property3";
        }


        public String Property3 { get; set; }

        public override string ToString()
        {
            return String.Empty;
        }
    }

    public class MyBoolEditor : System.Drawing.Design.UITypeEditor
    {
        public override bool GetPaintValueSupported
            (System.ComponentModel.ITypeDescriptorContext context)
        { return true; }
        public override void PaintValue(PaintValueEventArgs e)
        {
            var rect = e.Bounds;
            rect.Inflate(1, 1);
            ControlPaint.DrawCheckBox(e.Graphics, rect, ButtonState.Flat |
                (((bool)e.Value) ? ButtonState.Checked : ButtonState.Normal));
        }
    }

    public class UpDownValueEditor : UITypeEditor
    {
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService editorService = null;
            if (provider != null)
            {
                editorService = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            }

            if (editorService != null)
            {
                NumericUpDown udControl = new NumericUpDown();
                udControl.DecimalPlaces = 0;
                udControl.Minimum = 0;
                udControl.Maximum = 127;
                udControl.Value = (UInt16)value;
                editorService.DropDownControl(udControl);
                value = (UInt16)udControl.Value;
            }

            return value;
        }
    }
    public class NumericUpDownTypeEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            if (context == null || context.Instance == null)
                return base.GetEditStyle(context);
            return UITypeEditorEditStyle.DropDown;
        }
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService editorService;
            if (context == null || context.Instance == null || provider == null)
                return value;
            try
            {
                // get the editor service, just like in windows forms
                editorService = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
                NumericUpDown nmr = new NumericUpDown();
                nmr.Size = new Size(60, 120);
                nmr.Minimum = 0;
                nmr.Maximum = 200;
                nmr.Increment = 0.01M;         /// 업다운 증가 단위(float이 필요해서 0.01로 했음)
                nmr.DecimalPlaces = 6;        /// 소수 이하 표시할 자리 수.
                nmr.Value = new decimal((float)value);
                editorService.DropDownControl(nmr);
                return (float)nmr.Value;
            }
            finally
            {
                editorService = null;
            }
        }
    }//    출처: https://blueasa.tistory.com/671 [Try & Error:티스토리]
}
