using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Clifton.TouchScreen {
    public static class ControlHelper {
        public static DataGridView FormatDefaultDataGrid(ref DataGridView dgView) {
            //basic properties
            dgView.AllowUserToAddRows = false;
            dgView.AllowUserToDeleteRows = false;
            dgView.AllowUserToOrderColumns = true;
            dgView.AllowUserToResizeColumns = false;
            dgView.AllowUserToResizeRows = false;
            dgView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgView.CausesValidation = false;
            dgView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dgView.ColumnHeadersHeight = 50;
            dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dgView.MultiSelect = false;
            dgView.ReadOnly = true;
            dgView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgView.RowHeadersVisible = false;
            dgView.RowHeadersWidth = 4;
            dgView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgView.RowTemplate.Height = 50;
            dgView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgView.ShowCellErrors = false;
            dgView.ShowCellToolTips = false;
            dgView.ShowEditingIcon = false;
            dgView.ShowRowErrors = false;

            //properties that don't show up in designer view
            dgView.AutoGenerateColumns = false;

            return dgView;
        }
    };
}
