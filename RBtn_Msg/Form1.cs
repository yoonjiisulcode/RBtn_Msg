using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RBtn_Msg
{
    public partial class Form1 : Form
    {
        MessageBoxButtons mbb;  // 메시지 버튼 옵션 설정 
        MessageBoxIcon mbi;     // 메시지 버튼 아이콘 설정

        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (this.rbOk.Checked)
            {
                this.mbb = MessageBoxButtons.OK;
            }else if(this.rbOkCancel.Checked)
            {
                this.mbb = MessageBoxButtons.OKCancel;
            }else if(this.rbYesNo.Checked)
            {
                this.mbb = MessageBoxButtons.YesNo;
            }else if(this.rbError.Checked)
            {
                this.mbi = MessageBoxIcon.Error;
            }else if(this.rbInformation.Checked)
            {
                this.mbi = MessageBoxIcon.Information;
            }else if(this.rbQuestion.Checked)
            {
                this.mbi = MessageBoxIcon.Question;
            }

            MessageBox.Show("메시지 박스를 확인하세요", "알림", mbb, mbi);
        }
    }
}
