using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

using PosLibrary;
using PosLibrary.DBSpace;

namespace DTRMNS {


    // this defines a custom UI type editor to display a list of possible SQLExpress Servers
    // used by the property grid to display item in edit mode
    public class DatabaseServerEditor : UITypeEditor {
        private IWindowsFormsEditorService _editorService;

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context) {
            // drop down mode (we'll host a listbox in the drop down)

            //return UITypeEditorEditStyle.Modal;

            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value) {
            _editorService = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
           
            // use a list box
            ListBox lb = new ListBox();
            lb.SelectionMode = SelectionMode.One;
            lb.BorderStyle = BorderStyle.FixedSingle;
            lb.SelectedValueChanged += OnListBoxSelectedValueChanged;

            // use the IBenchmark.Name property for list box display
           // lb.DisplayMember = "Name";
            List<SqlExpressDesc> serverList = DRUF.GetEasyInstalledSqlExpressList();
            for (int i = 0; i < serverList.Count; i++) {
                lb.Items.Add(serverList[i].FullName);
            }
            lb.Width = 400;

            // show this model stuff
            _editorService.DropDownControl(lb);
            if (lb.SelectedItem == null) // no selection, return the passed-in value as is
                return value;

            return lb.SelectedItem;
        }

        private void OnListBoxSelectedValueChanged(object sender, EventArgs e) {
            // close the drop down as soon as something is clicked
            _editorService.CloseDropDown();
        }
    }
}
