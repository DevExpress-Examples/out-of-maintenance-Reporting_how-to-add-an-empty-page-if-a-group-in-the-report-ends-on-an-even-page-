using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using System.Collections;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            report.CreateDocument(false);

            int addedPagesCount = 0;
            IDictionaryEnumerator items = report.Groups.GetEnumerator();
            while(items.MoveNext()){
                DictionaryEntry item = (DictionaryEntry)items.Current;
                int i = Convert.ToInt32(item.Value) + addedPagesCount;
                if(i % 2 == 0) {
                    XtraReport2 emptyPage = new XtraReport2();
                    emptyPage.CreateDocument(false);
                    addedPagesCount++;
                    report.Pages.Insert(i+1, emptyPage.Pages[0]);
                }
            }


            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreviewDialog();
            
        }
    }
}
