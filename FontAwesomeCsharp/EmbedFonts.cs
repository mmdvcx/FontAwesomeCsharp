using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;

namespace FontAwesomeCsharp
{
    public static class EmbedFont
    {
        public static class RegularClass
        {
            [System.Runtime.InteropServices.DllImport("gdi32.dll")]
            private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

            private static PrivateFontCollection fonts = new PrivateFontCollection();
            public static FontFamily Regular;
            static RegularClass()
            {
                byte[] fontData = Properties.Resources.Font_Awesome_6_Pro_Regular_400;
                IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
                System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                uint dummy = 0;
                fonts.AddMemoryFont(fontPtr, Properties.Resources.Font_Awesome_6_Pro_Regular_400.Length);
                AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Font_Awesome_6_Pro_Regular_400.Length, IntPtr.Zero, ref dummy);
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

                Regular = fonts.Families[0];
            }
        }
        public static class SolidClass
        {
            [System.Runtime.InteropServices.DllImport("gdi32.dll")]
            private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

            private static PrivateFontCollection fonts = new PrivateFontCollection();
            public static FontFamily Solid;
            static SolidClass()
            {
                byte[] fontData = Properties.Resources.Font_Awesome_6_Pro_Solid_900;
                IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
                System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                uint dummy = 0;
                fonts.AddMemoryFont(fontPtr, Properties.Resources.Font_Awesome_6_Pro_Solid_900.Length);
                AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Font_Awesome_6_Pro_Solid_900.Length, IntPtr.Zero, ref dummy);
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

                Solid = fonts.Families[0];
            }
        }
        public static class LightClass
        {
            [System.Runtime.InteropServices.DllImport("gdi32.dll")]
            private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

            private static PrivateFontCollection fonts = new PrivateFontCollection();
            public static FontFamily Light;
            static LightClass()
            {
                byte[] fontData = Properties.Resources.Font_Awesome_6_Pro_Light_300;
                IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
                System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                uint dummy = 0;
                fonts.AddMemoryFont(fontPtr, Properties.Resources.Font_Awesome_6_Pro_Light_300.Length);
                AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Font_Awesome_6_Pro_Light_300.Length, IntPtr.Zero, ref dummy);
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

                Light = fonts.Families[0];
            }
        }
        public static class ThinClass
        {
            [System.Runtime.InteropServices.DllImport("gdi32.dll")]
            private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

            private static PrivateFontCollection fonts = new PrivateFontCollection();
            public static FontFamily Thin;
            static ThinClass()
            {
                byte[] fontData = Properties.Resources.Font_Awesome_6_Pro_Thin_100;
                IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
                System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                uint dummy = 0;
                fonts.AddMemoryFont(fontPtr, Properties.Resources.Font_Awesome_6_Pro_Thin_100.Length);
                AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Font_Awesome_6_Pro_Thin_100.Length, IntPtr.Zero, ref dummy);
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

                Thin = fonts.Families[0];
            }
        }
        public static class DuotoneClass
        {
            [System.Runtime.InteropServices.DllImport("gdi32.dll")]
            private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

            private static PrivateFontCollection fonts = new PrivateFontCollection();
            public static FontFamily Duotone;
            static DuotoneClass()
            {
                byte[] fontData = Properties.Resources.Font_Awesome_6_Duotone_Solid_900;
                IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
                System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                uint dummy = 0;
                fonts.AddMemoryFont(fontPtr, Properties.Resources.Font_Awesome_6_Duotone_Solid_900.Length);
                AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Font_Awesome_6_Duotone_Solid_900.Length, IntPtr.Zero, ref dummy);
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

                Duotone = fonts.Families[0];
            }
        }
        public static class BrandsClass
        {
            [System.Runtime.InteropServices.DllImport("gdi32.dll")]
            private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

            private static PrivateFontCollection fonts = new PrivateFontCollection();
            public static FontFamily Brands;
            static BrandsClass()
            {
                byte[] fontData = Properties.Resources.Font_Awesome_6_Brands_Regular_400;
                IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
                System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                uint dummy = 0;
                fonts.AddMemoryFont(fontPtr, Properties.Resources.Font_Awesome_6_Brands_Regular_400.Length);
                AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Font_Awesome_6_Brands_Regular_400.Length, IntPtr.Zero, ref dummy);
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

                Brands = fonts.Families[0];
            }
        }
    }
}
