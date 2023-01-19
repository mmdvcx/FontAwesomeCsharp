using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using static FontAwesomeCsharp.AwesomeIcon;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace FontAwesomeCsharp
{
    public class FontIcon
    {
        public string FontIcon_Name { get; set; }
        public string FontIcon_Unicode { get; set; }
        public FontIconTypes FontIcon_Type { get; set; }
    }
    public partial class AwesomeIcon : Panel
    {
        public enum FontIconTypes
        {
            Regular,
            Solid,
            Light,
            Thin,
            Duotone,
            Brands
        }

        private string FontIcon_Name = "HouseChimneyBlank";
        private string FontIcon_Unicode = FontUnicode.UnicodeToString("0xe3b0");
        private Font FontIcon_Font = new Font(EmbedFont.RegularClass.Regular, 30);
        private FontIconTypes FontIcon_Type = FontIconTypes.Regular;
        private float fontIconSize = 30;
        private bool iconAutoSize = true;

        private Label label = new Label() { TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill, Font = new Font(EmbedFont.RegularClass.Regular, 30) };
        public AwesomeIcon()
        {
            this.Height = 60;
            this.Width = 60;
            this.Font = FontIcon_Font;
            Icon = new FontIcon() { FontIcon_Name = FontIcon_Name, FontIcon_Type = FontIconTypes.Regular, FontIcon_Unicode = FontIcon_Unicode };

            this.Resize += AwesomeIcon_Resize;
            this.DockChanged += AwesomeIcon_Resize;
            this.SizeChanged += AwesomeIcon_Resize;
            this.Controls.Add(label);
        }


        private void AwesomeIcon_Resize(object sender, System.EventArgs e)
        {
            try
            {
                if (iconAutoSize)
                {
                    if (label.Text.Length == 0)
                    {
                        return;
                    }

                    float height = label.Height * 0.99f;
                    float width = label.Width * 0.99f;

                    this.SuspendLayout();

                    Font tryFont = label.Font;
                    Size tempSize = TextRenderer.MeasureText(label.Text, tryFont);

                    float heightRatio = height / tempSize.Height;
                    float widthRatio = width / tempSize.Width;

                    IconSize = tryFont.Size * Math.Min(widthRatio, heightRatio);
                    tryFont = new Font(tryFont.FontFamily, tryFont.Size * Math.Min(widthRatio, heightRatio), tryFont.Style);

                    label.Font = tryFont;
                    this.ResumeLayout();
                }
            }
            catch (Exception)
            {
            }

        }
        public override bool AutoSize
        {
            get { return false; }
            set { }
        }
        public override DockStyle Dock { get => base.Dock; set { base.Dock = value; AwesomeIcon_Resize(null, null); } }

        [Category("Custom Button (mmdvcx)")]
        public FontIconTypes IconFont
        {
            get { return FontIcon_Type; }
            set
            {
                FontIcon_Type = value;
                if (label.Font != null) label.Font.Dispose();

                if (FontIcon_Type == FontIconTypes.Regular)
                    label.Font = new Font(EmbedFont.RegularClass.Regular, fontIconSize);
                else if (FontIcon_Type == FontIconTypes.Solid)
                    label.Font = new Font(EmbedFont.SolidClass.Solid, fontIconSize);
                else if (FontIcon_Type == FontIconTypes.Light)
                    label.Font = new Font(EmbedFont.LightClass.Light, fontIconSize);
                else if (FontIcon_Type == FontIconTypes.Thin)
                    label.Font = new Font(EmbedFont.ThinClass.Thin, fontIconSize);
                else if (FontIcon_Type == FontIconTypes.Duotone)
                    label.Font = new Font(EmbedFont.DuotoneClass.Duotone, fontIconSize);
                else if (FontIcon_Type == FontIconTypes.Brands)
                    label.Font = new Font(EmbedFont.BrandsClass.Brands, fontIconSize);
            }
        }

        [Editor(typeof(MaskEditor), typeof(UITypeEditor)), Category("Custom Button (mmdvcx)")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public object Icon
        {
            get { return FontIcon_Name; }
            set
            {
                if (value is FontIcon)
                {
                    FontIcon_Name = (value as FontIcon).FontIcon_Name;
                    FontIcon_Unicode = (value as FontIcon).FontIcon_Unicode;
                    label.Text = FontIcon_Unicode;

                    if ((value as FontIcon).FontIcon_Type == FontIconTypes.Duotone)
                    {
                        IconFont = FontIconTypes.Duotone;
                        label.Font = new Font(EmbedFont.DuotoneClass.Duotone, fontIconSize);
                    }
                    else if ((value as FontIcon).FontIcon_Type == FontIconTypes.Brands)
                    {
                        IconFont = FontIconTypes.Brands;
                        label.Font = new Font(EmbedFont.BrandsClass.Brands, fontIconSize);
                    }
                    else
                    {
                        IconFont = FontIconTypes.Regular;
                        label.Font = new Font(EmbedFont.RegularClass.Regular, fontIconSize);
                    }
                }
            }
        }

        [Category("Custom Button (mmdvcx)")]
        public float IconSize
        {
            get { return fontIconSize; }
            set
            {
                fontIconSize = value;
                if (label.Font != null) label.Font.Dispose();

                label.Font = new Font(this.Font.FontFamily, fontIconSize);
            }
        }

        [Category("Custom Button (mmdvcx)")]
        public bool IconAutoSize
        {
            get { return iconAutoSize; }
            set
            {
                iconAutoSize = value;
            }
        }
    }
    public class MaskEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            try
            {
                IWindowsFormsEditorService service = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
                if (service != null)
                {
                    var ctrl = new IconPicker();
                    ctrl.StartPosition = FormStartPosition.CenterScreen;
                    ctrl.ShowInTaskbar = false;

                    service.ShowDialog(ctrl);

                    if (!string.IsNullOrEmpty(ctrl.IconName) && !string.IsNullOrEmpty(ctrl.IconUnicode))
                    {
                        value = new FontIcon() { FontIcon_Name = ctrl.IconName, FontIcon_Unicode = ctrl.IconUnicode, FontIcon_Type = ctrl.IconFont };
                    }
                }
                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FF" + ex.Message);
                return value;
            }
        }
    }
    public class TypeDescriptionContext : ITypeDescriptorContext
    {
        private Control editingObject;
        private PropertyDescriptor editingProperty;
        public TypeDescriptionContext(Control obj, PropertyDescriptor property)
        {
            editingObject = obj;
            editingProperty = property;
        }
        public IContainer Container
        {
            get { return editingObject.Container; }
        }
        public object Instance
        {
            get { return editingObject; }
        }
        public void OnComponentChanged()
        {
        }
        public bool OnComponentChanging()
        {
            return true;
        }
        public PropertyDescriptor PropertyDescriptor
        {
            get { return editingProperty; }
        }
        public object GetService(Type serviceType)
        {
            return editingObject.Site.GetService(serviceType);
        }
    }
}
