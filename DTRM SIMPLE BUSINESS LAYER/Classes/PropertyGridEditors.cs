using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

namespace DTRMNS {
    public class FolderNameEditor : UITypeEditor {
        private FolderBrowserDialog fbd = new FolderBrowserDialog();
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            //fbd.SelectedPath = value.ToString();
            fbd.SelectedPath = value.ToString();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                return fbd.SelectedPath;
            }
            return base.EditValue(context, provider, value);
        }
    }

    public class FilteredFileNameEditor : UITypeEditor {
        private OpenFileDialog ofd = new OpenFileDialog();
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context) {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context,IServiceProvider provider,object value) {
            ofd.FileName = value.ToString();
            ofd.Filter = "Text File|*.txt|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK) {
                return ofd.FileName;
            }
            return base.EditValue(context, provider, value);
        }
    }

    public class FilteredImageFileEditor : UITypeEditor {
        private OpenFileDialog ofd = new OpenFileDialog();
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context) {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value) {
            ofd.FileName = value.ToString();
            ofd.Filter = "PNG File|*.png|GIF File|*.gif|JPEG File|*.jpeg|JPG File|*.jpg|BMP File|*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK) {
                //FileInfo finfo = new FileInfo(ofd.FileName);
                return ofd.FileName;
            }
            return base.EditValue(context, provider, value);
        }
    }

    public class FilteredColorSelectEditor : UITypeEditor {
        private ColorDialog ofd = new ColorDialog();
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context) {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value) {
            ofd.Color = System.Drawing.Color.FromName(value.ToString());
            //ofd.FileName = value.ToString();
            //ofd.Filter = "PNG File|*.png|GIF File|*.gif|JPEG File|*.jpeg|JPG File|*.jpg|BMP File|*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK) {
                //FileInfo finfo = new FileInfo(ofd.FileName);
                return ofd.Color.Name;
            }
            return base.EditValue(context, provider, value);
        }
    }

}
