using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static FontAwesomeCsharp.AwesomeIcon;

namespace FontAwesomeCsharp
{
    public partial class IconPicker : Form
    {
        DataTable IconsDataTable = new DataTable();
        public string IconName { get; set; }
        public string IconUnicode { get; set; }
        public FontIconTypes IconFont { get; set; }
        public enum FontType
        {
            Regular,
            Solid,
            Light,
            Thin,
            Duotone,
            Brands
        }
        public IconPicker()
        {
            InitializeComponent();
        }

        private void IconPicker_Load(object sender, EventArgs e)
        {
            try
            {
                FillDataTable();
                FillDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillDataTable()
        {
            object fontObject = new object();
            BindingFlags bindingFlags = new BindingFlags();

            IconsDataTable.Columns.Add("Name", typeof(string));
            IconsDataTable.Columns.Add("Regular", typeof(string));
            IconsDataTable.Columns.Add("Solid", typeof(string));
            IconsDataTable.Columns.Add("Light", typeof(string));
            IconsDataTable.Columns.Add("Thin", typeof(string));
            IconsDataTable.Columns.Add("Duotone", typeof(string));
            IconsDataTable.Columns.Add("Brands", typeof(string));
            IconsDataTable.Columns.Add("Type", typeof(string));


            fontObject = new FontUnicode.General();
            bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
            foreach (FieldInfo field in typeof(FontUnicode.General).GetFields(bindingFlags))
            {
                string unicode = FontUnicode.UnicodeToString(field.GetValue(fontObject).ToString());
                IconsDataTable.Rows.Add(new object[] { field.Name, unicode, unicode, unicode, unicode, unicode, unicode, "General" });
            }

            fontObject = new FontUnicode.Duotone();
            bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
            foreach (FieldInfo field in typeof(FontUnicode.Duotone).GetFields(bindingFlags))
            {
                string unicode = FontUnicode.UnicodeToString(field.GetValue(fontObject).ToString());
                IconsDataTable.Rows.Add(new object[] { field.Name, unicode, unicode, unicode, unicode, unicode, unicode, "Duotone" });
            }

            fontObject = new FontUnicode.Brands();
            bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
            foreach (FieldInfo field in typeof(FontUnicode.Brands).GetFields(bindingFlags))
            {
                string unicode = FontUnicode.UnicodeToString(field.GetValue(fontObject).ToString());
                IconsDataTable.Rows.Add(new object[] { field.Name, unicode, unicode, unicode, unicode, unicode, unicode, "Brands" });
            }
        }
        private void FillDataGrid()
        {
            try
            {
                IconsGridView.DataSource = IconsDataTable;

                IconsGridView.Columns[0].HeaderText = "Name";
                IconsGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                IconsGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                IconsGridView.Columns[1].DefaultCellStyle.Font = new Font(EmbedFont.RegularClass.Regular, 24);

                IconsGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                IconsGridView.Columns[2].DefaultCellStyle.Font = new Font(EmbedFont.SolidClass.Solid, 24);

                IconsGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                IconsGridView.Columns[3].DefaultCellStyle.Font = new Font(EmbedFont.LightClass.Light, 24);

                IconsGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                IconsGridView.Columns[4].DefaultCellStyle.Font = new Font(EmbedFont.ThinClass.Thin, 24);

                IconsGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                IconsGridView.Columns[5].DefaultCellStyle.Font = new Font(EmbedFont.DuotoneClass.Duotone, 24);

                IconsGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                IconsGridView.Columns[6].DefaultCellStyle.Font = new Font(EmbedFont.BrandsClass.Brands, 24);

                IconsGridView.Columns[7].Visible = false;

                DataGridViewButtonColumn selectColumn = new DataGridViewButtonColumn();
                selectColumn.Text = "Select";
                selectColumn.UseColumnTextForButtonValue = true;
                IconsGridView.Columns.Add(selectColumn);
            }
            catch (Exception)
            {

            }

        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSourceRegular = new BindingSource();
            bindingSourceRegular.DataSource = IconsGridView.DataSource;
            bindingSourceRegular.Filter = "name Like '%" + SearchBox.Text + "%'";
            IconsGridView.DataSource = bindingSourceRegular;
        }
        private void IconsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;

                BindingManagerBase bm = this.IconsGridView.BindingContext[this.IconsGridView.DataSource, this.IconsGridView.DataMember];
                DataRow dr = ((DataRowView)bm.Current).Row;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dr != null)
                {
                    IconName = (dr[0].ToString());
                    IconUnicode = (dr[1].ToString());

                    if (dr[7].ToString() == "Duotone")
                        IconFont = FontIconTypes.Duotone;
                    else if (dr[7].ToString() == "Brands")
                        IconFont = FontIconTypes.Brands;
                    else
                        IconFont = FontIconTypes.Regular;
                    this.Close();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                this.Dispose();
            }
        }
    }
}
