//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demos.Properties
{
    
    internal partial class Resources
    {
        private static System.Resources.ResourceManager manager;
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if ((Resources.manager == null))
                {
                    Resources.manager = new System.Resources.ResourceManager("Demos.Properties.Resources", typeof(Resources).Assembly);
                }
                return Resources.manager;
            }
        }
        internal static System.Drawing.Bitmap GetBitmap(Resources.BitmapResources id)
        {
            return ((System.Drawing.Bitmap)(ResourceManager.GetObject(((short)(id)))));
        }
        internal static System.Drawing.Font GetFont(Resources.FontResources id)
        {
            return ((System.Drawing.Font)(ResourceManager.GetObject(((short)(id)))));
        }
        [System.SerializableAttribute()]
        internal enum BitmapResources : short
        {
            Qspi = -32580,
            Template = -21726,
            settingImage = -17023,
            Ethernet = -16161,
            Piezo = -5876,
            Usb = 1556,
            Sd = 12737,
        }
        [System.SerializableAttribute()]
        internal enum FontResources : short
        {
            droid_reg10 = -27850,
            droid_reg12 = -27848,
            droid_reg11 = -27847,
            droid_reg14 = -27846,
            droid_reg18 = -27842,
            droid_reg24 = -13442,
            droid_reg09 = -7428,
            droid_reg08 = -7427,
            droid_reg32 = 14655,
            droid_reg48 = 24547,
        }
    }
}
