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
using System.Drawing.Drawing2D;

namespace FontAwesomeCsharp
{
    public class FontIcon
    {
        public string FontIcon_Name { get; set; }
        public string FontIcon_Unicode { get; set; }
        public FontIconTypes FontIcon_Type { get; set; }
    }
    public partial class AwesomeIcon : Button
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

        private string Icon_Text = "0xe3b0";        
        private Font Icon_Font = new Font(EmbedFont.BrandsClass.Brands, 30);
        private FontIconTypes Icon_Type = FontIconTypes.Regular;
        private string Icon_Name = "HouseChimneyBlank";
        private float Icon_Size = 30;
        private bool Icon_AutoSize = true;

        public AwesomeIcon()
        {
            this.Height = 60;
            this.Width = 60;
            this.Resize += AwesomeIcon_Resize;
            this.DockChanged += AwesomeIcon_Resize;
            this.SizeChanged += AwesomeIcon_Resize;
            this.ChangeUICues += AwesomeIcon_ChangeUICues;
            this.Font = Icon_Font;
            this.Text = Icon_Text;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.FlatAppearance.BorderSize = 0;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }

        private void AwesomeIcon_ChangeUICues(object sender, UICuesEventArgs e)
        {
            AwesomeIcon_Resize(null, null);
        }

        private void AwesomeIcon_Resize(object sender, System.EventArgs e)
        {
            try
            {
                if (Icon_AutoSize)
                {
                    if (Text.Length == 0)
                    {
                        return;
                    }

                    float height = this.Height * 0.99f;
                    float width = this.Width * 0.99f;

                    this.SuspendLayout();

                    Font tryFont = this.Font;
                    Size tempSize = TextRenderer.MeasureText(Text, tryFont);

                    float heightRatio = height / tempSize.Height;
                    float widthRatio = width / tempSize.Width;

                    IconSize = tryFont.Size * Math.Min(widthRatio, heightRatio);

                    Icon_Font = new Font(tryFont.FontFamily, IconSize, tryFont.Style);
                    this.Font = Icon_Font;

                    this.ResumeLayout();
                }
            }
            catch (Exception)
            {
            }

        }

        public override Font Font
        {
            get { return base.Font; }
            set { base.Font = Icon_Font; }
        }


        [Category("Custom Button (mmdvcx)")]
        public FontIconTypes FontType
        {
            get { return Icon_Type; }
            set
            {
                Icon_Type = value;

                if (Icon_Type == FontIconTypes.Regular)
                    Icon_Font = new Font(EmbedFont.RegularClass.Regular, Icon_Size);
                else if (Icon_Type == FontIconTypes.Solid)
                    Icon_Font = new Font(EmbedFont.SolidClass.Solid, Icon_Size);
                else if (Icon_Type == FontIconTypes.Light)
                    Icon_Font = new Font(EmbedFont.LightClass.Light, Icon_Size);
                else if (Icon_Type == FontIconTypes.Thin)
                    Icon_Font = new Font(EmbedFont.ThinClass.Thin, Icon_Size);
                else if (Icon_Type == FontIconTypes.Duotone)
                    Icon_Font = new Font(EmbedFont.DuotoneClass.Duotone, Icon_Size);
                else if (Icon_Type == FontIconTypes.Brands)
                    Icon_Font = new Font(EmbedFont.BrandsClass.Brands, Icon_Size);

                this.Font = Icon_Font;
                AwesomeIcon_Resize(null, null);
            }
        }

        [Editor(typeof(MaskEditor), typeof(UITypeEditor)), Category("Custom Button (mmdvcx)")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public object Icon
        {
            get { return Icon_Name; }
            set
            {
                if (value is FontIcon)
                {
                    Icon_Name = (value as FontIcon).FontIcon_Name;
                    Icon_Text = (value as FontIcon).FontIcon_Unicode;
                    this.Text = Icon_Text;

                    if ((value as FontIcon).FontIcon_Type == FontIconTypes.Duotone)
                    {
                        FontType = FontIconTypes.Duotone;
                    }
                    else if ((value as FontIcon).FontIcon_Type == FontIconTypes.Brands)
                    {
                        FontType = FontIconTypes.Brands;
                    }
                    else
                    {
                        FontType = FontIconTypes.Regular;
                    }
                    AwesomeIcon_Resize(null, null);
                }
            }
        }

        [Category("Custom Button (mmdvcx)")]
        public float IconSize
        {
            get { return Icon_Size; }
            set
            {
                Icon_Size = value;
                Icon_Font = new Font(Icon_Font.FontFamily, Icon_Size);
                this.Font = Icon_Font;
            }
        }

        [Category("Custom Button (mmdvcx)")]
        public bool IconAutoSize
        {
            get { return Icon_AutoSize; }
            set
            {
                Icon_AutoSize = value;
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
