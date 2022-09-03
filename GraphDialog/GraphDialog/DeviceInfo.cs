using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GraphDialog
{
    [DefaultPropertyAttribute("DeviceInfo")]
    class DeviceInfo
    {
        [CategoryAttribute("ID Settings"), DescriptionAttribute("Name of the customer")]
        public enum SpeedMode { Slow, Normal, Fast }
        public enum BrightnessMode { Dark, Normal, Bright }

        public SpeedMode speedMode{ get; set; }
        public BrightnessMode brightmode { get; set; }

        public string DevName { get; set; }
        public int ID { get; set; }
        public float Temperature { get; set; }

        [CategoryAttribute("Motion Settings"), DescriptionAttribute("Name of the ")]
        public MotionInfo DevMotion { get; set; }
        

        public DeviceInfo()
        {
            DevName = "default";
            ID = 123;
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
        public MotionInfo()
        {
            DevName = "Motion default";
            ID = 567;
            Temperature = 44.44f;
        }
    }


    //    var settings = new Settings();
    //    settings.Subcategory1 = new SubCategory1() { Property1 = "P1", Property2 = "P2"};
    //    settings.Subcategory2 = new SubCategory2() { Property3 = "P3"};
    //    grid.SelectedObject = settings;
    //...

    public class Settings
    {
        [Category("Category1")]
        public SubCategory1 Subcategory1 { get; set; }

        [Category("Category1")]
        public SubCategory2 Subcategory2 { get; set; }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SubCategory1
    {
        public String Property1 { get; set; }

        public String Property2 { get; set; }

        public override string ToString()
        {
            return String.Empty;
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SubCategory2
    {
        public String Property3 { get; set; }

        public override string ToString()
        {
            return String.Empty;
        }
    }
}
