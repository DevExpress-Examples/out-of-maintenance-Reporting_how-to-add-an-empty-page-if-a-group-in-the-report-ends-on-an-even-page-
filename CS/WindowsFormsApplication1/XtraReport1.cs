using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1 {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
            Groups = new SortedList();
        }
        public SortedList Groups { get; set; }
        private void xrLabel2_PrintOnPage(object sender, PrintOnPageEventArgs e) {
            Groups.Add(((XRLabel)sender).Tag, e.PageIndex);
        }

    }
}
